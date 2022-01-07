namespace RBot
{
    partial class StatsForm
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
			this.lblStats = new System.Windows.Forms.Label();
			this.statsTimer = new System.Windows.Forms.Timer(this.components);
			this.lnkReset = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// lblStats
			// 
			this.lblStats.AutoSize = true;
			this.lblStats.Location = new System.Drawing.Point(12, 9);
			this.lblStats.Name = "lblStats";
			this.lblStats.Size = new System.Drawing.Size(91, 78);
			this.lblStats.TabIndex = 0;
			this.lblStats.Text = "Kills: 0\r\nDeaths: 0\r\nQuests (A/C): 0/0\r\nPickups: 0\r\nRelogins: 0\r\nTime: 00:00:00";
			// 
			// statsTimer
			// 
			this.statsTimer.Enabled = true;
			this.statsTimer.Interval = 1000;
			this.statsTimer.Tick += new System.EventHandler(this.statsTimer_Tick);
			// 
			// lnkReset
			// 
			this.lnkReset.AutoSize = true;
			this.lnkReset.Location = new System.Drawing.Point(185, 9);
			this.lnkReset.Name = "lnkReset";
			this.lnkReset.Size = new System.Drawing.Size(35, 13);
			this.lnkReset.TabIndex = 1;
			this.lnkReset.TabStop = true;
			this.lnkReset.Text = "Reset";
			this.lnkReset.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReset_LinkClicked);
			// 
			// StatsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(232, 98);
			this.Controls.Add(this.lnkReset);
			this.Controls.Add(this.lblStats);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "StatsForm";
			this.ShowIcon = false;
			this.Text = "Stats";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Timer statsTimer;
        private System.Windows.Forms.LinkLabel lnkReset;
    }
}