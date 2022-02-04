namespace RBot
{
    partial class AutoUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstDrops = new System.Windows.Forms.ListBox();
            this.cmsDrops = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteDrops = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllDrops = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDrop = new System.Windows.Forms.TextBox();
            this.btnAddDrop = new System.Windows.Forms.Button();
            this.btnStartAttack = new System.Windows.Forms.Button();
            this.btnStartDrops = new System.Windows.Forms.Button();
            this.btnStartBoosts = new System.Windows.Forms.Button();
            this.btnStartHunt = new System.Windows.Forms.Button();
            this.btnAddQuest = new System.Windows.Forms.Button();
            this.txtQuest = new System.Windows.Forms.TextBox();
            this.lstQuests = new System.Windows.Forms.ListBox();
            this.cmsQuests = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteQuests = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllQuests = new System.Windows.Forms.ToolStripMenuItem();
            this.chkClass = new System.Windows.Forms.CheckBox();
            this.chkGold = new System.Windows.Forms.CheckBox();
            this.chkExperience = new System.Windows.Forms.CheckBox();
            this.chkRep = new System.Windows.Forms.CheckBox();
            this.tlpQuestsBoosts = new System.Windows.Forms.TableLayoutPanel();
            this.tlpDrops = new System.Windows.Forms.TableLayoutPanel();
            this.tlpAuto = new System.Windows.Forms.TableLayoutPanel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmsDrops.SuspendLayout();
            this.cmsQuests.SuspendLayout();
            this.tlpQuestsBoosts.SuspendLayout();
            this.tlpDrops.SuspendLayout();
            this.tlpAuto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstDrops
            // 
            this.lstDrops.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpDrops.SetColumnSpan(this.lstDrops, 2);
            this.lstDrops.ContextMenuStrip = this.cmsDrops;
            this.lstDrops.FormattingEnabled = true;
            this.lstDrops.ItemHeight = 15;
            this.lstDrops.Location = new System.Drawing.Point(3, 3);
            this.lstDrops.Name = "lstDrops";
            this.lstDrops.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstDrops.Size = new System.Drawing.Size(161, 244);
            this.lstDrops.TabIndex = 0;
            this.lstDrops.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstDrops_KeyDown);
            // 
            // cmsDrops
            // 
            this.cmsDrops.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteDrops,
            this.deleteAllDrops});
            this.cmsDrops.Name = "cmsDrops";
            this.cmsDrops.Size = new System.Drawing.Size(125, 48);
            // 
            // deleteDrops
            // 
            this.deleteDrops.Name = "deleteDrops";
            this.deleteDrops.Size = new System.Drawing.Size(124, 22);
            this.deleteDrops.Text = "Delete";
            this.deleteDrops.Click += new System.EventHandler(this.deleteDrops_Click);
            // 
            // deleteAllDrops
            // 
            this.deleteAllDrops.Name = "deleteAllDrops";
            this.deleteAllDrops.Size = new System.Drawing.Size(124, 22);
            this.deleteAllDrops.Text = "Delete All";
            this.deleteAllDrops.Click += new System.EventHandler(this.deleteAllDrops_Click);
            // 
            // txtDrop
            // 
            this.txtDrop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDrop.Location = new System.Drawing.Point(3, 256);
            this.txtDrop.Name = "txtDrop";
            this.txtDrop.PlaceholderText = "Drop Name";
            this.txtDrop.Size = new System.Drawing.Size(110, 23);
            this.txtDrop.TabIndex = 1;
            this.txtDrop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDrops_KeyDown);
            // 
            // btnAddDrop
            // 
            this.btnAddDrop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDrop.Location = new System.Drawing.Point(119, 256);
            this.btnAddDrop.Name = "btnAddDrop";
            this.btnAddDrop.Size = new System.Drawing.Size(45, 24);
            this.btnAddDrop.TabIndex = 2;
            this.btnAddDrop.Text = "Add";
            this.btnAddDrop.UseVisualStyleBackColor = true;
            this.btnAddDrop.Click += new System.EventHandler(this.btnAddDrop_Click);
            // 
            // btnStartAttack
            // 
            this.btnStartAttack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartAttack.Location = new System.Drawing.Point(3, 43);
            this.btnStartAttack.Name = "btnStartAttack";
            this.btnStartAttack.Size = new System.Drawing.Size(161, 34);
            this.btnStartAttack.TabIndex = 3;
            this.btnStartAttack.Text = "Auto Attack";
            this.btnStartAttack.UseVisualStyleBackColor = true;
            this.btnStartAttack.Click += new System.EventHandler(this.btnStartAttack_Click);
            // 
            // btnStartDrops
            // 
            this.btnStartDrops.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpDrops.SetColumnSpan(this.btnStartDrops, 2);
            this.btnStartDrops.Location = new System.Drawing.Point(3, 286);
            this.btnStartDrops.Name = "btnStartDrops";
            this.btnStartDrops.Size = new System.Drawing.Size(161, 24);
            this.btnStartDrops.TabIndex = 5;
            this.btnStartDrops.Text = "Start Drops";
            this.btnStartDrops.UseVisualStyleBackColor = true;
            this.btnStartDrops.Click += new System.EventHandler(this.btnStartDrops_Click);
            // 
            // btnStartBoosts
            // 
            this.btnStartBoosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpQuestsBoosts.SetColumnSpan(this.btnStartBoosts, 2);
            this.btnStartBoosts.Location = new System.Drawing.Point(3, 286);
            this.btnStartBoosts.Name = "btnStartBoosts";
            this.btnStartBoosts.Size = new System.Drawing.Size(162, 24);
            this.btnStartBoosts.TabIndex = 6;
            this.btnStartBoosts.Text = "Start Boosts";
            this.btnStartBoosts.UseVisualStyleBackColor = true;
            this.btnStartBoosts.Click += new System.EventHandler(this.btnStartBoosts_Click);
            // 
            // btnStartHunt
            // 
            this.btnStartHunt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartHunt.Location = new System.Drawing.Point(170, 43);
            this.btnStartHunt.Name = "btnStartHunt";
            this.btnStartHunt.Size = new System.Drawing.Size(162, 34);
            this.btnStartHunt.TabIndex = 8;
            this.btnStartHunt.Text = "Auto Hunt";
            this.btnStartHunt.UseVisualStyleBackColor = true;
            this.btnStartHunt.Click += new System.EventHandler(this.btnStartHunt_Click);
            // 
            // btnAddQuest
            // 
            this.btnAddQuest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddQuest.Location = new System.Drawing.Point(120, 156);
            this.btnAddQuest.Name = "btnAddQuest";
            this.btnAddQuest.Size = new System.Drawing.Size(45, 24);
            this.btnAddQuest.TabIndex = 11;
            this.btnAddQuest.Text = "Add";
            this.btnAddQuest.UseVisualStyleBackColor = true;
            this.btnAddQuest.Click += new System.EventHandler(this.btnAddQuest_Click);
            // 
            // txtQuest
            // 
            this.txtQuest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuest.Location = new System.Drawing.Point(3, 156);
            this.txtQuest.Name = "txtQuest";
            this.txtQuest.PlaceholderText = "Quest IDs";
            this.txtQuest.Size = new System.Drawing.Size(111, 23);
            this.txtQuest.TabIndex = 10;
            this.txtQuest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuest_KeyDown);
            // 
            // lstQuests
            // 
            this.lstQuests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpQuestsBoosts.SetColumnSpan(this.lstQuests, 2);
            this.lstQuests.ContextMenuStrip = this.cmsQuests;
            this.lstQuests.FormattingEnabled = true;
            this.lstQuests.ItemHeight = 15;
            this.lstQuests.Location = new System.Drawing.Point(3, 3);
            this.lstQuests.Name = "lstQuests";
            this.lstQuests.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstQuests.Size = new System.Drawing.Size(162, 139);
            this.lstQuests.TabIndex = 9;
            this.lstQuests.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstQuests_KeyDown);
            // 
            // cmsQuests
            // 
            this.cmsQuests.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteQuests,
            this.deleteAllQuests});
            this.cmsQuests.Name = "cmsQuests";
            this.cmsQuests.Size = new System.Drawing.Size(125, 48);
            // 
            // deleteQuests
            // 
            this.deleteQuests.Name = "deleteQuests";
            this.deleteQuests.Size = new System.Drawing.Size(124, 22);
            this.deleteQuests.Text = "Delete";
            this.deleteQuests.Click += new System.EventHandler(this.deleteQuests_Click);
            // 
            // deleteAllQuests
            // 
            this.deleteAllQuests.Name = "deleteAllQuests";
            this.deleteAllQuests.Size = new System.Drawing.Size(124, 22);
            this.deleteAllQuests.Text = "Delete All";
            this.deleteAllQuests.Click += new System.EventHandler(this.deleteAllQuests_Click);
            // 
            // chkClass
            // 
            this.chkClass.AutoSize = true;
            this.tlpQuestsBoosts.SetColumnSpan(this.chkClass, 2);
            this.chkClass.Location = new System.Drawing.Point(3, 186);
            this.chkClass.Name = "chkClass";
            this.chkClass.Size = new System.Drawing.Size(53, 19);
            this.chkClass.TabIndex = 12;
            this.chkClass.Tag = "class";
            this.chkClass.Text = "Class";
            this.chkClass.UseVisualStyleBackColor = true;
            this.chkClass.CheckedChanged += new System.EventHandler(this.Boost_CheckedChanged);
            // 
            // chkGold
            // 
            this.chkGold.AutoSize = true;
            this.tlpQuestsBoosts.SetColumnSpan(this.chkGold, 2);
            this.chkGold.Location = new System.Drawing.Point(3, 211);
            this.chkGold.Name = "chkGold";
            this.chkGold.Size = new System.Drawing.Size(51, 19);
            this.chkGold.TabIndex = 13;
            this.chkGold.Tag = "gold";
            this.chkGold.Text = "Gold";
            this.chkGold.UseVisualStyleBackColor = true;
            this.chkGold.CheckedChanged += new System.EventHandler(this.Boost_CheckedChanged);
            // 
            // chkExperience
            // 
            this.chkExperience.AutoSize = true;
            this.tlpQuestsBoosts.SetColumnSpan(this.chkExperience, 2);
            this.chkExperience.Location = new System.Drawing.Point(3, 236);
            this.chkExperience.Name = "chkExperience";
            this.chkExperience.Size = new System.Drawing.Size(83, 19);
            this.chkExperience.TabIndex = 14;
            this.chkExperience.Tag = "xp";
            this.chkExperience.Text = "Experience";
            this.chkExperience.UseVisualStyleBackColor = true;
            this.chkExperience.CheckedChanged += new System.EventHandler(this.Boost_CheckedChanged);
            // 
            // chkRep
            // 
            this.chkRep.AutoSize = true;
            this.tlpQuestsBoosts.SetColumnSpan(this.chkRep, 2);
            this.chkRep.Location = new System.Drawing.Point(3, 261);
            this.chkRep.Name = "chkRep";
            this.chkRep.Size = new System.Drawing.Size(84, 19);
            this.chkRep.TabIndex = 15;
            this.chkRep.Tag = "rep";
            this.chkRep.Text = "Reputation";
            this.chkRep.UseVisualStyleBackColor = true;
            this.chkRep.CheckedChanged += new System.EventHandler(this.Boost_CheckedChanged);
            // 
            // tlpQuestsBoosts
            // 
            this.tlpQuestsBoosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpQuestsBoosts.ColumnCount = 2;
            this.tlpQuestsBoosts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpQuestsBoosts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpQuestsBoosts.Controls.Add(this.lstQuests, 0, 0);
            this.tlpQuestsBoosts.Controls.Add(this.chkRep, 0, 5);
            this.tlpQuestsBoosts.Controls.Add(this.btnStartBoosts, 0, 6);
            this.tlpQuestsBoosts.Controls.Add(this.txtQuest, 0, 1);
            this.tlpQuestsBoosts.Controls.Add(this.chkExperience, 0, 4);
            this.tlpQuestsBoosts.Controls.Add(this.btnAddQuest, 1, 1);
            this.tlpQuestsBoosts.Controls.Add(this.chkGold, 0, 3);
            this.tlpQuestsBoosts.Controls.Add(this.chkClass, 0, 2);
            this.tlpQuestsBoosts.Location = new System.Drawing.Point(167, 80);
            this.tlpQuestsBoosts.Margin = new System.Windows.Forms.Padding(0);
            this.tlpQuestsBoosts.Name = "tlpQuestsBoosts";
            this.tlpQuestsBoosts.RowCount = 7;
            this.tlpQuestsBoosts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpQuestsBoosts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpQuestsBoosts.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpQuestsBoosts.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpQuestsBoosts.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpQuestsBoosts.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpQuestsBoosts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpQuestsBoosts.Size = new System.Drawing.Size(168, 313);
            this.tlpQuestsBoosts.TabIndex = 16;
            // 
            // tlpDrops
            // 
            this.tlpDrops.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpDrops.ColumnCount = 2;
            this.tlpDrops.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpDrops.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpDrops.Controls.Add(this.lstDrops, 0, 0);
            this.tlpDrops.Controls.Add(this.txtDrop, 0, 1);
            this.tlpDrops.Controls.Add(this.btnAddDrop, 1, 1);
            this.tlpDrops.Controls.Add(this.btnStartDrops, 0, 2);
            this.tlpDrops.Location = new System.Drawing.Point(0, 80);
            this.tlpDrops.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDrops.Name = "tlpDrops";
            this.tlpDrops.RowCount = 3;
            this.tlpDrops.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDrops.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpDrops.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpDrops.Size = new System.Drawing.Size(167, 313);
            this.tlpDrops.TabIndex = 17;
            // 
            // tlpAuto
            // 
            this.tlpAuto.ColumnCount = 2;
            this.tlpAuto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAuto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAuto.Controls.Add(this.btnStartAttack, 0, 1);
            this.tlpAuto.Controls.Add(this.tlpQuestsBoosts, 1, 2);
            this.tlpAuto.Controls.Add(this.btnStartHunt, 1, 1);
            this.tlpAuto.Controls.Add(this.tlpDrops, 0, 2);
            this.tlpAuto.Controls.Add(this.lblStatus, 0, 0);
            this.tlpAuto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAuto.Location = new System.Drawing.Point(0, 0);
            this.tlpAuto.Name = "tlpAuto";
            this.tlpAuto.RowCount = 3;
            this.tlpAuto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpAuto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpAuto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAuto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAuto.Size = new System.Drawing.Size(335, 393);
            this.tlpAuto.TabIndex = 18;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.tlpAuto.SetColumnSpan(this.lblStatus, 2);
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(3, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(329, 40);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "Status: [None]";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AutoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpAuto);
            this.MinimumSize = new System.Drawing.Size(335, 393);
            this.Name = "AutoUserControl";
            this.Size = new System.Drawing.Size(335, 393);
            this.cmsDrops.ResumeLayout(false);
            this.cmsQuests.ResumeLayout(false);
            this.tlpQuestsBoosts.ResumeLayout(false);
            this.tlpQuestsBoosts.PerformLayout();
            this.tlpDrops.ResumeLayout(false);
            this.tlpDrops.PerformLayout();
            this.tlpAuto.ResumeLayout(false);
            this.tlpAuto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDrops;
        private System.Windows.Forms.TextBox txtDrop;
        private System.Windows.Forms.Button btnAddDrop;
        private System.Windows.Forms.Button btnStartAttack;
        private System.Windows.Forms.Button btnStartDrops;
        private System.Windows.Forms.Button btnStartBoosts;
        private System.Windows.Forms.Button btnStartHunt;
        private System.Windows.Forms.Button btnAddQuest;
        private System.Windows.Forms.TextBox txtQuest;
        private System.Windows.Forms.ListBox lstQuests;
        private System.Windows.Forms.CheckBox chkClass;
        private System.Windows.Forms.CheckBox chkGold;
        private System.Windows.Forms.CheckBox chkExperience;
        private System.Windows.Forms.CheckBox chkRep;
        private System.Windows.Forms.TableLayoutPanel tlpDrops;
        private System.Windows.Forms.TableLayoutPanel tlpQuestsBoosts;
        private System.Windows.Forms.TableLayoutPanel tlpAuto;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ContextMenuStrip cmsDrops;
        private System.Windows.Forms.ToolStripMenuItem deleteDrops;
        private System.Windows.Forms.ToolStripMenuItem deleteAllDrops;
        private System.Windows.Forms.ContextMenuStrip cmsQuests;
        private System.Windows.Forms.ToolStripMenuItem deleteQuests;
        private System.Windows.Forms.ToolStripMenuItem deleteAllQuests;
    }
}
