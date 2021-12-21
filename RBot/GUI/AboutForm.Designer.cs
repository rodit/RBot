namespace RBot
{
    partial class AboutForm
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
            this.lblRBotVersion = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.lblBuildDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLinkWebsite = new System.Windows.Forms.LinkLabel();
            this.lblLinkProject = new System.Windows.Forms.LinkLabel();
            this.lblLinkDiscord = new System.Windows.Forms.LinkLabel();
            this.lblLinkDoc = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRBotVersion
            // 
            this.lblRBotVersion.AutoSize = true;
            this.lblRBotVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRBotVersion.Location = new System.Drawing.Point(12, 9);
            this.lblRBotVersion.Name = "lblRBotVersion";
            this.lblRBotVersion.Size = new System.Drawing.Size(139, 17);
            this.lblRBotVersion.TabIndex = 0;
            this.lblRBotVersion.Text = "RBot Version 0.0.0.0";
            // 
            // pbIcon
            // 
            this.pbIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbIcon.BackgroundImage = global::RBot.Properties.Resources.rbot;
            this.pbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbIcon.Location = new System.Drawing.Point(402, 10);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(235, 236);
            this.pbIcon.TabIndex = 1;
            this.pbIcon.TabStop = false;
            // 
            // lblBuildDate
            // 
            this.lblBuildDate.AutoSize = true;
            this.lblBuildDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBuildDate.Location = new System.Drawing.Point(12, 39);
            this.lblBuildDate.Name = "lblBuildDate";
            this.lblBuildDate.Size = new System.Drawing.Size(119, 17);
            this.lblBuildDate.TabIndex = 2;
            this.lblBuildDate.Text = "Build Date: [Date]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Discord:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Website:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Project:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Documentation:";
            // 
            // lblLinkWebsite
            // 
            this.lblLinkWebsite.AutoSize = true;
            this.lblLinkWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblLinkWebsite.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(102)))), ((int)(((byte)(210)))));
            this.lblLinkWebsite.Location = new System.Drawing.Point(67, 71);
            this.lblLinkWebsite.Name = "lblLinkWebsite";
            this.lblLinkWebsite.Size = new System.Drawing.Size(84, 15);
            this.lblLinkWebsite.TabIndex = 7;
            this.lblLinkWebsite.TabStop = true;
            this.lblLinkWebsite.Text = "https://auqw.tk";
            this.lblLinkWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkWebsite_LinkClicked);
            // 
            // lblLinkProject
            // 
            this.lblLinkProject.AutoSize = true;
            this.lblLinkProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblLinkProject.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(102)))), ((int)(((byte)(210)))));
            this.lblLinkProject.Location = new System.Drawing.Point(60, 87);
            this.lblLinkProject.Name = "lblLinkProject";
            this.lblLinkProject.Size = new System.Drawing.Size(215, 15);
            this.lblLinkProject.TabIndex = 8;
            this.lblLinkProject.TabStop = true;
            this.lblLinkProject.Text = "https://github.com/BrenoHenrike/RBot/\r\n";
            this.lblLinkProject.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkProject_LinkClicked);
            // 
            // lblLinkDiscord
            // 
            this.lblLinkDiscord.AutoSize = true;
            this.lblLinkDiscord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblLinkDiscord.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(102)))), ((int)(((byte)(210)))));
            this.lblLinkDiscord.Location = new System.Drawing.Point(66, 103);
            this.lblLinkDiscord.Name = "lblLinkDiscord";
            this.lblLinkDiscord.Size = new System.Drawing.Size(149, 15);
            this.lblLinkDiscord.TabIndex = 9;
            this.lblLinkDiscord.TabStop = true;
            this.lblLinkDiscord.Text = "https://discord.io/AQWBots";
            this.lblLinkDiscord.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkDiscord_LinkClicked);
            // 
            // lblLinkDoc
            // 
            this.lblLinkDoc.AutoSize = true;
            this.lblLinkDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblLinkDoc.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(102)))), ((int)(((byte)(210)))));
            this.lblLinkDoc.Location = new System.Drawing.Point(104, 119);
            this.lblLinkDoc.Name = "lblLinkDoc";
            this.lblLinkDoc.Size = new System.Drawing.Size(238, 15);
            this.lblLinkDoc.TabIndex = 10;
            this.lblLinkDoc.TabStop = true;
            this.lblLinkDoc.Text = "https://brenohenrike.github.io/Rbot-Scripts/";
            this.lblLinkDoc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkDoc_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Credits:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(15, 176);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(376, 77);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "1) rodit (https://github.com/rodit/)\n     ⤷ Fork: https://github.com/rodit/RBot\n2" +
    ") Purple/SharpTheNightmare (https://github.com/SharpTheNightmare/)\n     ⤷ For co" +
    "ntributions\n";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 257);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLinkDoc);
            this.Controls.Add(this.lblLinkDiscord);
            this.Controls.Add(this.lblLinkProject);
            this.Controls.Add(this.lblLinkWebsite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBuildDate);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.lblRBotVersion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(661, 296);
            this.Name = "AboutForm";
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRBotVersion;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lblBuildDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel lblLinkWebsite;
        private System.Windows.Forms.LinkLabel lblLinkProject;
        private System.Windows.Forms.LinkLabel lblLinkDiscord;
        private System.Windows.Forms.LinkLabel lblLinkDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}