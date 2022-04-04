namespace RBot
{
    partial class ScriptReposForm
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
            this.btnUpdateAll = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataScripts = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cxtScripts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpScriptRepo = new System.Windows.Forms.TableLayoutPanel();
            this.btnDownloadAll = new System.Windows.Forms.Button();
            this.statStrip = new System.Windows.Forms.StatusStrip();
            this.statDownloaded = new System.Windows.Forms.ToolStripStatusLabel();
            this.statOutdated = new System.Windows.Forms.ToolStripStatusLabel();
            this.statStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataScripts)).BeginInit();
            this.cxtScripts.SuspendLayout();
            this.tlpScriptRepo.SuspendLayout();
            this.statStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateAll
            // 
            this.btnUpdateAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateAll.Location = new System.Drawing.Point(4, 3);
            this.btnUpdateAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateAll.Name = "btnUpdateAll";
            this.btnUpdateAll.Size = new System.Drawing.Size(112, 24);
            this.btnUpdateAll.TabIndex = 0;
            this.btnUpdateAll.Text = "Update All";
            this.btnUpdateAll.UseVisualStyleBackColor = true;
            this.btnUpdateAll.Click += new System.EventHandler(this.btnUpdateAll_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(598, 3);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 24);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataScripts
            // 
            this.dataScripts.AllowUserToAddRows = false;
            this.dataScripts.AllowUserToDeleteRows = false;
            this.dataScripts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataScripts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataScripts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colAuthor,
            this.colPath,
            this.colSize});
            this.tlpScriptRepo.SetColumnSpan(this.dataScripts, 5);
            this.dataScripts.ContextMenuStrip = this.cxtScripts;
            this.dataScripts.Location = new System.Drawing.Point(4, 33);
            this.dataScripts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataScripts.Name = "dataScripts";
            this.dataScripts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataScripts.RowHeadersVisible = false;
            this.dataScripts.Size = new System.Drawing.Size(706, 500);
            this.dataScripts.TabIndex = 3;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colAuthor
            // 
            this.colAuthor.HeaderText = "Author";
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.ReadOnly = true;
            this.colAuthor.Visible = false;
            // 
            // colPath
            // 
            this.colPath.FillWeight = 80F;
            this.colPath.HeaderText = "Folder Path";
            this.colPath.Name = "colPath";
            // 
            // colSize
            // 
            this.colSize.FillWeight = 20F;
            this.colSize.HeaderText = "Size";
            this.colSize.Name = "colSize";
            this.colSize.ReadOnly = true;
            // 
            // cxtScripts
            // 
            this.cxtScripts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDownload,
            this.btnLoad,
            this.btnDelete});
            this.cxtScripts.Name = "cxtScripts";
            this.cxtScripts.Size = new System.Drawing.Size(129, 70);
            this.cxtScripts.Text = "Scripts";
            // 
            // btnDownload
            // 
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(128, 22);
            this.btnDownload.Text = "Download";
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(128, 22);
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 22);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tlpScriptRepo
            // 
            this.tlpScriptRepo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpScriptRepo.ColumnCount = 5;
            this.tlpScriptRepo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpScriptRepo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpScriptRepo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpScriptRepo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpScriptRepo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpScriptRepo.Controls.Add(this.btnUpdateAll, 0, 0);
            this.tlpScriptRepo.Controls.Add(this.btnRefresh, 4, 0);
            this.tlpScriptRepo.Controls.Add(this.dataScripts, 0, 1);
            this.tlpScriptRepo.Controls.Add(this.btnDownloadAll, 1, 0);
            this.tlpScriptRepo.Controls.Add(this.statStrip, 0, 2);
            this.tlpScriptRepo.Controls.Add(this.label1, 2, 0);
            this.tlpScriptRepo.Controls.Add(this.txtFilter, 3, 0);
            this.tlpScriptRepo.Location = new System.Drawing.Point(0, 0);
            this.tlpScriptRepo.Name = "tlpScriptRepo";
            this.tlpScriptRepo.RowCount = 3;
            this.tlpScriptRepo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpScriptRepo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpScriptRepo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpScriptRepo.Size = new System.Drawing.Size(714, 561);
            this.tlpScriptRepo.TabIndex = 4;
            // 
            // btnDownloadAll
            // 
            this.btnDownloadAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownloadAll.Location = new System.Drawing.Point(124, 3);
            this.btnDownloadAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDownloadAll.Name = "btnDownloadAll";
            this.btnDownloadAll.Size = new System.Drawing.Size(112, 24);
            this.btnDownloadAll.TabIndex = 4;
            this.btnDownloadAll.Text = "Download All";
            this.btnDownloadAll.UseVisualStyleBackColor = true;
            this.btnDownloadAll.Click += new System.EventHandler(this.btnDownloadAll_Click);
            // 
            // statStrip
            // 
            this.statStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpScriptRepo.SetColumnSpan(this.statStrip, 5);
            this.statStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statDownloaded,
            this.statOutdated,
            this.statStatus});
            this.statStrip.Location = new System.Drawing.Point(0, 536);
            this.statStrip.Name = "statStrip";
            this.statStrip.Size = new System.Drawing.Size(714, 25);
            this.statStrip.TabIndex = 5;
            this.statStrip.Text = "Status";
            // 
            // statDownloaded
            // 
            this.statDownloaded.Name = "statDownloaded";
            this.statDownloaded.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.statDownloaded.Size = new System.Drawing.Size(85, 20);
            this.statDownloaded.Text = "Downloaded:";
            // 
            // statOutdated
            // 
            this.statOutdated.Name = "statOutdated";
            this.statOutdated.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.statOutdated.Size = new System.Drawing.Size(66, 20);
            this.statOutdated.Text = "Outdated:";
            // 
            // statStatus
            // 
            this.statStatus.Name = "statStatus";
            this.statStatus.Size = new System.Drawing.Size(548, 20);
            this.statStatus.Spring = true;
            this.statStatus.Text = "Idle";
            this.statStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(243, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Location = new System.Drawing.Point(313, 3);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(278, 23);
            this.txtFilter.TabIndex = 7;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // ScriptReposForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 561);
            this.Controls.Add(this.tlpScriptRepo);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(380, 230);
            this.Name = "ScriptReposForm";
            this.Text = "Scripts";
            this.Load += new System.EventHandler(this.ScriptReposForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataScripts)).EndInit();
            this.cxtScripts.ResumeLayout(false);
            this.tlpScriptRepo.ResumeLayout(false);
            this.tlpScriptRepo.PerformLayout();
            this.statStrip.ResumeLayout(false);
            this.statStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateAll;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataScripts;
        private System.Windows.Forms.ContextMenuStrip cxtScripts;
        private System.Windows.Forms.ToolStripMenuItem btnDownload;
        private System.Windows.Forms.ToolStripMenuItem btnLoad;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;
        private System.Windows.Forms.TableLayoutPanel tlpScriptRepo;
        private System.Windows.Forms.Button btnDownloadAll;
        private System.Windows.Forms.StatusStrip statStrip;
        private System.Windows.Forms.ToolStripStatusLabel statDownloaded;
        private System.Windows.Forms.ToolStripStatusLabel statOutdated;
        private System.Windows.Forms.ToolStripStatusLabel statStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
    }
}