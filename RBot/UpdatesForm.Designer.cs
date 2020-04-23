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
            this.cbReleases = new System.Windows.Forms.ComboBox();
            this.lnkRefresh = new System.Windows.Forms.LinkLabel();
            this.lblUpdateInfo = new System.Windows.Forms.Label();
            this.lnkDownloadSelected = new System.Windows.Forms.LinkLabel();
            this.lnkDownload = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblAllReleases
            // 
            this.lblAllReleases.AutoSize = true;
            this.lblAllReleases.Location = new System.Drawing.Point(12, 91);
            this.lblAllReleases.Name = "lblAllReleases";
            this.lblAllReleases.Size = new System.Drawing.Size(68, 13);
            this.lblAllReleases.TabIndex = 1;
            this.lblAllReleases.Text = "All Releases:";
            // 
            // lblLatestVersion
            // 
            this.lblLatestVersion.AutoSize = true;
            this.lblLatestVersion.Location = new System.Drawing.Point(12, 9);
            this.lblLatestVersion.Name = "lblLatestVersion";
            this.lblLatestVersion.Size = new System.Drawing.Size(127, 39);
            this.lblLatestVersion.TabIndex = 2;
            this.lblLatestVersion.Text = "Latest Version: Loading...\r\nRelease: Name\r\nTime: Time";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 48);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(104, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Loading Status...";
            // 
            // cbReleases
            // 
            this.cbReleases.FormattingEnabled = true;
            this.cbReleases.Location = new System.Drawing.Point(12, 107);
            this.cbReleases.Name = "cbReleases";
            this.cbReleases.Size = new System.Drawing.Size(271, 21);
            this.cbReleases.TabIndex = 4;
            this.cbReleases.SelectedIndexChanged += new System.EventHandler(this.cbReleases_SelectedIndexChanged);
            // 
            // lnkRefresh
            // 
            this.lnkRefresh.AutoSize = true;
            this.lnkRefresh.Location = new System.Drawing.Point(12, 69);
            this.lnkRefresh.Name = "lnkRefresh";
            this.lnkRefresh.Size = new System.Drawing.Size(44, 13);
            this.lnkRefresh.TabIndex = 5;
            this.lnkRefresh.TabStop = true;
            this.lnkRefresh.Text = "Refresh";
            this.lnkRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRefresh_LinkClicked);
            // 
            // lblUpdateInfo
            // 
            this.lblUpdateInfo.AutoSize = true;
            this.lblUpdateInfo.Location = new System.Drawing.Point(12, 131);
            this.lblUpdateInfo.Name = "lblUpdateInfo";
            this.lblUpdateInfo.Size = new System.Drawing.Size(103, 13);
            this.lblUpdateInfo.TabIndex = 6;
            this.lblUpdateInfo.Text = "No update selected.";
            // 
            // lnkDownloadSelected
            // 
            this.lnkDownloadSelected.AutoSize = true;
            this.lnkDownloadSelected.Location = new System.Drawing.Point(228, 131);
            this.lnkDownloadSelected.Name = "lnkDownloadSelected";
            this.lnkDownloadSelected.Size = new System.Drawing.Size(55, 13);
            this.lnkDownloadSelected.TabIndex = 7;
            this.lnkDownloadSelected.TabStop = true;
            this.lnkDownloadSelected.Text = "Download";
            this.lnkDownloadSelected.Visible = false;
            this.lnkDownloadSelected.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDownloadSelected_LinkClicked);
            // 
            // lnkDownload
            // 
            this.lnkDownload.AutoSize = true;
            this.lnkDownload.Location = new System.Drawing.Point(228, 48);
            this.lnkDownload.Name = "lnkDownload";
            this.lnkDownload.Size = new System.Drawing.Size(55, 13);
            this.lnkDownload.TabIndex = 8;
            this.lnkDownload.TabStop = true;
            this.lnkDownload.Text = "Download";
            this.lnkDownload.Visible = false;
            this.lnkDownload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDownload_LinkClicked);
            // 
            // UpdatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 155);
            this.Controls.Add(this.lnkDownload);
            this.Controls.Add(this.lnkDownloadSelected);
            this.Controls.Add(this.lblUpdateInfo);
            this.Controls.Add(this.lnkRefresh);
            this.Controls.Add(this.cbReleases);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblLatestVersion);
            this.Controls.Add(this.lblAllReleases);
            this.Name = "UpdatesForm";
            this.Text = "Updates";
            this.Load += new System.EventHandler(this.UpdatesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAllReleases;
        private System.Windows.Forms.Label lblLatestVersion;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbReleases;
        private System.Windows.Forms.LinkLabel lnkRefresh;
        private System.Windows.Forms.Label lblUpdateInfo;
        private System.Windows.Forms.LinkLabel lnkDownloadSelected;
        private System.Windows.Forms.LinkLabel lnkDownload;
    }
}