namespace RBot
{
    partial class CosmeticForm
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
            this.cbPlayer = new System.Windows.Forms.ComboBox();
            this.btnGrabCosm = new System.Windows.Forms.Button();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.lnkRefresh = new System.Windows.Forms.LinkLabel();
            this.btnCopyAll = new System.Windows.Forms.Button();
            this.btnEquipSelected = new System.Windows.Forms.Button();
            this.lnkGrabTarget = new System.Windows.Forms.LinkLabel();
            this.tlpCosmetics = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCosmetics.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPlayer
            // 
            this.cbPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPlayer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPlayer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tlpCosmetics.SetColumnSpan(this.cbPlayer, 3);
            this.cbPlayer.FormattingEnabled = true;
            this.cbPlayer.Location = new System.Drawing.Point(4, 3);
            this.cbPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbPlayer.Name = "cbPlayer";
            this.cbPlayer.Size = new System.Drawing.Size(274, 23);
            this.cbPlayer.TabIndex = 0;
            // 
            // btnGrabCosm
            // 
            this.btnGrabCosm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrabCosm.Location = new System.Drawing.Point(286, 3);
            this.btnGrabCosm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGrabCosm.Name = "btnGrabCosm";
            this.btnGrabCosm.Size = new System.Drawing.Size(89, 23);
            this.btnGrabCosm.TabIndex = 1;
            this.btnGrabCosm.Text = "Grab";
            this.btnGrabCosm.UseVisualStyleBackColor = true;
            this.btnGrabCosm.Click += new System.EventHandler(this.btnGrabCosm_Click);
            // 
            // lbItems
            // 
            this.lbItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCosmetics.SetColumnSpan(this.lbItems, 4);
            this.lbItems.FormattingEnabled = true;
            this.lbItems.ItemHeight = 15;
            this.lbItems.Location = new System.Drawing.Point(4, 56);
            this.lbItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(371, 244);
            this.lbItems.TabIndex = 2;
            // 
            // lnkRefresh
            // 
            this.lnkRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkRefresh.AutoSize = true;
            this.tlpCosmetics.SetColumnSpan(this.lnkRefresh, 2);
            this.lnkRefresh.Location = new System.Drawing.Point(0, 34);
            this.lnkRefresh.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.lnkRefresh.Name = "lnkRefresh";
            this.lnkRefresh.Size = new System.Drawing.Size(184, 15);
            this.lnkRefresh.TabIndex = 3;
            this.lnkRefresh.TabStop = true;
            this.lnkRefresh.Text = "Refresh Players";
            this.lnkRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRefresh_LinkClicked);
            // 
            // btnCopyAll
            // 
            this.btnCopyAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tlpCosmetics.SetColumnSpan(this.btnCopyAll, 2);
            this.btnCopyAll.Location = new System.Drawing.Point(4, 308);
            this.btnCopyAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCopyAll.Name = "btnCopyAll";
            this.btnCopyAll.Size = new System.Drawing.Size(180, 23);
            this.btnCopyAll.TabIndex = 4;
            this.btnCopyAll.Text = "Equip All";
            this.btnCopyAll.UseVisualStyleBackColor = true;
            this.btnCopyAll.Click += new System.EventHandler(this.btnCopyAll_Click);
            // 
            // btnEquipSelected
            // 
            this.btnEquipSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCosmetics.SetColumnSpan(this.btnEquipSelected, 2);
            this.btnEquipSelected.Location = new System.Drawing.Point(192, 308);
            this.btnEquipSelected.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEquipSelected.Name = "btnEquipSelected";
            this.btnEquipSelected.Size = new System.Drawing.Size(183, 23);
            this.btnEquipSelected.TabIndex = 5;
            this.btnEquipSelected.Text = "Equip Selected";
            this.btnEquipSelected.UseVisualStyleBackColor = true;
            this.btnEquipSelected.Click += new System.EventHandler(this.btnEquipSelected_Click);
            // 
            // lnkGrabTarget
            // 
            this.lnkGrabTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkGrabTarget.AutoSize = true;
            this.tlpCosmetics.SetColumnSpan(this.lnkGrabTarget, 2);
            this.lnkGrabTarget.Location = new System.Drawing.Point(192, 30);
            this.lnkGrabTarget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkGrabTarget.Name = "lnkGrabTarget";
            this.lnkGrabTarget.Size = new System.Drawing.Size(183, 23);
            this.lnkGrabTarget.TabIndex = 6;
            this.lnkGrabTarget.TabStop = true;
            this.lnkGrabTarget.Text = "Grab Target";
            this.lnkGrabTarget.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkGrabTarget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGrabTarget_LinkClicked);
            // 
            // tlpCosmetics
            // 
            this.tlpCosmetics.ColumnCount = 4;
            this.tlpCosmetics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCosmetics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCosmetics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCosmetics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCosmetics.Controls.Add(this.cbPlayer, 0, 0);
            this.tlpCosmetics.Controls.Add(this.btnEquipSelected, 2, 3);
            this.tlpCosmetics.Controls.Add(this.btnGrabCosm, 3, 0);
            this.tlpCosmetics.Controls.Add(this.btnCopyAll, 0, 3);
            this.tlpCosmetics.Controls.Add(this.lnkRefresh, 0, 1);
            this.tlpCosmetics.Controls.Add(this.lbItems, 0, 2);
            this.tlpCosmetics.Controls.Add(this.lnkGrabTarget, 2, 1);
            this.tlpCosmetics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCosmetics.Location = new System.Drawing.Point(0, 0);
            this.tlpCosmetics.Name = "tlpCosmetics";
            this.tlpCosmetics.RowCount = 4;
            this.tlpCosmetics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpCosmetics.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCosmetics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCosmetics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpCosmetics.Size = new System.Drawing.Size(379, 334);
            this.tlpCosmetics.TabIndex = 7;
            // 
            // CosmeticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.borderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(379, 334);
            this.Controls.Add(this.tlpCosmetics);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(265, 238);
            this.Name = "CosmeticForm";
            this.Text = "SWF Cosmetics";
            this.tlpCosmetics.ResumeLayout(false);
            this.tlpCosmetics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPlayer;
        private System.Windows.Forms.Button btnGrabCosm;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.LinkLabel lnkRefresh;
        private System.Windows.Forms.Button btnCopyAll;
        private System.Windows.Forms.Button btnEquipSelected;
        private System.Windows.Forms.LinkLabel lnkGrabTarget;
        private System.Windows.Forms.TableLayoutPanel tlpCosmetics;
    }
}