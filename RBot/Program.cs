using System;
using System.Drawing;
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
        AssemblyLoadContext.Default.Resolving += (context, name) => {
            string assemblyPath = $"{Environment.CurrentDirectory}\\Assemblies\\{name.Name}.dll";
            if (assemblyPath != null)
                return context.LoadFromAssemblyPath(assemblyPath);
            return null;
        };
        AppRuntime.Init();

        Application.EnableVisualStyles();
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.SetCompatibleTextRenderingDefault(false);
        SetDefaultIcon();
        Application.Run(new MainForm());
    }

    public static void SetDefaultIcon()
    {
        Icon icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
        typeof(Form).GetField("defaultIcon", BindingFlags.Static | BindingFlags.NonPublic).SetValue(null, icon);
    }
}
