namespace RBot
{
    partial class GameIDForm
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
            this.lbQuests = new System.Windows.Forms.ListBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnCopyID = new System.Windows.Forms.Button();
            this.btnCopyName = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lnkUpdate = new System.Windows.Forms.LinkLabel();
            this.tlpQuests = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTitle = new System.Windows.Forms.TableLayoutPanel();
            this.tlpIDsForm = new System.Windows.Forms.TableLayoutPanel();
            this.tlpQuests.SuspendLayout();
            this.tlpTitle.SuspendLayout();
            this.tlpIDsForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbQuests
            // 
            this.tlpQuests.SetColumnSpan(this.lbQuests, 3);
            this.lbQuests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbQuests.FormattingEnabled = true;
            this.lbQuests.ItemHeight = 15;
            this.lbQuests.Location = new System.Drawing.Point(4, 3);
            this.lbQuests.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbQuests.Name = "lbQuests";
            this.lbQuests.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbQuests.Size = new System.Drawing.Size(595, 290);
            this.lbQuests.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSearch.Location = new System.Drawing.Point(4, 0);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(48, 30);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Filter:";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFilter
            // 
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFilter.Enabled = false;
            this.txtFilter.Location = new System.Drawing.Point(60, 3);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(471, 23);
            this.txtFilter.TabIndex = 2;
            this.txtFilter.Text = "Loading...";
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // btnCopyID
            // 
            this.btnCopyID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopyID.Location = new System.Drawing.Point(4, 299);
            this.btnCopyID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCopyID.Name = "btnCopyID";
            this.btnCopyID.Size = new System.Drawing.Size(192, 24);
            this.btnCopyID.TabIndex = 3;
            this.btnCopyID.Text = "Copy IDs (Ctrl+C)";
            this.btnCopyID.UseVisualStyleBackColor = true;
            this.btnCopyID.Click += new System.EventHandler(this.btnCopyID_Click);
            // 
            // btnCopyName
            // 
            this.btnCopyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopyName.Location = new System.Drawing.Point(405, 299);
            this.btnCopyName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCopyName.Name = "btnCopyName";
            this.btnCopyName.Size = new System.Drawing.Size(194, 24);
            this.btnCopyName.TabIndex = 4;
            this.btnCopyName.Text = "Copy Names (Ctrl+Shift+C)";
            this.btnCopyName.UseVisualStyleBackColor = true;
            this.btnCopyName.Click += new System.EventHandler(this.btnCopyName_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoad.Location = new System.Drawing.Point(204, 299);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(193, 24);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load (Ctrl+L)";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lnkUpdate
            // 
            this.lnkUpdate.AutoSize = true;
            this.lnkUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnkUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnkUpdate.Location = new System.Drawing.Point(539, 0);
            this.lnkUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkUpdate.Name = "lnkUpdate";
            this.lnkUpdate.Size = new System.Drawing.Size(60, 30);
            this.lnkUpdate.TabIndex = 6;
            this.lnkUpdate.TabStop = true;
            this.lnkUpdate.Text = "Update";
            this.lnkUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUpdate_LinkClicked);
            // 
            // tlpQuests
            // 
            this.tlpQuests.ColumnCount = 3;
            this.tlpQuests.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpQuests.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpQuests.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpQuests.Controls.Add(this.btnCopyID, 0, 1);
            this.tlpQuests.Controls.Add(this.btnLoad, 1, 1);
            this.tlpQuests.Controls.Add(this.lbQuests, 0, 0);
            this.tlpQuests.Controls.Add(this.btnCopyName, 2, 1);
            this.tlpQuests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpQuests.Location = new System.Drawing.Point(0, 30);
            this.tlpQuests.Margin = new System.Windows.Forms.Padding(0);
            this.tlpQuests.Name = "tlpQuests";
            this.tlpQuests.RowCount = 2;
            this.tlpQuests.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpQuests.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpQuests.Size = new System.Drawing.Size(603, 326);
            this.tlpQuests.TabIndex = 7;
            // 
            // tlpTitle
            // 
            this.tlpTitle.ColumnCount = 3;
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTitle.Controls.Add(this.lblSearch, 0, 0);
            this.tlpTitle.Controls.Add(this.lnkUpdate, 2, 0);
            this.tlpTitle.Controls.Add(this.txtFilter, 1, 0);
            this.tlpTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTitle.Location = new System.Drawing.Point(0, 0);
            this.tlpTitle.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTitle.Name = "tlpTitle";
            this.tlpTitle.RowCount = 1;
            this.tlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTitle.Size = new System.Drawing.Size(603, 30);
            this.tlpTitle.TabIndex = 0;
            // 
            // tlpIDsForm
            // 
            this.tlpIDsForm.ColumnCount = 1;
            this.tlpIDsForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpIDsForm.Controls.Add(this.tlpTitle, 0, 0);
            this.tlpIDsForm.Controls.Add(this.tlpQuests, 0, 1);
            this.tlpIDsForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpIDsForm.Location = new System.Drawing.Point(0, 0);
            this.tlpIDsForm.Name = "tlpIDsForm";
            this.tlpIDsForm.RowCount = 2;
            this.tlpIDsForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpIDsForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpIDsForm.Size = new System.Drawing.Size(603, 356);
            this.tlpIDsForm.TabIndex = 7;
            // 
            // GameIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 356);
            this.Controls.Add(this.tlpIDsForm);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(327, 232);
            this.Name = "GameIDForm";
            this.Text = "IDs";
            this.Load += new System.EventHandler(this.GameIDForm_Load);
            this.tlpQuests.ResumeLayout(false);
            this.tlpTitle.ResumeLayout(false);
            this.tlpTitle.PerformLayout();
            this.tlpIDsForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbQuests;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnCopyID;
        private System.Windows.Forms.Button btnCopyName;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.LinkLabel lnkUpdate;
        private System.Windows.Forms.TableLayoutPanel tlpQuests;
        private System.Windows.Forms.TableLayoutPanel tlpTitle;
        private System.Windows.Forms.TableLayoutPanel tlpIDsForm;
    }
}