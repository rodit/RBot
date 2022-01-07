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
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSkills
            // 
            this.lbSkills.FormattingEnabled = true;
            this.lbSkills.Location = new System.Drawing.Point(12, 13);
            this.lbSkills.Name = "lbSkills";
            this.lbSkills.Size = new System.Drawing.Size(264, 225);
            this.lbSkills.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(282, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(129, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(282, 41);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(282, 70);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(129, 23);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(282, 99);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(129, 23);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(282, 128);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(129, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(282, 163);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(59, 13);
            this.lblDelay.TabIndex = 6;
            this.lblDelay.Text = "Delay (ms):";
            // 
            // numDelay
            // 
            this.numDelay.Location = new System.Drawing.Point(347, 161);
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
            this.numDelay.Size = new System.Drawing.Size(64, 20);
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
            this.btnEditUseRule.Location = new System.Drawing.Point(282, 187);
            this.btnEditUseRule.Name = "btnEditUseRule";
            this.btnEditUseRule.Size = new System.Drawing.Size(129, 23);
            this.btnEditUseRule.TabIndex = 8;
            this.btnEditUseRule.Text = "Edit Use Rule";
            this.btnEditUseRule.UseVisualStyleBackColor = true;
            this.btnEditUseRule.Click += new System.EventHandler(this.btnEditUseRule_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(282, 216);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(129, 23);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(282, 245);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbSkills
            // 
            this.cbSkills.FormattingEnabled = true;
            this.cbSkills.Location = new System.Drawing.Point(12, 245);
            this.cbSkills.Name = "cbSkills";
            this.cbSkills.Size = new System.Drawing.Size(264, 21);
            this.cbSkills.TabIndex = 11;
            // 
            // lnkRefreshSkills
            // 
            this.lnkRefreshSkills.AutoSize = true;
            this.lnkRefreshSkills.Location = new System.Drawing.Point(232, 266);
            this.lnkRefreshSkills.Name = "lnkRefreshSkills";
            this.lnkRefreshSkills.Size = new System.Drawing.Size(44, 13);
            this.lnkRefreshSkills.TabIndex = 12;
            this.lnkRefreshSkills.TabStop = true;
            this.lnkRefreshSkills.Text = "Refresh";
            this.lnkRefreshSkills.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRefreshSkills_LinkClicked);
            // 
            // SkillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 281);
            this.Controls.Add(this.lnkRefreshSkills);
            this.Controls.Add(this.cbSkills);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEditUseRule);
            this.Controls.Add(this.numDelay);
            this.Controls.Add(this.lblDelay);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lbSkills);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SkillsForm";
            this.Text = "Skills";
            this.Load += new System.EventHandler(this.SkillsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}