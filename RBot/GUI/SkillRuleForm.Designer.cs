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
            this.tlpUseRule = new System.Windows.Forms.TableLayoutPanel();
            this.tlpUseRule.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbRules
            // 
            this.tlpUseRule.SetColumnSpan(this.lbRules, 2);
            this.lbRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRules.FormattingEnabled = true;
            this.lbRules.ItemHeight = 15;
            this.lbRules.Location = new System.Drawing.Point(4, 3);
            this.lbRules.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbRules.Name = "lbRules";
            this.lbRules.Size = new System.Drawing.Size(250, 259);
            this.lbRules.TabIndex = 0;
            // 
            // cbRules
            // 
            this.cbRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbRules.FormattingEnabled = true;
            this.cbRules.Location = new System.Drawing.Point(4, 268);
            this.cbRules.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbRules.Name = "cbRules";
            this.cbRules.Size = new System.Drawing.Size(147, 23);
            this.cbRules.TabIndex = 1;
            // 
            // propsRule
            // 
            this.propsRule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propsRule.Location = new System.Drawing.Point(262, 3);
            this.propsRule.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.propsRule.Name = "propsRule";
            this.propsRule.Size = new System.Drawing.Size(252, 259);
            this.propsRule.TabIndex = 2;
            this.propsRule.ToolbarVisible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(159, 268);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 24);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Rule";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEditCombined
            // 
            this.btnEditCombined.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditCombined.Location = new System.Drawing.Point(262, 268);
            this.btnEditCombined.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditCombined.Name = "btnEditCombined";
            this.btnEditCombined.Size = new System.Drawing.Size(252, 24);
            this.btnEditCombined.TabIndex = 4;
            this.btnEditCombined.Text = "Combined Rule Options";
            this.btnEditCombined.UseVisualStyleBackColor = true;
            this.btnEditCombined.Click += new System.EventHandler(this.btnEditCombined_Click);
            // 
            // tlpUseRule
            // 
            this.tlpUseRule.ColumnCount = 3;
            this.tlpUseRule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpUseRule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpUseRule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUseRule.Controls.Add(this.cbRules, 0, 1);
            this.tlpUseRule.Controls.Add(this.lbRules, 0, 0);
            this.tlpUseRule.Controls.Add(this.propsRule, 2, 0);
            this.tlpUseRule.Controls.Add(this.btnEditCombined, 2, 1);
            this.tlpUseRule.Controls.Add(this.btnAdd, 1, 1);
            this.tlpUseRule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUseRule.Location = new System.Drawing.Point(0, 0);
            this.tlpUseRule.Name = "tlpUseRule";
            this.tlpUseRule.RowCount = 2;
            this.tlpUseRule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUseRule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpUseRule.Size = new System.Drawing.Size(518, 295);
            this.tlpUseRule.TabIndex = 5;
            // 
            // SkillRuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 295);
            this.Controls.Add(this.tlpUseRule);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(335, 200);
            this.Name = "SkillRuleForm";
            this.ShowIcon = false;
            this.Text = "Edit Use Rule";
            this.Load += new System.EventHandler(this.SkillRuleForm_Load);
            this.tlpUseRule.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbRules;
        private System.Windows.Forms.ComboBox cbRules;
        private System.Windows.Forms.PropertyGrid propsRule;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEditCombined;
        private System.Windows.Forms.TableLayoutPanel tlpUseRule;
    }
}