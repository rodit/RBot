using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.Loader;
using System.Windows.Forms;

namespace RBot;

static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        AssemblyLoadContext.Default.Resolving += (context, name) =>
        {
            string assemblyPath = $"{Environment.CurrentDirectory}\\Assemblies\\{name.Name}.dll";
            if (assemblyPath != null)
                return context.LoadFromAssemblyPath(assemblyPath);
            return null;
        };
        var currentDomain = AppDomain.CurrentDomain;
        currentDomain.UnhandledException += CurrentDomain_UnhandledException;

        AppRuntime.Init();

        Application.EnableVisualStyles();
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.SetCompatibleTextRenderingDefault(false);
        SetDefaultIcon();
        Application.Run(new MainForm());
    }

    private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        MessageBox.Show($"A crash has been catched, send an screenshot of this to Breno_Henrike#6959 or ping me at https://discord.io/AQWBots:\r\n{e}", "Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public static void SetDefaultIcon()
    {
        Icon icon = Icon.ExtractAssociatedIcon(Path.Combine(Environment.CurrentDirectory, "Assemblies\\rbot.ico"));
        typeof(Form).GetField("defaultIcon", BindingFlags.Static | BindingFlags.NonPublic).SetValue(null, icon);
    }
}
