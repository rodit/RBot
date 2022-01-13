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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
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
            this.lblRBotVersion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRBotVersion.Location = new System.Drawing.Point(5, 5);
            this.lblRBotVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRBotVersion.Name = "lblRBotVersion";
            this.lblRBotVersion.Size = new System.Drawing.Size(196, 30);
            this.lblRBotVersion.TabIndex = 0;
            this.lblRBotVersion.Text = "RBot Version 0.0.0.0";
            // 
            // pbIcon
            // 
            this.pbIcon.BackgroundImage = global::RBot.Properties.Resources.rbot;
            this.pbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbIcon.Location = new System.Drawing.Point(452, 5);
            this.pbIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(249, 258);
            this.pbIcon.TabIndex = 1;
            this.pbIcon.TabStop = false;
            // 
            // lblBuildDate
            // 
            this.lblBuildDate.AutoSize = true;
            this.lblBuildDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuildDate.Location = new System.Drawing.Point(5, 35);
            this.lblBuildDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuildDate.Name = "lblBuildDate";
            this.lblBuildDate.Size = new System.Drawing.Size(130, 21);
            this.lblBuildDate.TabIndex = 2;
            this.lblBuildDate.Text = "Build Date: [Date]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(5, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Discord:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(5, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Website:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(5, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Project:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(5, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Documentation:";
            // 
            // lblLinkWebsite
            // 
            this.lblLinkWebsite.AutoSize = true;
            this.lblLinkWebsite.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLinkWebsite.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(102)))), ((int)(((byte)(210)))));
            this.lblLinkWebsite.Location = new System.Drawing.Point(120, 70);
            this.lblLinkWebsite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLinkWebsite.Name = "lblLinkWebsite";
            this.lblLinkWebsite.Size = new System.Drawing.Size(94, 17);
            this.lblLinkWebsite.TabIndex = 7;
            this.lblLinkWebsite.TabStop = true;
            this.lblLinkWebsite.Text = "https://auqw.tk";
            // 
            // lblLinkProject
            // 
            this.lblLinkProject.AutoSize = true;
            this.lblLinkProject.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLinkProject.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(102)))), ((int)(((byte)(210)))));
            this.lblLinkProject.Location = new System.Drawing.Point(120, 87);
            this.lblLinkProject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLinkProject.Name = "lblLinkProject";
            this.lblLinkProject.Size = new System.Drawing.Size(235, 17);
            this.lblLinkProject.TabIndex = 8;
            this.lblLinkProject.TabStop = true;
            this.lblLinkProject.Text = "https://github.com/BrenoHenrike/RBot/\r\n";
            // 
            // lblLinkDiscord
            // 
            this.lblLinkDiscord.AutoSize = true;
            this.lblLinkDiscord.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLinkDiscord.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(102)))), ((int)(((byte)(210)))));
            this.lblLinkDiscord.Location = new System.Drawing.Point(120, 104);
            this.lblLinkDiscord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLinkDiscord.Name = "lblLinkDiscord";
            this.lblLinkDiscord.Size = new System.Drawing.Size(168, 17);
            this.lblLinkDiscord.TabIndex = 9;
            this.lblLinkDiscord.TabStop = true;
            this.lblLinkDiscord.Text = "https://discord.io/AQWBots";
            // 
            // lblLinkDoc
            // 
            this.lblLinkDoc.AutoSize = true;
            this.lblLinkDoc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLinkDoc.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(102)))), ((int)(((byte)(210)))));
            this.lblLinkDoc.Location = new System.Drawing.Point(120, 121);
            this.lblLinkDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLinkDoc.Name = "lblLinkDoc";
            this.lblLinkDoc.Size = new System.Drawing.Size(263, 17);
            this.lblLinkDoc.TabIndex = 10;
            this.lblLinkDoc.TabStop = true;
            this.lblLinkDoc.Text = "https://brenohenrike.github.io/Rbot-Scripts/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Credits:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(5, 171);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(439, 92);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 271);
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
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
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