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
            this.propsGrabbed = new System.Windows.Forms.PropertyGrid();
            this.cbGrabType = new System.Windows.Forms.ComboBox();
            this.btnGrab = new System.Windows.Forms.Button();
            this.lnkIds = new System.Windows.Forms.LinkLabel();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.tlpLoaders = new System.Windows.Forms.TableLayoutPanel();
            this.LoadersTT = new System.Windows.Forms.ToolTip(this.components);
            this.tlpLoaders.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIds
            // 
            this.txtIds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLoaders.SetColumnSpan(this.txtIds, 2);
            this.txtIds.Location = new System.Drawing.Point(4, 3);
            this.txtIds.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIds.Name = "txtIds";
            this.txtIds.Size = new System.Drawing.Size(277, 23);
            this.txtIds.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(403, 3);
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
            this.cbLoadType.Location = new System.Drawing.Point(289, 3);
            this.cbLoadType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.lbGrab.FormattingEnabled = true;
            this.lbGrab.ItemHeight = 15;
            this.lbGrab.Location = new System.Drawing.Point(4, 63);
            this.lbGrab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbGrab.Name = "lbGrab";
            this.lbGrab.Size = new System.Drawing.Size(277, 274);
            this.lbGrab.TabIndex = 3;
            // 
            // propsGrabbed
            // 
            this.propsGrabbed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLoaders.SetColumnSpan(this.propsGrabbed, 2);
            this.propsGrabbed.HelpVisible = false;
            this.propsGrabbed.Location = new System.Drawing.Point(289, 63);
            this.propsGrabbed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.propsGrabbed.Name = "propsGrabbed";
            this.propsGrabbed.Size = new System.Drawing.Size(279, 274);
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
            this.cbGrabType.Location = new System.Drawing.Point(4, 343);
            this.cbGrabType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbGrabType.Name = "cbGrabType";
            this.cbGrabType.Size = new System.Drawing.Size(277, 23);
            this.cbGrabType.TabIndex = 5;
            this.cbGrabType.Text = "Shop Items";
            // 
            // btnGrab
            // 
            this.btnGrab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLoaders.SetColumnSpan(this.btnGrab, 2);
            this.btnGrab.Location = new System.Drawing.Point(289, 343);
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
            this.tlpLoaders.SetColumnSpan(this.lnkIds, 2);
            this.lnkIds.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnkIds.Location = new System.Drawing.Point(289, 30);
            this.lnkIds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkIds.Name = "lnkIds";
            this.lnkIds.Size = new System.Drawing.Size(279, 30);
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
            this.txtFilter.Location = new System.Drawing.Point(89, 33);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(192, 23);
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
            this.lblFilter.Location = new System.Drawing.Point(3, 30);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(79, 30);
            this.lblFilter.TabIndex = 9;
            this.lblFilter.Text = "Filter:";
            this.lblFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.tlpLoaders.Controls.Add(this.lnkIds, 2, 1);
            this.tlpLoaders.Controls.Add(this.propsGrabbed, 2, 2);
            this.tlpLoaders.Location = new System.Drawing.Point(0, 0);
            this.tlpLoaders.Name = "tlpLoaders";
            this.tlpLoaders.RowCount = 4;
            this.tlpLoaders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpLoaders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpLoaders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLoaders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpLoaders.Size = new System.Drawing.Size(572, 370);
            this.tlpLoaders.TabIndex = 10;
            // 
            // LoadersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 370);
            this.Controls.Add(this.tlpLoaders);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(424, 274);
            this.Name = "LoadersForm";
            this.Text = "Loaders";
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
    }
}