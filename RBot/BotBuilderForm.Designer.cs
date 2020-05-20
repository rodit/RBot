namespace RBot
{
    partial class BotBuilderForm
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
            this.lbCommands = new System.Windows.Forms.ListBox();
            this.cbCommandTypes = new System.Windows.Forms.ComboBox();
            this.btnAddCommand = new System.Windows.Forms.Button();
            this.propCommand = new System.Windows.Forms.PropertyGrid();
            this.builderMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.builderSplit = new System.Windows.Forms.SplitContainer();
            this.btnRemoveCommand = new System.Windows.Forms.Button();
            this.builderMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.builderSplit)).BeginInit();
            this.builderSplit.Panel1.SuspendLayout();
            this.builderSplit.Panel2.SuspendLayout();
            this.builderSplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCommands
            // 
            this.lbCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCommands.FormattingEnabled = true;
            this.lbCommands.Location = new System.Drawing.Point(3, 3);
            this.lbCommands.Name = "lbCommands";
            this.lbCommands.Size = new System.Drawing.Size(316, 290);
            this.lbCommands.TabIndex = 0;
            this.lbCommands.SelectedIndexChanged += new System.EventHandler(this.lbCommands_SelectedIndexChanged);
            // 
            // cbCommandTypes
            // 
            this.cbCommandTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCommandTypes.DisplayMember = "Name";
            this.cbCommandTypes.FormattingEnabled = true;
            this.cbCommandTypes.Location = new System.Drawing.Point(3, 299);
            this.cbCommandTypes.Name = "cbCommandTypes";
            this.cbCommandTypes.Size = new System.Drawing.Size(316, 21);
            this.cbCommandTypes.TabIndex = 1;
            this.cbCommandTypes.ValueMember = "Name";
            // 
            // btnAddCommand
            // 
            this.btnAddCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCommand.Location = new System.Drawing.Point(3, 326);
            this.btnAddCommand.Name = "btnAddCommand";
            this.btnAddCommand.Size = new System.Drawing.Size(316, 23);
            this.btnAddCommand.TabIndex = 2;
            this.btnAddCommand.Text = "Add";
            this.btnAddCommand.UseVisualStyleBackColor = true;
            this.btnAddCommand.Click += new System.EventHandler(this.btnAddCommand_Click);
            // 
            // propCommand
            // 
            this.propCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propCommand.HelpVisible = false;
            this.propCommand.Location = new System.Drawing.Point(0, 0);
            this.propCommand.Name = "propCommand";
            this.propCommand.Size = new System.Drawing.Size(320, 381);
            this.propCommand.TabIndex = 3;
            this.propCommand.ToolbarVisible = false;
            // 
            // builderMenuStrip
            // 
            this.builderMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.builderMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.builderMenuStrip.Name = "builderMenuStrip";
            this.builderMenuStrip.Size = new System.Drawing.Size(646, 24);
            this.builderMenuStrip.TabIndex = 4;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // builderSplit
            // 
            this.builderSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.builderSplit.Location = new System.Drawing.Point(0, 24);
            this.builderSplit.Name = "builderSplit";
            // 
            // builderSplit.Panel1
            // 
            this.builderSplit.Panel1.Controls.Add(this.btnRemoveCommand);
            this.builderSplit.Panel1.Controls.Add(this.cbCommandTypes);
            this.builderSplit.Panel1.Controls.Add(this.btnAddCommand);
            this.builderSplit.Panel1.Controls.Add(this.lbCommands);
            // 
            // builderSplit.Panel2
            // 
            this.builderSplit.Panel2.Controls.Add(this.propCommand);
            this.builderSplit.Size = new System.Drawing.Size(646, 381);
            this.builderSplit.SplitterDistance = 322;
            this.builderSplit.TabIndex = 5;
            // 
            // btnRemoveCommand
            // 
            this.btnRemoveCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveCommand.Location = new System.Drawing.Point(3, 355);
            this.btnRemoveCommand.Name = "btnRemoveCommand";
            this.btnRemoveCommand.Size = new System.Drawing.Size(316, 23);
            this.btnRemoveCommand.TabIndex = 3;
            this.btnRemoveCommand.Text = "Remove";
            this.btnRemoveCommand.UseVisualStyleBackColor = true;
            // 
            // BotBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 405);
            this.Controls.Add(this.builderSplit);
            this.Controls.Add(this.builderMenuStrip);
            this.MainMenuStrip = this.builderMenuStrip;
            this.Name = "BotBuilderForm";
            this.Text = "Bot Builder";
            this.builderMenuStrip.ResumeLayout(false);
            this.builderMenuStrip.PerformLayout();
            this.builderSplit.Panel1.ResumeLayout(false);
            this.builderSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.builderSplit)).EndInit();
            this.builderSplit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCommands;
        private System.Windows.Forms.ComboBox cbCommandTypes;
        private System.Windows.Forms.Button btnAddCommand;
        private System.Windows.Forms.PropertyGrid propCommand;
        private System.Windows.Forms.MenuStrip builderMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.SplitContainer builderSplit;
        private System.Windows.Forms.Button btnRemoveCommand;
    }
}