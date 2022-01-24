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
            this.tlpStats = new System.Windows.Forms.TableLayoutPanel();
            this.tlpStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStats.Location = new System.Drawing.Point(5, 5);
            this.lblStats.Margin = new System.Windows.Forms.Padding(5);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(121, 120);
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
            this.lnkReset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkReset.AutoSize = true;
            this.lnkReset.Location = new System.Drawing.Point(219, 5);
            this.lnkReset.Margin = new System.Windows.Forms.Padding(5);
            this.lnkReset.Name = "lnkReset";
            this.lnkReset.Size = new System.Drawing.Size(35, 120);
            this.lnkReset.TabIndex = 1;
            this.lnkReset.TabStop = true;
            this.lnkReset.Text = "Reset";
            this.lnkReset.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lnkReset.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReset_LinkClicked);
            // 
            // tlpStats
            // 
            this.tlpStats.ColumnCount = 2;
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpStats.Controls.Add(this.lblStats, 0, 0);
            this.tlpStats.Controls.Add(this.lnkReset, 1, 0);
            this.tlpStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStats.Location = new System.Drawing.Point(0, 0);
            this.tlpStats.Name = "tlpStats";
            this.tlpStats.RowCount = 1;
            this.tlpStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStats.Size = new System.Drawing.Size(259, 130);
            this.tlpStats.TabIndex = 2;
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 130);
            this.Controls.Add(this.tlpStats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "StatsForm";
            this.ShowIcon = false;
            this.Text = "Stats";
            this.tlpStats.ResumeLayout(false);
            this.tlpStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Timer statsTimer;
        private System.Windows.Forms.LinkLabel lnkReset;
        private System.Windows.Forms.TableLayoutPanel tlpStats;
    }
}