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
			this.SuspendLayout();
			// 
			// cbPlayer
			// 
			this.cbPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbPlayer.FormattingEnabled = true;
			this.cbPlayer.Location = new System.Drawing.Point(12, 14);
			this.cbPlayer.Name = "cbPlayer";
			this.cbPlayer.Size = new System.Drawing.Size(294, 21);
			this.cbPlayer.TabIndex = 0;
			// 
			// btnGrabCosm
			// 
			this.btnGrabCosm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGrabCosm.Location = new System.Drawing.Point(312, 12);
			this.btnGrabCosm.Name = "btnGrabCosm";
			this.btnGrabCosm.Size = new System.Drawing.Size(94, 23);
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
			this.lbItems.FormattingEnabled = true;
			this.lbItems.Location = new System.Drawing.Point(12, 54);
			this.lbItems.Name = "lbItems";
			this.lbItems.Size = new System.Drawing.Size(394, 173);
			this.lbItems.TabIndex = 2;
			// 
			// lnkRefresh
			// 
			this.lnkRefresh.AutoSize = true;
			this.lnkRefresh.Location = new System.Drawing.Point(9, 38);
			this.lnkRefresh.Name = "lnkRefresh";
			this.lnkRefresh.Size = new System.Drawing.Size(81, 13);
			this.lnkRefresh.TabIndex = 3;
			this.lnkRefresh.TabStop = true;
			this.lnkRefresh.Text = "Refresh Players";
			this.lnkRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRefresh_LinkClicked);
			// 
			// btnCopyAll
			// 
			this.btnCopyAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCopyAll.Location = new System.Drawing.Point(12, 234);
			this.btnCopyAll.Name = "btnCopyAll";
			this.btnCopyAll.Size = new System.Drawing.Size(208, 23);
			this.btnCopyAll.TabIndex = 4;
			this.btnCopyAll.Text = "Equip All";
			this.btnCopyAll.UseVisualStyleBackColor = true;
			this.btnCopyAll.Click += new System.EventHandler(this.btnCopyAll_Click);
			// 
			// btnEquipSelected
			// 
			this.btnEquipSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEquipSelected.Location = new System.Drawing.Point(226, 234);
			this.btnEquipSelected.Name = "btnEquipSelected";
			this.btnEquipSelected.Size = new System.Drawing.Size(180, 23);
			this.btnEquipSelected.TabIndex = 5;
			this.btnEquipSelected.Text = "Equip Selected";
			this.btnEquipSelected.UseVisualStyleBackColor = true;
			this.btnEquipSelected.Click += new System.EventHandler(this.btnEquipSelected_Click);
			// 
			// lnkGrabTarget
			// 
			this.lnkGrabTarget.AutoSize = true;
			this.lnkGrabTarget.Location = new System.Drawing.Point(342, 38);
			this.lnkGrabTarget.Name = "lnkGrabTarget";
			this.lnkGrabTarget.Size = new System.Drawing.Size(64, 13);
			this.lnkGrabTarget.TabIndex = 6;
			this.lnkGrabTarget.TabStop = true;
			this.lnkGrabTarget.Text = "Grab Target";
			this.lnkGrabTarget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGrabTarget_LinkClicked);
			// 
			// CosmeticForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(418, 269);
			this.Controls.Add(this.lnkGrabTarget);
			this.Controls.Add(this.btnEquipSelected);
			this.Controls.Add(this.btnCopyAll);
			this.Controls.Add(this.lnkRefresh);
			this.Controls.Add(this.lbItems);
			this.Controls.Add(this.btnGrabCosm);
			this.Controls.Add(this.cbPlayer);
			this.Name = "CosmeticForm";
			this.Text = "SWF Cosmetics";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPlayer;
        private System.Windows.Forms.Button btnGrabCosm;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.LinkLabel lnkRefresh;
        private System.Windows.Forms.Button btnCopyAll;
        private System.Windows.Forms.Button btnEquipSelected;
        private System.Windows.Forms.LinkLabel lnkGrabTarget;
    }
}