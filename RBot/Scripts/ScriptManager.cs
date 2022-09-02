using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using RBot.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RBot;

public class ScriptManager
{
    public static Thread CurrentScriptThread { get; set; }
    /// <summary>
    /// Whether the script is running.
    /// </summary>
    public static bool ScriptRunning => CurrentScriptThread?.IsAlive ?? false;
    /// <summary>
    /// The path to the current loaded script.
    /// </summary>
    public static string LoadedScript { get; set; }
    /// <summary>
    /// The last script compiled.
    /// </summary>
    public static string CompiledScript { get; set; }

    public static event Action ScriptStarted;
    public static event Action<bool> ScriptStopped;
    public static event Action<Exception> ScriptError;

    private static Dictionary<string, bool> _configured = new();
    private static List<string> _refCache = new();

    internal static CancellationTokenSource ScriptCTS;

    internal static async Task<Exception> StartScriptAsync()
    {
        if (ScriptRunning)
        {
            ScriptInterface.Instance.Log("Script already running.");
            return new Exception("Script already running.");
        }

        try
        {
            Forms.Main.StopAuto();
            ScriptInterface.exit = false;
            object script = await Task.Run(() => Compile(File.ReadAllText(LoadedScript)));
            LoadScriptConfig(script);
            if (_configured.TryGetValue(ScriptInterface.Instance.Config.Storage, out bool b) && !b)
                ScriptInterface.Instance.Config.Configure();
            ScriptInterface.Instance.Handlers.Clear();
            ScriptInterface.Instance.Runtime = new ScriptRuntimeVars();
            CurrentScriptThread = new Thread(async () =>
            {
                ScriptCTS = new();
                ScriptStarted?.Invoke();
                try
                {
                    script.GetType().GetMethod("ScriptMain").Invoke(script, new object[] { ScriptInterface.Instance });
                }
                catch (Exception e)
                {
                    if (e is not TargetInvocationException || !stoppedByScript)
                    {
                        Debug.WriteLine($"Error while running script:\r\nMessage: {e.InnerException?.Message ?? e.Message}\r\nStackTrace: {e.InnerException?.StackTrace ?? e.StackTrace}");
                        ScriptError?.Invoke(e);
                    }
                }
                finally
                {
                    stoppedByScript = false;
                    ScriptCTS.Dispose();
                    ScriptCTS = null;
                    if(runScriptStoppingBool)
                    {
                        try
                        {
                            switch (await ScriptInterface.Instance.Events.OnScriptStoppedAsync())
                            {
                                case true:
                                    Debug.WriteLine("Script finished succesfully.");
                                    break;
                                case false:
                                    Debug.WriteLine("Script finished early or with errors.");
                                    break;
                                default:
                                    break;
                            }
                        }
                        catch { }
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
                    ScriptStopped?.Invoke(true);
                }
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

    /// <summary>
    /// Stop the script, wait for 5 seconds then start it again.
    /// </summary>
    public static void RestartScript()
    {
        Debug.WriteLine("Restarting script");
        StopScript(false);
        Task.Run(async () =>
            {
                Thread.Sleep(5000);
                await StartScriptAsync();
            });
    }

    internal static void LoadScriptConfig(object script)
    {
        ScriptOptionContainer opts = ScriptInterface.Instance.Config = new ScriptOptionContainer();
        Type t = script.GetType();
        FieldInfo storageField = t.GetField("OptionsStorage");
        FieldInfo optsField = t.GetField("Options");
        FieldInfo multiOptsField = t.GetField("MultiOptions");
        FieldInfo dontPreconfField = t.GetField("DontPreconfigure");
        if (multiOptsField != null)
        {
            List<FieldInfo> multiOpts = new List<FieldInfo>();
            foreach (string optField in (string[])multiOptsField.GetValue(script))
            {
                FieldInfo fi = t.GetField(optField);
                if (fi != null)
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

    internal static bool stoppedByScript;
    private static bool runScriptStoppingBool;
    /// <summary>
    /// Force the script to stop.
    /// </summary>
    public static void StopScript(bool runScriptStoppingEvent = true)
    {
        runScriptStoppingBool = runScriptStoppingEvent;
        ScriptInterface.exit = true;
        stoppedByScript = true;
        ScriptCTS?.Cancel();
        ScriptInterface.Instance.Wait._ForTrue(() => !ScriptRunning, null, 20);
    }

    internal static object Compile(string source)
    {
        Stopwatch sw = new();
        sw.Start();

        List<MetadataReference> references = new();
        references.Add(MetadataReference.CreateFromFile(typeof(ScriptManager).Assembly.Location));
        string toRemove = "";
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
                        string local = Path.Combine(AppContext.BaseDirectory, parts[1]);
                        if (File.Exists(local))
                            references.Add(MetadataReference.CreateFromFile(local));
                        else if (File.Exists(parts[1]))
                            references.Add(MetadataReference.CreateFromFile(parts[1]));
                        break;
                    case "include":
                        string localSource = Path.Combine(AppContext.BaseDirectory, parts[1]);
                        if (File.Exists(localSource))
                            sources.Add(File.ReadAllText(localSource));
                        else if (File.Exists(parts[1]))
                            sources.Add(File.ReadAllText(parts[1]));
                        break;
                }
                toRemove = $"{toRemove}{line}{Environment.NewLine}";
            }
        }

        if (sources.Count > 1)
        {
            sources[0] = sources[0].Replace(toRemove, "");
            string joinedSource = string.Join('\n', sources);
            List<string> lines = joinedSource.Split('\n').Select(l => l.Trim()).ToList();
            List<string> usings = new();
            for (int i = lines.Count - 1; i >= 0; i--)
            {
                if (lines[i].StartsWith("using") && lines[i].Split(' ').Length == 2)
                {
                    if (!usings.Contains(lines[i]))
                        usings.Add(lines[i]);
                    lines.RemoveAt(i);
                }
            }
            lines.Insert(0, string.Join('\n', usings));
            sources = lines;
        }
        string final = string.Join('\n', sources);

        var refPaths = new[] {
               typeof(object).GetTypeInfo().Assembly.Location,
               typeof(Console).GetTypeInfo().Assembly.Location,
               Path.Combine(Path.GetDirectoryName(typeof(System.Runtime.GCSettings).GetTypeInfo().Assembly.Location), "System.Runtime.dll")
            };

        if (_refCache.Count == 0 && Directory.Exists("plugins"))
            _refCache.AddRange(Directory.GetFiles("plugins", "*.dll").Select(x => Path.Combine(AppContext.BaseDirectory, x)).Where(CanLoadAssembly));
        _refCache.ForEach(x => references.Add(MetadataReference.CreateFromFile(x)));

        var refs = AppDomain.CurrentDomain
            .GetAssemblies()
            .Where(a => !a.IsDynamic)
            .Select(a => a.Location)
            .Where(s => !string.IsNullOrEmpty(s))
            .Where(s => !s.Contains("xunit"))
            .Select(s => MetadataReference.CreateFromFile(s))
            .ToList();
        references.AddRange(refs);
        references.AddRange(refPaths.Select(r => MetadataReference.CreateFromFile(r)).ToArray());

        references.AddRange(new MetadataReference[]
        {
                MetadataReference.CreateFromFile(typeof(object).Assembly.Location),
                MetadataReference.CreateFromFile(typeof(Enumerable).Assembly.Location)
        });

        string assemblyName = Path.GetRandomFileName();
        SyntaxTree syntaxTree = CSharpSyntaxTree.ParseText(final);
        CompiledScript = syntaxTree.GetText().ToString();

        var compilation = CSharpCompilation.Create(
            assemblyName,
            new[] { syntaxTree },
            references,
            new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

        sw.Stop();
        Debug.WriteLine($"Script compilation took {sw.Elapsed.TotalMilliseconds}ms.");

        using var ms = new MemoryStream();

        EmitResult result = compilation.Emit(ms);
        if (result.Success)
        {
            ms.Seek(0, SeekOrigin.Begin);
            Assembly assembly = Assembly.Load(ms.ToArray());
            Type t = assembly.DefinedTypes.First(t => t.GetDeclaredMethod("ScriptMain") != null);
            if (t == null)
                throw new Exception("No declared type with entry point found.");
            return Activator.CreateInstance(t);
        }
        else
        {
            IEnumerable<Diagnostic> failures = result.Diagnostics.Where(diagnostic =>
                diagnostic.IsWarningAsError ||
                diagnostic.Severity == DiagnosticSeverity.Error);
            StringBuilder sb = new();
            foreach (Diagnostic diagnostic in failures)
                sb.AppendLine($"{diagnostic.Id}: {diagnostic.GetMessage()}");
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
