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
			this.btnSaveDebug = new System.Windows.Forms.Button();
			this.btnClearDebug = new System.Windows.Forms.Button();
			this.txtDebugLog = new System.Windows.Forms.TextBox();
			this.tabScriptLog = new System.Windows.Forms.TabPage();
			this.btnSaveScript = new System.Windows.Forms.Button();
			this.btnClearScript = new System.Windows.Forms.Button();
			this.txtScriptLog = new System.Windows.Forms.TextBox();
			this.tabFlashCalls = new System.Windows.Forms.TabPage();
			this.btnClearFlash = new System.Windows.Forms.Button();
			this.lbFlashCalls = new System.Windows.Forms.ListBox();
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
			this.tabLogs.Name = "tabLogs";
			this.tabLogs.SelectedIndex = 0;
			this.tabLogs.Size = new System.Drawing.Size(434, 335);
			this.tabLogs.TabIndex = 0;
			// 
			// tabDebugLog
			// 
			this.tabDebugLog.Controls.Add(this.btnSaveDebug);
			this.tabDebugLog.Controls.Add(this.btnClearDebug);
			this.tabDebugLog.Controls.Add(this.txtDebugLog);
			this.tabDebugLog.Location = new System.Drawing.Point(4, 22);
			this.tabDebugLog.Name = "tabDebugLog";
			this.tabDebugLog.Size = new System.Drawing.Size(426, 309);
			this.tabDebugLog.TabIndex = 0;
			this.tabDebugLog.Text = "Debug";
			this.tabDebugLog.UseVisualStyleBackColor = true;
			// 
			// btnSaveDebug
			// 
			this.btnSaveDebug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaveDebug.Location = new System.Drawing.Point(3, 283);
			this.btnSaveDebug.Name = "btnSaveDebug";
			this.btnSaveDebug.Size = new System.Drawing.Size(213, 23);
			this.btnSaveDebug.TabIndex = 2;
			this.btnSaveDebug.Text = "Save";
			this.btnSaveDebug.UseVisualStyleBackColor = true;
			this.btnSaveDebug.Click += new System.EventHandler(this.btnSaveDebug_Click);
			// 
			// btnClearDebug
			// 
			this.btnClearDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClearDebug.Location = new System.Drawing.Point(222, 283);
			this.btnClearDebug.Name = "btnClearDebug";
			this.btnClearDebug.Size = new System.Drawing.Size(201, 23);
			this.btnClearDebug.TabIndex = 1;
			this.btnClearDebug.Text = "Clear";
			this.btnClearDebug.UseVisualStyleBackColor = true;
			this.btnClearDebug.Click += new System.EventHandler(this.btnClearDebug_Click);
			// 
			// txtDebugLog
			// 
			this.txtDebugLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDebugLog.Location = new System.Drawing.Point(0, 0);
			this.txtDebugLog.Multiline = true;
			this.txtDebugLog.Name = "txtDebugLog";
			this.txtDebugLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtDebugLog.Size = new System.Drawing.Size(426, 277);
			this.txtDebugLog.TabIndex = 0;
			// 
			// tabScriptLog
			// 
			this.tabScriptLog.Controls.Add(this.btnSaveScript);
			this.tabScriptLog.Controls.Add(this.btnClearScript);
			this.tabScriptLog.Controls.Add(this.txtScriptLog);
			this.tabScriptLog.Location = new System.Drawing.Point(4, 22);
			this.tabScriptLog.Name = "tabScriptLog";
			this.tabScriptLog.Size = new System.Drawing.Size(426, 309);
			this.tabScriptLog.TabIndex = 1;
			this.tabScriptLog.Text = "Script";
			this.tabScriptLog.UseVisualStyleBackColor = true;
			// 
			// btnSaveScript
			// 
			this.btnSaveScript.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaveScript.Location = new System.Drawing.Point(3, 283);
			this.btnSaveScript.Name = "btnSaveScript";
			this.btnSaveScript.Size = new System.Drawing.Size(213, 23);
			this.btnSaveScript.TabIndex = 5;
			this.btnSaveScript.Text = "Save";
			this.btnSaveScript.UseVisualStyleBackColor = true;
			this.btnSaveScript.Click += new System.EventHandler(this.btnSaveScript_Click);
			// 
			// btnClearScript
			// 
			this.btnClearScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClearScript.Location = new System.Drawing.Point(222, 283);
			this.btnClearScript.Name = "btnClearScript";
			this.btnClearScript.Size = new System.Drawing.Size(201, 23);
			this.btnClearScript.TabIndex = 4;
			this.btnClearScript.Text = "Clear";
			this.btnClearScript.UseVisualStyleBackColor = true;
			this.btnClearScript.Click += new System.EventHandler(this.btnClearScript_Click);
			// 
			// txtScriptLog
			// 
			this.txtScriptLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtScriptLog.Location = new System.Drawing.Point(0, 0);
			this.txtScriptLog.Multiline = true;
			this.txtScriptLog.Name = "txtScriptLog";
			this.txtScriptLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtScriptLog.Size = new System.Drawing.Size(426, 277);
			this.txtScriptLog.TabIndex = 3;
			// 
			// tabFlashCalls
			// 
			this.tabFlashCalls.Controls.Add(this.btnClearFlash);
			this.tabFlashCalls.Controls.Add(this.lbFlashCalls);
			this.tabFlashCalls.Location = new System.Drawing.Point(4, 22);
			this.tabFlashCalls.Name = "tabFlashCalls";
			this.tabFlashCalls.Size = new System.Drawing.Size(426, 309);
			this.tabFlashCalls.TabIndex = 2;
			this.tabFlashCalls.Text = "Flash Call Errors";
			this.tabFlashCalls.UseVisualStyleBackColor = true;
			// 
			// btnClearFlash
			// 
			this.btnClearFlash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClearFlash.Location = new System.Drawing.Point(3, 283);
			this.btnClearFlash.Name = "btnClearFlash";
			this.btnClearFlash.Size = new System.Drawing.Size(420, 23);
			this.btnClearFlash.TabIndex = 6;
			this.btnClearFlash.Text = "Clear";
			this.btnClearFlash.UseVisualStyleBackColor = true;
			this.btnClearFlash.Click += new System.EventHandler(this.btnClearFlash_Click);
			// 
			// lbFlashCalls
			// 
			this.lbFlashCalls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbFlashCalls.FormattingEnabled = true;
			this.lbFlashCalls.Location = new System.Drawing.Point(0, 0);
			this.lbFlashCalls.Name = "lbFlashCalls";
			this.lbFlashCalls.Size = new System.Drawing.Size(426, 277);
			this.lbFlashCalls.TabIndex = 0;
			// 
			// LogForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 335);
			this.Controls.Add(this.tabLogs);
			this.Name = "LogForm";
			this.Text = "Logs";
			this.Load += new System.EventHandler(this.LogForm_Load);
			this.tabLogs.ResumeLayout(false);
			this.tabDebugLog.ResumeLayout(false);
			this.tabDebugLog.PerformLayout();
			this.tabScriptLog.ResumeLayout(false);
			this.tabScriptLog.PerformLayout();
			this.tabFlashCalls.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabLogs;
        private System.Windows.Forms.TabPage tabDebugLog;
        private System.Windows.Forms.TabPage tabScriptLog;
        private System.Windows.Forms.TabPage tabFlashCalls;
        private System.Windows.Forms.TextBox txtDebugLog;
        private System.Windows.Forms.Button btnClearDebug;
        private System.Windows.Forms.Button btnSaveDebug;
        private System.Windows.Forms.Button btnSaveScript;
        private System.Windows.Forms.Button btnClearScript;
        private System.Windows.Forms.TextBox txtScriptLog;
        private System.Windows.Forms.ListBox lbFlashCalls;
        private System.Windows.Forms.Button btnClearFlash;
    }
}