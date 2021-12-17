namespace RBot
{
    partial class AdvancedSkillForm
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
            this.numSkillIndex = new System.Windows.Forms.NumericUpDown();
            this.btnAddSkill = new System.Windows.Forms.Button();
            this.txtSkillString = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.gbCalcTimeout = new System.Windows.Forms.GroupBox();
            this.numSkillTimeout = new System.Windows.Forms.NumericUpDown();
            this.lblST = new System.Windows.Forms.Label();
            this.numSkillTimer = new System.Windows.Forms.NumericUpDown();
            this.lblLongCD = new System.Windows.Forms.Label();
            this.lblSkillTimerCalc = new System.Windows.Forms.Label();
            this.numSkillCD = new System.Windows.Forms.NumericUpDown();
            this.gbUseRules = new System.Windows.Forms.GroupBox();
            this.cmsUseRule = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsUseRule_Reset = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGreaterMana = new System.Windows.Forms.Label();
            this.lblGreaterHealth = new System.Windows.Forms.Label();
            this.numWait = new System.Windows.Forms.NumericUpDown();
            this.numHealth = new System.Windows.Forms.NumericUpDown();
            this.numMana = new System.Windows.Forms.NumericUpDown();
            this.chkSkip = new System.Windows.Forms.CheckBox();
            this.lblWait = new System.Windows.Forms.Label();
            this.chkShouldUse = new System.Windows.Forms.CheckBox();
            this.lblMana = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.gbUseMode = new System.Windows.Forms.GroupBox();
            this.rbOptMode = new System.Windows.Forms.RadioButton();
            this.rbWaitMode = new System.Windows.Forms.RadioButton();
            this.lstSkillSequence = new System.Windows.Forms.ListBox();
            this.cmsSkill = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsSkill_Up = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSkill_Down = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSkill_Remove = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSkill_RemoveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSaveName = new System.Windows.Forms.TextBox();
            this.lblSaveName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkOverride = new System.Windows.Forms.CheckBox();
            this.grpSave = new System.Windows.Forms.GroupBox();
            this.lstSavedSkills = new System.Windows.Forms.ListBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnClearSkillString = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillIndex)).BeginInit();
            this.gbCalcTimeout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillCD)).BeginInit();
            this.gbUseRules.SuspendLayout();
            this.cmsUseRule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMana)).BeginInit();
            this.gbUseMode.SuspendLayout();
            this.cmsSkill.SuspendLayout();
            this.grpSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // numSkillIndex
            // 
            this.numSkillIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numSkillIndex.Location = new System.Drawing.Point(108, 273);
            this.numSkillIndex.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numSkillIndex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSkillIndex.Name = "numSkillIndex";
            this.numSkillIndex.Size = new System.Drawing.Size(48, 20);
            this.numSkillIndex.TabIndex = 11;
            this.numSkillIndex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddSkill
            // 
            this.btnAddSkill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSkill.Location = new System.Drawing.Point(160, 272);
            this.btnAddSkill.Name = "btnAddSkill";
            this.btnAddSkill.Size = new System.Drawing.Size(67, 22);
            this.btnAddSkill.TabIndex = 12;
            this.btnAddSkill.Text = "Add";
            this.btnAddSkill.UseVisualStyleBackColor = true;
            this.btnAddSkill.Click += new System.EventHandler(this.btnAddSkill_Click);
            // 
            // txtSkillString
            // 
            this.txtSkillString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSkillString.Location = new System.Drawing.Point(108, 301);
            this.txtSkillString.Name = "txtSkillString";
            this.txtSkillString.Size = new System.Drawing.Size(221, 20);
            this.txtSkillString.TabIndex = 14;
            this.txtSkillString.TextChanged += new System.EventHandler(this.txtSkillString_TextChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConvert.Location = new System.Drawing.Point(5, 299);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(97, 22);
            this.btnConvert.TabIndex = 13;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // gbCalcTimeout
            // 
            this.gbCalcTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCalcTimeout.Controls.Add(this.numSkillTimeout);
            this.gbCalcTimeout.Controls.Add(this.lblST);
            this.gbCalcTimeout.Controls.Add(this.numSkillTimer);
            this.gbCalcTimeout.Controls.Add(this.lblLongCD);
            this.gbCalcTimeout.Controls.Add(this.lblSkillTimerCalc);
            this.gbCalcTimeout.Controls.Add(this.numSkillCD);
            this.gbCalcTimeout.Location = new System.Drawing.Point(235, 5);
            this.gbCalcTimeout.Name = "gbCalcTimeout";
            this.gbCalcTimeout.Size = new System.Drawing.Size(200, 82);
            this.gbCalcTimeout.TabIndex = 16;
            this.gbCalcTimeout.TabStop = false;
            this.gbCalcTimeout.Text = "Calculate SkillTimeout";
            // 
            // numSkillTimeout
            // 
            this.numSkillTimeout.Location = new System.Drawing.Point(109, 58);
            this.numSkillTimeout.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSkillTimeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numSkillTimeout.Name = "numSkillTimeout";
            this.numSkillTimeout.Size = new System.Drawing.Size(85, 20);
            this.numSkillTimeout.TabIndex = 6;
            this.numSkillTimeout.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // lblST
            // 
            this.lblST.AutoSize = true;
            this.lblST.Location = new System.Drawing.Point(15, 62);
            this.lblST.Name = "lblST";
            this.lblST.Size = new System.Drawing.Size(67, 13);
            this.lblST.TabIndex = 2;
            this.lblST.Text = "SkillTimeout:";
            // 
            // numSkillTimer
            // 
            this.numSkillTimer.Location = new System.Drawing.Point(6, 32);
            this.numSkillTimer.Name = "numSkillTimer";
            this.numSkillTimer.Size = new System.Drawing.Size(85, 20);
            this.numSkillTimer.TabIndex = 0;
            this.numSkillTimer.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblLongCD
            // 
            this.lblLongCD.AutoSize = true;
            this.lblLongCD.Location = new System.Drawing.Point(106, 16);
            this.lblLongCD.Name = "lblLongCD";
            this.lblLongCD.Size = new System.Drawing.Size(85, 13);
            this.lblLongCD.TabIndex = 4;
            this.lblLongCD.Text = "Longest CD (ms)";
            // 
            // lblSkillTimerCalc
            // 
            this.lblSkillTimerCalc.AutoSize = true;
            this.lblSkillTimerCalc.Location = new System.Drawing.Point(3, 16);
            this.lblSkillTimerCalc.Name = "lblSkillTimerCalc";
            this.lblSkillTimerCalc.Size = new System.Drawing.Size(74, 13);
            this.lblSkillTimerCalc.TabIndex = 3;
            this.lblSkillTimerCalc.Text = "SkillTimer (ms)";
            // 
            // numSkillCD
            // 
            this.numSkillCD.Location = new System.Drawing.Point(109, 32);
            this.numSkillCD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numSkillCD.Name = "numSkillCD";
            this.numSkillCD.Size = new System.Drawing.Size(85, 20);
            this.numSkillCD.TabIndex = 1;
            this.numSkillCD.ValueChanged += new System.EventHandler(this.numSkillCD_ValueChanged);
            // 
            // gbUseRules
            // 
            this.gbUseRules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUseRules.ContextMenuStrip = this.cmsUseRule;
            this.gbUseRules.Controls.Add(this.lblGreaterMana);
            this.gbUseRules.Controls.Add(this.lblGreaterHealth);
            this.gbUseRules.Controls.Add(this.numWait);
            this.gbUseRules.Controls.Add(this.numHealth);
            this.gbUseRules.Controls.Add(this.numMana);
            this.gbUseRules.Controls.Add(this.chkSkip);
            this.gbUseRules.Controls.Add(this.lblWait);
            this.gbUseRules.Controls.Add(this.chkShouldUse);
            this.gbUseRules.Controls.Add(this.lblMana);
            this.gbUseRules.Controls.Add(this.lblHealth);
            this.gbUseRules.Location = new System.Drawing.Point(235, 144);
            this.gbUseRules.Name = "gbUseRules";
            this.gbUseRules.Size = new System.Drawing.Size(200, 150);
            this.gbUseRules.TabIndex = 10;
            this.gbUseRules.TabStop = false;
            this.gbUseRules.Text = "Use Rules";
            // 
            // cmsUseRule
            // 
            this.cmsUseRule.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsUseRule_Reset});
            this.cmsUseRule.Name = "cmsUseRule";
            this.cmsUseRule.Size = new System.Drawing.Size(134, 26);
            // 
            // cmsUseRule_Reset
            // 
            this.cmsUseRule_Reset.Name = "cmsUseRule_Reset";
            this.cmsUseRule_Reset.Size = new System.Drawing.Size(133, 22);
            this.cmsUseRule_Reset.Text = "Reset fields";
            this.cmsUseRule_Reset.Click += new System.EventHandler(this.cmsUseRule_Reset_Click);
            // 
            // lblGreaterMana
            // 
            this.lblGreaterMana.AutoSize = true;
            this.lblGreaterMana.Location = new System.Drawing.Point(78, 72);
            this.lblGreaterMana.Name = "lblGreaterMana";
            this.lblGreaterMana.Size = new System.Drawing.Size(13, 13);
            this.lblGreaterMana.TabIndex = 3;
            this.lblGreaterMana.Text = ">";
            this.lblGreaterMana.Click += new System.EventHandler(this.SwitchGreaterSign);
            // 
            // lblGreaterHealth
            // 
            this.lblGreaterHealth.AutoSize = true;
            this.lblGreaterHealth.Location = new System.Drawing.Point(78, 48);
            this.lblGreaterHealth.Name = "lblGreaterHealth";
            this.lblGreaterHealth.Size = new System.Drawing.Size(13, 13);
            this.lblGreaterHealth.TabIndex = 1;
            this.lblGreaterHealth.Text = ">";
            this.lblGreaterHealth.Click += new System.EventHandler(this.SwitchGreaterSign);
            // 
            // numWait
            // 
            this.numWait.Location = new System.Drawing.Point(81, 97);
            this.numWait.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numWait.Name = "numWait";
            this.numWait.Size = new System.Drawing.Size(110, 20);
            this.numWait.TabIndex = 5;
            // 
            // numHealth
            // 
            this.numHealth.Location = new System.Drawing.Point(109, 46);
            this.numHealth.Name = "numHealth";
            this.numHealth.Size = new System.Drawing.Size(82, 20);
            this.numHealth.TabIndex = 2;
            // 
            // numMana
            // 
            this.numMana.Location = new System.Drawing.Point(109, 72);
            this.numMana.Name = "numMana";
            this.numMana.Size = new System.Drawing.Size(82, 20);
            this.numMana.TabIndex = 4;
            // 
            // chkSkip
            // 
            this.chkSkip.AutoSize = true;
            this.chkSkip.Location = new System.Drawing.Point(6, 123);
            this.chkSkip.Name = "chkSkip";
            this.chkSkip.Size = new System.Drawing.Size(118, 17);
            this.chkSkip.TabIndex = 6;
            this.chkSkip.Text = "Skip if not available";
            this.chkSkip.UseVisualStyleBackColor = true;
            // 
            // lblWait
            // 
            this.lblWait.AutoSize = true;
            this.lblWait.Location = new System.Drawing.Point(6, 99);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(51, 13);
            this.lblWait.TabIndex = 9;
            this.lblWait.Text = "Wait (ms)";
            // 
            // chkShouldUse
            // 
            this.chkShouldUse.AutoSize = true;
            this.chkShouldUse.Location = new System.Drawing.Point(6, 19);
            this.chkShouldUse.Name = "chkShouldUse";
            this.chkShouldUse.Size = new System.Drawing.Size(71, 17);
            this.chkShouldUse.TabIndex = 0;
            this.chkShouldUse.Text = "Use rule?";
            this.chkShouldUse.UseVisualStyleBackColor = true;
            // 
            // lblMana
            // 
            this.lblMana.AutoSize = true;
            this.lblMana.Location = new System.Drawing.Point(6, 74);
            this.lblMana.Name = "lblMana";
            this.lblMana.Size = new System.Drawing.Size(34, 13);
            this.lblMana.TabIndex = 8;
            this.lblMana.Text = "Mana";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(6, 48);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(55, 13);
            this.lblHealth.TabIndex = 7;
            this.lblHealth.Text = "Health (%)";
            // 
            // gbUseMode
            // 
            this.gbUseMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUseMode.Controls.Add(this.rbOptMode);
            this.gbUseMode.Controls.Add(this.rbWaitMode);
            this.gbUseMode.Location = new System.Drawing.Point(235, 93);
            this.gbUseMode.Name = "gbUseMode";
            this.gbUseMode.Size = new System.Drawing.Size(200, 45);
            this.gbUseMode.TabIndex = 17;
            this.gbUseMode.TabStop = false;
            this.gbUseMode.Text = "Use Mode";
            // 
            // rbOptMode
            // 
            this.rbOptMode.AutoSize = true;
            this.rbOptMode.Location = new System.Drawing.Point(6, 19);
            this.rbOptMode.Name = "rbOptMode";
            this.rbOptMode.Size = new System.Drawing.Size(70, 17);
            this.rbOptMode.TabIndex = 0;
            this.rbOptMode.Text = "Optimistic";
            this.rbOptMode.UseVisualStyleBackColor = true;
            // 
            // rbWaitMode
            // 
            this.rbWaitMode.AutoSize = true;
            this.rbWaitMode.Checked = true;
            this.rbWaitMode.Location = new System.Drawing.Point(109, 19);
            this.rbWaitMode.Name = "rbWaitMode";
            this.rbWaitMode.Size = new System.Drawing.Size(47, 17);
            this.rbWaitMode.TabIndex = 1;
            this.rbWaitMode.TabStop = true;
            this.rbWaitMode.Text = "Wait";
            this.rbWaitMode.UseVisualStyleBackColor = true;
            // 
            // lstSkillSequence
            // 
            this.lstSkillSequence.AllowDrop = true;
            this.lstSkillSequence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSkillSequence.ContextMenuStrip = this.cmsSkill;
            this.lstSkillSequence.FormattingEnabled = true;
            this.lstSkillSequence.HorizontalScrollbar = true;
            this.lstSkillSequence.Location = new System.Drawing.Point(5, 5);
            this.lstSkillSequence.Name = "lstSkillSequence";
            this.lstSkillSequence.Size = new System.Drawing.Size(222, 264);
            this.lstSkillSequence.TabIndex = 9;
            this.lstSkillSequence.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstSkillSequence_DragDrop);
            this.lstSkillSequence.DragOver += new System.Windows.Forms.DragEventHandler(this.lstSkillSequence_DragOver);
            this.lstSkillSequence.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstSkillSequence_KeyDown);
            this.lstSkillSequence.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstSkillSequence_MouseDown);
            // 
            // cmsSkill
            // 
            this.cmsSkill.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsSkill_Up,
            this.cmsSkill_Down,
            this.cmsSkill_Remove,
            this.cmsSkill_RemoveAll});
            this.cmsSkill.Name = "cmsSkill";
            this.cmsSkill.Size = new System.Drawing.Size(135, 92);
            // 
            // cmsSkill_Up
            // 
            this.cmsSkill_Up.Name = "cmsSkill_Up";
            this.cmsSkill_Up.Size = new System.Drawing.Size(134, 22);
            this.cmsSkill_Up.Text = "Up";
            this.cmsSkill_Up.Click += new System.EventHandler(this.cmsSkill_Up_Click);
            // 
            // cmsSkill_Down
            // 
            this.cmsSkill_Down.Name = "cmsSkill_Down";
            this.cmsSkill_Down.Size = new System.Drawing.Size(134, 22);
            this.cmsSkill_Down.Text = "Down";
            this.cmsSkill_Down.Click += new System.EventHandler(this.cmsSkill_Down_Click);
            // 
            // cmsSkill_Remove
            // 
            this.cmsSkill_Remove.Name = "cmsSkill_Remove";
            this.cmsSkill_Remove.Size = new System.Drawing.Size(134, 22);
            this.cmsSkill_Remove.Text = "Remove";
            this.cmsSkill_Remove.Click += new System.EventHandler(this.cmsSkill_Remove_Click);
            // 
            // cmsSkill_RemoveAll
            // 
            this.cmsSkill_RemoveAll.Name = "cmsSkill_RemoveAll";
            this.cmsSkill_RemoveAll.Size = new System.Drawing.Size(134, 22);
            this.cmsSkill_RemoveAll.Text = "Remove All";
            this.cmsSkill_RemoveAll.Click += new System.EventHandler(this.cmsSkill_RemoveAll_Click);
            // 
            // txtSaveName
            // 
            this.txtSaveName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaveName.Location = new System.Drawing.Point(103, 14);
            this.txtSaveName.Name = "txtSaveName";
            this.txtSaveName.Size = new System.Drawing.Size(146, 20);
            this.txtSaveName.TabIndex = 18;
            // 
            // lblSaveName
            // 
            this.lblSaveName.AutoSize = true;
            this.lblSaveName.Location = new System.Drawing.Point(16, 18);
            this.lblSaveName.Name = "lblSaveName";
            this.lblSaveName.Size = new System.Drawing.Size(66, 13);
            this.lblSaveName.TabIndex = 10;
            this.lblSaveName.Text = "Save Name:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(255, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 22);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkOverride
            // 
            this.chkOverride.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkOverride.AutoSize = true;
            this.chkOverride.Checked = true;
            this.chkOverride.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOverride.Location = new System.Drawing.Point(330, 17);
            this.chkOverride.Name = "chkOverride";
            this.chkOverride.Size = new System.Drawing.Size(66, 17);
            this.chkOverride.TabIndex = 10;
            this.chkOverride.Text = "Override";
            this.chkOverride.UseVisualStyleBackColor = true;
            // 
            // grpSave
            // 
            this.grpSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSave.Controls.Add(this.lstSavedSkills);
            this.grpSave.Controls.Add(this.lblSaveName);
            this.grpSave.Controls.Add(this.chkOverride);
            this.grpSave.Controls.Add(this.txtSaveName);
            this.grpSave.Controls.Add(this.btnSave);
            this.grpSave.Location = new System.Drawing.Point(5, 323);
            this.grpSave.Name = "grpSave";
            this.grpSave.Size = new System.Drawing.Size(430, 272);
            this.grpSave.TabIndex = 20;
            this.grpSave.TabStop = false;
            // 
            // lstSavedSkills
            // 
            this.lstSavedSkills.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSavedSkills.FormattingEnabled = true;
            this.lstSavedSkills.Location = new System.Drawing.Point(6, 40);
            this.lstSavedSkills.Name = "lstSavedSkills";
            this.lstSavedSkills.Size = new System.Drawing.Size(418, 225);
            this.lstSavedSkills.TabIndex = 20;
            this.lstSavedSkills.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstSavedSkills_MouseDoubleClick);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(363, 300);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(72, 22);
            this.btnCopy.TabIndex = 15;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnClearSkillString
            // 
            this.btnClearSkillString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearSkillString.Location = new System.Drawing.Point(335, 300);
            this.btnClearSkillString.Name = "btnClearSkillString";
            this.btnClearSkillString.Size = new System.Drawing.Size(23, 22);
            this.btnClearSkillString.TabIndex = 21;
            this.btnClearSkillString.Text = "✖";
            this.btnClearSkillString.UseVisualStyleBackColor = true;
            this.btnClearSkillString.Click += new System.EventHandler(this.btnClearSkillString_Click);
            // 
            // AdvancedSkillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 601);
            this.Controls.Add(this.btnClearSkillString);
            this.Controls.Add(this.grpSave);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.numSkillIndex);
            this.Controls.Add(this.btnAddSkill);
            this.Controls.Add(this.txtSkillString);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.gbCalcTimeout);
            this.Controls.Add(this.gbUseRules);
            this.Controls.Add(this.gbUseMode);
            this.Controls.Add(this.lstSkillSequence);
            this.MinimumSize = new System.Drawing.Size(455, 640);
            this.Name = "AdvancedSkillForm";
            this.Text = "Advanced Skills";
            ((System.ComponentModel.ISupportInitialize)(this.numSkillIndex)).EndInit();
            this.gbCalcTimeout.ResumeLayout(false);
            this.gbCalcTimeout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillCD)).EndInit();
            this.gbUseRules.ResumeLayout(false);
            this.gbUseRules.PerformLayout();
            this.cmsUseRule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMana)).EndInit();
            this.gbUseMode.ResumeLayout(false);
            this.gbUseMode.PerformLayout();
            this.cmsSkill.ResumeLayout(false);
            this.grpSave.ResumeLayout(false);
            this.grpSave.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numSkillIndex;
        private System.Windows.Forms.Button btnAddSkill;
        private System.Windows.Forms.TextBox txtSkillString;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.GroupBox gbCalcTimeout;
        private System.Windows.Forms.Label lblST;
        private System.Windows.Forms.NumericUpDown numSkillTimer;
        private System.Windows.Forms.Label lblLongCD;
        private System.Windows.Forms.Label lblSkillTimerCalc;
        private System.Windows.Forms.NumericUpDown numSkillCD;
        private System.Windows.Forms.GroupBox gbUseRules;
        private System.Windows.Forms.Label lblGreaterMana;
        private System.Windows.Forms.Label lblGreaterHealth;
        private System.Windows.Forms.NumericUpDown numWait;
        private System.Windows.Forms.NumericUpDown numHealth;
        private System.Windows.Forms.NumericUpDown numMana;
        private System.Windows.Forms.CheckBox chkSkip;
        private System.Windows.Forms.Label lblWait;
        private System.Windows.Forms.CheckBox chkShouldUse;
        private System.Windows.Forms.Label lblMana;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.GroupBox gbUseMode;
        private System.Windows.Forms.RadioButton rbOptMode;
        private System.Windows.Forms.RadioButton rbWaitMode;
        private System.Windows.Forms.ListBox lstSkillSequence;
        private System.Windows.Forms.TextBox txtSaveName;
        private System.Windows.Forms.Label lblSaveName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkOverride;
        private System.Windows.Forms.GroupBox grpSave;
        private System.Windows.Forms.ListBox lstSavedSkills;
        private System.Windows.Forms.ContextMenuStrip cmsSkill;
        private System.Windows.Forms.ContextMenuStrip cmsUseRule;
        private System.Windows.Forms.ToolStripMenuItem cmsSkill_Up;
        private System.Windows.Forms.ToolStripMenuItem cmsSkill_Down;
        private System.Windows.Forms.ToolStripMenuItem cmsSkill_Remove;
        private System.Windows.Forms.ToolStripMenuItem cmsSkill_RemoveAll;
        private System.Windows.Forms.ToolStripMenuItem cmsUseRule_Reset;
        private System.Windows.Forms.NumericUpDown numSkillTimeout;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnClearSkillString;
    }
}