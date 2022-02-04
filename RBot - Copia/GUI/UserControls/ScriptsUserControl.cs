using RBot.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBot
{
    public partial class ScriptsUserControl : UserControl
    {
        public ScriptsUserControl()
        {
            InitializeComponent();
            lblScriptName.Text = "";
            ScriptManager.ScriptStarted += ScriptManager_ScriptStarted;
            ScriptManager.ScriptStopped += ScriptManager_ScriptStopped;
        }

        private void btnLoadScript_Click(object sender, EventArgs e)
        {
            string directory = Path.Combine(Environment.CurrentDirectory, "Scripts"); ;
            if (ModifierKeys == Keys.Control)
                Process.Start("explorer.exe", directory);
            else
            {
                using OpenFileDialog ofd = new();
                ofd.Filter = "RBot Scripts (*.cs)|*.cs";
                ofd.InitialDirectory = directory;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ScriptManager.LoadedScript = ofd.FileName;
                    lblScriptName.Text = $"{Path.GetFileName(ofd.FileName)}";
                    ScriptsTT.SetToolTip(lblScriptName, $"{Path.GetFileName(ofd.FileName)}");
                    lblStatus.Text = "Status: [Script loaded]";
                }
            }
        }

        private void btnEditScript_Click(object sender, EventArgs e)
        {
            if (ModifierKeys == Keys.Control)
                Process.Start("editor\\ScriptEditor.exe");
            else if (ScriptManager.LoadedScript != null)
            {
                ProcessStartInfo psi = new("editor\\ScriptEditor.exe", $"\"{ScriptManager.LoadedScript}\"");
                psi.WorkingDirectory = Environment.CurrentDirectory;
                psi.UseShellExecute = false;
                Process.Start(psi);
            }
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            Forms.Log.Show();
        }

        private void btnGetScripts_Click(object sender, EventArgs e)
        {
            if(ModifierKeys == Keys.Control)
            {
                Forms.Repos.Show();
                return;
            }

            Process.Start("https://github.com/BrenoHenrike/Rbot-Scripts/releases");
        }

        private async void btnStartScript_Click(object sender, EventArgs e)
        {
            if (ScriptManager.LoadedScript is null)
            {
                MessageBox.Show("No script loaded.");
                return;
            }

            if (ScriptManager.ScriptRunning)
            {
                ScriptManager.StopScript();
                return;
            }

            ScriptsTT.SetToolTip(lblStatus, "");
            btnStartScript.Enabled = false;
            btnStartScript.Text = "Compiling...";
            Exception ex = await ScriptManager.StartScriptAsync();
            if (ex is not null)
            {
                MessageBox.Show($"Error while starting script:\r\n{ex}", "Script Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnStartScript.Text = "Start Script";
                lblStatus.Text = "Status: [Error]";
                ScriptsTT.SetToolTip(lblStatus, $"Error while starting script:\r\n{ex}");
            }
            btnStartScript.Enabled = true;
        }

        private void ScriptManager_ScriptStarted()
        {
            lblStatus.CheckedInvoke(() => lblStatus.Text = "Status: [Running]");
            btnStartScript.CheckedInvoke(() => btnStartScript.Text = "Stop Script");
        }

        private void ScriptManager_ScriptStopped(bool obj)
        {
            lblStatus.CheckedInvoke(() => lblStatus.Text = "Status: [Stopped]");
            btnStartScript.CheckedInvoke(() => btnStartScript.Text = "Start Script");
        }
    }
}
