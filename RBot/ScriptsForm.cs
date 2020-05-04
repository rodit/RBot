using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

using RBot.Utils;

namespace RBot
{
    public partial class ScriptsForm : HideForm
    {
        private bool _expanded = false;

        public ScriptsForm() : base()
        {
            InitializeComponent();
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
                ProcessStartInfo psi = new ProcessStartInfo("editor\\ScriptEditor.exe", ScriptManager.LoadedScript);
                psi.WorkingDirectory = Environment.CurrentDirectory;
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
                    ScriptManager.ScriptStopped -= ScriptManager_ScriptStopped;
                    ScriptManager.StopScript();
                    btnStartScript.Text = "Start Script";
                }
                else
                {
                    btnStartScript.Enabled = false;
                    btnStartScript.Text = "Compiling...";

                    Exception ex = await ScriptManager.StartScriptAsync();
                    if (ex != null)
                        MessageBox.Show($"Error while starting script:\r\n{ex}", "Script Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    ScriptManager.ScriptStopped += ScriptManager_ScriptStopped;

                    btnStartScript.Text = "Stop Script";
                    btnStartScript.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("No script loaded.");
            }
        }

        private void ScriptManager_ScriptStopped(bool obj)
        {
            ScriptManager.ScriptStopped -= ScriptManager_ScriptStopped;
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
                        string converted = BotConverter.GenCodeGrimoire(ofd.FileName);
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
                btnAdvanced.Text = "Advanced >>";
            }
            else
            {
                Height = 225;
                btnAdvanced.Text = "Advanced <<";
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
                        string converted = BotConverter.GenCodeGrimoire(ofd.FileName);
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
