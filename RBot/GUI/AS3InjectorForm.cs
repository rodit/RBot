using System;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using RBot.Flash;

namespace RBot;

public partial class AS3InjectorForm : HideForm
{
    const string DefaultText = "package {\r\n\r\n\timport flash.display.*;\r\n\timport flash.external.*;\r\n\r\n\tpublic class Patch extends MovieClip {\r\n\r\n\t\tprivate var game:*;\r\n\r\n\t\tpublic function run(root:*) {\r\n\t\t\tgame = root.getGame();\r\n\t\t\t\r\n\t\t\t\r\n\t\t}\r\n\t}\r\n}";

    public string CurrentFile { get; set; }
    private bool _modified;
    public bool Modified
    {
        get => _modified;
        set
        {
            Text = "AS3 Injector - " + (CurrentFile ?? "Unsaved.as") + (value ? "*" : "");
            _modified = value;
        }
    }

    public AS3InjectorForm()
    {
        InitializeComponent();

        KeyPreview = true;
        txtCode.Text = DefaultText;
    }

    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!Modified || MessageBox.Show("The current script has unsaved changes which will be lost if a new script is started. Are you sure you would like to start a new script?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        {
            txtCode.Text = DefaultText;
            CurrentFile = null;
            Modified = false;
        }
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!Modified || MessageBox.Show("The current script has unsaved changes which will be lost if another script is opened. Are you sure you would like to open a new script?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        {
            using OpenFileDialog ofd = new();
            ofd.Filter = "ActionScript Files (*.as)|*.as";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                CurrentFile = ofd.FileName;
                txtCode.Text = File.ReadAllText(CurrentFile);
                Modified = false;
            }
        }
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (CurrentFile == null)
            saveAsToolStripMenuItem.PerformClick();
        else
        {
            File.WriteAllText(CurrentFile, txtCode.Text);
            Modified = false;
        }
    }

    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using SaveFileDialog sfd = new();
        sfd.Filter = "ActionScript Files (*.as)|*.as";
        if (sfd.ShowDialog() == DialogResult.OK)
        {
            CurrentFile = sfd.FileName;
            Modified = false;
            File.WriteAllText(CurrentFile, txtCode.Text);
        }
    }

    private async void injectToolStripMenuItem_Click(object sender, EventArgs e)
    {
        injectToolStripMenuItem.Enabled = false;
        injectToolStripMenuItem.Text = "Compiling...";
        string text = txtCode.Text;
        await Task.Run(() =>
        {
            Directory.CreateDirectory(Path.Combine(AppContext.BaseDirectory, "tmp"));
            File.WriteAllText("tmp/Patch.as", text);

            var p = Process.Start(new ProcessStartInfo("tools/as3compile.exe")
            {
                Arguments = "tmp/Patch.as -o tmp/Patch.swf",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardError = true
            });

            StringBuilder sb = new();
            using (StreamReader err = p.StandardError)
            {
                while (!err.EndOfStream)
                    sb.AppendLine(err.ReadLine());
            }

            p.WaitForExit();
            if (p.ExitCode == 0)
            {
                injectToolStripMenuItem.Text = "Injecting...";
                FlashUtil.Call("injectScript", new Uri(Path.Combine(AppContext.BaseDirectory, "tmp", "Patch.swf")).AbsoluteUri);
            }
            else
                MessageBox.Show($"Compiler exited with code {p.ExitCode}:\r\n{sb}", "Compile Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        });

        injectToolStripMenuItem.Text = "Inject (Ctrl+F5)";
        injectToolStripMenuItem.Enabled = true;
    }

    private void txtCode_TextChanged(object sender, EventArgs e)
    {
        Modified = true;
    }
}
