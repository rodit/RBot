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
            this.tlpCalcSkillTimeout = new System.Windows.Forms.TableLayoutPanel();
            this.numSkillTimeout = new System.Windows.Forms.NumericUpDown();
            this.lblSkillTimerCalc = new System.Windows.Forms.Label();
            this.lblST = new System.Windows.Forms.Label();
            this.lblLongCD = new System.Windows.Forms.Label();
            this.numSkillCD = new System.Windows.Forms.NumericUpDown();
            this.numSkillTimer = new System.Windows.Forms.NumericUpDown();
            this.gbUseRules = new System.Windows.Forms.GroupBox();
            this.cmsUseRule = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsUseRule_Reset = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpUseRules = new System.Windows.Forms.TableLayoutPanel();
            this.chkShouldUse = new System.Windows.Forms.CheckBox();
            this.numWait = new System.Windows.Forms.NumericUpDown();
            this.lblGreaterMana = new System.Windows.Forms.Label();
            this.numMana = new System.Windows.Forms.NumericUpDown();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblMana = new System.Windows.Forms.Label();
            this.lblWait = new System.Windows.Forms.Label();
            this.chkSkip = new System.Windows.Forms.CheckBox();
            this.lblGreaterHealth = new System.Windows.Forms.Label();
            this.numHealth = new System.Windows.Forms.NumericUpDown();
            this.gbUseMode = new System.Windows.Forms.GroupBox();
            this.tlpUseMode = new System.Windows.Forms.TableLayoutPanel();
            this.rbOptMode = new System.Windows.Forms.RadioButton();
            this.rbWaitMode = new System.Windows.Forms.RadioButton();
            this.lstSkillSequence = new System.Windows.Forms.ListBox();
            this.cmsSkill = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsSkill_Up = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSkill_Down = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSkill_Remove = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSkill_RemoveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnClearSkillString = new System.Windows.Forms.Button();
            this.tlpSkillList = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSkills = new System.Windows.Forms.TableLayoutPanel();
            this.tlpConvert = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSave = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemoveSkill = new System.Windows.Forms.Button();
            this.lstSavedSkills = new System.Windows.Forms.ListBox();
            this.lblSaveName = new System.Windows.Forms.Label();
            this.txtSaveName = new System.Windows.Forms.TextBox();
            this.chkOverride = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbModes = new System.Windows.Forms.ComboBox();
            this.tlpAdvancedSkills = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillIndex)).BeginInit();
            this.gbCalcTimeout.SuspendLayout();
            this.tlpCalcSkillTimeout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillTimer)).BeginInit();
            this.gbUseRules.SuspendLayout();
            this.cmsUseRule.SuspendLayout();
            this.tlpUseRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHealth)).BeginInit();
            this.gbUseMode.SuspendLayout();
            this.tlpUseMode.SuspendLayout();
            this.cmsSkill.SuspendLayout();
            this.tlpSkillList.SuspendLayout();
            this.tlpSkills.SuspendLayout();
            this.tlpConvert.SuspendLayout();
            this.tlpSave.SuspendLayout();
            this.tlpAdvancedSkills.SuspendLayout();
            this.SuspendLayout();
            // 
            // numSkillIndex
            // 
            this.numSkillIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numSkillIndex.Location = new System.Drawing.Point(99, 314);
            this.numSkillIndex.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.numSkillIndex.Size = new System.Drawing.Size(39, 23);
            this.numSkillIndex.TabIndex = 11;
            this.numSkillIndex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddSkill
            // 
            this.btnAddSkill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSkill.Location = new System.Drawing.Point(146, 314);
            this.btnAddSkill.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddSkill.Name = "btnAddSkill";
            this.btnAddSkill.Size = new System.Drawing.Size(89, 24);
            this.btnAddSkill.TabIndex = 12;
            this.btnAddSkill.Text = "Add";
            this.btnAddSkill.UseVisualStyleBackColor = true;
            this.btnAddSkill.Click += new System.EventHandler(this.btnAddSkill_Click);
            // 
            // txtSkillString
            // 
            this.txtSkillString.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSkillString.Location = new System.Drawing.Point(124, 3);
            this.txtSkillString.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSkillString.Name = "txtSkillString";
            this.txtSkillString.Size = new System.Drawing.Size(234, 23);
            this.txtSkillString.TabIndex = 14;
            this.txtSkillString.TextChanged += new System.EventHandler(this.txtSkillString_TextChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvert.Location = new System.Drawing.Point(4, 3);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(112, 24);
            this.btnConvert.TabIndex = 13;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // gbCalcTimeout
            // 
            this.gbCalcTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCalcTimeout.Controls.Add(this.tlpCalcSkillTimeout);
            this.gbCalcTimeout.Location = new System.Drawing.Point(243, 3);
            this.gbCalcTimeout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbCalcTimeout.Name = "gbCalcTimeout";
            this.gbCalcTimeout.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbCalcTimeout.Size = new System.Drawing.Size(231, 95);
            this.gbCalcTimeout.TabIndex = 16;
            this.gbCalcTimeout.TabStop = false;
            this.gbCalcTimeout.Text = "Calculate SkillTimeout";
            // 
            // tlpCalcSkillTimeout
            // 
            this.tlpCalcSkillTimeout.ColumnCount = 2;
            this.tlpCalcSkillTimeout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCalcSkillTimeout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCalcSkillTimeout.Controls.Add(this.numSkillTimeout, 1, 2);
            this.tlpCalcSkillTimeout.Controls.Add(this.lblSkillTimerCalc, 0, 0);
            this.tlpCalcSkillTimeout.Controls.Add(this.lblST, 0, 2);
            this.tlpCalcSkillTimeout.Controls.Add(this.lblLongCD, 1, 0);
            this.tlpCalcSkillTimeout.Controls.Add(this.numSkillCD, 1, 1);
            this.tlpCalcSkillTimeout.Controls.Add(this.numSkillTimer, 0, 1);
            this.tlpCalcSkillTimeout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCalcSkillTimeout.Location = new System.Drawing.Point(4, 19);
            this.tlpCalcSkillTimeout.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCalcSkillTimeout.Name = "tlpCalcSkillTimeout";
            this.tlpCalcSkillTimeout.RowCount = 3;
            this.tlpCalcSkillTimeout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCalcSkillTimeout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCalcSkillTimeout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCalcSkillTimeout.Size = new System.Drawing.Size(223, 73);
            this.tlpCalcSkillTimeout.TabIndex = 25;
            // 
            // numSkillTimeout
            // 
            this.numSkillTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numSkillTimeout.Location = new System.Drawing.Point(115, 47);
            this.numSkillTimeout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.numSkillTimeout.Size = new System.Drawing.Size(104, 23);
            this.numSkillTimeout.TabIndex = 6;
            this.numSkillTimeout.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // lblSkillTimerCalc
            // 
            this.lblSkillTimerCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSkillTimerCalc.AutoSize = true;
            this.lblSkillTimerCalc.Location = new System.Drawing.Point(4, 0);
            this.lblSkillTimerCalc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSkillTimerCalc.Name = "lblSkillTimerCalc";
            this.lblSkillTimerCalc.Size = new System.Drawing.Size(103, 15);
            this.lblSkillTimerCalc.TabIndex = 3;
            this.lblSkillTimerCalc.Text = "SkillTimer (ms)";
            this.lblSkillTimerCalc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblST
            // 
            this.lblST.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblST.AutoSize = true;
            this.lblST.Location = new System.Drawing.Point(4, 44);
            this.lblST.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblST.Name = "lblST";
            this.lblST.Size = new System.Drawing.Size(103, 29);
            this.lblST.TabIndex = 2;
            this.lblST.Text = "SkillTimeout:";
            this.lblST.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLongCD
            // 
            this.lblLongCD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLongCD.AutoSize = true;
            this.lblLongCD.Location = new System.Drawing.Point(115, 0);
            this.lblLongCD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLongCD.Name = "lblLongCD";
            this.lblLongCD.Size = new System.Drawing.Size(104, 15);
            this.lblLongCD.TabIndex = 4;
            this.lblLongCD.Text = "Longest CD (ms)";
            this.lblLongCD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numSkillCD
            // 
            this.numSkillCD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numSkillCD.Location = new System.Drawing.Point(115, 18);
            this.numSkillCD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numSkillCD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numSkillCD.Name = "numSkillCD";
            this.numSkillCD.Size = new System.Drawing.Size(104, 23);
            this.numSkillCD.TabIndex = 1;
            this.numSkillCD.ValueChanged += new System.EventHandler(this.numSkillCD_ValueChanged);
            // 
            // numSkillTimer
            // 
            this.numSkillTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numSkillTimer.Location = new System.Drawing.Point(4, 18);
            this.numSkillTimer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numSkillTimer.Name = "numSkillTimer";
            this.numSkillTimer.Size = new System.Drawing.Size(103, 23);
            this.numSkillTimer.TabIndex = 0;
            this.numSkillTimer.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // gbUseRules
            // 
            this.gbUseRules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUseRules.ContextMenuStrip = this.cmsUseRule;
            this.gbUseRules.Controls.Add(this.tlpUseRules);
            this.gbUseRules.Location = new System.Drawing.Point(243, 162);
            this.gbUseRules.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbUseRules.Name = "gbUseRules";
            this.gbUseRules.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbUseRules.Size = new System.Drawing.Size(231, 176);
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
            // tlpUseRules
            // 
            this.tlpUseRules.ColumnCount = 3;
            this.tlpUseRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUseRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpUseRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUseRules.Controls.Add(this.chkShouldUse, 0, 0);
            this.tlpUseRules.Controls.Add(this.numWait, 1, 3);
            this.tlpUseRules.Controls.Add(this.lblGreaterMana, 1, 2);
            this.tlpUseRules.Controls.Add(this.numMana, 2, 2);
            this.tlpUseRules.Controls.Add(this.lblHealth, 0, 1);
            this.tlpUseRules.Controls.Add(this.lblMana, 0, 2);
            this.tlpUseRules.Controls.Add(this.lblWait, 0, 3);
            this.tlpUseRules.Controls.Add(this.chkSkip, 0, 4);
            this.tlpUseRules.Controls.Add(this.lblGreaterHealth, 1, 1);
            this.tlpUseRules.Controls.Add(this.numHealth, 2, 1);
            this.tlpUseRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUseRules.Location = new System.Drawing.Point(4, 19);
            this.tlpUseRules.Name = "tlpUseRules";
            this.tlpUseRules.RowCount = 5;
            this.tlpUseRules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpUseRules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpUseRules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpUseRules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpUseRules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpUseRules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpUseRules.Size = new System.Drawing.Size(223, 154);
            this.tlpUseRules.TabIndex = 10;
            // 
            // chkShouldUse
            // 
            this.chkShouldUse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShouldUse.AutoSize = true;
            this.tlpUseRules.SetColumnSpan(this.chkShouldUse, 3);
            this.chkShouldUse.Location = new System.Drawing.Point(4, 3);
            this.chkShouldUse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkShouldUse.Name = "chkShouldUse";
            this.chkShouldUse.Size = new System.Drawing.Size(215, 24);
            this.chkShouldUse.TabIndex = 0;
            this.chkShouldUse.Text = "Use rule?";
            this.chkShouldUse.UseVisualStyleBackColor = true;
            // 
            // numWait
            // 
            this.numWait.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpUseRules.SetColumnSpan(this.numWait, 2);
            this.numWait.Location = new System.Drawing.Point(102, 93);
            this.numWait.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numWait.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numWait.Name = "numWait";
            this.numWait.Size = new System.Drawing.Size(117, 23);
            this.numWait.TabIndex = 5;
            // 
            // lblGreaterMana
            // 
            this.lblGreaterMana.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGreaterMana.AutoSize = true;
            this.lblGreaterMana.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGreaterMana.Location = new System.Drawing.Point(102, 60);
            this.lblGreaterMana.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGreaterMana.Name = "lblGreaterMana";
            this.lblGreaterMana.Size = new System.Drawing.Size(19, 30);
            this.lblGreaterMana.TabIndex = 3;
            this.lblGreaterMana.Text = ">";
            this.lblGreaterMana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGreaterMana.Click += new System.EventHandler(this.SwitchGreaterSign);
            // 
            // numMana
            // 
            this.numMana.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numMana.Location = new System.Drawing.Point(129, 63);
            this.numMana.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numMana.Name = "numMana";
            this.numMana.Size = new System.Drawing.Size(90, 23);
            this.numMana.TabIndex = 4;
            // 
            // lblHealth
            // 
            this.lblHealth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(4, 30);
            this.lblHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(90, 30);
            this.lblHealth.TabIndex = 7;
            this.lblHealth.Text = "Health (%)";
            this.lblHealth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMana
            // 
            this.lblMana.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMana.AutoSize = true;
            this.lblMana.Location = new System.Drawing.Point(4, 60);
            this.lblMana.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMana.Name = "lblMana";
            this.lblMana.Size = new System.Drawing.Size(90, 30);
            this.lblMana.TabIndex = 8;
            this.lblMana.Text = "Mana";
            this.lblMana.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWait
            // 
            this.lblWait.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWait.AutoSize = true;
            this.lblWait.Location = new System.Drawing.Point(4, 90);
            this.lblWait.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(90, 30);
            this.lblWait.TabIndex = 9;
            this.lblWait.Text = "Wait (ms)";
            this.lblWait.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkSkip
            // 
            this.chkSkip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSkip.AutoSize = true;
            this.tlpUseRules.SetColumnSpan(this.chkSkip, 3);
            this.chkSkip.Location = new System.Drawing.Point(4, 123);
            this.chkSkip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkSkip.Name = "chkSkip";
            this.chkSkip.Size = new System.Drawing.Size(215, 28);
            this.chkSkip.TabIndex = 6;
            this.chkSkip.Text = "Skip if not available";
            this.chkSkip.UseVisualStyleBackColor = true;
            // 
            // lblGreaterHealth
            // 
            this.lblGreaterHealth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGreaterHealth.AutoSize = true;
            this.lblGreaterHealth.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGreaterHealth.Location = new System.Drawing.Point(102, 30);
            this.lblGreaterHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGreaterHealth.Name = "lblGreaterHealth";
            this.lblGreaterHealth.Size = new System.Drawing.Size(19, 30);
            this.lblGreaterHealth.TabIndex = 1;
            this.lblGreaterHealth.Text = ">";
            this.lblGreaterHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGreaterHealth.Click += new System.EventHandler(this.SwitchGreaterSign);
            // 
            // numHealth
            // 
            this.numHealth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numHealth.Location = new System.Drawing.Point(129, 33);
            this.numHealth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numHealth.Name = "numHealth";
            this.numHealth.Size = new System.Drawing.Size(90, 23);
            this.numHealth.TabIndex = 2;
            // 
            // gbUseMode
            // 
            this.gbUseMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUseMode.Controls.Add(this.tlpUseMode);
            this.gbUseMode.Location = new System.Drawing.Point(243, 104);
            this.gbUseMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbUseMode.Name = "gbUseMode";
            this.gbUseMode.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbUseMode.Size = new System.Drawing.Size(231, 52);
            this.gbUseMode.TabIndex = 17;
            this.gbUseMode.TabStop = false;
            this.gbUseMode.Text = "Use Mode";
            // 
            // tlpUseMode
            // 
            this.tlpUseMode.ColumnCount = 2;
            this.tlpUseMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUseMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUseMode.Controls.Add(this.rbOptMode, 0, 0);
            this.tlpUseMode.Controls.Add(this.rbWaitMode, 1, 0);
            this.tlpUseMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUseMode.Location = new System.Drawing.Point(4, 19);
            this.tlpUseMode.Margin = new System.Windows.Forms.Padding(0);
            this.tlpUseMode.Name = "tlpUseMode";
            this.tlpUseMode.RowCount = 1;
            this.tlpUseMode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUseMode.Size = new System.Drawing.Size(223, 30);
            this.tlpUseMode.TabIndex = 25;
            // 
            // rbOptMode
            // 
            this.rbOptMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbOptMode.AutoSize = true;
            this.rbOptMode.Location = new System.Drawing.Point(4, 3);
            this.rbOptMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbOptMode.Name = "rbOptMode";
            this.rbOptMode.Size = new System.Drawing.Size(103, 24);
            this.rbOptMode.TabIndex = 0;
            this.rbOptMode.Text = "Optimistic";
            this.rbOptMode.UseVisualStyleBackColor = true;
            // 
            // rbWaitMode
            // 
            this.rbWaitMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbWaitMode.AutoSize = true;
            this.rbWaitMode.Checked = true;
            this.rbWaitMode.Location = new System.Drawing.Point(115, 3);
            this.rbWaitMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbWaitMode.Name = "rbWaitMode";
            this.rbWaitMode.Size = new System.Drawing.Size(104, 24);
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
            this.tlpSkillList.SetColumnSpan(this.lstSkillSequence, 3);
            this.lstSkillSequence.ContextMenuStrip = this.cmsSkill;
            this.lstSkillSequence.FormattingEnabled = true;
            this.lstSkillSequence.HorizontalScrollbar = true;
            this.lstSkillSequence.ItemHeight = 15;
            this.lstSkillSequence.Location = new System.Drawing.Point(4, 3);
            this.lstSkillSequence.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstSkillSequence.Name = "lstSkillSequence";
            this.lstSkillSequence.Size = new System.Drawing.Size(231, 304);
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
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(398, 3);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(82, 24);
            this.btnCopy.TabIndex = 15;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnClearSkillString
            // 
            this.btnClearSkillString.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearSkillString.Location = new System.Drawing.Point(366, 3);
            this.btnClearSkillString.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClearSkillString.Name = "btnClearSkillString";
            this.btnClearSkillString.Size = new System.Drawing.Size(24, 24);
            this.btnClearSkillString.TabIndex = 21;
            this.btnClearSkillString.Text = "✖";
            this.btnClearSkillString.UseVisualStyleBackColor = true;
            this.btnClearSkillString.Click += new System.EventHandler(this.btnClearSkillString_Click);
            // 
            // tlpSkillList
            // 
            this.tlpSkillList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSkillList.ColumnCount = 3;
            this.tlpSkillList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpSkillList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSkillList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpSkillList.Controls.Add(this.numSkillIndex, 1, 1);
            this.tlpSkillList.Controls.Add(this.btnAddSkill, 2, 1);
            this.tlpSkillList.Controls.Add(this.lstSkillSequence, 0, 0);
            this.tlpSkillList.Location = new System.Drawing.Point(0, 0);
            this.tlpSkillList.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSkillList.Name = "tlpSkillList";
            this.tlpSkillList.RowCount = 2;
            this.tlpSkills.SetRowSpan(this.tlpSkillList, 3);
            this.tlpSkillList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSkillList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSkillList.Size = new System.Drawing.Size(239, 341);
            this.tlpSkillList.TabIndex = 22;
            // 
            // tlpSkills
            // 
            this.tlpSkills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSkills.ColumnCount = 2;
            this.tlpSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSkills.Controls.Add(this.gbCalcTimeout, 1, 0);
            this.tlpSkills.Controls.Add(this.tlpSkillList, 0, 0);
            this.tlpSkills.Controls.Add(this.gbUseMode, 1, 1);
            this.tlpSkills.Controls.Add(this.gbUseRules, 1, 2);
            this.tlpSkills.Location = new System.Drawing.Point(3, 3);
            this.tlpSkills.Name = "tlpSkills";
            this.tlpSkills.RowCount = 3;
            this.tlpSkills.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSkills.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSkills.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSkills.Size = new System.Drawing.Size(478, 341);
            this.tlpSkills.TabIndex = 23;
            // 
            // tlpConvert
            // 
            this.tlpConvert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpConvert.ColumnCount = 4;
            this.tlpConvert.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpConvert.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpConvert.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpConvert.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpConvert.Controls.Add(this.btnConvert, 0, 0);
            this.tlpConvert.Controls.Add(this.txtSkillString, 1, 0);
            this.tlpConvert.Controls.Add(this.btnClearSkillString, 2, 0);
            this.tlpConvert.Controls.Add(this.btnCopy, 3, 0);
            this.tlpConvert.Location = new System.Drawing.Point(0, 347);
            this.tlpConvert.Margin = new System.Windows.Forms.Padding(0);
            this.tlpConvert.Name = "tlpConvert";
            this.tlpConvert.RowCount = 1;
            this.tlpConvert.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpConvert.Size = new System.Drawing.Size(484, 30);
            this.tlpConvert.TabIndex = 23;
            // 
            // tlpSave
            // 
            this.tlpSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSave.ColumnCount = 6;
            this.tlpSave.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpSave.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSave.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpSave.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpSave.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSave.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpSave.Controls.Add(this.btnRemoveSkill, 5, 0);
            this.tlpSave.Controls.Add(this.lstSavedSkills, 0, 1);
            this.tlpSave.Controls.Add(this.lblSaveName, 0, 0);
            this.tlpSave.Controls.Add(this.txtSaveName, 1, 0);
            this.tlpSave.Controls.Add(this.chkOverride, 4, 0);
            this.tlpSave.Controls.Add(this.btnSave, 3, 0);
            this.tlpSave.Controls.Add(this.cbModes, 2, 0);
            this.tlpSave.Location = new System.Drawing.Point(0, 377);
            this.tlpSave.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSave.Name = "tlpSave";
            this.tlpSave.RowCount = 2;
            this.tlpSave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSave.Size = new System.Drawing.Size(484, 310);
            this.tlpSave.TabIndex = 21;
            // 
            // btnRemoveSkill
            // 
            this.btnRemoveSkill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveSkill.Location = new System.Drawing.Point(456, 3);
            this.btnRemoveSkill.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRemoveSkill.Name = "btnRemoveSkill";
            this.btnRemoveSkill.Size = new System.Drawing.Size(24, 24);
            this.btnRemoveSkill.TabIndex = 22;
            this.btnRemoveSkill.Text = "✖";
            this.btnRemoveSkill.UseVisualStyleBackColor = true;
            this.btnRemoveSkill.Click += new System.EventHandler(this.btnRemoveSkill_Click);
            // 
            // lstSavedSkills
            // 
            this.lstSavedSkills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSave.SetColumnSpan(this.lstSavedSkills, 6);
            this.lstSavedSkills.FormattingEnabled = true;
            this.lstSavedSkills.ItemHeight = 15;
            this.lstSavedSkills.Location = new System.Drawing.Point(4, 33);
            this.lstSavedSkills.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstSavedSkills.Name = "lstSavedSkills";
            this.lstSavedSkills.Size = new System.Drawing.Size(476, 274);
            this.lstSavedSkills.TabIndex = 20;
            this.lstSavedSkills.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstSavedSkills_MouseDoubleClick);
            // 
            // lblSaveName
            // 
            this.lblSaveName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaveName.AutoSize = true;
            this.lblSaveName.Location = new System.Drawing.Point(4, 0);
            this.lblSaveName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaveName.Name = "lblSaveName";
            this.lblSaveName.Size = new System.Drawing.Size(72, 30);
            this.lblSaveName.TabIndex = 10;
            this.lblSaveName.Text = "Save Name:";
            this.lblSaveName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSaveName
            // 
            this.txtSaveName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaveName.Location = new System.Drawing.Point(84, 3);
            this.txtSaveName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSaveName.Name = "txtSaveName";
            this.txtSaveName.Size = new System.Drawing.Size(145, 23);
            this.txtSaveName.TabIndex = 18;
            // 
            // chkOverride
            // 
            this.chkOverride.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkOverride.AutoSize = true;
            this.chkOverride.Checked = true;
            this.chkOverride.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOverride.Location = new System.Drawing.Point(377, 3);
            this.chkOverride.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkOverride.Name = "chkOverride";
            this.chkOverride.Size = new System.Drawing.Size(71, 24);
            this.chkOverride.TabIndex = 10;
            this.chkOverride.Text = "Override";
            this.chkOverride.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(307, 3);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 24);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbModes
            // 
            this.cbModes.FormattingEnabled = true;
            this.cbModes.Items.AddRange(new object[] {
            "Base,",
            "Atk",
            "Def",
            "Farm",
            "Solo",
            "Supp"});
            this.cbModes.Location = new System.Drawing.Point(236, 3);
            this.cbModes.Name = "cbModes";
            this.cbModes.Size = new System.Drawing.Size(64, 23);
            this.cbModes.TabIndex = 23;
            // 
            // tlpAdvancedSkills
            // 
            this.tlpAdvancedSkills.ColumnCount = 1;
            this.tlpAdvancedSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAdvancedSkills.Controls.Add(this.tlpSkills, 0, 0);
            this.tlpAdvancedSkills.Controls.Add(this.tlpSave, 0, 2);
            this.tlpAdvancedSkills.Controls.Add(this.tlpConvert, 0, 1);
            this.tlpAdvancedSkills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAdvancedSkills.Location = new System.Drawing.Point(0, 0);
            this.tlpAdvancedSkills.Name = "tlpAdvancedSkills";
            this.tlpAdvancedSkills.RowCount = 3;
            this.tlpAdvancedSkills.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAdvancedSkills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpAdvancedSkills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAdvancedSkills.Size = new System.Drawing.Size(484, 687);
            this.tlpAdvancedSkills.TabIndex = 24;
            // 
            // AdvancedSkillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 687);
            this.Controls.Add(this.tlpAdvancedSkills);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(500, 726);
            this.Name = "AdvancedSkillForm";
            this.Text = "Advanced Skills";
            ((System.ComponentModel.ISupportInitialize)(this.numSkillIndex)).EndInit();
            this.gbCalcTimeout.ResumeLayout(false);
            this.tlpCalcSkillTimeout.ResumeLayout(false);
            this.tlpCalcSkillTimeout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillTimer)).EndInit();
            this.gbUseRules.ResumeLayout(false);
            this.cmsUseRule.ResumeLayout(false);
            this.tlpUseRules.ResumeLayout(false);
            this.tlpUseRules.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHealth)).EndInit();
            this.gbUseMode.ResumeLayout(false);
            this.tlpUseMode.ResumeLayout(false);
            this.tlpUseMode.PerformLayout();
            this.cmsSkill.ResumeLayout(false);
            this.tlpSkillList.ResumeLayout(false);
            this.tlpSkills.ResumeLayout(false);
            this.tlpConvert.ResumeLayout(false);
            this.tlpConvert.PerformLayout();
            this.tlpSave.ResumeLayout(false);
            this.tlpSave.PerformLayout();
            this.tlpAdvancedSkills.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tlpSkillList;
        private System.Windows.Forms.TableLayoutPanel tlpSkills;
        private System.Windows.Forms.TableLayoutPanel tlpConvert;
        private System.Windows.Forms.TableLayoutPanel tlpSave;
        private System.Windows.Forms.Button btnRemoveSkill;
        private System.Windows.Forms.ListBox lstSavedSkills;
        private System.Windows.Forms.Label lblSaveName;
        private System.Windows.Forms.TextBox txtSaveName;
        private System.Windows.Forms.CheckBox chkOverride;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tlpAdvancedSkills;
        private System.Windows.Forms.ComboBox cbModes;
        private System.Windows.Forms.TableLayoutPanel tlpCalcSkillTimeout;
        private System.Windows.Forms.TableLayoutPanel tlpUseRules;
        private System.Windows.Forms.TableLayoutPanel tlpUseMode;
    }
}