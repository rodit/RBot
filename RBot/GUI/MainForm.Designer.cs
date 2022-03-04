namespace RBot
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoReloginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.botOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotkeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cosmeticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aS3InjectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spammerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interceptorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadUnloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadFlashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hidePlayersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDebugHandlersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameContainer = new System.Windows.Forms.Panel();
            this.pnlAuto = new System.Windows.Forms.Panel();
            this.ucAuto = new RBot.AutoUserControl();
            this.pnlJump = new System.Windows.Forms.Panel();
            this.btnJumpWindow = new System.Windows.Forms.Button();
            this.ucJump = new RBot.JumpUserControl();
            this.notifyRBot = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsSystemTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsHide = new System.Windows.Forms.ToolStripMenuItem();
            this.tsShow = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadFlashToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.gameContainer.SuspendLayout();
            this.pnlAuto.SuspendLayout();
            this.pnlJump.SuspendLayout();
            this.cmsSystemTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.scriptsToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.skillsToolStripMenuItem,
            this.packetsToolStripMenuItem,
            this.pluginsToolStripMenuItem,
            this.bankToolStripMenuItem,
            this.logToolStripMenuItem,
            this.jumpToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.autoToolStripMenuItem});
            this.mainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(1036, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // scriptsToolStripMenuItem
            // 
            this.scriptsToolStripMenuItem.Name = "scriptsToolStripMenuItem";
            this.scriptsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.scriptsToolStripMenuItem.Text = "Scripts";
            this.scriptsToolStripMenuItem.Click += new System.EventHandler(this.scriptsToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoReloginToolStripMenuItem,
            this.botOptionsToolStripMenuItem,
            this.scriptOptionsToolStripMenuItem,
            this.applicationOptionsToolStripMenuItem,
            this.hotkeysToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // autoReloginToolStripMenuItem
            // 
            this.autoReloginToolStripMenuItem.Name = "autoReloginToolStripMenuItem";
            this.autoReloginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autoReloginToolStripMenuItem.Text = "Auto Relogin";
            this.autoReloginToolStripMenuItem.Click += new System.EventHandler(this.autoReloginToolStripMenuItem_Click);
            // 
            // botOptionsToolStripMenuItem
            // 
            this.botOptionsToolStripMenuItem.Name = "botOptionsToolStripMenuItem";
            this.botOptionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.botOptionsToolStripMenuItem.Text = "Bot Options";
            this.botOptionsToolStripMenuItem.Click += new System.EventHandler(this.botOptionsToolStripMenuItem_Click);
            // 
            // scriptOptionsToolStripMenuItem
            // 
            this.scriptOptionsToolStripMenuItem.Name = "scriptOptionsToolStripMenuItem";
            this.scriptOptionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.scriptOptionsToolStripMenuItem.Text = "Script Options";
            this.scriptOptionsToolStripMenuItem.Click += new System.EventHandler(this.scriptOptionsToolStripMenuItem_Click);
            // 
            // applicationOptionsToolStripMenuItem
            // 
            this.applicationOptionsToolStripMenuItem.Name = "applicationOptionsToolStripMenuItem";
            this.applicationOptionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.applicationOptionsToolStripMenuItem.Text = "Application Options";
            this.applicationOptionsToolStripMenuItem.Click += new System.EventHandler(this.applicationOptionsToolStripMenuItem_Click);
            // 
            // hotkeysToolStripMenuItem
            // 
            this.hotkeysToolStripMenuItem.Name = "hotkeysToolStripMenuItem";
            this.hotkeysToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hotkeysToolStripMenuItem.Text = "Hotkeys";
            this.hotkeysToolStripMenuItem.Click += new System.EventHandler(this.hotkeysToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cosmeticsToolStripMenuItem,
            this.loadersToolStripMenuItem,
            this.aS3InjectorToolStripMenuItem,
            this.statsToolStripMenuItem,
            this.updatesToolStripMenuItem,
            this.consoleStripMenuItem,
            this.reloadFlashToolStripMenuItem1});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // cosmeticsToolStripMenuItem
            // 
            this.cosmeticsToolStripMenuItem.Name = "cosmeticsToolStripMenuItem";
            this.cosmeticsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cosmeticsToolStripMenuItem.Text = "Cosmetics";
            this.cosmeticsToolStripMenuItem.Click += new System.EventHandler(this.cosmeticsToolStripMenuItem_Click);
            // 
            // loadersToolStripMenuItem
            // 
            this.loadersToolStripMenuItem.Name = "loadersToolStripMenuItem";
            this.loadersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadersToolStripMenuItem.Text = "Loaders";
            this.loadersToolStripMenuItem.Click += new System.EventHandler(this.loadersToolStripMenuItem_Click);
            // 
            // aS3InjectorToolStripMenuItem
            // 
            this.aS3InjectorToolStripMenuItem.Name = "aS3InjectorToolStripMenuItem";
            this.aS3InjectorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aS3InjectorToolStripMenuItem.Text = "As3 Injector";
            this.aS3InjectorToolStripMenuItem.Click += new System.EventHandler(this.aS3InjectorToolStripMenuItem_Click);
            // 
            // statsToolStripMenuItem
            // 
            this.statsToolStripMenuItem.Name = "statsToolStripMenuItem";
            this.statsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.statsToolStripMenuItem.Text = "Stats";
            this.statsToolStripMenuItem.Click += new System.EventHandler(this.statsToolStripMenuItem_Click);
            // 
            // updatesToolStripMenuItem
            // 
            this.updatesToolStripMenuItem.Name = "updatesToolStripMenuItem";
            this.updatesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updatesToolStripMenuItem.Text = "Updates";
            this.updatesToolStripMenuItem.Click += new System.EventHandler(this.updatesToolStripMenuItem_Click);
            // 
            // consoleStripMenuItem
            // 
            this.consoleStripMenuItem.Name = "consoleStripMenuItem";
            this.consoleStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consoleStripMenuItem.Text = "Console";
            this.consoleStripMenuItem.Click += new System.EventHandler(this.consoleStripMenuItem_Click);
            // 
            // skillsToolStripMenuItem
            // 
            this.skillsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleToolStripMenuItem,
            this.advancedToolStripMenuItem});
            this.skillsToolStripMenuItem.Name = "skillsToolStripMenuItem";
            this.skillsToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.skillsToolStripMenuItem.Text = "Skills";
            // 
            // simpleToolStripMenuItem
            // 
            this.simpleToolStripMenuItem.Name = "simpleToolStripMenuItem";
            this.simpleToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.simpleToolStripMenuItem.Text = "Legacy";
            this.simpleToolStripMenuItem.Click += new System.EventHandler(this.simpleToolStripMenuItem_Click);
            // 
            // advancedToolStripMenuItem
            // 
            this.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
            this.advancedToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.advancedToolStripMenuItem.Text = "Advanced";
            this.advancedToolStripMenuItem.Click += new System.EventHandler(this.advancedToolStripMenuItem_Click);
            // 
            // packetsToolStripMenuItem
            // 
            this.packetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spammerToolStripMenuItem,
            this.loggerToolStripMenuItem,
            this.interceptorToolStripMenuItem});
            this.packetsToolStripMenuItem.Name = "packetsToolStripMenuItem";
            this.packetsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.packetsToolStripMenuItem.Text = "Packets";
            // 
            // spammerToolStripMenuItem
            // 
            this.spammerToolStripMenuItem.Name = "spammerToolStripMenuItem";
            this.spammerToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.spammerToolStripMenuItem.Text = "Spammer";
            this.spammerToolStripMenuItem.Click += new System.EventHandler(this.spammerToolStripMenuItem_Click);
            // 
            // loggerToolStripMenuItem
            // 
            this.loggerToolStripMenuItem.Name = "loggerToolStripMenuItem";
            this.loggerToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.loggerToolStripMenuItem.Text = "Logger";
            this.loggerToolStripMenuItem.Click += new System.EventHandler(this.loggerToolStripMenuItem_Click);
            // 
            // interceptorToolStripMenuItem
            // 
            this.interceptorToolStripMenuItem.Name = "interceptorToolStripMenuItem";
            this.interceptorToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.interceptorToolStripMenuItem.Text = "Interceptor";
            this.interceptorToolStripMenuItem.Click += new System.EventHandler(this.interceptorToolStripMenuItem_Click);
            // 
            // pluginsToolStripMenuItem
            // 
            this.pluginsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadUnloadToolStripMenuItem});
            this.pluginsToolStripMenuItem.Name = "pluginsToolStripMenuItem";
            this.pluginsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.pluginsToolStripMenuItem.Text = "Plugins";
            // 
            // loadUnloadToolStripMenuItem
            // 
            this.loadUnloadToolStripMenuItem.Name = "loadUnloadToolStripMenuItem";
            this.loadUnloadToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.loadUnloadToolStripMenuItem.Text = "Plugin Options";
            this.loadUnloadToolStripMenuItem.Click += new System.EventHandler(this.pluginsToolStripMenuItem_Click);
            // 
            // bankToolStripMenuItem
            // 
            this.bankToolStripMenuItem.Name = "bankToolStripMenuItem";
            this.bankToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.bankToolStripMenuItem.Text = "Bank";
            this.bankToolStripMenuItem.Click += new System.EventHandler(this.bankToolStripMenuItem_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.logToolStripMenuItem.Text = "Logs";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // jumpToolStripMenuItem
            // 
            this.jumpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.jumpToolStripMenuItem.Name = "jumpToolStripMenuItem";
            this.jumpToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.jumpToolStripMenuItem.Text = "Jump ⇲";
            this.jumpToolStripMenuItem.Click += new System.EventHandler(this.ShowJump);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadFlashToolStripMenuItem,
            this.setNameToolStripMenuItem,
            this.hidePlayersToolStripMenuItem,
            this.addDebugHandlersToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // reloadFlashToolStripMenuItem
            // 
            this.reloadFlashToolStripMenuItem.Name = "reloadFlashToolStripMenuItem";
            this.reloadFlashToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.reloadFlashToolStripMenuItem.Text = "Reload Flash";
            this.reloadFlashToolStripMenuItem.Click += new System.EventHandler(this.reloadFlashToolStripMenuItem_Click);
            // 
            // setNameToolStripMenuItem
            // 
            this.setNameToolStripMenuItem.Name = "setNameToolStripMenuItem";
            this.setNameToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.setNameToolStripMenuItem.Text = "Set Name";
            this.setNameToolStripMenuItem.Click += new System.EventHandler(this.setNameToolStripMenuItem_Click);
            // 
            // hidePlayersToolStripMenuItem
            // 
            this.hidePlayersToolStripMenuItem.Name = "hidePlayersToolStripMenuItem";
            this.hidePlayersToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.hidePlayersToolStripMenuItem.Text = "Hide Players";
            this.hidePlayersToolStripMenuItem.Click += new System.EventHandler(this.hidePlayersToolStripMenuItem_Click);
            // 
            // addDebugHandlersToolStripMenuItem
            // 
            this.addDebugHandlersToolStripMenuItem.Name = "addDebugHandlersToolStripMenuItem";
            this.addDebugHandlersToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.addDebugHandlersToolStripMenuItem.Text = "Add Debug Handlers";
            this.addDebugHandlersToolStripMenuItem.Click += new System.EventHandler(this.addDebugHandlersToolStripMenuItem_Click);
            // 
            // autoToolStripMenuItem
            // 
            this.autoToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.autoToolStripMenuItem.Name = "autoToolStripMenuItem";
            this.autoToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.autoToolStripMenuItem.Text = "Auto ⇲";
            this.autoToolStripMenuItem.Click += new System.EventHandler(this.autoToolStripMenuItem_Click);
            // 
            // gameContainer
            // 
            this.gameContainer.Controls.Add(this.pnlAuto);
            this.gameContainer.Controls.Add(this.pnlJump);
            this.gameContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameContainer.Location = new System.Drawing.Point(0, 24);
            this.gameContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gameContainer.Name = "gameContainer";
            this.gameContainer.Size = new System.Drawing.Size(1036, 595);
            this.gameContainer.TabIndex = 1;
            // 
            // pnlAuto
            // 
            this.pnlAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAuto.AutoSize = true;
            this.pnlAuto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlAuto.Controls.Add(this.ucAuto);
            this.pnlAuto.Location = new System.Drawing.Point(698, 1);
            this.pnlAuto.Name = "pnlAuto";
            this.pnlAuto.Size = new System.Drawing.Size(338, 396);
            this.pnlAuto.TabIndex = 6;
            // 
            // ucAuto
            // 
            this.ucAuto.Location = new System.Drawing.Point(0, -1);
            this.ucAuto.MinimumSize = new System.Drawing.Size(335, 393);
            this.ucAuto.Name = "ucAuto";
            this.ucAuto.Size = new System.Drawing.Size(335, 393);
            this.ucAuto.TabIndex = 0;
            // 
            // pnlJump
            // 
            this.pnlJump.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlJump.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlJump.Controls.Add(this.btnJumpWindow);
            this.pnlJump.Controls.Add(this.ucJump);
            this.pnlJump.Location = new System.Drawing.Point(790, 1);
            this.pnlJump.Name = "pnlJump";
            this.pnlJump.Size = new System.Drawing.Size(245, 90);
            this.pnlJump.TabIndex = 6;
            // 
            // btnJumpWindow
            // 
            this.btnJumpWindow.Location = new System.Drawing.Point(5, 61);
            this.btnJumpWindow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnJumpWindow.Name = "btnJumpWindow";
            this.btnJumpWindow.Size = new System.Drawing.Size(235, 25);
            this.btnJumpWindow.TabIndex = 5;
            this.btnJumpWindow.Text = "Open Jump Window";
            this.btnJumpWindow.UseVisualStyleBackColor = true;
            this.btnJumpWindow.Click += new System.EventHandler(this.btnJumpWindow_Click);
            // 
            // ucJump
            // 
            this.ucJump.Location = new System.Drawing.Point(0, -1);
            this.ucJump.Name = "ucJump";
            this.ucJump.Size = new System.Drawing.Size(245, 61);
            this.ucJump.TabIndex = 0;
            // 
            // notifyRBot
            // 
            this.notifyRBot.ContextMenuStrip = this.cmsSystemTray;
            this.notifyRBot.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyRBot.Icon")));
            this.notifyRBot.Text = "Rbot";
            this.notifyRBot.Visible = true;
            this.notifyRBot.DoubleClick += new System.EventHandler(this.notifyRBot_DoubleClick);
            // 
            // cmsSystemTray
            // 
            this.cmsSystemTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsHide,
            this.tsShow});
            this.cmsSystemTray.Name = "cmsSystemTray";
            this.cmsSystemTray.Size = new System.Drawing.Size(104, 48);
            // 
            // tsHide
            // 
            this.tsHide.Name = "tsHide";
            this.tsHide.Size = new System.Drawing.Size(103, 22);
            this.tsHide.Text = "Hide";
            this.tsHide.Click += new System.EventHandler(this.tsHide_Click);
            // 
            // tsShow
            // 
            this.tsShow.Name = "tsShow";
            this.tsShow.Size = new System.Drawing.Size(103, 22);
            this.tsShow.Text = "Show";
            this.tsShow.Click += new System.EventHandler(this.tsShow_Click);
            // 
            // reloadFlashToolStripMenuItem1
            // 
            this.reloadFlashToolStripMenuItem1.Name = "reloadFlashToolStripMenuItem1";
            this.reloadFlashToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.reloadFlashToolStripMenuItem1.Text = "Reload Flash";
            this.reloadFlashToolStripMenuItem1.Click += new System.EventHandler(this.reloadFlashToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 619);
            this.Controls.Add(this.gameContainer);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RBot";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.gameContainer.ResumeLayout(false);
            this.gameContainer.PerformLayout();
            this.pnlAuto.ResumeLayout(false);
            this.pnlJump.ResumeLayout(false);
            this.cmsSystemTray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadFlashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hidePlayersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scriptsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem botOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scriptOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoReloginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spammerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interceptorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jumpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pluginsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDebugHandlersToolStripMenuItem;
        private System.Windows.Forms.Panel gameContainer;
        private System.Windows.Forms.Button btnJumpWindow;
        private System.Windows.Forms.ToolStripMenuItem simpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadUnloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cosmeticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aS3InjectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel pnlJump;
        private JumpUserControl ucJump;
        private System.Windows.Forms.ToolStripMenuItem autoToolStripMenuItem;
        private System.Windows.Forms.Panel pnlAuto;
        private AutoUserControl ucAuto;
        private System.Windows.Forms.ToolStripMenuItem consoleStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyRBot;
        private System.Windows.Forms.ContextMenuStrip cmsSystemTray;
        private System.Windows.Forms.ToolStripMenuItem tsHide;
        private System.Windows.Forms.ToolStripMenuItem tsShow;
        private System.Windows.Forms.ToolStripMenuItem hotkeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadFlashToolStripMenuItem1;
    }
}

