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
            this.lblStatus = new System.Windows.Forms.Label();
            this.dataScripts = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cxtScripts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpScriptRepo = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataScripts)).BeginInit();
            this.cxtScripts.SuspendLayout();
            this.tlpScriptRepo.SuspendLayout();
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
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(124, 0);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(466, 30);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Idle";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.colSize});
            this.tlpScriptRepo.SetColumnSpan(this.dataScripts, 3);
            this.dataScripts.ContextMenuStrip = this.cxtScripts;
            this.dataScripts.Location = new System.Drawing.Point(4, 33);
            this.dataScripts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataScripts.Name = "dataScripts";
            this.dataScripts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataScripts.RowHeadersVisible = false;
            this.dataScripts.Size = new System.Drawing.Size(706, 525);
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
            // 
            // colSize
            // 
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
            // 
            // btnLoad
            // 
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(128, 22);
            this.btnLoad.Text = "Load";
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 22);
            this.btnDelete.Text = "Delete";
            // 
            // tlpScriptRepo
            // 
            this.tlpScriptRepo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpScriptRepo.ColumnCount = 3;
            this.tlpScriptRepo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpScriptRepo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpScriptRepo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpScriptRepo.Controls.Add(this.btnUpdateAll, 0, 0);
            this.tlpScriptRepo.Controls.Add(this.btnRefresh, 2, 0);
            this.tlpScriptRepo.Controls.Add(this.dataScripts, 0, 1);
            this.tlpScriptRepo.Controls.Add(this.lblStatus, 1, 0);
            this.tlpScriptRepo.Location = new System.Drawing.Point(0, 0);
            this.tlpScriptRepo.Name = "tlpScriptRepo";
            this.tlpScriptRepo.RowCount = 2;
            this.tlpScriptRepo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpScriptRepo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpScriptRepo.Size = new System.Drawing.Size(714, 561);
            this.tlpScriptRepo.TabIndex = 4;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateAll;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView dataScripts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
        private System.Windows.Forms.ContextMenuStrip cxtScripts;
        private System.Windows.Forms.ToolStripMenuItem btnDownload;
        private System.Windows.Forms.ToolStripMenuItem btnLoad;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;
        private System.Windows.Forms.TableLayoutPanel tlpScriptRepo;
    }
}