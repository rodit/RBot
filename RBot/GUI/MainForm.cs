using AxShockwaveFlashObjects;
using RBot.Flash;
using RBot.Options;
using RBot.PatchProxy;
using RBot.Plugins;
using RBot.Updates;
using RBot.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RBot;

public partial class MainForm : Form
{
    public static ScriptInterface Bot => ScriptInterface.Instance;
    public MenuStrip MainMenu => mainMenu;
    public ToolStripMenuItem Plugins => pluginsToolStripMenuItem;
    internal NotifyIcon NotifyIcon => notifyRBot;

    public MainForm()
    {
        Forms.Main = this;

        if (AppRuntime.Options.Get<bool>("proxy.enabled"))
        {
            (RProxyServer.Instance = new RProxyServer(AppRuntime.Options.Get<int>("proxy.port"))).Start();
            WinINetProxyHook.Hook();
        }

        InitializeComponent();
        InitFlash();

        pnlJump.Visible = false;
        pnlAuto.Visible = false;

        Bot.Init();
        PluginManager.Init();

        KeyPreview = true;
        FormClosing += MainForm_FormClosing;

        debugToolStripMenuItem.Visible = Debugger.IsAttached;
        if (Debugger.IsAttached)
        {
            Forms.Log.Show();
            Debug.WriteLine("Debugger is attached.");
        }

        Text = $"RBot {Application.ProductVersion}";

        ScriptManager.ScriptStarted += TrayNotificationScriptStart;
        ScriptManager.ScriptStopped += TrayNotificationScriptStopped;
        ScriptManager.ScriptError += TrayNotificationScriptError;
    }

    private void TrayNotificationScriptError(Exception obj)
    {
        ShowBalloonTip("Script Error", $"{Bot.Player.Username ?? "[No name]"} - Script Manager encountered an error.", ToolTipIcon.Error);
    }

    private void TrayNotificationScriptStopped(bool obj)
    {
        ShowBalloonTip("Script Stopped", $"{Bot.Player.Username ?? "[No name]"} - The script has been stopped.", ToolTipIcon.Info);
    }

    private void TrayNotificationScriptStart()
    {
        ShowBalloonTip("Script Started", $"{Bot.Player.Username ?? "[No name]"} - The script has been started.", ToolTipIcon.Info);
    }

    private void ShowBalloonTip(string title, string text, ToolTipIcon icon)
    {
        if(!Visible)
            notifyRBot.ShowBalloonTip(5000, title, text, icon);
    }

