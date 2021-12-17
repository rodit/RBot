namespace RBot
{
    partial class ScriptsForm
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
            this.btnLoadScript = new System.Windows.Forms.Button();
            this.btnEditScript = new System.Windows.Forms.Button();
            this.btnGetScripts = new System.Windows.Forms.Button();
            this.btnStartScript = new System.Windows.Forms.Button();
            this.txtRunOnExit = new System.Windows.Forms.TextBox();
            this.chkRunOnExit = new System.Windows.Forms.CheckBox();
            this.btnClearEventHandlers = new System.Windows.Forms.Button();
            this.btnLogs = new System.Windows.Forms.Button();
            this.txtScriptLog = new System.Windows.Forms.TextBox();
            this.cmsLogs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadScript
            // 
            this.btnLoadScript.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLoadScript.Location = new System.Drawing.Point(5, 12);
            this.btnLoadScript.Name = "btnLoadScript";
            this.btnLoadScript.Size = new System.Drawing.Size(170, 23);
            this.btnLoadScript.TabIndex = 0;
            this.btnLoadScript.Text = "Load Script";
            this.btnLoadScript.UseVisualStyleBackColor = true;
            this.btnLoadScript.Click += new System.EventHandler(this.btnLoadScript_Click);
            // 
            // btnEditScript
            // 
            this.btnEditScript.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditScript.Location = new System.Drawing.Point(5, 41);
            this.btnEditScript.Name = "btnEditScript";
            this.btnEditScript.Size = new System.Drawing.Size(170, 23);
            this.btnEditScript.TabIndex = 1;
            this.btnEditScript.Text = "Edit Script";
            this.btnEditScript.UseVisualStyleBackColor = true;
            this.btnEditScript.Click += new System.EventHandler(this.btnEditScript_Click);
            // 
            // btnGetScripts
            // 
            this.btnGetScripts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGetScripts.Location = new System.Drawing.Point(180, 41);
            this.btnGetScripts.Name = "btnGetScripts";
            this.btnGetScripts.Size = new System.Drawing.Size(115, 23);
            this.btnGetScripts.TabIndex = 2;
            this.btnGetScripts.Text = "Get Scripts";
            this.btnGetScripts.UseVisualStyleBackColor = true;
            this.btnGetScripts.Click += new System.EventHandler(this.btnGetScripts_Click);
            // 
            // btnStartScript
            // 
            this.btnStartScript.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStartScript.Location = new System.Drawing.Point(5, 70);
            this.btnStartScript.Name = "btnStartScript";
            this.btnStartScript.Size = new System.Drawing.Size(290, 23);
            this.btnStartScript.TabIndex = 3;
            this.btnStartScript.Text = "Start Script";
            this.btnStartScript.UseVisualStyleBackColor = true;
            this.btnStartScript.Click += new System.EventHandler(this.btnStartScript_Click);
            // 
            // txtRunOnExit
            // 
            this.txtRunOnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtRunOnExit.Location = new System.Drawing.Point(5, 246);
            this.txtRunOnExit.Name = "txtRunOnExit";
            this.txtRunOnExit.Size = new System.Drawing.Size(205, 20);
            this.txtRunOnExit.TabIndex = 6;
            // 
            // chkRunOnExit
            // 
            this.chkRunOnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkRunOnExit.AutoSize = true;
            this.chkRunOnExit.Location = new System.Drawing.Point(215, 248);
            this.chkRunOnExit.Name = "chkRunOnExit";
            this.chkRunOnExit.Size = new System.Drawing.Size(83, 17);
            this.chkRunOnExit.TabIndex = 7;
            this.chkRunOnExit.Text = "Run On Exit";
            this.chkRunOnExit.UseVisualStyleBackColor = true;
            this.chkRunOnExit.CheckedChanged += new System.EventHandler(this.chkRunOnExit_CheckedChanged);
            // 
            // btnClearEventHandlers
            // 
            this.btnClearEventHandlers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClearEventHandlers.Location = new System.Drawing.Point(5, 272);
            this.btnClearEventHandlers.Name = "btnClearEventHandlers";
            this.btnClearEventHandlers.Size = new System.Drawing.Size(290, 23);
            this.btnClearEventHandlers.TabIndex = 8;
            this.btnClearEventHandlers.Text = "Clear Script Event Handlers";
            this.btnClearEventHandlers.UseVisualStyleBackColor = true;
            this.btnClearEventHandlers.Click += new System.EventHandler(this.btnClearEventHandlers_Click);
            // 
            // btnLogs
            // 
            this.btnLogs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogs.Location = new System.Drawing.Point(180, 12);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(115, 23);
            this.btnLogs.TabIndex = 10;
            this.btnLogs.Text = "Open Logs";
            this.btnLogs.UseVisualStyleBackColor = true;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // txtScriptLog
            // 
            this.txtScriptLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScriptLog.ContextMenuStrip = this.cmsLogs;
            this.txtScriptLog.Location = new System.Drawing.Point(5, 99);
            this.txtScriptLog.Multiline = true;
            this.txtScriptLog.Name = "txtScriptLog";
            this.txtScriptLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtScriptLog.Size = new System.Drawing.Size(290, 141);
            this.txtScriptLog.TabIndex = 11;
            // 
            // cmsLogs
            // 
            this.cmsLogs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.cmsLogs.Name = "cmsLogs";
            this.cmsLogs.Size = new System.Drawing.Size(102, 48);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.ClearLogs);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveLogs);
            // 
            // ScriptsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 301);
            this.Controls.Add(this.txtScriptLog);
            this.Controls.Add(this.btnLogs);
            this.Controls.Add(this.btnClearEventHandlers);
            this.Controls.Add(this.chkRunOnExit);
            this.Controls.Add(this.txtRunOnExit);
            this.Controls.Add(this.btnStartScript);
            this.Controls.Add(this.btnGetScripts);
            this.Controls.Add(this.btnEditScript);
            this.Controls.Add(this.btnLoadScript);
            this.MinimumSize = new System.Drawing.Size(315, 340);
            this.Name = "ScriptsForm";
            this.Text = "Scripts";
            this.cmsLogs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEditScript;
        private System.Windows.Forms.Button btnGetScripts;
        private System.Windows.Forms.TextBox txtRunOnExit;
        private System.Windows.Forms.CheckBox chkRunOnExit;
        private System.Windows.Forms.Button btnClearEventHandlers;
        public System.Windows.Forms.Button btnLoadScript;
        public System.Windows.Forms.Button btnStartScript;
		private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.TextBox txtScriptLog;
        private System.Windows.Forms.ContextMenuStrip cmsLogs;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}