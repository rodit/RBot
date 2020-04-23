using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.CodeDom.Compiler;
using System.Reflection;

using RBot.Options;
using RBot.Utils;

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
        public static bool ScriptRunning => CurrentScriptThread != null;
        public static string LoadedScript { get; set; }

        private static CodeDomProvider _provider = CodeDomProvider.CreateProvider("CSharp");
        private static Dictionary<string, bool> _configured = new Dictionary<string, bool>();

        public static Exception StartScript()
        {
            if (ScriptRunning)
            {
                ScriptInterface.Instance.Log("Script already running.");
                return new Exception("Script already running.");
            }
            else
            {
                try
                {
                    object script = Compile(File.ReadAllText(LoadedScript));
                    LoadScriptConfig(script);
                    if (_configured.TryGetValue(ScriptInterface.Instance.Config.Storage, out bool b) && !b)
                        ScriptInterface.Instance.Config.Configure();
                    script.GetType().GetMethod("ScriptMain").Invoke(script, new object[] { ScriptInterface.Instance });
                    return null;
                }
                catch (Exception e)
                {
                    return e;
                }
            }
        }

        public static void LoadScriptConfig(object script)
        {
            ScriptOptionContainer opts = ScriptInterface.Instance.Config = new ScriptOptionContainer();
            Type t = script.GetType();
            FieldInfo storageField = t.GetField("OptionsStorage");
            FieldInfo optsField = t.GetField("Options");
            FieldInfo dontPreconfField = t.GetField("DontPreconfigure");
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
                CurrentScriptThread.Abort();
            CurrentScriptThread = null;
        }

        public static object Compile(string source)
        {
            CompilerParameters opts = new CompilerParameters();
            opts.GenerateInMemory = true;
            opts.TreatWarningsAsErrors = false;
            opts.GenerateExecutable = false;
            opts.ReferencedAssemblies.Add(typeof(ScriptManager).Assembly.Location);
            opts.ReferencedAssemblies.AddRange(DefaultRefs.Select(r => File.Exists(r) ? Path.Combine(Environment.CurrentDirectory, r) : r).ToArray());
            opts.ReferencedAssemblies.AddRange(Directory.GetFiles(".", "*.dll").Select(x => Path.Combine(Environment.CurrentDirectory, x)).Where(CanLoadAssembly).ToArray());
            if (Directory.Exists("plugins"))
                opts.ReferencedAssemblies.AddRange(Directory.GetFiles("plugins", "*.dll").Select(x => Path.Combine(Environment.CurrentDirectory, x)).Where(CanLoadAssembly).ToArray());
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
                            else
                                opts.ReferencedAssemblies.Add(parts[1]);
                            break;
                    }
                }
            }
            CompilerResults results = _provider.CompileAssemblyFromSource(opts, source);
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
