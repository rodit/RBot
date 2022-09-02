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
            string assemblyPath = $"{AppContext.BaseDirectory}\\Assemblies\\{name.Name}.dll";
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
        Exception ex = (Exception)e.ExceptionObject;
        if(ex.Message.Contains("RBot.Forms"))
        {
            MessageBox.Show("A problem has been found. Please, reinstall RBot and/or .NET.", "Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        MessageBox.Show($"Application Crash.\r\nVersion: {Application.ProductVersion}\r\nMessage: {ex.Message}\r\nStackTrace: {ex.StackTrace}", "Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public static void SetDefaultIcon()
    {
        Icon icon = Icon.ExtractAssociatedIcon(Path.Combine(AppContext.BaseDirectory, "Assemblies\\rbot.ico"));
        typeof(Form).GetField("defaultIcon", BindingFlags.Static | BindingFlags.NonPublic).SetValue(null, icon);
    }
}
