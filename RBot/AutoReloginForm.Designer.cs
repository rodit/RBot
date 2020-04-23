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
            this.SuspendLayout();
            // 
            // cbServers
            // 
            this.cbServers.FormattingEnabled = true;
            this.cbServers.Location = new System.Drawing.Point(12, 12);
            this.cbServers.Name = "cbServers";
            this.cbServers.Size = new System.Drawing.Size(335, 21);
            this.cbServers.TabIndex = 0;
            // 
            // chkRelogin
            // 
            this.chkRelogin.AutoSize = true;
            this.chkRelogin.Location = new System.Drawing.Point(12, 39);
            this.chkRelogin.Name = "chkRelogin";
            this.chkRelogin.Size = new System.Drawing.Size(87, 17);
            this.chkRelogin.TabIndex = 1;
            this.chkRelogin.Text = "Auto Relogin";
            this.chkRelogin.UseVisualStyleBackColor = true;
            // 
            // chkReloginAny
            // 
            this.chkReloginAny.AutoSize = true;
            this.chkReloginAny.Location = new System.Drawing.Point(12, 62);
            this.chkReloginAny.Name = "chkReloginAny";
            this.chkReloginAny.Size = new System.Drawing.Size(133, 17);
            this.chkReloginAny.TabIndex = 2;
            this.chkReloginAny.Text = "Relogin To Any Server";
            this.chkReloginAny.UseVisualStyleBackColor = true;
            // 
            // chkSafeRelogin
            // 
            this.chkSafeRelogin.AutoSize = true;
            this.chkSafeRelogin.Location = new System.Drawing.Point(12, 85);
            this.chkSafeRelogin.Name = "chkSafeRelogin";
            this.chkSafeRelogin.Size = new System.Drawing.Size(87, 17);
            this.chkSafeRelogin.TabIndex = 3;
            this.chkSafeRelogin.Text = "Safe Relogin";
            this.chkSafeRelogin.UseVisualStyleBackColor = true;
            // 
            // AutoReloginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 112);
            this.Controls.Add(this.chkSafeRelogin);
            this.Controls.Add(this.chkReloginAny);
            this.Controls.Add(this.chkRelogin);
            this.Controls.Add(this.cbServers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AutoReloginForm";
            this.Text = "Auto Relogin";
            this.Load += new System.EventHandler(this.AutoReloginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbServers;
        private System.Windows.Forms.CheckBox chkRelogin;
        private System.Windows.Forms.CheckBox chkReloginAny;
        private System.Windows.Forms.CheckBox chkSafeRelogin;
    }
}