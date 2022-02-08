namespace RBot
{
    partial class PacketSpammerForm
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
            this.lbPackets = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDelay = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.chkClient = new System.Windows.Forms.CheckBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtPacket = new System.Windows.Forms.TextBox();
            this.packetTimer = new System.Windows.Forms.Timer(this.components);
            this.tlpPacketSpammer = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tlpPacketSpammer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPackets
            // 
            this.lbPackets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPackets.FormattingEnabled = true;
            this.lbPackets.ItemHeight = 15;
            this.lbPackets.Location = new System.Drawing.Point(4, 3);
            this.lbPackets.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbPackets.Name = "lbPackets";
            this.tlpPacketSpammer.SetRowSpan(this.lbPackets, 8);
            this.lbPackets.Size = new System.Drawing.Size(409, 259);
            this.lbPackets.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.tlpPacketSpammer.SetColumnSpan(this.btnAdd, 2);
            this.btnAdd.Location = new System.Drawing.Point(421, 3);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 24);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.tlpPacketSpammer.SetColumnSpan(this.btnRemove, 2);
            this.btnRemove.Location = new System.Drawing.Point(421, 33);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(112, 24);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.tlpPacketSpammer.SetColumnSpan(this.btnClear, 2);
            this.btnClear.Location = new System.Drawing.Point(421, 63);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 24);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLoad
            // 
            this.tlpPacketSpammer.SetColumnSpan(this.btnLoad, 2);
            this.btnLoad.Location = new System.Drawing.Point(421, 93);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(112, 24);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.tlpPacketSpammer.SetColumnSpan(this.btnSave, 2);
            this.btnSave.Location = new System.Drawing.Point(421, 123);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 24);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDelay
            // 
            this.lblDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDelay.AutoSize = true;
            this.lblDelay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDelay.Location = new System.Drawing.Point(421, 150);
            this.lblDelay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(42, 30);
            this.lblDelay.TabIndex = 6;
            this.lblDelay.Text = "Delay:";
            this.lblDelay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(471, 153);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(62, 23);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            this.tlpPacketSpammer.SetColumnSpan(this.btnStart, 2);
            this.btnStart.Location = new System.Drawing.Point(421, 183);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 24);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // chkClient
            // 
            this.chkClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkClient.AutoSize = true;
            this.tlpPacketSpammer.SetColumnSpan(this.chkClient, 2);
            this.chkClient.Location = new System.Drawing.Point(421, 213);
            this.chkClient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkClient.Name = "chkClient";
            this.chkClient.Size = new System.Drawing.Size(112, 19);
            this.chkClient.TabIndex = 9;
            this.chkClient.Text = "Send to Client";
            this.chkClient.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.tlpPacketSpammer.SetColumnSpan(this.btnSend, 2);
            this.btnSend.Location = new System.Drawing.Point(421, 268);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(112, 24);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtPacket
            // 
            this.txtPacket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPacket.Location = new System.Drawing.Point(4, 268);
            this.txtPacket.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPacket.Name = "txtPacket";
            this.txtPacket.Size = new System.Drawing.Size(409, 23);
            this.txtPacket.TabIndex = 11;
            // 
            // packetTimer
            // 
            this.packetTimer.Interval = 1000;
            this.packetTimer.Tick += new System.EventHandler(this.packetTimer_Tick);
            // 
            // tlpPacketSpammer
            // 
            this.tlpPacketSpammer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPacketSpammer.ColumnCount = 3;
            this.tlpPacketSpammer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPacketSpammer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpPacketSpammer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpPacketSpammer.Controls.Add(this.lbPackets, 0, 0);
            this.tlpPacketSpammer.Controls.Add(this.lblDelay, 1, 5);
            this.tlpPacketSpammer.Controls.Add(this.btnSend, 1, 8);
            this.tlpPacketSpammer.Controls.Add(this.numericUpDown1, 2, 5);
            this.tlpPacketSpammer.Controls.Add(this.chkClient, 1, 7);
            this.tlpPacketSpammer.Controls.Add(this.btnAdd, 1, 0);
            this.tlpPacketSpammer.Controls.Add(this.btnStart, 1, 6);
            this.tlpPacketSpammer.Controls.Add(this.btnRemove, 1, 1);
            this.tlpPacketSpammer.Controls.Add(this.btnClear, 1, 2);
            this.tlpPacketSpammer.Controls.Add(this.btnLoad, 1, 3);
            this.tlpPacketSpammer.Controls.Add(this.btnSave, 1, 4);
            this.tlpPacketSpammer.Controls.Add(this.txtPacket, 0, 8);
            this.tlpPacketSpammer.Location = new System.Drawing.Point(0, 0);
            this.tlpPacketSpammer.Name = "tlpPacketSpammer";
            this.tlpPacketSpammer.RowCount = 9;
            this.tlpPacketSpammer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPacketSpammer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPacketSpammer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPacketSpammer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPacketSpammer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPacketSpammer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPacketSpammer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPacketSpammer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPacketSpammer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPacketSpammer.Size = new System.Drawing.Size(537, 295);
            this.tlpPacketSpammer.TabIndex = 12;
            // 
            // PacketSpammerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 295);
            this.Controls.Add(this.tlpPacketSpammer);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(320, 305);
            this.Name = "PacketSpammerForm";
            this.Text = "Packet Spammer";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tlpPacketSpammer.ResumeLayout(false);
            this.tlpPacketSpammer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbPackets;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox chkClient;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtPacket;
        private System.Windows.Forms.Timer packetTimer;
        private System.Windows.Forms.TableLayoutPanel tlpPacketSpammer;
    }
}