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
            this.SuspendLayout();
            // 
            // lbQuests
            // 
            this.lbQuests.FormattingEnabled = true;
            this.lbQuests.Location = new System.Drawing.Point(12, 40);
            this.lbQuests.Name = "lbQuests";
            this.lbQuests.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbQuests.Size = new System.Drawing.Size(462, 238);
            this.lbQuests.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(32, 13);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Filter:";
            // 
            // txtFilter
            // 
            this.txtFilter.Enabled = false;
            this.txtFilter.Location = new System.Drawing.Point(50, 12);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(376, 20);
            this.txtFilter.TabIndex = 2;
            this.txtFilter.Text = "Loading...";
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // btnCopyID
            // 
            this.btnCopyID.Location = new System.Drawing.Point(12, 284);
            this.btnCopyID.Name = "btnCopyID";
            this.btnCopyID.Size = new System.Drawing.Size(164, 23);
            this.btnCopyID.TabIndex = 3;
            this.btnCopyID.Text = "Copy IDs (Ctrl+C)";
            this.btnCopyID.UseVisualStyleBackColor = true;
            this.btnCopyID.Click += new System.EventHandler(this.btnCopyID_Click);
            // 
            // btnCopyName
            // 
            this.btnCopyName.Location = new System.Drawing.Point(330, 284);
            this.btnCopyName.Name = "btnCopyName";
            this.btnCopyName.Size = new System.Drawing.Size(144, 23);
            this.btnCopyName.TabIndex = 4;
            this.btnCopyName.Text = "Copy Names (Ctrl+Shift+C)";
            this.btnCopyName.UseVisualStyleBackColor = true;
            this.btnCopyName.Click += new System.EventHandler(this.btnCopyName_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(182, 284);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(142, 23);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load (Ctrl+L)";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lnkUpdate
            // 
            this.lnkUpdate.AutoSize = true;
            this.lnkUpdate.Location = new System.Drawing.Point(432, 15);
            this.lnkUpdate.Name = "lnkUpdate";
            this.lnkUpdate.Size = new System.Drawing.Size(42, 13);
            this.lnkUpdate.TabIndex = 6;
            this.lnkUpdate.TabStop = true;
            this.lnkUpdate.Text = "Update";
            this.lnkUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUpdate_LinkClicked);
            // 
            // GameIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 316);
            this.Controls.Add(this.lnkUpdate);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnCopyName);
            this.Controls.Add(this.btnCopyID);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lbQuests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GameIDForm";
            this.Text = "IDs";
            this.Load += new System.EventHandler(this.GameIDForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbQuests;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnCopyID;
        private System.Windows.Forms.Button btnCopyName;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.LinkLabel lnkUpdate;
    }
}