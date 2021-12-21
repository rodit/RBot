using RBot.Utils;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace RBot
{
    public partial class ScriptsForm : HideForm
    {
        public ScriptsForm()
        {
            InitializeComponent();
            ScriptManager.ScriptStarted += ScriptManager_ScriptStarted;
            ScriptManager.ScriptStopped += ScriptManager_ScriptStopped;
        }

        private void btnLoadScript_Click(object sender, EventArgs e)
        {
            string directory = Path.Combine(Environment.CurrentDirectory, "Scripts"); ;
            if (ModifierKeys == Keys.Control)
                Process.Start("explorer.exe", directory);
            else
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "RBot Scripts (*.cs)|*.cs";
                    ofd.InitialDirectory = directory;
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        ScriptManager.LoadedScript = ofd.FileName;
                        Text = $"Scripts - {Path.GetFileName(ofd.FileName)}";
                    }
                }
        }

        private void btnEditScript_Click(object sender, EventArgs e)
        {
            if (ScriptManager.LoadedScript != null)
            {
                ProcessStartInfo psi = new ProcessStartInfo("editor\\ScriptEditor.exe", $"\"{ScriptManager.LoadedScript}\"");
                psi.WorkingDirectory = Environment.CurrentDirectory;
                psi.UseShellExecute = false;
                Process.Start(psi);
            }
        }

        private void btnGetScripts_Click(object sender, EventArgs e)
        {
            Forms.Repos.Show();
        }

        private async void btnStartScript_Click(object sender, EventArgs e)
        {
            if (ScriptManager.LoadedScript != null)
            {
                if (ScriptManager.ScriptRunning)
                {
                    ScriptManager.StopScript();
                }
                else
                {
                    btnStartScript.Enabled = false;
                    btnStartScript.Text = "Compiling...";

                    Exception ex = await ScriptManager.StartScriptAsync();
                    if (ex != null)
                    {
                        MessageBox.Show($"Error while starting script:\r\n{ex}", "Script Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnStartScript.Text = "Start Script";
                    }

                    btnStartScript.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("No script loaded.");
            }
        }

        private void ScriptManager_ScriptStarted()
        {
            btnStartScript.CheckedInvoke(() => btnStartScript.Text = "Stop Script");
        }

        private void ScriptManager_ScriptStopped(bool obj)
        {
            btnStartScript.CheckedInvoke(() => btnStartScript.Text = "Start Script");
        }

        private void chkRunOnExit_CheckedChanged(object sender, EventArgs e)
        {
            Bot.Options.RunOnExit = chkRunOnExit.Checked ? txtRunOnExit.Text : null;
        }

        private void btnClearEventHandlers_Click(object sender, EventArgs e)
            => Bot.Events.ClearHandlers();

        private void btnLogs_Click(object sender, EventArgs e)
            => Forms.Log.Show();

        public void AppendText(string text)
            => txtScriptLog.CheckedInvoke(() => txtScriptLog.AppendText(text));

        private void ClearLogs(object sender, EventArgs e)
            => txtScriptLog.CheckedInvoke(() => txtScriptLog.Clear());

        private void SaveLogs(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text Files (*.txt)|*.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                    File.WriteAllText(sfd.FileName, txtScriptLog.Text);
            }
        }
    }
}
