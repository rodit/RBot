using Microsoft.CSharp;
using RBot.Options;
using RBot.Utils;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RBot
{
    public class ScriptManager
    {
        public static List<string> DefaultRefs { get; } = new List<string>()
        {
            "System.dll",
            "System.Core.dll",
            "System.Linq.dll",
            "System.Data.dll",
            "System.Drawing.dll",
            "System.Net.dll",
            "System.Windows.Forms.dll",
            "System.Xml.dll",
            "System.Xml.Linq.dll"
        };

        public static Thread CurrentScriptThread { get; set; }
        public static bool ScriptRunning => CurrentScriptThread?.IsAlive ?? false;
        public static string LoadedScript { get; set; }

        public static event Action ScriptStarted;
        public static event Action<bool> ScriptStopped;
        public static event Action<Exception> ScriptError;

        private static CodeDomProvider _provider = new CSharpCodeProvider();
        private static Dictionary<string, bool> _configured = new Dictionary<string, bool>();
        private static List<string> _refCache = new List<string>();

        public static async Task<Exception> StartScriptAsync()
        {
            if (ScriptRunning)
            {
                ScriptInterface.Instance.Log("Script already running.");
                return new Exception("Script already running.");
            }

            try
            {
                ScriptInterface.exit = false;
                object script = await Task.Run(() => Compile(File.ReadAllText(LoadedScript)));
                LoadScriptConfig(script);
                if (_configured.TryGetValue(ScriptInterface.Instance.Config.Storage, out bool b) && !b)
                    ScriptInterface.Instance.Config.Configure();
                ScriptInterface.Instance.Handlers.Clear();
                ScriptInterface.Instance.Runtime = new ScriptRuntimeVars();
                CurrentScriptThread = new Thread(() =>
                {
                    ScriptStarted?.Invoke();
                    try
                    {
                        script.GetType().GetMethod("ScriptMain").Invoke(script, new object[] { ScriptInterface.Instance });
                    }
                    catch (Exception e)
                    {
                        if (!(e is ThreadAbortException))
                        {
                            Debug.WriteLine($"Error while running script:\r\n{e}");
                            ScriptError?.Invoke(e);
                        }
                    }

                    ScriptStopped?.Invoke(true);
                });
                CurrentScriptThread.Name = "Script Thread";
                CurrentScriptThread.Start();
                return null;
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public static void RestartScript() { }

        public static void LoadScriptConfig(object script)
        {
            ScriptOptionContainer opts = ScriptInterface.Instance.Config = new ScriptOptionContainer();
            Type t = script.GetType();
            FieldInfo storageField = t.GetField("OptionsStorage");
            FieldInfo optsField = t.GetField("Options");
            FieldInfo multiOptsField = t.GetField("MultiOptions");
            FieldInfo dontPreconfField = t.GetField("DontPreconfigure");
            if(multiOptsField != null)
            {
                List<FieldInfo> multiOpts = new List<FieldInfo>();
                foreach(string optField in (string[])multiOptsField.GetValue(script))
                {
                    FieldInfo fi = t.GetField(optField);
                    if(fi != null)
                        multiOpts.Add(fi);
                }
                foreach (FieldInfo opt in multiOpts)
                {
                    List<IOption> parsedOpt = (List<IOption>)opt.GetValue(script);
                    parsedOpt.ForEach(o => o.Category = opt.Name);
                    opts.MultipleOptions.Add(opt.Name, parsedOpt);
                }
            }
            if (optsField != null)
                opts.Options.AddRange((List<IOption>)optsField.GetValue(script));
            if (storageField != null)
                opts.Storage = (string)storageField.GetValue(script);
            if (dontPreconfField != null)
                _configured[opts.Storage] = (bool)dontPreconfField.GetValue(script);
            else if (optsField != null)
                _configured[opts.Storage] = false;
            opts.SetDefaults();
            opts.Load();
        }

        public static void StopScript()
        {
            ScriptInterface.exit = true;
            CurrentScriptThread?.Join(1000);
            if (CurrentScriptThread?.IsAlive ?? false)
            {
                CurrentScriptThread.Abort();
                ScriptStopped?.Invoke(false);
                Forms.Scripts.btnStartScript.CheckedInvoke(() => Forms.Scripts.btnStartScript.Text = "Start Script");
            }

            ScriptInterface.Instance.Options.AutoRelogin = false;
            ScriptInterface.Instance.Options.LagKiller = false;
            ScriptInterface.Instance.Options.LagKiller = true;
            ScriptInterface.Instance.Options.LagKiller = false;
            ScriptInterface.Instance.Options.AggroAllMonsters = false;
            ScriptInterface.Instance.Options.AggroMonsters = false;
            ScriptInterface.Instance.Options.SkipCutscenes = false;
            ScriptInterface.Instance.Skills.StopTimer();
            ScriptInterface.Instance.Drops.Stop();
            ScriptInterface.Instance.Events.ClearHandlers();
            CurrentScriptThread = null;
        }

        public static object Compile(string source)
        {
            CompilerParameters opts = new CompilerParameters();
            opts.GenerateInMemory = true;
            opts.GenerateExecutable = false;
            opts.IncludeDebugInformation = true;
            opts.TreatWarningsAsErrors = false;
            opts.ReferencedAssemblies.Add(typeof(ScriptManager).Assembly.Location);
            opts.ReferencedAssemblies.AddRange(DefaultRefs.Select(r => File.Exists(r) ? Path.Combine(Environment.CurrentDirectory, r) : r).ToArray());
            if (_refCache.Count == 0)
            {
                _refCache.AddRange(Directory.GetFiles(".", "*.dll").Select(x => Path.Combine(Environment.CurrentDirectory, x)).Where(CanLoadAssembly));
                if (Directory.Exists("plugins"))
                    _refCache.AddRange(Directory.GetFiles("plugins", "*.dll").Select(x => Path.Combine(Environment.CurrentDirectory, x)).Where(CanLoadAssembly));
            }

            opts.ReferencedAssemblies.AddRange(_refCache.ToArray());
            var sources = new List<string>() { source };
            foreach (string line in source.Split('\n').Select(l => l.Trim()))
            {
                if (line.StartsWith("using"))
                    break;
                if (line.StartsWith("//cs_"))
                {
                    string[] parts = line.Split((char[])null, 2, StringSplitOptions.RemoveEmptyEntries);
                    string cmd = parts[0].Substring(5);
                    switch (cmd)
                    {
                        case "ref":
                            string local = Path.Combine(Environment.CurrentDirectory, parts[1]);
                            if (File.Exists(local))
                                opts.ReferencedAssemblies.Add(local);
                            else if (File.Exists(parts[1]))
                                opts.ReferencedAssemblies.Add(parts[1]);
                            break;
                        case "include":
                            string localSource = Path.Combine(Environment.CurrentDirectory, parts[1]);
                            if (File.Exists(localSource))
                                sources.Add(File.ReadAllText(localSource));
                            else if (File.Exists(parts[1]))
                                sources.Add(File.ReadAllText(parts[1]));
                            break;
                    }
                }
            }

            Stopwatch sw = new Stopwatch();
            sw.Start();
            // TODO Rework compiler to .NET 6
            CompilerResults results = _provider.CompileAssemblyFromSource(opts, sources.ToArray());
            sw.Stop();
            Debug.WriteLine($"Script compilation took {sw.Elapsed.TotalMilliseconds}ms.");
            if (results.Errors.Count == 0)
            {
                Type t = results.CompiledAssembly.DefinedTypes.First(t => t.GetDeclaredMethod("ScriptMain") != null);
                if (t == null)
                    throw new Exception("No declared type with entry point found.");
                return Activator.CreateInstance(t);
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                foreach (CompilerError error in results.Errors)
                    sb.AppendLine(error.ToString());
                throw new ScriptCompileException(sb.ToString());
            }
        }

        private static bool CanLoadAssembly(string path)
        {
            try
            {
                AssemblyName.GetAssemblyName(path);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
