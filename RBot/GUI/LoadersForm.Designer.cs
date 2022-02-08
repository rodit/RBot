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
            this.components = new System.ComponentModel.Container();
            this.txtIds = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cbLoadType = new System.Windows.Forms.ComboBox();
            this.lbGrab = new System.Windows.Forms.ListBox();
            this.cmsGrabber = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsBuy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLoadShop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsOpenQuest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAccQuest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTPMonster = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEquipItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsToBank = new System.Windows.Forms.ToolStripMenuItem();
            this.tsToInv = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSell = new System.Windows.Forms.ToolStripMenuItem();
            this.propsGrabbed = new System.Windows.Forms.PropertyGrid();
            this.cbGrabType = new System.Windows.Forms.ComboBox();
            this.btnGrab = new System.Windows.Forms.Button();
            this.lnkIds = new System.Windows.Forms.LinkLabel();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.tlpLoaders = new System.Windows.Forms.TableLayoutPanel();
            this.LoadersTT = new System.Windows.Forms.ToolTip(this.components);
            this.cmsGrabber.SuspendLayout();
            this.tlpLoaders.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIds
            // 
            this.txtIds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLoaders.SetColumnSpan(this.txtIds, 2);
            this.txtIds.Location = new System.Drawing.Point(4, 4);
            this.txtIds.Margin = new System.Windows.Forms.Padding(4);
            this.txtIds.Name = "txtIds";
            this.txtIds.Size = new System.Drawing.Size(276, 23);
            this.txtIds.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(402, 3);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(165, 24);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cbLoadType
            // 
            this.cbLoadType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLoadType.FormattingEnabled = true;
            this.cbLoadType.Items.AddRange(new object[] {
            "Shop",
            "Quests"});
            this.cbLoadType.Location = new System.Drawing.Point(288, 4);
            this.cbLoadType.Margin = new System.Windows.Forms.Padding(4);
            this.cbLoadType.Name = "cbLoadType";
            this.cbLoadType.Size = new System.Drawing.Size(106, 23);
            this.cbLoadType.TabIndex = 2;
            this.cbLoadType.Text = "Shop";
            // 
            // lbGrab
            // 
            this.lbGrab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLoaders.SetColumnSpan(this.lbGrab, 2);
            this.lbGrab.ContextMenuStrip = this.cmsGrabber;
            this.lbGrab.FormattingEnabled = true;
            this.lbGrab.ItemHeight = 15;
            this.lbGrab.Location = new System.Drawing.Point(4, 63);
            this.lbGrab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbGrab.Name = "lbGrab";
            this.lbGrab.Size = new System.Drawing.Size(276, 274);
            this.lbGrab.TabIndex = 3;
            // 
            // cmsGrabber
            // 
            this.cmsGrabber.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBuy,
            this.tsLoadShop,
            this.tsOpenQuest,
            this.tsAccQuest,
            this.tsTPMonster,
            this.tsEquipItem,
            this.tsToBank,
            this.tsToInv,
            this.tsSell});
            this.cmsGrabber.Name = "cmsGrabber";
            this.cmsGrabber.Size = new System.Drawing.Size(146, 202);
            // 
            // tsBuy
            // 
            this.tsBuy.Name = "tsBuy";
            this.tsBuy.Size = new System.Drawing.Size(145, 22);
            this.tsBuy.Text = "Buy";
            this.tsBuy.Click += new System.EventHandler(this.tsBuy_Click);
            // 
            // tsLoadShop
            // 
            this.tsLoadShop.Name = "tsLoadShop";
            this.tsLoadShop.Size = new System.Drawing.Size(145, 22);
            this.tsLoadShop.Text = "Load";
            this.tsLoadShop.Click += new System.EventHandler(this.tsLoadShop_Click);
            // 
            // tsOpenQuest
            // 
            this.tsOpenQuest.Name = "tsOpenQuest";
            this.tsOpenQuest.Size = new System.Drawing.Size(145, 22);
            this.tsOpenQuest.Text = "Open Quest";
            this.tsOpenQuest.Click += new System.EventHandler(this.tsOpenQuest_Click);
            // 
            // tsAccQuest
            // 
            this.tsAccQuest.Name = "tsAccQuest";
            this.tsAccQuest.Size = new System.Drawing.Size(145, 22);
            this.tsAccQuest.Text = "Accept Quest";
            this.tsAccQuest.Click += new System.EventHandler(this.tsAccQuest_Click);
            // 
            // tsTPMonster
            // 
            this.tsTPMonster.Name = "tsTPMonster";
            this.tsTPMonster.Size = new System.Drawing.Size(145, 22);
            this.tsTPMonster.Text = "Teleport To";
            this.tsTPMonster.Click += new System.EventHandler(this.tsTPMonster_Click);
            // 
            // tsEquipItem
            // 
            this.tsEquipItem.Name = "tsEquipItem";
            this.tsEquipItem.Size = new System.Drawing.Size(145, 22);
            this.tsEquipItem.Text = "Equip";
            this.tsEquipItem.Click += new System.EventHandler(this.tsEquipItem_Click);
            // 
            // tsToBank
            // 
            this.tsToBank.Name = "tsToBank";
            this.tsToBank.Size = new System.Drawing.Size(145, 22);
            this.tsToBank.Text = "To Bank";
            this.tsToBank.Click += new System.EventHandler(this.tsToBank_Click);
            // 
            // tsToInv
            // 
            this.tsToInv.Name = "tsToInv";
            this.tsToInv.Size = new System.Drawing.Size(145, 22);
            this.tsToInv.Text = "To Inventory";
            this.tsToInv.Click += new System.EventHandler(this.tsToInv_Click);
            // 
            // tsSell
            // 
            this.tsSell.Name = "tsSell";
            this.tsSell.Size = new System.Drawing.Size(145, 22);
            this.tsSell.Text = "Sell";
            this.tsSell.Click += new System.EventHandler(this.tsSell_Click);
            // 
            // propsGrabbed
            // 
            this.propsGrabbed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLoaders.SetColumnSpan(this.propsGrabbed, 2);
            this.propsGrabbed.HelpVisible = false;
            this.propsGrabbed.Location = new System.Drawing.Point(288, 63);
            this.propsGrabbed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.propsGrabbed.Name = "propsGrabbed";
            this.propsGrabbed.Size = new System.Drawing.Size(279, 275);
            this.propsGrabbed.TabIndex = 4;
            this.propsGrabbed.ToolbarVisible = false;
            // 
            // cbGrabType
            // 
            this.cbGrabType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGrabType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbGrabType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tlpLoaders.SetColumnSpan(this.cbGrabType, 2);
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
            this.cbGrabType.Location = new System.Drawing.Point(4, 345);
            this.cbGrabType.Margin = new System.Windows.Forms.Padding(4);
            this.cbGrabType.Name = "cbGrabType";
            this.cbGrabType.Size = new System.Drawing.Size(276, 23);
            this.cbGrabType.TabIndex = 5;
            this.cbGrabType.Text = "Shop Items";
            // 
            // btnGrab
            // 
            this.btnGrab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLoaders.SetColumnSpan(this.btnGrab, 2);
            this.btnGrab.Location = new System.Drawing.Point(288, 344);
            this.btnGrab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGrab.Name = "btnGrab";
            this.btnGrab.Size = new System.Drawing.Size(279, 24);
            this.btnGrab.TabIndex = 6;
            this.btnGrab.Text = "Grab";
            this.btnGrab.UseVisualStyleBackColor = true;
            this.btnGrab.Click += new System.EventHandler(this.btnGrab_Click);
            // 
            // lnkIds
            // 
            this.lnkIds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkIds.AutoSize = true;
            this.lnkIds.BackColor = System.Drawing.Color.Transparent;
            this.lnkIds.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnkIds.Location = new System.Drawing.Point(402, 30);
            this.lnkIds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkIds.Name = "lnkIds";
            this.lnkIds.Size = new System.Drawing.Size(165, 30);
            this.lnkIds.TabIndex = 7;
            this.lnkIds.TabStop = true;
            this.lnkIds.Text = "Quest IDs";
            this.lnkIds.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkIds.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkIds_LinkClicked);
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Location = new System.Drawing.Point(89, 34);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(191, 23);
            this.txtFilter.TabIndex = 8;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFilter.Location = new System.Drawing.Point(0, 30);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(85, 30);
            this.lblFilter.TabIndex = 9;
            this.lblFilter.Text = "Search:";
            this.lblFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoadersTT.SetToolTip(this.lblFilter, "Ctrl + F to focus on the filter textbox.");
            // 
            // tlpLoaders
            // 
            this.tlpLoaders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLoaders.ColumnCount = 4;
            this.tlpLoaders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpLoaders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpLoaders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpLoaders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpLoaders.Controls.Add(this.txtIds, 0, 0);
            this.tlpLoaders.Controls.Add(this.btnGrab, 2, 3);
            this.tlpLoaders.Controls.Add(this.lblFilter, 0, 1);
            this.tlpLoaders.Controls.Add(this.cbGrabType, 0, 3);
            this.tlpLoaders.Controls.Add(this.cbLoadType, 2, 0);
            this.tlpLoaders.Controls.Add(this.txtFilter, 1, 1);
            this.tlpLoaders.Controls.Add(this.lbGrab, 0, 2);
            this.tlpLoaders.Controls.Add(this.btnLoad, 3, 0);
            this.tlpLoaders.Controls.Add(this.lnkIds, 3, 1);
            this.tlpLoaders.Controls.Add(this.propsGrabbed, 2, 2);
            this.tlpLoaders.Location = new System.Drawing.Point(0, 0);
            this.tlpLoaders.Name = "tlpLoaders";
            this.tlpLoaders.RowCount = 4;
            this.tlpLoaders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpLoaders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpLoaders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLoaders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpLoaders.Size = new System.Drawing.Size(571, 371);
            this.tlpLoaders.TabIndex = 10;
            // 
            // LoadersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 371);
            this.Controls.Add(this.tlpLoaders);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(424, 274);
            this.Name = "LoadersForm";
            this.Text = "Loaders";
            this.cmsGrabber.ResumeLayout(false);
            this.tlpLoaders.ResumeLayout(false);
            this.tlpLoaders.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TableLayoutPanel tlpLoaders;
        private System.Windows.Forms.ToolTip LoadersTT;
        private System.Windows.Forms.ContextMenuStrip cmsGrabber;
        private System.Windows.Forms.ToolStripMenuItem tsBuy;
        private System.Windows.Forms.ToolStripMenuItem tsLoadShop;
        private System.Windows.Forms.ToolStripMenuItem tsOpenQuest;
        private System.Windows.Forms.ToolStripMenuItem tsAccQuest;
        private System.Windows.Forms.ToolStripMenuItem tsTPMonster;
        private System.Windows.Forms.ToolStripMenuItem tsToBank;
        private System.Windows.Forms.ToolStripMenuItem tsToInv;
        private System.Windows.Forms.ToolStripMenuItem tsEquipItem;
        private System.Windows.Forms.ToolStripMenuItem tsSell;
    }
}