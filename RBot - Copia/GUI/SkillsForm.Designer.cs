namespace RBot
{
    partial class SkillsForm
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
            this.lbSkills = new System.Windows.Forms.ListBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblDelay = new System.Windows.Forms.Label();
            this.numDelay = new System.Windows.Forms.NumericUpDown();
            this.btnEditUseRule = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbSkills = new System.Windows.Forms.ComboBox();
            this.lnkRefreshSkills = new System.Windows.Forms.LinkLabel();
            this.tlpSkills = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).BeginInit();
            this.tlpSkills.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSkills
            // 
            this.lbSkills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSkills.FormattingEnabled = true;
            this.lbSkills.ItemHeight = 15;
            this.lbSkills.Location = new System.Drawing.Point(4, 3);
            this.lbSkills.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbSkills.Name = "lbSkills";
            this.tlpSkills.SetRowSpan(this.lbSkills, 8);
            this.lbSkills.Size = new System.Drawing.Size(363, 289);
            this.lbSkills.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.tlpSkills.SetColumnSpan(this.btnLoad, 2);
            this.btnLoad.Location = new System.Drawing.Point(375, 3);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(147, 24);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.tlpSkills.SetColumnSpan(this.btnSave, 2);
            this.btnSave.Location = new System.Drawing.Point(375, 33);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 24);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUp
            // 
            this.tlpSkills.SetColumnSpan(this.btnUp, 2);
            this.btnUp.Location = new System.Drawing.Point(375, 63);
            this.btnUp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(147, 24);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.tlpSkills.SetColumnSpan(this.btnDown, 2);
            this.btnDown.Location = new System.Drawing.Point(375, 93);
            this.btnDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(147, 24);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnClear
            // 
            this.tlpSkills.SetColumnSpan(this.btnClear, 2);
            this.btnClear.Location = new System.Drawing.Point(375, 123);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(147, 24);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblDelay
            // 
            this.lblDelay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(375, 221);
            this.lblDelay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(67, 15);
            this.lblDelay.TabIndex = 6;
            this.lblDelay.Text = "Delay (ms):";
            this.lblDelay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numDelay
            // 
            this.numDelay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numDelay.Location = new System.Drawing.Point(450, 210);
            this.numDelay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numDelay.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDelay.Name = "numDelay";
            this.numDelay.Size = new System.Drawing.Size(72, 23);
            this.numDelay.TabIndex = 7;
            this.numDelay.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numDelay.ValueChanged += new System.EventHandler(this.numDelay_ValueChanged);
            // 
            // btnEditUseRule
            // 
            this.tlpSkills.SetColumnSpan(this.btnEditUseRule, 2);
            this.btnEditUseRule.Location = new System.Drawing.Point(375, 239);
            this.btnEditUseRule.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditUseRule.Name = "btnEditUseRule";
            this.btnEditUseRule.Size = new System.Drawing.Size(147, 24);
            this.btnEditUseRule.TabIndex = 8;
            this.btnEditUseRule.Text = "Edit Use Rule";
            this.btnEditUseRule.UseVisualStyleBackColor = true;
            this.btnEditUseRule.Click += new System.EventHandler(this.btnEditUseRule_Click);
            // 
            // btnRemove
            // 
            this.tlpSkills.SetColumnSpan(this.btnRemove, 2);
            this.btnRemove.Location = new System.Drawing.Point(375, 269);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(147, 24);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.tlpSkills.SetColumnSpan(this.btnAdd, 2);
            this.btnAdd.Location = new System.Drawing.Point(375, 299);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(147, 24);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbSkills
            // 
            this.cbSkills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSkills.FormattingEnabled = true;
            this.cbSkills.Location = new System.Drawing.Point(4, 299);
            this.cbSkills.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbSkills.Name = "cbSkills";
            this.cbSkills.Size = new System.Drawing.Size(363, 23);
            this.cbSkills.TabIndex = 11;
            // 
            // lnkRefreshSkills
            // 
            this.lnkRefreshSkills.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkRefreshSkills.AutoSize = true;
            this.lnkRefreshSkills.Location = new System.Drawing.Point(321, 326);
            this.lnkRefreshSkills.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkRefreshSkills.Name = "lnkRefreshSkills";
            this.lnkRefreshSkills.Size = new System.Drawing.Size(46, 15);
            this.lnkRefreshSkills.TabIndex = 12;
            this.lnkRefreshSkills.TabStop = true;
            this.lnkRefreshSkills.Text = "Refresh";
            this.lnkRefreshSkills.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRefreshSkills_LinkClicked);
            // 
            // tlpSkills
            // 
            this.tlpSkills.ColumnCount = 3;
            this.tlpSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpSkills.Controls.Add(this.btnLoad, 1, 0);
            this.tlpSkills.Controls.Add(this.lnkRefreshSkills, 0, 9);
            this.tlpSkills.Controls.Add(this.btnSave, 1, 1);
            this.tlpSkills.Controls.Add(this.cbSkills, 0, 8);
            this.tlpSkills.Controls.Add(this.lbSkills, 0, 0);
            this.tlpSkills.Controls.Add(this.btnAdd, 1, 8);
            this.tlpSkills.Controls.Add(this.btnUp, 1, 2);
            this.tlpSkills.Controls.Add(this.btnRemove, 1, 7);
            this.tlpSkills.Controls.Add(this.btnDown, 1, 3);
            this.tlpSkills.Controls.Add(this.btnEditUseRule, 1, 6);
            this.tlpSkills.Controls.Add(this.btnClear, 1, 4);
            this.tlpSkills.Controls.Add(this.lblDelay, 1, 5);
            this.tlpSkills.Controls.Add(this.numDelay, 2, 5);
            this.tlpSkills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSkills.Location = new System.Drawing.Point(0, 0);
            this.tlpSkills.Name = "tlpSkills";
            this.tlpSkills.RowCount = 10;
            this.tlpSkills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSkills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSkills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSkills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSkills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSkills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSkills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSkills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSkills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSkills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSkills.Size = new System.Drawing.Size(526, 346);
            this.tlpSkills.TabIndex = 13;
            // 
            // SkillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 346);
            this.Controls.Add(this.tlpSkills);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(375, 330);
            this.Name = "SkillsForm";
            this.Text = "Skills";
            this.Load += new System.EventHandler(this.SkillsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).EndInit();
            this.tlpSkills.ResumeLayout(false);
            this.tlpSkills.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbSkills;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.NumericUpDown numDelay;
        private System.Windows.Forms.Button btnEditUseRule;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbSkills;
        private System.Windows.Forms.LinkLabel lnkRefreshSkills;
        private System.Windows.Forms.TableLayoutPanel tlpSkills;
    }
}