namespace RBot
{
    partial class SkillRuleForm
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
			this.lbRules = new System.Windows.Forms.ListBox();
			this.cbRules = new System.Windows.Forms.ComboBox();
			this.propsRule = new System.Windows.Forms.PropertyGrid();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEditCombined = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbRules
			// 
			this.lbRules.FormattingEnabled = true;
			this.lbRules.Location = new System.Drawing.Point(12, 12);
			this.lbRules.Name = "lbRules";
			this.lbRules.Size = new System.Drawing.Size(223, 238);
			this.lbRules.TabIndex = 0;
			// 
			// cbRules
			// 
			this.cbRules.FormattingEnabled = true;
			this.cbRules.Location = new System.Drawing.Point(12, 256);
			this.cbRules.Name = "cbRules";
			this.cbRules.Size = new System.Drawing.Size(137, 21);
			this.cbRules.TabIndex = 1;
			// 
			// propsRule
			// 
			this.propsRule.Location = new System.Drawing.Point(241, 12);
			this.propsRule.Name = "propsRule";
			this.propsRule.Size = new System.Drawing.Size(182, 238);
			this.propsRule.TabIndex = 2;
			this.propsRule.ToolbarVisible = false;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(155, 254);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(80, 23);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "Add Rule";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnEditCombined
			// 
			this.btnEditCombined.Location = new System.Drawing.Point(241, 254);
			this.btnEditCombined.Name = "btnEditCombined";
			this.btnEditCombined.Size = new System.Drawing.Size(182, 23);
			this.btnEditCombined.TabIndex = 4;
			this.btnEditCombined.Text = "Combined Rule Options";
			this.btnEditCombined.UseVisualStyleBackColor = true;
			this.btnEditCombined.Click += new System.EventHandler(this.btnEditCombined_Click);
			// 
			// SkillRuleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(435, 287);
			this.Controls.Add(this.btnEditCombined);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.propsRule);
			this.Controls.Add(this.cbRules);
			this.Controls.Add(this.lbRules);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "SkillRuleForm";
			this.ShowIcon = false;
			this.Text = "Edit Use Rule";
			this.Load += new System.EventHandler(this.SkillRuleForm_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbRules;
        private System.Windows.Forms.ComboBox cbRules;
        private System.Windows.Forms.PropertyGrid propsRule;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEditCombined;
    }
}