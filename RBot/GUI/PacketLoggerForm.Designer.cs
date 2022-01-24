namespace RBot
{
    partial class PacketLoggerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PacketLoggerForm));
            this.lbPackets = new System.Windows.Forms.ListBox();
            this.cmsListBoxPackets = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkEnabled = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tlpPacketLogger = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.chklbFilters = new System.Windows.Forms.CheckedListBox();
            this.LoggerTT = new System.Windows.Forms.ToolTip(this.components);
            this.cmsListBoxPackets.SuspendLayout();
            this.tlpPacketLogger.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPackets
            // 
            this.lbPackets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPacketLogger.SetColumnSpan(this.lbPackets, 2);
            this.lbPackets.ContextMenuStrip = this.cmsListBoxPackets;
            this.lbPackets.FormattingEnabled = true;
            this.lbPackets.ItemHeight = 15;
            this.lbPackets.Location = new System.Drawing.Point(4, 3);
            this.lbPackets.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbPackets.Name = "lbPackets";
            this.tlpPacketLogger.SetRowSpan(this.lbPackets, 2);
            this.lbPackets.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbPackets.Size = new System.Drawing.Size(334, 259);
            this.lbPackets.TabIndex = 0;
            this.LoggerTT.SetToolTip(this.lbPackets, "You can select and copy multiple packets to use in the packet spammer.\r\nRight cli" +
        "ck to clear selections.");
            // 
            // cmsListBoxPackets
            // 
            this.cmsListBoxPackets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearSelectionToolStripMenuItem});
            this.cmsListBoxPackets.Name = "cmsListBoxPackets";
            this.cmsListBoxPackets.Size = new System.Drawing.Size(153, 26);
            // 
            // clearSelectionToolStripMenuItem
            // 
            this.clearSelectionToolStripMenuItem.Name = "clearSelectionToolStripMenuItem";
            this.clearSelectionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearSelectionToolStripMenuItem.Text = "Clear Selection";
            this.clearSelectionToolStripMenuItem.Click += new System.EventHandler(this.clearSelectionToolStripMenuItem_Click);
            // 
            // chkEnabled
            // 
            this.chkEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkEnabled.AutoSize = true;
            this.chkEnabled.Location = new System.Drawing.Point(346, 268);
            this.chkEnabled.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Size = new System.Drawing.Size(187, 24);
            this.chkEnabled.TabIndex = 1;
            this.chkEnabled.Text = "Enabled";
            this.LoggerTT.SetToolTip(this.chkEnabled, "Enables the packet listener.");
            this.chkEnabled.UseVisualStyleBackColor = true;
            this.chkEnabled.CheckedChanged += new System.EventHandler(this.chkEnabled_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(4, 268);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(163, 24);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.LoggerTT.SetToolTip(this.btnClear, "Clears the current list of packets.");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(175, 268);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 24);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.LoggerTT.SetToolTip(this.btnSave, "Saves the current list of packets.");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tlpPacketLogger
            // 
            this.tlpPacketLogger.ColumnCount = 3;
            this.tlpPacketLogger.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tlpPacketLogger.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tlpPacketLogger.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPacketLogger.Controls.Add(this.btnClear, 0, 2);
            this.tlpPacketLogger.Controls.Add(this.btnSave, 1, 2);
            this.tlpPacketLogger.Controls.Add(this.chkEnabled, 2, 2);
            this.tlpPacketLogger.Controls.Add(this.label1, 2, 0);
            this.tlpPacketLogger.Controls.Add(this.chklbFilters, 2, 1);
            this.tlpPacketLogger.Controls.Add(this.lbPackets, 0, 0);
            this.tlpPacketLogger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPacketLogger.Location = new System.Drawing.Point(0, 0);
            this.tlpPacketLogger.Name = "tlpPacketLogger";
            this.tlpPacketLogger.RowCount = 3;
            this.tlpPacketLogger.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPacketLogger.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPacketLogger.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPacketLogger.Size = new System.Drawing.Size(537, 295);
            this.tlpPacketLogger.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(345, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter out:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoggerTT.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // chklbFilters
            // 
            this.chklbFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chklbFilters.CheckOnClick = true;
            this.chklbFilters.FormattingEnabled = true;
            this.chklbFilters.Items.AddRange(new object[] {
            "Combat",
            "User Data",
            "Join",
            "Jump",
            "Movement",
            "Get Map",
            "Quest",
            "Shop",
            "Equip",
            "Drop",
            "Send",
            "Misc"});
            this.chklbFilters.Location = new System.Drawing.Point(345, 33);
            this.chklbFilters.Name = "chklbFilters";
            this.chklbFilters.Size = new System.Drawing.Size(189, 220);
            this.chklbFilters.TabIndex = 5;
            this.LoggerTT.SetToolTip(this.chklbFilters, resources.GetString("chklbFilters.ToolTip"));
            // 
            // PacketLoggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 295);
            this.Controls.Add(this.tlpPacketLogger);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PacketLoggerForm";
            this.Text = "Packet Logger";
            this.Load += new System.EventHandler(this.PacketLoggerForm_Load);
            this.cmsListBoxPackets.ResumeLayout(false);
            this.tlpPacketLogger.ResumeLayout(false);
            this.tlpPacketLogger.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbPackets;
        private System.Windows.Forms.CheckBox chkEnabled;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tlpPacketLogger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chklbFilters;
        private System.Windows.Forms.ToolTip LoggerTT;
        private System.Windows.Forms.ContextMenuStrip cmsListBoxPackets;
        private System.Windows.Forms.ToolStripMenuItem clearSelectionToolStripMenuItem;
    }
}