namespace RBot
{
    partial class StrategyBuilderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StrategyBuilderForm));
            this.lbStrats = new System.Windows.Forms.ListBox();
            this.stratMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitStrats = new System.Windows.Forms.SplitContainer();
            this.btnShowGraph = new System.Windows.Forms.Button();
            this.btnEditDrops = new System.Windows.Forms.Button();
            this.chkDropTemp = new System.Windows.Forms.CheckBox();
            this.txtShopMap = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRegisterDrop = new System.Windows.Forms.Button();
            this.txtDropName = new System.Windows.Forms.TextBox();
            this.txtDropMonsters = new System.Windows.Forms.TextBox();
            this.lblDropTitle = new System.Windows.Forms.Label();
            this.txtDropMap = new System.Windows.Forms.TextBox();
            this.btnRegisterShop = new System.Windows.Forms.Button();
            this.numShopID = new System.Windows.Forms.NumericUpDown();
            this.btnRegisterQuest = new System.Windows.Forms.Button();
            this.numQuestID = new System.Windows.Forms.NumericUpDown();
            this.lblQuestID = new System.Windows.Forms.Label();
            this.lblShop = new System.Windows.Forms.Label();
            this.stratMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitStrats)).BeginInit();
            this.splitStrats.Panel1.SuspendLayout();
            this.splitStrats.Panel2.SuspendLayout();
            this.splitStrats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numShopID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuestID)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStrats
            // 
            this.lbStrats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStrats.FormattingEnabled = true;
            this.lbStrats.Location = new System.Drawing.Point(0, 0);
            this.lbStrats.Name = "lbStrats";
            this.lbStrats.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbStrats.Size = new System.Drawing.Size(274, 321);
            this.lbStrats.TabIndex = 0;
            this.lbStrats.SelectedIndexChanged += new System.EventHandler(this.lbStrats_SelectedIndexChanged);
            // 
            // stratMainMenu
            // 
            this.stratMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.stratMainMenu.Location = new System.Drawing.Point(0, 0);
            this.stratMainMenu.Name = "stratMainMenu";
            this.stratMainMenu.Size = new System.Drawing.Size(607, 24);
            this.stratMainMenu.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(183, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateScriptToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // generateScriptToolStripMenuItem
            // 
            this.generateScriptToolStripMenuItem.Name = "generateScriptToolStripMenuItem";
            this.generateScriptToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.generateScriptToolStripMenuItem.Text = "Generate Script";
            this.generateScriptToolStripMenuItem.Click += new System.EventHandler(this.generateScriptToolStripMenuItem_Click);
            // 
            // splitStrats
            // 
            this.splitStrats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitStrats.Location = new System.Drawing.Point(0, 24);
            this.splitStrats.Name = "splitStrats";
            // 
            // splitStrats.Panel1
            // 
            this.splitStrats.Panel1.Controls.Add(this.lbStrats);
            // 
            // splitStrats.Panel2
            // 
            this.splitStrats.Panel2.Controls.Add(this.btnShowGraph);
            this.splitStrats.Panel2.Controls.Add(this.btnEditDrops);
            this.splitStrats.Panel2.Controls.Add(this.chkDropTemp);
            this.splitStrats.Panel2.Controls.Add(this.txtShopMap);
            this.splitStrats.Panel2.Controls.Add(this.btnClear);
            this.splitStrats.Panel2.Controls.Add(this.btnRemove);
            this.splitStrats.Panel2.Controls.Add(this.btnRegisterDrop);
            this.splitStrats.Panel2.Controls.Add(this.txtDropName);
            this.splitStrats.Panel2.Controls.Add(this.txtDropMonsters);
            this.splitStrats.Panel2.Controls.Add(this.lblDropTitle);
            this.splitStrats.Panel2.Controls.Add(this.txtDropMap);
            this.splitStrats.Panel2.Controls.Add(this.btnRegisterShop);
            this.splitStrats.Panel2.Controls.Add(this.numShopID);
            this.splitStrats.Panel2.Controls.Add(this.btnRegisterQuest);
            this.splitStrats.Panel2.Controls.Add(this.numQuestID);
            this.splitStrats.Panel2.Controls.Add(this.lblQuestID);
            this.splitStrats.Panel2.Controls.Add(this.lblShop);
            this.splitStrats.Size = new System.Drawing.Size(607, 321);
            this.splitStrats.SplitterDistance = 274;
            this.splitStrats.TabIndex = 2;
            // 
            // btnShowGraph
            // 
            this.btnShowGraph.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowGraph.Location = new System.Drawing.Point(3, 260);
            this.btnShowGraph.Name = "btnShowGraph";
            this.btnShowGraph.Size = new System.Drawing.Size(319, 23);
            this.btnShowGraph.TabIndex = 23;
            this.btnShowGraph.Text = "Show Graph";
            this.btnShowGraph.UseVisualStyleBackColor = true;
            this.btnShowGraph.Click += new System.EventHandler(this.btnShowGraph_Click);
            // 
            // btnEditDrops
            // 
            this.btnEditDrops.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditDrops.Location = new System.Drawing.Point(3, 231);
            this.btnEditDrops.Name = "btnEditDrops";
            this.btnEditDrops.Size = new System.Drawing.Size(319, 23);
            this.btnEditDrops.TabIndex = 22;
            this.btnEditDrops.Text = "Edit Drop Aggregate";
            this.btnEditDrops.UseVisualStyleBackColor = true;
            this.btnEditDrops.Click += new System.EventHandler(this.btnEditDrops_Click);
            // 
            // chkDropTemp
            // 
            this.chkDropTemp.AutoSize = true;
            this.chkDropTemp.Location = new System.Drawing.Point(3, 206);
            this.chkDropTemp.Name = "chkDropTemp";
            this.chkDropTemp.Size = new System.Drawing.Size(53, 17);
            this.chkDropTemp.TabIndex = 21;
            this.chkDropTemp.Text = "Temp";
            this.chkDropTemp.UseVisualStyleBackColor = true;
            // 
            // txtShopMap
            // 
            this.txtShopMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShopMap.Location = new System.Drawing.Point(240, 56);
            this.txtShopMap.Name = "txtShopMap";
            this.txtShopMap.Size = new System.Drawing.Size(82, 20);
            this.txtShopMap.TabIndex = 20;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(192, 295);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(3, 295);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(183, 23);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRegisterDrop
            // 
            this.btnRegisterDrop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterDrop.Location = new System.Drawing.Point(62, 202);
            this.btnRegisterDrop.Name = "btnRegisterDrop";
            this.btnRegisterDrop.Size = new System.Drawing.Size(260, 23);
            this.btnRegisterDrop.TabIndex = 12;
            this.btnRegisterDrop.Text = "Register Drop";
            this.btnRegisterDrop.UseVisualStyleBackColor = true;
            this.btnRegisterDrop.Click += new System.EventHandler(this.btnRegisterDrop_Click);
            // 
            // txtDropName
            // 
            this.txtDropName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDropName.Location = new System.Drawing.Point(3, 176);
            this.txtDropName.Name = "txtDropName";
            this.txtDropName.Size = new System.Drawing.Size(319, 20);
            this.txtDropName.TabIndex = 11;
            // 
            // txtDropMonsters
            // 
            this.txtDropMonsters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDropMonsters.Location = new System.Drawing.Point(3, 150);
            this.txtDropMonsters.Name = "txtDropMonsters";
            this.txtDropMonsters.Size = new System.Drawing.Size(319, 20);
            this.txtDropMonsters.TabIndex = 10;
            // 
            // lblDropTitle
            // 
            this.lblDropTitle.AutoSize = true;
            this.lblDropTitle.Location = new System.Drawing.Point(3, 108);
            this.lblDropTitle.Name = "lblDropTitle";
            this.lblDropTitle.Size = new System.Drawing.Size(33, 13);
            this.lblDropTitle.TabIndex = 9;
            this.lblDropTitle.Text = "Drop:";
            // 
            // txtDropMap
            // 
            this.txtDropMap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDropMap.Location = new System.Drawing.Point(3, 124);
            this.txtDropMap.Name = "txtDropMap";
            this.txtDropMap.Size = new System.Drawing.Size(319, 20);
            this.txtDropMap.TabIndex = 8;
            // 
            // btnRegisterShop
            // 
            this.btnRegisterShop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterShop.Location = new System.Drawing.Point(3, 82);
            this.btnRegisterShop.Name = "btnRegisterShop";
            this.btnRegisterShop.Size = new System.Drawing.Size(319, 23);
            this.btnRegisterShop.TabIndex = 7;
            this.btnRegisterShop.Text = "Register Shop";
            this.btnRegisterShop.UseVisualStyleBackColor = true;
            this.btnRegisterShop.Click += new System.EventHandler(this.btnRegisterShop_Click);
            // 
            // numShopID
            // 
            this.numShopID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numShopID.Location = new System.Drawing.Point(3, 56);
            this.numShopID.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numShopID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numShopID.Name = "numShopID";
            this.numShopID.Size = new System.Drawing.Size(231, 20);
            this.numShopID.TabIndex = 6;
            this.numShopID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRegisterQuest
            // 
            this.btnRegisterQuest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterQuest.Location = new System.Drawing.Point(240, 14);
            this.btnRegisterQuest.Name = "btnRegisterQuest";
            this.btnRegisterQuest.Size = new System.Drawing.Size(82, 23);
            this.btnRegisterQuest.TabIndex = 5;
            this.btnRegisterQuest.Text = "Register";
            this.btnRegisterQuest.UseVisualStyleBackColor = true;
            this.btnRegisterQuest.Click += new System.EventHandler(this.btnRegisterQuest_Click);
            // 
            // numQuestID
            // 
            this.numQuestID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numQuestID.Location = new System.Drawing.Point(3, 17);
            this.numQuestID.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numQuestID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuestID.Name = "numQuestID";
            this.numQuestID.Size = new System.Drawing.Size(231, 20);
            this.numQuestID.TabIndex = 4;
            this.numQuestID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQuestID
            // 
            this.lblQuestID.AutoSize = true;
            this.lblQuestID.Location = new System.Drawing.Point(3, 0);
            this.lblQuestID.Name = "lblQuestID";
            this.lblQuestID.Size = new System.Drawing.Size(52, 13);
            this.lblQuestID.TabIndex = 3;
            this.lblQuestID.Text = "Quest ID:";
            // 
            // lblShop
            // 
            this.lblShop.AutoSize = true;
            this.lblShop.Location = new System.Drawing.Point(3, 40);
            this.lblShop.Name = "lblShop";
            this.lblShop.Size = new System.Drawing.Size(35, 13);
            this.lblShop.TabIndex = 0;
            this.lblShop.Text = "Shop:";
            // 
            // StrategyBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 345);
            this.Controls.Add(this.splitStrats);
            this.Controls.Add(this.stratMainMenu);
            this.MainMenuStrip = this.stratMainMenu;
            this.Name = "StrategyBuilderForm";
            this.Text = "Strategy Builder";
            this.stratMainMenu.ResumeLayout(false);
            this.stratMainMenu.PerformLayout();
            this.splitStrats.Panel1.ResumeLayout(false);
            this.splitStrats.Panel2.ResumeLayout(false);
            this.splitStrats.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitStrats)).EndInit();
            this.splitStrats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numShopID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuestID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbStrats;
        private System.Windows.Forms.MenuStrip stratMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitStrats;
        private System.Windows.Forms.Label lblQuestID;
        private System.Windows.Forms.Label lblShop;
        private System.Windows.Forms.NumericUpDown numQuestID;
        private System.Windows.Forms.Button btnRegisterQuest;
        private System.Windows.Forms.Button btnRegisterShop;
        private System.Windows.Forms.NumericUpDown numShopID;
        private System.Windows.Forms.Label lblDropTitle;
        private System.Windows.Forms.TextBox txtDropMap;
        private System.Windows.Forms.TextBox txtDropMonsters;
        private System.Windows.Forms.TextBox txtDropName;
        private System.Windows.Forms.Button btnRegisterDrop;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtShopMap;
        private System.Windows.Forms.CheckBox chkDropTemp;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateScriptToolStripMenuItem;
        private System.Windows.Forms.Button btnEditDrops;
    private System.Windows.Forms.Button btnShowGraph;
  }
}