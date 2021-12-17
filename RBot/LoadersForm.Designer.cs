namespace RBot
{
    partial class LoadersForm
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
            this.txtIds = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cbLoadType = new System.Windows.Forms.ComboBox();
            this.lbGrab = new System.Windows.Forms.ListBox();
            this.propsGrabbed = new System.Windows.Forms.PropertyGrid();
            this.cbGrabType = new System.Windows.Forms.ComboBox();
            this.btnGrab = new System.Windows.Forms.Button();
            this.lnkIds = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtIds
            // 
            this.txtIds.Location = new System.Drawing.Point(12, 12);
            this.txtIds.Name = "txtIds";
            this.txtIds.Size = new System.Drawing.Size(384, 20);
            this.txtIds.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 38);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(409, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cbLoadType
            // 
            this.cbLoadType.FormattingEnabled = true;
            this.cbLoadType.Items.AddRange(new object[] {
            "Shop",
            "Quests"});
            this.cbLoadType.Location = new System.Drawing.Point(402, 11);
            this.cbLoadType.Name = "cbLoadType";
            this.cbLoadType.Size = new System.Drawing.Size(79, 21);
            this.cbLoadType.TabIndex = 2;
            this.cbLoadType.Text = "Shop";
            // 
            // lbGrab
            // 
            this.lbGrab.FormattingEnabled = true;
            this.lbGrab.Location = new System.Drawing.Point(12, 67);
            this.lbGrab.Name = "lbGrab";
            this.lbGrab.Size = new System.Drawing.Size(219, 225);
            this.lbGrab.TabIndex = 3;
            // 
            // propsGrabbed
            // 
            this.propsGrabbed.HelpVisible = false;
            this.propsGrabbed.Location = new System.Drawing.Point(237, 67);
            this.propsGrabbed.Name = "propsGrabbed";
            this.propsGrabbed.Size = new System.Drawing.Size(244, 225);
            this.propsGrabbed.TabIndex = 4;
            this.propsGrabbed.ToolbarVisible = false;
            // 
            // cbGrabType
            // 
            this.cbGrabType.FormattingEnabled = true;
            this.cbGrabType.Items.AddRange(new object[] {
            "Shop Items",
            "Shop IDs",
            "Quests",
            "Inventory Items",
            "House Inventory Items",
            "Temp Inventory Items",
            "Bank Items",
            "Cell Monsters",
            "Map Monsters"});
            this.cbGrabType.Location = new System.Drawing.Point(12, 298);
            this.cbGrabType.Name = "cbGrabType";
            this.cbGrabType.Size = new System.Drawing.Size(219, 21);
            this.cbGrabType.TabIndex = 5;
            this.cbGrabType.Text = "Shop Items";
            // 
            // btnGrab
            // 
            this.btnGrab.Location = new System.Drawing.Point(237, 297);
            this.btnGrab.Name = "btnGrab";
            this.btnGrab.Size = new System.Drawing.Size(244, 23);
            this.btnGrab.TabIndex = 6;
            this.btnGrab.Text = "Grab";
            this.btnGrab.UseVisualStyleBackColor = true;
            this.btnGrab.Click += new System.EventHandler(this.btnGrab_Click);
            // 
            // lnkIds
            // 
            this.lnkIds.AutoSize = true;
            this.lnkIds.BackColor = System.Drawing.Color.Transparent;
            this.lnkIds.Location = new System.Drawing.Point(427, 43);
            this.lnkIds.Name = "lnkIds";
            this.lnkIds.Size = new System.Drawing.Size(54, 13);
            this.lnkIds.TabIndex = 7;
            this.lnkIds.TabStop = true;
            this.lnkIds.Text = "Quest IDs";
            this.lnkIds.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkIds_LinkClicked);
            // 
            // LoadersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 327);
            this.Controls.Add(this.lnkIds);
            this.Controls.Add(this.btnGrab);
            this.Controls.Add(this.cbGrabType);
            this.Controls.Add(this.propsGrabbed);
            this.Controls.Add(this.lbGrab);
            this.Controls.Add(this.cbLoadType);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtIds);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoadersForm";
            this.Text = "Loaders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIds;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox cbLoadType;
        private System.Windows.Forms.ListBox lbGrab;
        private System.Windows.Forms.PropertyGrid propsGrabbed;
        private System.Windows.Forms.ComboBox cbGrabType;
        private System.Windows.Forms.Button btnGrab;
        private System.Windows.Forms.LinkLabel lnkIds;
    }
}