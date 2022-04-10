
namespace RBot
{
    partial class ScriptsUserControl
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
            this.btnLogs = new System.Windows.Forms.Button();
            this.btnStartScript = new System.Windows.Forms.Button();
            this.btnGetScripts = new System.Windows.Forms.Button();
            this.btnEditScript = new System.Windows.Forms.Button();
            this.btnLoadScript = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblScriptName = new System.Windows.Forms.Label();
            this.ScriptsTT = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogs
            // 
            this.btnLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogs.Location = new System.Drawing.Point(133, 49);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(124, 24);
            this.btnLogs.TabIndex = 15;
            this.btnLogs.Text = "Open Logs";
            this.btnLogs.UseVisualStyleBackColor = true;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // btnStartScript
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnStartScript, 2);
            this.btnStartScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartScript.Location = new System.Drawing.Point(3, 109);
            this.btnStartScript.Name = "btnStartScript";
            this.btnStartScript.Size = new System.Drawing.Size(254, 31);
            this.btnStartScript.TabIndex = 14;
            this.btnStartScript.Text = "Start Script";
            this.btnStartScript.UseVisualStyleBackColor = true;
            this.btnStartScript.Click += new System.EventHandler(this.btnStartScript_Click);
            // 
            // btnGetScripts
            // 
            this.btnGetScripts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGetScripts.Location = new System.Drawing.Point(133, 79);
            this.btnGetScripts.Name = "btnGetScripts";
            this.btnGetScripts.Size = new System.Drawing.Size(124, 24);
            this.btnGetScripts.TabIndex = 13;
            this.btnGetScripts.Text = "Get Scripts";
            this.btnGetScripts.UseVisualStyleBackColor = true;
            this.btnGetScripts.Click += new System.EventHandler(this.btnGetScripts_Click);
            // 
            // btnEditScript
            // 
            this.btnEditScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditScript.Location = new System.Drawing.Point(3, 79);
            this.btnEditScript.Name = "btnEditScript";
            this.btnEditScript.Size = new System.Drawing.Size(124, 24);
            this.btnEditScript.TabIndex = 12;
            this.btnEditScript.Text = "Edit Script";
            this.btnEditScript.UseVisualStyleBackColor = true;
            this.btnEditScript.Click += new System.EventHandler(this.btnEditScript_Click);
            // 
            // btnLoadScript
            // 
            this.btnLoadScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadScript.Location = new System.Drawing.Point(3, 49);
            this.btnLoadScript.Name = "btnLoadScript";
            this.btnLoadScript.Size = new System.Drawing.Size(124, 24);
            this.btnLoadScript.TabIndex = 11;
            this.btnLoadScript.Text = "Load Script";
            this.btnLoadScript.UseVisualStyleBackColor = true;
            this.btnLoadScript.Click += new System.EventHandler(this.btnLoadScript_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnLogs, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnGetScripts, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnEditScript, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnLoadScript, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnStartScript, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblStatus, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblScriptName, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 143);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // lblStatus
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lblStatus, 2);
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(3, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(254, 23);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "Status: [No script]";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScriptName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lblScriptName, 2);
            this.lblScriptName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScriptName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScriptName.Location = new System.Drawing.Point(3, 23);
            this.lblScriptName.Name = "lblScriptName";
            this.lblScriptName.Size = new System.Drawing.Size(254, 23);
            this.lblScriptName.TabIndex = 17;
            this.lblScriptName.Text = "Script Name";
            this.lblScriptName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScriptsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ScriptsUserControl";
            this.Size = new System.Drawing.Size(260, 143);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogs;
        public System.Windows.Forms.Button btnStartScript;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnGetScripts;
        private System.Windows.Forms.Button btnEditScript;
        public System.Windows.Forms.Button btnLoadScript;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblScriptName;
        private System.Windows.Forms.ToolTip ScriptsTT;
    }
}