    internal void StopAuto() => ucAuto.Stop("Script started");

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        IOption opt = AppRuntime.Options.Options.Find(x => x.Name.StartsWith("binding.") && (Keys)AppRuntime.Options.Get<int>(x) == keyData);
        if (opt != null)
        {
            ProcessBinding(opt.Name.Split('.')[1]);
            return true;
        }
        return base.ProcessCmdKey(ref msg, keyData);
    }

    private static void ProcessBinding(string binding)
    {
        if (binding == null)
            return;

        if (binding == "bank")
        {
            Bot.Player.OpenBank();
            return;
        }

        if(binding == "console")
        {
            Forms.Console.Show();
            return;
        }

        Forms.Scripts.Show();
        switch (binding)
        {
            case "start":
                if (!ScriptManager.ScriptRunning)
                    Forms.Scripts.ToggleScript();
                break;
            case "stop":
                if (ScriptManager.ScriptRunning)
                    Forms.Scripts.ToggleScript();
                break;
            case "toggle":
                Forms.Scripts.ToggleScript();
                break;
            case "load":
                Forms.Scripts.LoadScript();
                break;
        }
    }

    private void consoleStripMenuItem_Click(object sender, EventArgs e)
    {
        Forms.Console.Show();
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        notifyRBot.Visible = false;
        notifyRBot.Dispose();
        Bot.Exit();
        Environment.Exit(0);
    }

    public void InitFlash()
    {
        if (!EoLHook.IsHooked)
            EoLHook.Hook();

        FlashUtil.Flash?.Dispose();

        AxShockwaveFlash flash = new();
        flash.BeginInit();
        flash.Name = "flash";
        flash.Dock = DockStyle.Fill;
        flash.TabIndex = 0;
        flash.FlashCall += FlashUtil.CallHandler;
        gameContainer.Controls.Add(flash);
        flash.EndInit();
        FlashUtil.Flash = flash;

        byte[] swf = File.ReadAllBytes("rbot.swf");
        using (MemoryStream stream = new())
        using (BinaryWriter writer = new(stream))
        {
            writer.Write(8 + swf.Length);
            writer.Write(1432769894);
            writer.Write(swf.Length);
            writer.Write(swf);
            writer.Seek(0, SeekOrigin.Begin);
            flash.OcxState = new AxHost.State(stream, 1, false, null);
        }

        EoLHook.Unhook();
    }

    private async void MainForm_Load(object sender, EventArgs e)
    {
        if (!AppRuntime.Options.Get<bool>("updates.check"))
            return;

        List<UpdateInfo> infos = await UpdateChecker.GetReleases();
        UpdateInfo latest = infos.OrderByDescending(x => x.ParsedVersion).FirstOrDefault(x => AppRuntime.Options.Get<bool>("updates.beta") || !x.Prerelease);

        if (latest == null || latest.ParsedVersion.CompareTo(Version.Parse(Application.ProductVersion)) <= 0)
            return;

        if (MessageBox.Show($"An update is available:\r\n{latest.Name}\r\nVersion: {latest.Version}\r\n{(latest.Prerelease ? "This is a prerelease update.\r\n" : "")}Would you like to download it?",
                            "Update Available",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information) == DialogResult.Yes)
            Process.Start(latest.URL);
    }

    #region MainMenu

    private void scriptOptionsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (ScriptManager.LoadedScript == null)
        {
            if (MessageBox.Show("No script is currently loaded. Please load a script to edit its options.", "No Script Loaded", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                Forms.Scripts.Show();
            }
        }
        else
        {
            try
            {
                object compiled = ScriptManager.Compile(File.ReadAllText(ScriptManager.LoadedScript));
                ScriptManager.LoadScriptConfig(compiled);
                if (Bot.Config.Options.Count > 0 || Bot.Config.MultipleOptions.Count > 0)
                {
                    using GenericOptionsForm gof = new() { Container = Bot.Config };
                    gof.ShowDialog();
                }
                else
                    MessageBox.Show("The loaded script has no options to configure.", "No Options", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Script cannot be configured as it has compilation errors:\r\n" + ex);
            }
        }
    }

    private void scriptsToolStripMenuItem_Click(object sender, EventArgs e)
        => Forms.Scripts.Show();

    private void botOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        => Forms.Options.Show();

    private void applicationOptionsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using GenericOptionsForm gof = new() { Container = AppRuntime.Options };
        gof.ShowDialog();
    }

    private void autoReloginToolStripMenuItem_Click(object sender, EventArgs e)
        => Forms.AutoRelogin.Show();

    private void logToolStripMenuItem_Click(object sender, EventArgs e)
        => Forms.Log.Show();

    private void skillsToolStripMenuItem_Click(object sender, EventArgs e)
        => Forms.AdvancedSkills.Show();

    private void spammerToolStripMenuItem_Click(object sender, EventArgs e)
        => Forms.PacketSpammer.Show();

    private void loggerToolStripMenuItem_Click(object sender, EventArgs e)
        => Forms.PacketLogger.Show();

    private void interceptorToolStripMenuItem_Click(object sender, EventArgs e)
        => Forms.PacketInterceptor.Show();

    private void loadersToolStripMenuItem_Click(object sender, EventArgs e)
        => Forms.Loaders.Show();

    private void bankToolStripMenuItem_Click(object sender, EventArgs e)
        => Bot.Player.OpenBank();

    private void aS3InjectorToolStripMenuItem_Click(object sender, EventArgs e)
        => Forms.Injector.Show();

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        => Forms.About.Show();

    private void pluginsToolStripMenuItem_Click(object sender, EventArgs e)
        => Forms.Plugins.Show();

    private void updatesToolStripMenuItem_Click(object sender, EventArgs e)
        => Forms.Updates.Show();

    private void statsToolStripMenuItem_Click(object sender, EventArgs e)
        => Forms.Stats.Show();

    private void cosmeticsToolStripMenuItem_Click(object sender, EventArgs e)
        => Forms.Cosmetics.Show();

    private void btnJumpWindow_Click(object sender, EventArgs e)
        => Forms.Jump.Show();

    private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        => Forms.Skills.Show();

    private void advancedToolStripMenuItem_Click(object sender, EventArgs e)
        => Forms.AdvancedSkills.Show();

    #endregion MainMenu

    #region Debug

    private void addDebugHandlersToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Bot.Events.CellChanged += (_, m, c, p) => Debug.WriteLine($"CellChanged: {m}: {c}, {p}");
        Bot.Events.MapChanged += (_, m) => Debug.WriteLine($"MapChanged: {m}");
        Bot.Events.MonsterKilled += _ => Debug.WriteLine("MonsterKilled");
        Bot.Events.PlayerAFK += _ => Debug.WriteLine("PlayerAFK");
        Bot.Events.PlayerDeath += _ => Debug.WriteLine("PlayerDeath");
        Bot.Events.QuestAccepted += (_, q) => Debug.WriteLine($"QuestAccepted: {q}");
        Bot.Events.QuestTurnedIn += (_, q) => Debug.WriteLine($"QuestTurnedIn: {q}");
        Bot.Events.ReloginTriggered += (_, k) => Debug.WriteLine($"ReloginTriggered: {k}");
        Bot.Events.TryBuyItem += (_, id, sid, siid) => Debug.WriteLine($"TryBuyItem: {id}, {sid}, {siid}");
    }

    private void reloadFlashToolStripMenuItem_Click(object sender, EventArgs e)
        => InitFlash();

    private void setNameToolStripMenuItem_Click(object sender, EventArgs e)
        => Bot.Options.CustomName = "ARTIX";

    private void hidePlayersToolStripMenuItem_Click(object sender, EventArgs e)
        => Bot.Options.HidePlayers = !ScriptInterface.Instance.Options.HidePlayers;

    #endregion Debug

    private void ShowJump(object sender, EventArgs e)
    {
        if (ModifierKeys == Keys.Control)
        {
            Forms.Jump.Show();
            return;
        }
        pnlJump.Visible = !pnlJump.Visible;
        if (pnlAuto.Visible)
        {
            pnlAuto.Visible = false;
            autoToolStripMenuItem.Text = pnlAuto.Visible ? "Auto ⇱" : "Auto ⇲";
        }
        jumpToolStripMenuItem.Text = pnlJump.Visible ? "Jump ⇱" : "Jump ⇲";
    }

    private void autoToolStripMenuItem_Click(object sender, EventArgs e)
    {
        pnlAuto.Visible = !pnlAuto.Visible;
        if (pnlJump.Visible)
        {
            pnlJump.Visible = false;
            jumpToolStripMenuItem.Text = pnlJump.Visible ? "Jump ⇱" : "Jump ⇲";
        }
        autoToolStripMenuItem.Text = pnlAuto.Visible ? "Auto ⇱" : "Auto ⇲";
    }

    private void tsHide_Click(object sender, EventArgs e)
    {
        Hide();
    }

    private void tsShow_Click(object sender, EventArgs e)
    {
        Show();
    }

    private void notifyRBot_DoubleClick(object sender, EventArgs e)
    {
        if (Visible)
        {
            Hide();
            return;
        }

        Show();
    }
}
