namespace RBot
{
    partial class LogForm
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
            this.tabLogs = new System.Windows.Forms.TabControl();
            this.tabDebugLog = new System.Windows.Forms.TabPage();
            this.ucDebugLogs = new RBot.LogsUserControl();
            this.tabScriptLog = new System.Windows.Forms.TabPage();
            this.ucScriptLogs = new RBot.LogsUserControl();
            this.tabFlashCalls = new System.Windows.Forms.TabPage();
            this.ucFlashLogs = new RBot.LogsUserControl();
            this.tabLogs.SuspendLayout();
            this.tabDebugLog.SuspendLayout();
            this.tabScriptLog.SuspendLayout();
            this.tabFlashCalls.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLogs
            // 
            this.tabLogs.Controls.Add(this.tabDebugLog);
            this.tabLogs.Controls.Add(this.tabScriptLog);
            this.tabLogs.Controls.Add(this.tabFlashCalls);
            this.tabLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLogs.Location = new System.Drawing.Point(0, 0);
            this.tabLogs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.SelectedIndex = 0;
            this.tabLogs.Size = new System.Drawing.Size(506, 387);
            this.tabLogs.TabIndex = 0;
            // 
            // tabDebugLog
            // 
            this.tabDebugLog.Controls.Add(this.ucDebugLogs);
            this.tabDebugLog.Location = new System.Drawing.Point(4, 24);
            this.tabDebugLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabDebugLog.Name = "tabDebugLog";
            this.tabDebugLog.Size = new System.Drawing.Size(498, 359);
            this.tabDebugLog.TabIndex = 0;
            this.tabDebugLog.Text = "Debug";
            this.tabDebugLog.UseVisualStyleBackColor = true;
            // 
            // ucDebugLogs
            // 
            this.ucDebugLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDebugLogs.Location = new System.Drawing.Point(0, 0);
            this.ucDebugLogs.Name = "ucDebugLogs";
            this.ucDebugLogs.SetLogType = RBot.LogsUserControl.LogType.DebugLogs;
            this.ucDebugLogs.Size = new System.Drawing.Size(498, 359);
            this.ucDebugLogs.TabIndex = 0;
            // 
            // tabScriptLog
            // 
            this.tabScriptLog.Controls.Add(this.ucScriptLogs);
            this.tabScriptLog.Location = new System.Drawing.Point(4, 24);
            this.tabScriptLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabScriptLog.Name = "tabScriptLog";
            this.tabScriptLog.Size = new System.Drawing.Size(498, 359);
            this.tabScriptLog.TabIndex = 1;
            this.tabScriptLog.Text = "Script";
            this.tabScriptLog.UseVisualStyleBackColor = true;
            // 
            // ucScriptLogs
            // 
            this.ucScriptLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucScriptLogs.Location = new System.Drawing.Point(0, 0);
            this.ucScriptLogs.Name = "ucScriptLogs";
            this.ucScriptLogs.SetLogType = RBot.LogsUserControl.LogType.ScriptLogs;
            this.ucScriptLogs.Size = new System.Drawing.Size(498, 359);
            this.ucScriptLogs.TabIndex = 0;
            // 
            // tabFlashCalls
            // 
            this.tabFlashCalls.Controls.Add(this.ucFlashLogs);
            this.tabFlashCalls.Location = new System.Drawing.Point(4, 24);
            this.tabFlashCalls.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabFlashCalls.Name = "tabFlashCalls";
            this.tabFlashCalls.Size = new System.Drawing.Size(498, 359);
            this.tabFlashCalls.TabIndex = 2;
            this.tabFlashCalls.Text = "Flash Call Errors";
            this.tabFlashCalls.UseVisualStyleBackColor = true;
            // 
            // ucFlashLogs
            // 
            this.ucFlashLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucFlashLogs.Location = new System.Drawing.Point(0, 0);
            this.ucFlashLogs.Name = "ucFlashLogs";
            this.ucFlashLogs.SetLogType = RBot.LogsUserControl.LogType.FlashLogs;
            this.ucFlashLogs.Size = new System.Drawing.Size(498, 359);
            this.ucFlashLogs.TabIndex = 0;
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 387);
            this.Controls.Add(this.tabLogs);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LogForm";
            this.Text = "Logs";
            this.Load += new System.EventHandler(this.LogForm_Load);
            this.tabLogs.ResumeLayout(false);
            this.tabDebugLog.ResumeLayout(false);
            this.tabScriptLog.ResumeLayout(false);
            this.tabFlashCalls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabLogs;
        private System.Windows.Forms.TabPage tabDebugLog;
        private System.Windows.Forms.TabPage tabScriptLog;
        private System.Windows.Forms.TabPage tabFlashCalls;
        private LogsUserControl ucDebugLogs;
        private LogsUserControl ucScriptLogs;
        private LogsUserControl ucFlashLogs;
    }
}