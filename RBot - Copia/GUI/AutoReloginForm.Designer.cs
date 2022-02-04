namespace RBot
{
    partial class AutoReloginForm
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
            this.cbServers = new System.Windows.Forms.ComboBox();
            this.chkRelogin = new System.Windows.Forms.CheckBox();
            this.chkReloginAny = new System.Windows.Forms.CheckBox();
            this.chkSafeRelogin = new System.Windows.Forms.CheckBox();
            this.tlpAutoRelogin = new System.Windows.Forms.TableLayoutPanel();
            this.tlpAutoRelogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbServers
            // 
            this.cbServers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbServers.FormattingEnabled = true;
            this.cbServers.Location = new System.Drawing.Point(4, 3);
            this.cbServers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbServers.Name = "cbServers";
            this.cbServers.Size = new System.Drawing.Size(411, 23);
            this.cbServers.TabIndex = 0;
            // 
            // chkRelogin
            // 
            this.chkRelogin.AutoSize = true;
            this.chkRelogin.Location = new System.Drawing.Point(4, 33);
            this.chkRelogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkRelogin.Name = "chkRelogin";
            this.chkRelogin.Size = new System.Drawing.Size(95, 19);
            this.chkRelogin.TabIndex = 1;
            this.chkRelogin.Text = "Auto Relogin";
            this.chkRelogin.UseVisualStyleBackColor = true;
            // 
            // chkReloginAny
            // 
            this.chkReloginAny.AutoSize = true;
            this.chkReloginAny.Location = new System.Drawing.Point(4, 58);
            this.chkReloginAny.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkReloginAny.Name = "chkReloginAny";
            this.chkReloginAny.Size = new System.Drawing.Size(140, 19);
            this.chkReloginAny.TabIndex = 2;
            this.chkReloginAny.Text = "Relogin To Any Server";
            this.chkReloginAny.UseVisualStyleBackColor = true;
            // 
            // chkSafeRelogin
            // 
            this.chkSafeRelogin.AutoSize = true;
            this.chkSafeRelogin.Location = new System.Drawing.Point(4, 83);
            this.chkSafeRelogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkSafeRelogin.Name = "chkSafeRelogin";
            this.chkSafeRelogin.Size = new System.Drawing.Size(91, 19);
            this.chkSafeRelogin.TabIndex = 3;
            this.chkSafeRelogin.Text = "Safe Relogin";
            this.chkSafeRelogin.UseVisualStyleBackColor = true;
            // 
            // tlpAutoRelogin
            // 
            this.tlpAutoRelogin.ColumnCount = 1;
            this.tlpAutoRelogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAutoRelogin.Controls.Add(this.cbServers, 0, 0);
            this.tlpAutoRelogin.Controls.Add(this.chkSafeRelogin, 0, 3);
            this.tlpAutoRelogin.Controls.Add(this.chkRelogin, 0, 1);
            this.tlpAutoRelogin.Controls.Add(this.chkReloginAny, 0, 2);
            this.tlpAutoRelogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAutoRelogin.Location = new System.Drawing.Point(0, 0);
            this.tlpAutoRelogin.Name = "tlpAutoRelogin";
            this.tlpAutoRelogin.RowCount = 4;
            this.tlpAutoRelogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpAutoRelogin.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAutoRelogin.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAutoRelogin.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAutoRelogin.Size = new System.Drawing.Size(419, 105);
            this.tlpAutoRelogin.TabIndex = 4;
            // 
            // AutoReloginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.borderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(419, 105);
            this.Controls.Add(this.tlpAutoRelogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "AutoReloginForm";
            this.Text = "Auto Relogin";
            this.tlpAutoRelogin.ResumeLayout(false);
            this.tlpAutoRelogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbServers;
        private System.Windows.Forms.CheckBox chkRelogin;
        private System.Windows.Forms.CheckBox chkReloginAny;
        private System.Windows.Forms.CheckBox chkSafeRelogin;
        private System.Windows.Forms.TableLayoutPanel tlpAutoRelogin;
    }
}