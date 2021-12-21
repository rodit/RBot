using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Windows;

namespace ScriptEditor
{
    public partial class App : Application
    {
        public static string StartupFile { get; set; }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            bool flag = e.Args.Length != 0;
            if (flag)
            {
                StartupFile = e.Args[0];
            }
        }
    }
}
