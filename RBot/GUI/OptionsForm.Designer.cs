namespace RBot
{
    partial class OptionsForm
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
            this.chkInfiniteRange = new System.Windows.Forms.CheckBox();
            this.chkAggro = new System.Windows.Forms.CheckBox();
            this.chkMagnet = new System.Windows.Forms.CheckBox();
            this.chkPrivRooms = new System.Windows.Forms.CheckBox();
            this.chkSkipCutscenes = new System.Windows.Forms.CheckBox();
            this.chkLagKiller = new System.Windows.Forms.CheckBox();
            this.chkHidePlayers = new System.Windows.Forms.CheckBox();
            this.chkAcceptAll = new System.Windows.Forms.CheckBox();
            this.chkRejectAll = new System.Windows.Forms.CheckBox();
            this.chkUpgrade = new System.Windows.Forms.CheckBox();
            this.chkStaff = new System.Windows.Forms.CheckBox();
            this.chkFpsCounter = new System.Windows.Forms.CheckBox();
            this.chkDisableFX = new System.Windows.Forms.CheckBox();
            this.chkDisableCols = new System.Windows.Forms.CheckBox();
            this.numWalkSpeed = new System.Windows.Forms.NumericUpDown();
            this.lblWalkSpeed = new System.Windows.Forms.Label();
            this.btnSetFpsCap = new System.Windows.Forms.Button();
            this.numFpsCap = new System.Windows.Forms.NumericUpDown();
            this.txtCustomName = new System.Windows.Forms.TextBox();
            this.btnSetName = new System.Windows.Forms.Button();
            this.btnSetGuild = new System.Windows.Forms.Button();
            this.txtCustomGuild = new System.Windows.Forms.TextBox();
            this.dropTimer = new System.Windows.Forms.Timer(this.components);
            this.btnReloadMap = new System.Windows.Forms.Button();
            this.btnHotkeys = new System.Windows.Forms.Button();
            this.chkCheckSpace = new System.Windows.Forms.CheckBox();
            this.Check = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.freeInvLabel = new System.Windows.Forms.Label();
            this.filledInvLabel = new System.Windows.Forms.Label();
            this.maxInvLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.freeBankLabel = new System.Windows.Forms.Label();
            this.filledBankLabel = new System.Windows.Forms.Label();
            this.maxBankLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numWalkSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFpsCap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkInfiniteRange
            // 
            this.chkInfiniteRange.AutoSize = true;
            this.chkInfiniteRange.Location = new System.Drawing.Point(5, 10);
            this.chkInfiniteRange.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkInfiniteRange.Name = "chkInfiniteRange";
            this.chkInfiniteRange.Size = new System.Drawing.Size(99, 19);
            this.chkInfiniteRange.TabIndex = 0;
            this.chkInfiniteRange.Text = "Infinite Range";
            this.chkInfiniteRange.UseVisualStyleBackColor = true;
            // 
            // chkAggro
            // 
            this.chkAggro.AutoSize = true;
            this.chkAggro.Location = new System.Drawing.Point(5, 35);
            this.chkAggro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkAggro.Name = "chkAggro";
            this.chkAggro.Size = new System.Drawing.Size(111, 19);
            this.chkAggro.TabIndex = 1;
            this.chkAggro.Text = "Aggro Monsters";
            this.chkAggro.UseVisualStyleBackColor = true;
            // 
            // chkMagnet
            // 
            this.chkMagnet.AutoSize = true;
            this.chkMagnet.Location = new System.Drawing.Point(5, 60);
            this.chkMagnet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkMagnet.Name = "chkMagnet";
            this.chkMagnet.Size = new System.Drawing.Size(106, 19);
            this.chkMagnet.TabIndex = 2;
            this.chkMagnet.Text = "Enemy Magnet";
            this.chkMagnet.UseVisualStyleBackColor = true;
            // 
            // chkPrivRooms
            // 
            this.chkPrivRooms.AutoSize = true;
            this.chkPrivRooms.Location = new System.Drawing.Point(5, 85);
            this.chkPrivRooms.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkPrivRooms.Name = "chkPrivRooms";
            this.chkPrivRooms.Size = new System.Drawing.Size(102, 19);
            this.chkPrivRooms.TabIndex = 3;
            this.chkPrivRooms.Text = "Private Rooms";
            this.chkPrivRooms.UseVisualStyleBackColor = true;
            // 
            // chkSkipCutscenes
            // 
            this.chkSkipCutscenes.AutoSize = true;
            this.chkSkipCutscenes.Location = new System.Drawing.Point(5, 110);
            this.chkSkipCutscenes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkSkipCutscenes.Name = "chkSkipCutscenes";
            this.chkSkipCutscenes.Size = new System.Drawing.Size(105, 19);
            this.chkSkipCutscenes.TabIndex = 4;
            this.chkSkipCutscenes.Text = "Skip Cutscenes";
            this.chkSkipCutscenes.UseVisualStyleBackColor = true;
            // 
            // chkLagKiller
            // 
            this.chkLagKiller.AutoSize = true;
            this.chkLagKiller.Location = new System.Drawing.Point(5, 135);
            this.chkLagKiller.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkLagKiller.Name = "chkLagKiller";
            this.chkLagKiller.Size = new System.Drawing.Size(74, 19);
            this.chkLagKiller.TabIndex = 5;
            this.chkLagKiller.Text = "Lag Killer";
            this.chkLagKiller.UseVisualStyleBackColor = true;
            // 
            // chkHidePlayers
            // 
            this.chkHidePlayers.AutoSize = true;
            this.chkHidePlayers.Location = new System.Drawing.Point(5, 160);
            this.chkHidePlayers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkHidePlayers.Name = "chkHidePlayers";
            this.chkHidePlayers.Size = new System.Drawing.Size(91, 19);
            this.chkHidePlayers.TabIndex = 6;
            this.chkHidePlayers.Text = "Hide Players";
            this.chkHidePlayers.UseVisualStyleBackColor = true;
            // 
            // chkAcceptAll
            // 
            this.chkAcceptAll.AutoSize = true;
            this.chkAcceptAll.Location = new System.Drawing.Point(180, 10);
            this.chkAcceptAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkAcceptAll.Name = "chkAcceptAll";
            this.chkAcceptAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkAcceptAll.Size = new System.Drawing.Size(114, 19);
            this.chkAcceptAll.TabIndex = 7;
            this.chkAcceptAll.Text = "Accept All Drops";
            this.chkAcceptAll.UseVisualStyleBackColor = true;
            this.chkAcceptAll.CheckedChanged += new System.EventHandler(this.chkAcceptAll_CheckedChanged);
            // 
            // chkRejectAll
            // 
            this.chkRejectAll.AutoSize = true;
            this.chkRejectAll.Location = new System.Drawing.Point(180, 35);
            this.chkRejectAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkRejectAll.Name = "chkRejectAll";
            this.chkRejectAll.Size = new System.Drawing.Size(109, 19);
            this.chkRejectAll.TabIndex = 8;
            this.chkRejectAll.Text = "Reject All Drops";
            this.chkRejectAll.UseVisualStyleBackColor = true;
            this.chkRejectAll.CheckedChanged += new System.EventHandler(this.chkRejectAll_CheckedChanged);
            // 
            // chkUpgrade
            // 
            this.chkUpgrade.AutoSize = true;
            this.chkUpgrade.Location = new System.Drawing.Point(180, 60);
            this.chkUpgrade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkUpgrade.Name = "chkUpgrade";
            this.chkUpgrade.Size = new System.Drawing.Size(71, 19);
            this.chkUpgrade.TabIndex = 9;
            this.chkUpgrade.Text = "Upgrade";
            this.chkUpgrade.UseVisualStyleBackColor = true;
            this.chkUpgrade.CheckedChanged += new System.EventHandler(this.chkUpgrade_CheckedChanged);
            // 
            // chkStaff
            // 
            this.chkStaff.AutoSize = true;
            this.chkStaff.Location = new System.Drawing.Point(180, 85);
            this.chkStaff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkStaff.Name = "chkStaff";
            this.chkStaff.Size = new System.Drawing.Size(50, 19);
            this.chkStaff.TabIndex = 10;
            this.chkStaff.Text = "Staff";
            this.chkStaff.UseVisualStyleBackColor = true;
            this.chkStaff.CheckedChanged += new System.EventHandler(this.chkStaff_CheckedChanged);
            // 
            // chkFpsCounter
            // 
            this.chkFpsCounter.AutoSize = true;
            this.chkFpsCounter.Location = new System.Drawing.Point(180, 110);
            this.chkFpsCounter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkFpsCounter.Name = "chkFpsCounter";
            this.chkFpsCounter.Size = new System.Drawing.Size(91, 19);
            this.chkFpsCounter.TabIndex = 11;
            this.chkFpsCounter.Text = "FPS Counter";
            this.chkFpsCounter.UseVisualStyleBackColor = true;
            this.chkFpsCounter.CheckedChanged += new System.EventHandler(this.chkFpsCounter_CheckedChanged);
            // 
            // chkDisableFX
            // 
            this.chkDisableFX.AutoSize = true;
            this.chkDisableFX.Location = new System.Drawing.Point(180, 135);
            this.chkDisableFX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkDisableFX.Name = "chkDisableFX";
            this.chkDisableFX.Size = new System.Drawing.Size(80, 19);
            this.chkDisableFX.TabIndex = 12;
            this.chkDisableFX.Text = "Disable FX";
            this.chkDisableFX.UseVisualStyleBackColor = true;
            // 
            // chkDisableCols
            // 
            this.chkDisableCols.AutoSize = true;
            this.chkDisableCols.Location = new System.Drawing.Point(180, 160);
            this.chkDisableCols.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkDisableCols.Name = "chkDisableCols";
            this.chkDisableCols.Size = new System.Drawing.Size(118, 19);
            this.chkDisableCols.TabIndex = 13;
            this.chkDisableCols.Text = "Disable Collisions";
            this.chkDisableCols.UseVisualStyleBackColor = true;
            // 
            // numWalkSpeed
            // 
            this.numWalkSpeed.Location = new System.Drawing.Point(80, 183);
            this.numWalkSpeed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numWalkSpeed.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numWalkSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWalkSpeed.Name = "numWalkSpeed";
            this.numWalkSpeed.Size = new System.Drawing.Size(94, 23);
            this.numWalkSpeed.TabIndex = 14;
            this.numWalkSpeed.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lblWalkSpeed
            // 
            this.lblWalkSpeed.AutoSize = true;
            this.lblWalkSpeed.Location = new System.Drawing.Point(5, 186);
            this.lblWalkSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWalkSpeed.Name = "lblWalkSpeed";
            this.lblWalkSpeed.Size = new System.Drawing.Size(71, 15);
            this.lblWalkSpeed.TabIndex = 15;
            this.lblWalkSpeed.Text = "Walk Speed:";
            // 
            // btnSetFpsCap
            // 
            this.btnSetFpsCap.Location = new System.Drawing.Point(180, 214);
            this.btnSetFpsCap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSetFpsCap.Name = "btnSetFpsCap";
            this.btnSetFpsCap.Size = new System.Drawing.Size(115, 25);
            this.btnSetFpsCap.TabIndex = 16;
            this.btnSetFpsCap.Text = "Set FPS Cap";
            this.btnSetFpsCap.UseVisualStyleBackColor = true;
            this.btnSetFpsCap.Click += new System.EventHandler(this.btnSetFpsCap_Click);
            // 
            // numFpsCap
            // 
            this.numFpsCap.Location = new System.Drawing.Point(5, 215);
            this.numFpsCap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numFpsCap.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numFpsCap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFpsCap.Name = "numFpsCap";
            this.numFpsCap.Size = new System.Drawing.Size(170, 23);
            this.numFpsCap.TabIndex = 17;
            this.numFpsCap.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // txtCustomName
            // 
            this.txtCustomName.Location = new System.Drawing.Point(5, 243);
            this.txtCustomName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCustomName.Name = "txtCustomName";
            this.txtCustomName.Size = new System.Drawing.Size(170, 23);
            this.txtCustomName.TabIndex = 18;
            // 
            // btnSetName
            // 
            this.btnSetName.Location = new System.Drawing.Point(180, 242);
            this.btnSetName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSetName.Name = "btnSetName";
            this.btnSetName.Size = new System.Drawing.Size(115, 25);
            this.btnSetName.TabIndex = 19;
            this.btnSetName.Text = "Set Name";
            this.btnSetName.UseVisualStyleBackColor = true;
            this.btnSetName.Click += new System.EventHandler(this.btnSetName_Click);
            // 
            // btnSetGuild
            // 
            this.btnSetGuild.Location = new System.Drawing.Point(180, 270);
            this.btnSetGuild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSetGuild.Name = "btnSetGuild";
            this.btnSetGuild.Size = new System.Drawing.Size(115, 25);
            this.btnSetGuild.TabIndex = 21;
            this.btnSetGuild.Text = "Set Guild";
            this.btnSetGuild.UseVisualStyleBackColor = true;
            this.btnSetGuild.Click += new System.EventHandler(this.btnSetGuild_Click);
            // 
            // txtCustomGuild
            // 
            this.txtCustomGuild.Location = new System.Drawing.Point(5, 271);
            this.txtCustomGuild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCustomGuild.Name = "txtCustomGuild";
            this.txtCustomGuild.Size = new System.Drawing.Size(170, 23);
            this.txtCustomGuild.TabIndex = 20;
            // 
            // dropTimer
            // 
            this.dropTimer.Interval = 3000;
            this.dropTimer.Tick += new System.EventHandler(this.dropTimer_Tick);
            // 
            // btnReloadMap
            // 
            this.btnReloadMap.Location = new System.Drawing.Point(5, 300);
            this.btnReloadMap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReloadMap.Name = "btnReloadMap";
            this.btnReloadMap.Size = new System.Drawing.Size(290, 23);
            this.btnReloadMap.TabIndex = 22;
            this.btnReloadMap.Text = "Reload Map";
            this.btnReloadMap.UseVisualStyleBackColor = true;
            this.btnReloadMap.Click += new System.EventHandler(this.btnReloadMap_Click);
            // 
            // btnHotkeys
            // 
            this.btnHotkeys.Location = new System.Drawing.Point(5, 329);
            this.btnHotkeys.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHotkeys.Name = "btnHotkeys";
            this.btnHotkeys.Size = new System.Drawing.Size(290, 23);
            this.btnHotkeys.TabIndex = 23;
            this.btnHotkeys.Text = "Hotkeys";
            this.btnHotkeys.UseVisualStyleBackColor = true;
            this.btnHotkeys.Click += new System.EventHandler(this.btnHotkeys_Click);
            // 
            // chkCheckSpace
            // 
            this.chkCheckSpace.AutoSize = true;
            this.chkCheckSpace.Location = new System.Drawing.Point(180, 185);
            this.chkCheckSpace.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkCheckSpace.Name = "chkCheckSpace";
            this.chkCheckSpace.Size = new System.Drawing.Size(93, 19);
            this.chkCheckSpace.TabIndex = 24;
            this.chkCheckSpace.Text = "Check Space";
            this.chkCheckSpace.UseVisualStyleBackColor = true;
            this.chkCheckSpace.CheckedChanged += new System.EventHandler(this.chkCheckSpace_CheckedChanged);
            // 
            // Check
            // 
            this.Check.Interval = 250;
            this.Check.Tick += new System.EventHandler(this.Check_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.freeInvLabel);
            this.groupBox1.Controls.Add(this.filledInvLabel);
            this.groupBox1.Controls.Add(this.maxInvLabel);
            this.groupBox1.Location = new System.Drawing.Point(5, 354);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(145, 83);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventory";
            // 
            // freeInvLabel
            // 
            this.freeInvLabel.AutoSize = true;
            this.freeInvLabel.Location = new System.Drawing.Point(10, 60);
            this.freeInvLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.freeInvLabel.Name = "freeInvLabel";
            this.freeInvLabel.Size = new System.Drawing.Size(57, 15);
            this.freeInvLabel.TabIndex = 2;
            this.freeInvLabel.Text = "Free: N/A";
            // 
            // filledInvLabel
            // 
            this.filledInvLabel.AutoSize = true;
            this.filledInvLabel.Location = new System.Drawing.Point(10, 40);
            this.filledInvLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filledInvLabel.Name = "filledInvLabel";
            this.filledInvLabel.Size = new System.Drawing.Size(63, 15);
            this.filledInvLabel.TabIndex = 1;
            this.filledInvLabel.Text = "Filled: N/A";
            this.filledInvLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maxInvLabel
            // 
            this.maxInvLabel.AutoSize = true;
            this.maxInvLabel.Location = new System.Drawing.Point(10, 20);
            this.maxInvLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxInvLabel.Name = "maxInvLabel";
            this.maxInvLabel.Size = new System.Drawing.Size(58, 15);
            this.maxInvLabel.TabIndex = 0;
            this.maxInvLabel.Text = "Max: N/A";
            this.maxInvLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.freeBankLabel);
            this.groupBox2.Controls.Add(this.filledBankLabel);
            this.groupBox2.Controls.Add(this.maxBankLabel);
            this.groupBox2.Location = new System.Drawing.Point(150, 354);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(144, 83);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bank";
            // 
            // freeBankLabel
            // 
            this.freeBankLabel.AutoSize = true;
            this.freeBankLabel.Location = new System.Drawing.Point(10, 60);
            this.freeBankLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.freeBankLabel.Name = "freeBankLabel";
            this.freeBankLabel.Size = new System.Drawing.Size(57, 15);
            this.freeBankLabel.TabIndex = 3;
            this.freeBankLabel.Text = "Free: N/A";
            this.freeBankLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filledBankLabel
            // 
            this.filledBankLabel.AutoSize = true;
            this.filledBankLabel.Location = new System.Drawing.Point(10, 40);
            this.filledBankLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filledBankLabel.Name = "filledBankLabel";
            this.filledBankLabel.Size = new System.Drawing.Size(63, 15);
            this.filledBankLabel.TabIndex = 2;
            this.filledBankLabel.Text = "Filled: N/A";
            this.filledBankLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maxBankLabel
            // 
            this.maxBankLabel.AutoSize = true;
            this.maxBankLabel.Location = new System.Drawing.Point(10, 20);
            this.maxBankLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxBankLabel.Name = "maxBankLabel";
            this.maxBankLabel.Size = new System.Drawing.Size(58, 15);
            this.maxBankLabel.TabIndex = 1;
            this.maxBankLabel.Text = "Max: N/A";
            this.maxBankLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.borderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(299, 356);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkCheckSpace);
            this.Controls.Add(this.btnHotkeys);
            this.Controls.Add(this.btnReloadMap);
            this.Controls.Add(this.btnSetGuild);
            this.Controls.Add(this.txtCustomGuild);
            this.Controls.Add(this.btnSetName);
            this.Controls.Add(this.txtCustomName);
            this.Controls.Add(this.numFpsCap);
            this.Controls.Add(this.btnSetFpsCap);
            this.Controls.Add(this.lblWalkSpeed);
            this.Controls.Add(this.numWalkSpeed);
            this.Controls.Add(this.chkDisableCols);
            this.Controls.Add(this.chkDisableFX);
            this.Controls.Add(this.chkFpsCounter);
            this.Controls.Add(this.chkStaff);
            this.Controls.Add(this.chkUpgrade);
            this.Controls.Add(this.chkRejectAll);
            this.Controls.Add(this.chkAcceptAll);
            this.Controls.Add(this.chkHidePlayers);
            this.Controls.Add(this.chkLagKiller);
            this.Controls.Add(this.chkSkipCutscenes);
            this.Controls.Add(this.chkPrivRooms);
            this.Controls.Add(this.chkMagnet);
            this.Controls.Add(this.chkAggro);
            this.Controls.Add(this.chkInfiniteRange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "OptionsForm";
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.numWalkSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFpsCap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkInfiniteRange;
        private System.Windows.Forms.CheckBox chkAggro;
        private System.Windows.Forms.CheckBox chkMagnet;
        private System.Windows.Forms.CheckBox chkPrivRooms;
        private System.Windows.Forms.CheckBox chkSkipCutscenes;
        private System.Windows.Forms.CheckBox chkLagKiller;
        private System.Windows.Forms.CheckBox chkHidePlayers;
        private System.Windows.Forms.CheckBox chkAcceptAll;
        private System.Windows.Forms.CheckBox chkRejectAll;
        private System.Windows.Forms.CheckBox chkUpgrade;
        private System.Windows.Forms.CheckBox chkStaff;
        private System.Windows.Forms.CheckBox chkFpsCounter;
        private System.Windows.Forms.CheckBox chkDisableFX;
        private System.Windows.Forms.CheckBox chkDisableCols;
        private System.Windows.Forms.NumericUpDown numWalkSpeed;
        private System.Windows.Forms.Label lblWalkSpeed;
        private System.Windows.Forms.Button btnSetFpsCap;
        private System.Windows.Forms.NumericUpDown numFpsCap;
        private System.Windows.Forms.TextBox txtCustomName;
        private System.Windows.Forms.Button btnSetName;
        private System.Windows.Forms.Button btnSetGuild;
        private System.Windows.Forms.TextBox txtCustomGuild;
        private System.Windows.Forms.Timer dropTimer;
        private System.Windows.Forms.Button btnReloadMap;
        private System.Windows.Forms.Button btnHotkeys;
        private System.Windows.Forms.CheckBox chkCheckSpace;
        private System.Windows.Forms.Timer Check;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label freeInvLabel;
        private System.Windows.Forms.Label filledInvLabel;
        private System.Windows.Forms.Label maxInvLabel;
        private System.Windows.Forms.Label freeBankLabel;
        private System.Windows.Forms.Label filledBankLabel;
        private System.Windows.Forms.Label maxBankLabel;
    }
}