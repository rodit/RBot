using RBot.BotConverters.Grimoire;
using RBot.Utils;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace RBot
{
    public partial class ScriptsForm : HideForm
    {
        private readonly GrimoireConverter _grimConverter = new GrimoireConverter();
        private bool _expanded;

        public ScriptsForm()
        {
            InitializeComponent();

            ScriptManager.ScriptStarted += ScriptManager_ScriptStarted;
            ScriptManager.ScriptStopped += ScriptManager_ScriptStopped;
        }

        private void ScriptsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadScript_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "RBot Scripts (*.cs)|*.cs";
                ofd.InitialDirectory = Path.Combine(Environment.CurrentDirectory, "Scripts");
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

        private void btnConvertGbot_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Grimoire Bots (*.gbot)|*.gbot";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string converted = _grimConverter.Convert(ofd.FileName);
                        using (SaveFileDialog sfd = new SaveFileDialog())
                        {
                            sfd.Filter = "RBot Scripts (*.cs)|*.cs";
                            if (sfd.ShowDialog() == DialogResult.OK)
                                File.WriteAllText(sfd.FileName, converted);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error during conversion:\r\n{ex}");
                    }
                }
            }
        }

        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            if (_expanded)
            {
                Height = 167;
                btnAdvanced.Text = ">>";
            }
            else
            {
                Height = 225;
                btnAdvanced.Text = "<<";
            }

            _expanded = !_expanded;
        }

        private void chkRunOnExit_CheckedChanged(object sender, EventArgs e)
        {
            Bot.Options.RunOnExit = chkRunOnExit.Checked ? txtRunOnExit.Text : null;
        }

        private void btnClearEventHandlers_Click(object sender, EventArgs e)
        {
            Bot.Events.ClearHandlers();
        }

        private void btnLoadGbot_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Grimoire Bots (*.gbot)|*.gbot";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string converted = _grimConverter.Convert(ofd.FileName);
                        string save = Path.GetTempFileName() + ".cs";
                        File.WriteAllText(save, converted);
                        ScriptManager.LoadedScript = save;
                        Text = $"Scripts - {Path.GetFileName(ofd.FileName)}";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error during conversion:\r\n{ex}");
                    }
                }
            }
        }
    }
}
