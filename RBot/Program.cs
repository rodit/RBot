using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBot
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
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
}
