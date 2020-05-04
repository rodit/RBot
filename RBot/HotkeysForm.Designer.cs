namespace RBot
{
    partial class HotkeysForm
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
            this.lblStop = new System.Windows.Forms.Label();
            this.btnHKStartScript = new System.Windows.Forms.Button();
            this.btnHKStopScript = new System.Windows.Forms.Button();
            this.lblStart = new System.Windows.Forms.Label();
            this.btnHKToggle = new System.Windows.Forms.Button();
            this.lblToggle = new System.Windows.Forms.Label();
            this.btnHKLoad = new System.Windows.Forms.Button();
            this.lblLoadScript = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStop
            // 
            this.lblStop.AutoSize = true;
            this.lblStop.Location = new System.Drawing.Point(23, 17);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(62, 13);
            this.lblStop.TabIndex = 0;
            this.lblStop.Text = "Start Script:";
            // 
            // btnHKStartScript
            // 
            this.btnHKStartScript.Location = new System.Drawing.Point(91, 12);
            this.btnHKStartScript.Name = "btnHKStartScript";
            this.btnHKStartScript.Size = new System.Drawing.Size(65, 23);
            this.btnHKStartScript.TabIndex = 1;
            this.btnHKStartScript.Tag = "start";
            this.btnHKStartScript.UseVisualStyleBackColor = true;
            // 
            // btnHKStopScript
            // 
            this.btnHKStopScript.Location = new System.Drawing.Point(91, 41);
            this.btnHKStopScript.Name = "btnHKStopScript";
            this.btnHKStopScript.Size = new System.Drawing.Size(65, 23);
            this.btnHKStopScript.TabIndex = 3;
            this.btnHKStopScript.Tag = "stop";
            this.btnHKStopScript.UseVisualStyleBackColor = true;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(23, 46);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(62, 13);
            this.lblStart.TabIndex = 2;
            this.lblStart.Text = "Stop Script:";
            // 
            // btnHKToggle
            // 
            this.btnHKToggle.Location = new System.Drawing.Point(91, 70);
            this.btnHKToggle.Name = "btnHKToggle";
            this.btnHKToggle.Size = new System.Drawing.Size(65, 23);
            this.btnHKToggle.TabIndex = 5;
            this.btnHKToggle.Tag = "toggle";
            this.btnHKToggle.UseVisualStyleBackColor = true;
            // 
            // lblToggle
            // 
            this.lblToggle.AutoSize = true;
            this.lblToggle.Location = new System.Drawing.Point(12, 75);
            this.lblToggle.Name = "lblToggle";
            this.lblToggle.Size = new System.Drawing.Size(73, 13);
            this.lblToggle.TabIndex = 4;
            this.lblToggle.Text = "Toggle Script:";
            // 
            // btnHKLoad
            // 
            this.btnHKLoad.Location = new System.Drawing.Point(91, 99);
            this.btnHKLoad.Name = "btnHKLoad";
            this.btnHKLoad.Size = new System.Drawing.Size(65, 23);
            this.btnHKLoad.TabIndex = 7;
            this.btnHKLoad.Tag = "toggle";
            this.btnHKLoad.UseVisualStyleBackColor = true;
            // 
            // lblLoadScript
            // 
            this.lblLoadScript.AutoSize = true;
            this.lblLoadScript.Location = new System.Drawing.Point(21, 104);
            this.lblLoadScript.Name = "lblLoadScript";
            this.lblLoadScript.Size = new System.Drawing.Size(64, 13);
            this.lblLoadScript.TabIndex = 6;
            this.lblLoadScript.Text = "Load Script:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 128);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // HotkeysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 161);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnHKLoad);
            this.Controls.Add(this.lblLoadScript);
            this.Controls.Add(this.btnHKToggle);
            this.Controls.Add(this.lblToggle);
            this.Controls.Add(this.btnHKStopScript);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.btnHKStartScript);
            this.Controls.Add(this.lblStop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "HotkeysForm";
            this.Text = "Hotkeys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStop;
        private System.Windows.Forms.Button btnHKStartScript;
        private System.Windows.Forms.Button btnHKStopScript;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Button btnHKToggle;
        private System.Windows.Forms.Label lblToggle;
        private System.Windows.Forms.Button btnHKLoad;
        private System.Windows.Forms.Label lblLoadScript;
        private System.Windows.Forms.Button btnClose;
    }
}