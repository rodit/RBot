﻿namespace RBot
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
            this.btnClearEventHandlers = new System.Windows.Forms.Button();
            this.tlpScripts = new System.Windows.Forms.TableLayoutPanel();
            this.ucScripts = new RBot.ScriptsUserControl();
            this.ucScriptLogs = new RBot.LogsUserControl();
            this.btnReport = new System.Windows.Forms.Button();
            this.tlpScripts.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClearEventHandlers
            // 
            this.btnClearEventHandlers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearEventHandlers.Location = new System.Drawing.Point(3, 345);
            this.btnClearEventHandlers.Name = "btnClearEventHandlers";
            this.btnClearEventHandlers.Size = new System.Drawing.Size(343, 24);
            this.btnClearEventHandlers.TabIndex = 8;
            this.btnClearEventHandlers.Text = "Clear Script Event Handlers";
            this.btnClearEventHandlers.UseVisualStyleBackColor = true;
            this.btnClearEventHandlers.Click += new System.EventHandler(this.btnClearEventHandlers_Click);
            // 
            // tlpScripts
            // 
            this.tlpScripts.ColumnCount = 1;
            this.tlpScripts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpScripts.Controls.Add(this.btnReport, 0, 2);
            this.tlpScripts.Controls.Add(this.ucScripts, 0, 0);
            this.tlpScripts.Controls.Add(this.btnClearEventHandlers, 0, 2);
            this.tlpScripts.Controls.Add(this.ucScriptLogs, 0, 1);
            this.tlpScripts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpScripts.Location = new System.Drawing.Point(0, 0);
            this.tlpScripts.Name = "tlpScripts";
            this.tlpScripts.RowCount = 4;
            this.tlpScripts.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpScripts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpScripts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpScripts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpScripts.Size = new System.Drawing.Size(349, 372);
            this.tlpScripts.TabIndex = 12;
            // 
            // ucScripts
            // 
            this.ucScripts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucScripts.Location = new System.Drawing.Point(3, 3);
            this.ucScripts.Name = "ucScripts";
            this.ucScripts.Size = new System.Drawing.Size(343, 142);
            this.ucScripts.TabIndex = 12;
            // 
            // ucScriptLogs
            // 
            this.ucScriptLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucScriptLogs.Location = new System.Drawing.Point(0, 148);
            this.ucScriptLogs.Margin = new System.Windows.Forms.Padding(0);
            this.ucScriptLogs.Name = "ucScriptLogs";
            this.ucScriptLogs.SetLogType = RBot.LogsUserControl.LogType.ScriptLogs;
            this.ucScriptLogs.Size = new System.Drawing.Size(349, 164);
            this.ucScriptLogs.TabIndex = 13;
            // 
            // btnReport
            // 
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReport.Location = new System.Drawing.Point(3, 315);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(343, 24);
            this.btnReport.TabIndex = 14;
            this.btnReport.Text = "Report/Request Script";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // ScriptsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 372);
            this.Controls.Add(this.tlpScripts);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(365, 386);
            this.Name = "ScriptsForm";
            this.Text = "Scripts";
            this.tlpScripts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClearEventHandlers;
        private System.Windows.Forms.TableLayoutPanel tlpScripts;
        private ScriptsUserControl ucScripts;
        private LogsUserControl ucScriptLogs;
        private System.Windows.Forms.Button btnReport;
    }
}