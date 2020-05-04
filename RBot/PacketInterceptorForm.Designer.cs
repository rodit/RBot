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
            this.listPackets = new System.Windows.Forms.ListView();
            this.columnPackets = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblBlocked = new System.Windows.Forms.Label();
            this.lblIn = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panIn = new System.Windows.Forms.Panel();
            this.panOut = new System.Windows.Forms.Panel();
            this.lnkClearLog = new System.Windows.Forms.LinkLabel();
            this.chkLogPackets = new System.Windows.Forms.CheckBox();
            this.tabsInterceptor.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbServers
            // 
            this.cbServers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbServers.FormattingEnabled = true;
            this.cbServers.Location = new System.Drawing.Point(59, 13);
            this.cbServers.Name = "cbServers";
            this.cbServers.Size = new System.Drawing.Size(679, 21);
            this.cbServers.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(744, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(12, 17);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(41, 13);
            this.lblServer.TabIndex = 2;
            this.lblServer.Text = "Server:";
            // 
            // tabsInterceptor
            // 
            this.tabsInterceptor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabsInterceptor.Controls.Add(this.tabLog);
            this.tabsInterceptor.Location = new System.Drawing.Point(12, 40);
            this.tabsInterceptor.Name = "tabsInterceptor";
            this.tabsInterceptor.SelectedIndex = 0;
            this.tabsInterceptor.Size = new System.Drawing.Size(807, 435);
            this.tabsInterceptor.TabIndex = 3;
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.listPackets);
            this.tabLog.Controls.Add(this.lblBlocked);
            this.tabLog.Controls.Add(this.lblIn);
            this.tabLog.Controls.Add(this.lblOut);
            this.tabLog.Controls.Add(this.panel1);
            this.tabLog.Controls.Add(this.panIn);
            this.tabLog.Controls.Add(this.panOut);
            this.tabLog.Controls.Add(this.lnkClearLog);
            this.tabLog.Controls.Add(this.chkLogPackets);
            this.tabLog.Location = new System.Drawing.Point(4, 22);
            this.tabLog.Name = "tabLog";
            this.tabLog.Size = new System.Drawing.Size(799, 409);
            this.tabLog.TabIndex = 0;
            this.tabLog.Text = "Log";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // listPackets
            // 
            this.listPackets.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listPackets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listPackets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnPackets});
            this.listPackets.HideSelection = false;
            this.listPackets.Location = new System.Drawing.Point(3, 27);
            this.listPackets.Name = "listPackets";
            this.listPackets.Size = new System.Drawing.Size(796, 382);
            this.listPackets.TabIndex = 7;
            this.listPackets.UseCompatibleStateImageBehavior = false;
            // 
            // columnPackets
            // 
            this.columnPackets.Text = "Packets";
            // 
            // lblBlocked
            // 
            this.lblBlocked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBlocked.AutoSize = true;
            this.lblBlocked.Location = new System.Drawing.Point(510, 5);
            this.lblBlocked.Name = "lblBlocked";
            this.lblBlocked.Size = new System.Drawing.Size(46, 13);
            this.lblBlocked.TabIndex = 6;
            this.lblBlocked.Text = "Blocked";
            // 
            // lblIn
            // 
            this.lblIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIn.AutoSize = true;
            this.lblIn.Location = new System.Drawing.Point(388, 5);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(46, 13);
            this.lblIn.TabIndex = 6;
            this.lblIn.Text = "Inbound";
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(256, 5);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(54, 13);
            this.lblOut.TabIndex = 5;
            this.lblOut.Text = "Outbound";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(488, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 16);
            this.panel1.TabIndex = 4;
            // 
            // panIn
            // 
            this.panIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panIn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panIn.ForeColor = System.Drawing.Color.White;
            this.panIn.Location = new System.Drawing.Point(366, 4);
            this.panIn.Name = "panIn";
            this.panIn.Size = new System.Drawing.Size(16, 16);
            this.panIn.TabIndex = 3;
            // 
            // panOut
            // 
            this.panOut.BackColor = System.Drawing.Color.Yellow;
            this.panOut.ForeColor = System.Drawing.Color.White;
            this.panOut.Location = new System.Drawing.Point(234, 4);
            this.panOut.Name = "panOut";
            this.panOut.Size = new System.Drawing.Size(16, 16);
            this.panOut.TabIndex = 2;
            // 
            // lnkClearLog
            // 
            this.lnkClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkClearLog.AutoSize = true;
            this.lnkClearLog.Location = new System.Drawing.Point(765, 4);
            this.lnkClearLog.Name = "lnkClearLog";
            this.lnkClearLog.Size = new System.Drawing.Size(31, 13);
            this.lnkClearLog.TabIndex = 1;
            this.lnkClearLog.TabStop = true;
            this.lnkClearLog.Text = "Clear";
            this.lnkClearLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClearLog_LinkClicked);
            // 
            // chkLogPackets
            // 
            this.chkLogPackets.AutoSize = true;
            this.chkLogPackets.Location = new System.Drawing.Point(3, 4);
            this.chkLogPackets.Name = "chkLogPackets";
            this.chkLogPackets.Size = new System.Drawing.Size(86, 17);
            this.chkLogPackets.TabIndex = 0;
            this.chkLogPackets.Text = "Log Packets";
            this.chkLogPackets.UseVisualStyleBackColor = true;
            this.chkLogPackets.CheckedChanged += new System.EventHandler(this.chkLogPackets_CheckedChanged);
            // 
            // PacketInterceptorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 487);
            this.Controls.Add(this.tabsInterceptor);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cbServers);
            this.Name = "PacketInterceptorForm";
            this.Text = "Packet Interceptor";
            this.tabsInterceptor.ResumeLayout(false);
            this.tabLog.ResumeLayout(false);
            this.tabLog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}