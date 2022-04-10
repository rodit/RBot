namespace RBot
{
    partial class UpdatesForm
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
            this.lblAllReleases = new System.Windows.Forms.Label();
            this.lblLatestVersion = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lnkRefresh = new System.Windows.Forms.LinkLabel();
            this.lnkDownload = new System.Windows.Forms.LinkLabel();
            this.tlpUpdates = new System.Windows.Forms.TableLayoutPanel();
            this.cbReleases = new System.Windows.Forms.ComboBox();
            this.lblUpdateInfo = new System.Windows.Forms.Label();
            this.lnkDownloadSelected = new System.Windows.Forms.LinkLabel();
            this.tlpUpdates.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAllReleases
            // 
            this.lblAllReleases.AutoSize = true;
            this.lblAllReleases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAllReleases.Location = new System.Drawing.Point(4, 101);
            this.lblAllReleases.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllReleases.Name = "lblAllReleases";
            this.lblAllReleases.Padding = new System.Windows.Forms.Padding(3);
            this.lblAllReleases.Size = new System.Drawing.Size(267, 21);
            this.lblAllReleases.TabIndex = 1;
            this.lblAllReleases.Text = "All Releases:";
            // 
            // lblLatestVersion
            // 
            this.lblLatestVersion.AutoSize = true;
            this.lblLatestVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLatestVersion.Location = new System.Drawing.Point(4, 0);
            this.lblLatestVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLatestVersion.Name = "lblLatestVersion";
            this.lblLatestVersion.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.lblLatestVersion.Size = new System.Drawing.Size(267, 57);
            this.lblLatestVersion.TabIndex = 2;
            this.lblLatestVersion.Text = "Latest Version: Loading...\r\nRelease: Name\r\nTime: Time";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(4, 57);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.lblStatus.Size = new System.Drawing.Size(267, 19);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Loading Status...";
            // 
            // lnkRefresh
            // 
            this.lnkRefresh.AutoSize = true;
            this.lnkRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnkRefresh.Location = new System.Drawing.Point(4, 76);
            this.lnkRefresh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkRefresh.Name = "lnkRefresh";
            this.lnkRefresh.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.lnkRefresh.Size = new System.Drawing.Size(267, 25);
            this.lnkRefresh.TabIndex = 5;
            this.lnkRefresh.TabStop = true;
            this.lnkRefresh.Text = "Refresh";
            this.lnkRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRefresh_LinkClicked);
            // 
            // lnkDownload
            // 
            this.lnkDownload.AutoSize = true;
            this.lnkDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnkDownload.Location = new System.Drawing.Point(279, 57);
            this.lnkDownload.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkDownload.Name = "lnkDownload";
            this.lnkDownload.Size = new System.Drawing.Size(61, 19);
            this.lnkDownload.TabIndex = 8;
            this.lnkDownload.TabStop = true;
            this.lnkDownload.Text = "Download";
            this.lnkDownload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkDownload.Visible = false;
            this.lnkDownload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDownload_LinkClicked);
            // 
            // tlpUpdates
            // 
            this.tlpUpdates.ColumnCount = 2;
            this.tlpUpdates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUpdates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpUpdates.Controls.Add(this.cbReleases, 1, 3);
            this.tlpUpdates.Controls.Add(this.lblUpdateInfo, 0, 4);
            this.tlpUpdates.Controls.Add(this.lnkDownloadSelected, 1, 4);
            this.tlpUpdates.Controls.Add(this.lnkDownload, 1, 1);
            this.tlpUpdates.Controls.Add(this.lblLatestVersion, 0, 0);
            this.tlpUpdates.Controls.Add(this.lblStatus, 0, 1);
            this.tlpUpdates.Controls.Add(this.lnkRefresh, 0, 2);
            this.tlpUpdates.Controls.Add(this.lblAllReleases, 0, 3);
            this.tlpUpdates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUpdates.Location = new System.Drawing.Point(0, 0);
            this.tlpUpdates.Name = "tlpUpdates";
            this.tlpUpdates.RowCount = 6;
            this.tlpUpdates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUpdates.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUpdates.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUpdates.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUpdates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpUpdates.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUpdates.Size = new System.Drawing.Size(344, 173);
            this.tlpUpdates.TabIndex = 9;
            // 
            // cbReleases
            // 
            this.tlpUpdates.SetColumnSpan(this.cbReleases, 2);
            this.cbReleases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbReleases.FormattingEnabled = true;
            this.cbReleases.Location = new System.Drawing.Point(4, 125);
            this.cbReleases.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbReleases.Name = "cbReleases";
            this.cbReleases.Size = new System.Drawing.Size(336, 23);
            this.cbReleases.TabIndex = 4;
            this.cbReleases.SelectedIndexChanged += new System.EventHandler(this.cbReleases_SelectedIndexChanged);
            // 
            // lblUpdateInfo
            // 
            this.lblUpdateInfo.AutoSize = true;
            this.lblUpdateInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUpdateInfo.Location = new System.Drawing.Point(4, 152);
            this.lblUpdateInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateInfo.Name = "lblUpdateInfo";
            this.lblUpdateInfo.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.lblUpdateInfo.Size = new System.Drawing.Size(267, 21);
            this.lblUpdateInfo.TabIndex = 6;
            this.lblUpdateInfo.Text = "No update selected.";
            // 
            // lnkDownloadSelected
            // 
            this.lnkDownloadSelected.AutoSize = true;
            this.lnkDownloadSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnkDownloadSelected.Location = new System.Drawing.Point(279, 152);
            this.lnkDownloadSelected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkDownloadSelected.Name = "lnkDownloadSelected";
            this.lnkDownloadSelected.Size = new System.Drawing.Size(61, 21);
            this.lnkDownloadSelected.TabIndex = 7;
            this.lnkDownloadSelected.TabStop = true;
            this.lnkDownloadSelected.Text = "Download";
            this.lnkDownloadSelected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkDownloadSelected.Visible = false;
            this.lnkDownloadSelected.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDownloadSelected_LinkClicked);
            // 
            // UpdatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.borderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(344, 173);
            this.Controls.Add(this.tlpUpdates);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "UpdatesForm";
            this.Text = "Updates";
            this.Load += new System.EventHandler(this.UpdatesForm_Load);
            this.tlpUpdates.ResumeLayout(false);
            this.tlpUpdates.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblAllReleases;
        private System.Windows.Forms.Label lblLatestVersion;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.LinkLabel lnkRefresh;
        private System.Windows.Forms.LinkLabel lnkDownload;
        private System.Windows.Forms.TableLayoutPanel tlpUpdates;
        private System.Windows.Forms.LinkLabel lnkDownloadSelected;
        private System.Windows.Forms.Label lblUpdateInfo;
        private System.Windows.Forms.ComboBox cbReleases;
    }
}