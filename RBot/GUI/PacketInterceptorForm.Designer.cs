namespace RBot
{
    partial class PacketInterceptorForm
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
            this.cbServers = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblServer = new System.Windows.Forms.Label();
            this.tabsInterceptor = new System.Windows.Forms.TabControl();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.tlpInterceptor = new System.Windows.Forms.TableLayoutPanel();
            this.listPackets = new System.Windows.Forms.ListView();
            this.columnPackets = new System.Windows.Forms.ColumnHeader();
            this.lblBlocked = new System.Windows.Forms.Label();
            this.chkLogPackets = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOut = new System.Windows.Forms.Label();
            this.panOut = new System.Windows.Forms.Panel();
            this.panIn = new System.Windows.Forms.Panel();
            this.lblIn = new System.Windows.Forms.Label();
            this.lnkClearLog = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabsInterceptor.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.tlpInterceptor.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbServers
            // 
            this.cbServers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbServers.FormattingEnabled = true;
            this.cbServers.Location = new System.Drawing.Point(84, 3);
            this.cbServers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbServers.Name = "cbServers";
            this.cbServers.Size = new System.Drawing.Size(499, 23);
            this.cbServers.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(591, 3);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(92, 24);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblServer
            // 
            this.lblServer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblServer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServer.Location = new System.Drawing.Point(4, 0);
            this.lblServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(72, 30);
            this.lblServer.TabIndex = 2;
            this.lblServer.Text = "Server:";
            this.lblServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabsInterceptor
            // 
            this.tabsInterceptor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.tabsInterceptor, 3);
            this.tabsInterceptor.Controls.Add(this.tabLog);
            this.tabsInterceptor.Location = new System.Drawing.Point(4, 33);
            this.tabsInterceptor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabsInterceptor.Name = "tabsInterceptor";
            this.tabsInterceptor.SelectedIndex = 0;
            this.tabsInterceptor.Size = new System.Drawing.Size(679, 435);
            this.tabsInterceptor.TabIndex = 3;
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.tlpInterceptor);
            this.tabLog.Controls.Add(this.lnkClearLog);
            this.tabLog.Location = new System.Drawing.Point(4, 24);
            this.tabLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabLog.Name = "tabLog";
            this.tabLog.Size = new System.Drawing.Size(671, 407);
            this.tabLog.TabIndex = 0;
            this.tabLog.Text = "Log";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // tlpInterceptor
            // 
            this.tlpInterceptor.ColumnCount = 9;
            this.tlpInterceptor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpInterceptor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInterceptor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpInterceptor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpInterceptor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpInterceptor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpInterceptor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpInterceptor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpInterceptor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInterceptor.Controls.Add(this.listPackets, 0, 1);
            this.tlpInterceptor.Controls.Add(this.lblBlocked, 7, 0);
            this.tlpInterceptor.Controls.Add(this.chkLogPackets, 0, 0);
            this.tlpInterceptor.Controls.Add(this.panel1, 6, 0);
            this.tlpInterceptor.Controls.Add(this.lblOut, 3, 0);
            this.tlpInterceptor.Controls.Add(this.panOut, 2, 0);
            this.tlpInterceptor.Controls.Add(this.panIn, 4, 0);
            this.tlpInterceptor.Controls.Add(this.lblIn, 5, 0);
            this.tlpInterceptor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInterceptor.Location = new System.Drawing.Point(0, 0);
            this.tlpInterceptor.Name = "tlpInterceptor";
            this.tlpInterceptor.RowCount = 2;
            this.tlpInterceptor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpInterceptor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInterceptor.Size = new System.Drawing.Size(671, 407);
            this.tlpInterceptor.TabIndex = 8;
            // 
            // listPackets
            // 
            this.listPackets.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listPackets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listPackets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnPackets});
            this.tlpInterceptor.SetColumnSpan(this.listPackets, 9);
            this.listPackets.Location = new System.Drawing.Point(4, 33);
            this.listPackets.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listPackets.Name = "listPackets";
            this.listPackets.Size = new System.Drawing.Size(663, 371);
            this.listPackets.TabIndex = 7;
            this.listPackets.UseCompatibleStateImageBehavior = false;
            // 
            // columnPackets
            // 
            this.columnPackets.Text = "Packets";
            // 
            // lblBlocked
            // 
            this.lblBlocked.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBlocked.AutoSize = true;
            this.lblBlocked.Location = new System.Drawing.Point(471, 0);
            this.lblBlocked.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBlocked.Name = "lblBlocked";
            this.lblBlocked.Size = new System.Drawing.Size(62, 30);
            this.lblBlocked.TabIndex = 6;
            this.lblBlocked.Text = "Blocked";
            this.lblBlocked.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkLogPackets
            // 
            this.chkLogPackets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkLogPackets.AutoSize = true;
            this.chkLogPackets.Location = new System.Drawing.Point(4, 3);
            this.chkLogPackets.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkLogPackets.Name = "chkLogPackets";
            this.chkLogPackets.Size = new System.Drawing.Size(89, 24);
            this.chkLogPackets.TabIndex = 0;
            this.chkLogPackets.Text = "Log Packets";
            this.chkLogPackets.UseVisualStyleBackColor = true;
            this.chkLogPackets.CheckedChanged += new System.EventHandler(this.chkLogPackets_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(439, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(24, 24);
            this.panel1.TabIndex = 4;
            // 
            // lblOut
            // 
            this.lblOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(267, 0);
            this.lblOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(62, 30);
            this.lblOut.TabIndex = 5;
            this.lblOut.Text = "Outbound";
            this.lblOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panOut
            // 
            this.panOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panOut.BackColor = System.Drawing.Color.Yellow;
            this.panOut.ForeColor = System.Drawing.Color.White;
            this.panOut.Location = new System.Drawing.Point(235, 3);
            this.panOut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panOut.Name = "panOut";
            this.panOut.Size = new System.Drawing.Size(24, 24);
            this.panOut.TabIndex = 2;
            // 
            // panIn
            // 
            this.panIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panIn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panIn.ForeColor = System.Drawing.Color.White;
            this.panIn.Location = new System.Drawing.Point(337, 3);
            this.panIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panIn.Name = "panIn";
            this.panIn.Size = new System.Drawing.Size(24, 24);
            this.panIn.TabIndex = 3;
            // 
            // lblIn
            // 
            this.lblIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIn.AutoSize = true;
            this.lblIn.Location = new System.Drawing.Point(369, 0);
            this.lblIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(62, 30);
            this.lblIn.TabIndex = 6;
            this.lblIn.Text = "Inbound";
            this.lblIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lnkClearLog
            // 
            this.lnkClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkClearLog.AutoSize = true;
            this.lnkClearLog.Location = new System.Drawing.Point(684, 5);
            this.lnkClearLog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkClearLog.Name = "lnkClearLog";
            this.lnkClearLog.Size = new System.Drawing.Size(34, 15);
            this.lnkClearLog.TabIndex = 1;
            this.lnkClearLog.TabStop = true;
            this.lnkClearLog.Text = "Clear";
            this.lnkClearLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClearLog_LinkClicked);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnConnect, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblServer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbServers, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabsInterceptor, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(687, 471);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // PacketInterceptorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 471);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(440, 330);
            this.Name = "PacketInterceptorForm";
            this.Text = "Packet Interceptor";
            this.tabsInterceptor.ResumeLayout(false);
            this.tabLog.ResumeLayout(false);
            this.tabLog.PerformLayout();
            this.tlpInterceptor.ResumeLayout(false);
            this.tlpInterceptor.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbServers;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TabControl tabsInterceptor;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.CheckBox chkLogPackets;
        private System.Windows.Forms.LinkLabel lnkClearLog;
        private System.Windows.Forms.Panel panOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panIn;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label lblBlocked;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.ListView listPackets;
        private System.Windows.Forms.ColumnHeader columnPackets;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlpInterceptor;
    }
}