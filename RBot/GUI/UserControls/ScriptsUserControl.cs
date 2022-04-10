using RBot.Utils;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace RBot;

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
        LoadScript();
    }

    internal void LoadScript(string filePath = "")
    {
        string directory = Path.Combine(AppContext.BaseDirectory, "Scripts"); ;
        if (ModifierKeys == Keys.Control)
            Process.Start("explorer.exe", directory);
        else if(!string.IsNullOrEmpty(filePath))
            Load(filePath);
        else
        {
            using OpenFileDialog ofd = new();
            ofd.Filter = "RBot Scripts (*.cs)|*.cs";
            ofd.InitialDirectory = directory;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Load(ofd.FileName);
            }
        }

        void Load(string file)
        {
            ScriptManager.LoadedScript = file;
            lblScriptName.Text = $"{Path.GetFileName(file)}";
            ScriptsTT.SetToolTip(lblScriptName, $"{Path.GetFileName(file)}");
            lblStatus.Text = "Status: [Script loaded]";
        }
    }

    private void btnEditScript_Click(object sender, EventArgs e)
    {
        if (ModifierKeys == Keys.Control)
            Process.Start("editor\\ScriptEditor.exe", File.ReadAllText("editor\\DefaultScript.txt"));
        else if (ScriptManager.LoadedScript != null)
        {
            ProcessStartInfo psi = new("editor\\ScriptEditor.exe", $"\"{ScriptManager.LoadedScript}\"");
            psi.WorkingDirectory = Path.Combine(AppContext.BaseDirectory, "editor");
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
            OpenLink.OpenBrowserLink("https://github.com/BrenoHenrike/Scripts/releases");
            return;
        }
        Forms.Repos.Show();
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
