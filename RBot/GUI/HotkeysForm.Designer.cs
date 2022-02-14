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
            this.tlpHotKeys = new System.Windows.Forms.TableLayoutPanel();
            this.btnConsole = new System.Windows.Forms.Button();
            this.lblConsole = new System.Windows.Forms.Label();
            this.lblToggleAtk = new System.Windows.Forms.Label();
            this.lblToggleHunt = new System.Windows.Forms.Label();
            this.btnToggleAtk = new System.Windows.Forms.Button();
            this.btnToggleHunt = new System.Windows.Forms.Button();
            this.lblOpenBank = new System.Windows.Forms.Label();
            this.btnOpenBank = new System.Windows.Forms.Button();
            this.tlpHotKeys.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStop
            // 
            this.lblStop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStop.AutoSize = true;
            this.lblStop.Location = new System.Drawing.Point(4, 0);
            this.lblStop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(117, 36);
            this.lblStop.TabIndex = 0;
            this.lblStop.Text = "Start Script:";
            this.lblStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnHKStartScript
            // 
            this.btnHKStartScript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHKStartScript.Location = new System.Drawing.Point(129, 3);
            this.btnHKStartScript.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHKStartScript.Name = "btnHKStartScript";
            this.btnHKStartScript.Size = new System.Drawing.Size(118, 30);
            this.btnHKStartScript.TabIndex = 1;
            this.btnHKStartScript.Tag = "start";
            this.btnHKStartScript.UseVisualStyleBackColor = true;
            // 
            // btnHKStopScript
            // 
            this.btnHKStopScript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHKStopScript.Location = new System.Drawing.Point(129, 39);
            this.btnHKStopScript.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHKStopScript.Name = "btnHKStopScript";
            this.btnHKStopScript.Size = new System.Drawing.Size(118, 30);
            this.btnHKStopScript.TabIndex = 3;
            this.btnHKStopScript.Tag = "stop";
            this.btnHKStopScript.UseVisualStyleBackColor = true;
            // 
            // lblStart
            // 
            this.lblStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(4, 36);
            this.lblStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(117, 36);
            this.lblStart.TabIndex = 2;
            this.lblStart.Text = "Stop Script:";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnHKToggle
            // 
            this.btnHKToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHKToggle.Location = new System.Drawing.Point(129, 75);
            this.btnHKToggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHKToggle.Name = "btnHKToggle";
            this.btnHKToggle.Size = new System.Drawing.Size(118, 30);
            this.btnHKToggle.TabIndex = 5;
            this.btnHKToggle.Tag = "toggle";
            this.btnHKToggle.UseVisualStyleBackColor = true;
            // 
            // lblToggle
            // 
            this.lblToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToggle.AutoSize = true;
            this.lblToggle.Location = new System.Drawing.Point(4, 72);
            this.lblToggle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToggle.Name = "lblToggle";
            this.lblToggle.Size = new System.Drawing.Size(117, 36);
            this.lblToggle.TabIndex = 4;
            this.lblToggle.Text = "Toggle Script:";
            this.lblToggle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnHKLoad
            // 
            this.btnHKLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHKLoad.Location = new System.Drawing.Point(129, 111);
            this.btnHKLoad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHKLoad.Name = "btnHKLoad";
            this.btnHKLoad.Size = new System.Drawing.Size(118, 30);
            this.btnHKLoad.TabIndex = 7;
            this.btnHKLoad.Tag = "load";
            this.btnHKLoad.UseVisualStyleBackColor = true;
            // 
            // lblLoadScript
            // 
            this.lblLoadScript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoadScript.AutoSize = true;
            this.lblLoadScript.Location = new System.Drawing.Point(4, 108);
            this.lblLoadScript.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoadScript.Name = "lblLoadScript";
            this.lblLoadScript.Size = new System.Drawing.Size(117, 36);
            this.lblLoadScript.TabIndex = 6;
            this.lblLoadScript.Text = "Load Script:";
            this.lblLoadScript.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpHotKeys.SetColumnSpan(this.btnClose, 2);
            this.btnClose.Location = new System.Drawing.Point(4, 291);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(243, 29);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tlpHotKeys
            // 
            this.tlpHotKeys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpHotKeys.ColumnCount = 2;
            this.tlpHotKeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHotKeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHotKeys.Controls.Add(this.btnOpenBank, 1, 7);
            this.tlpHotKeys.Controls.Add(this.lblOpenBank, 0, 7);
            this.tlpHotKeys.Controls.Add(this.btnClose, 0, 8);
            this.tlpHotKeys.Controls.Add(this.btnHKStartScript, 1, 0);
            this.tlpHotKeys.Controls.Add(this.btnHKLoad, 1, 3);
            this.tlpHotKeys.Controls.Add(this.lblStart, 0, 1);
            this.tlpHotKeys.Controls.Add(this.btnHKStopScript, 1, 1);
            this.tlpHotKeys.Controls.Add(this.btnHKToggle, 1, 2);
            this.tlpHotKeys.Controls.Add(this.lblToggle, 0, 2);
            this.tlpHotKeys.Controls.Add(this.lblLoadScript, 0, 3);
            this.tlpHotKeys.Controls.Add(this.lblStop, 0, 0);
            this.tlpHotKeys.Controls.Add(this.lblToggleAtk, 0, 4);
            this.tlpHotKeys.Controls.Add(this.btnToggleAtk, 1, 4);
            this.tlpHotKeys.Controls.Add(this.btnToggleHunt, 1, 5);
            this.tlpHotKeys.Controls.Add(this.btnConsole, 1, 6);
            this.tlpHotKeys.Controls.Add(this.lblToggleHunt, 0, 5);
            this.tlpHotKeys.Controls.Add(this.lblConsole, 0, 6);
            this.tlpHotKeys.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpHotKeys.Location = new System.Drawing.Point(0, 0);
            this.tlpHotKeys.Name = "tlpHotKeys";
            this.tlpHotKeys.RowCount = 9;
            this.tlpHotKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpHotKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpHotKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpHotKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpHotKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpHotKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpHotKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpHotKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpHotKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpHotKeys.Size = new System.Drawing.Size(251, 323);
            this.tlpHotKeys.TabIndex = 9;
            // 
            // btnConsole
            // 
            this.btnConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsole.Location = new System.Drawing.Point(129, 219);
            this.btnConsole.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConsole.Name = "btnConsole";
            this.btnConsole.Size = new System.Drawing.Size(118, 30);
            this.btnConsole.TabIndex = 10;
            this.btnConsole.Tag = "console";
            this.btnConsole.UseVisualStyleBackColor = true;
            // 
            // lblConsole
            // 
            this.lblConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConsole.AutoSize = true;
            this.lblConsole.Location = new System.Drawing.Point(4, 216);
            this.lblConsole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsole.Name = "lblConsole";
            this.lblConsole.Size = new System.Drawing.Size(117, 36);
            this.lblConsole.TabIndex = 9;
            this.lblConsole.Text = "Open Console:";
            this.lblConsole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblToggleAtk
            // 
            this.lblToggleAtk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToggleAtk.AutoSize = true;
            this.lblToggleAtk.Location = new System.Drawing.Point(4, 144);
            this.lblToggleAtk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToggleAtk.Name = "lblToggleAtk";
            this.lblToggleAtk.Size = new System.Drawing.Size(117, 36);
            this.lblToggleAtk.TabIndex = 11;
            this.lblToggleAtk.Text = "Toggle Auto Attack:";
            this.lblToggleAtk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblToggleHunt
            // 
            this.lblToggleHunt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToggleHunt.AutoSize = true;
            this.lblToggleHunt.Location = new System.Drawing.Point(4, 180);
            this.lblToggleHunt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToggleHunt.Name = "lblToggleHunt";
            this.lblToggleHunt.Size = new System.Drawing.Size(117, 36);
            this.lblToggleHunt.TabIndex = 12;
            this.lblToggleHunt.Text = "Toggle Auto Hunt:";
            this.lblToggleHunt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnToggleAtk
            // 
            this.btnToggleAtk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToggleAtk.Location = new System.Drawing.Point(129, 147);
            this.btnToggleAtk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnToggleAtk.Name = "btnToggleAtk";
            this.btnToggleAtk.Size = new System.Drawing.Size(118, 30);
            this.btnToggleAtk.TabIndex = 13;
            this.btnToggleAtk.Tag = "attack";
            this.btnToggleAtk.UseVisualStyleBackColor = true;
            // 
            // btnToggleHunt
            // 
            this.btnToggleHunt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToggleHunt.Location = new System.Drawing.Point(129, 183);
            this.btnToggleHunt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnToggleHunt.Name = "btnToggleHunt";
            this.btnToggleHunt.Size = new System.Drawing.Size(118, 30);
            this.btnToggleHunt.TabIndex = 14;
            this.btnToggleHunt.Tag = "hunt";
            this.btnToggleHunt.UseVisualStyleBackColor = true;
            // 
            // lblOpenBank
            // 
            this.lblOpenBank.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOpenBank.AutoSize = true;
            this.lblOpenBank.Location = new System.Drawing.Point(4, 252);
            this.lblOpenBank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpenBank.Name = "lblOpenBank";
            this.lblOpenBank.Size = new System.Drawing.Size(117, 36);
            this.lblOpenBank.TabIndex = 15;
            this.lblOpenBank.Text = "Open Bank:";
            this.lblOpenBank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOpenBank
            // 
            this.btnOpenBank.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenBank.Location = new System.Drawing.Point(129, 255);
            this.btnOpenBank.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOpenBank.Name = "btnOpenBank";
            this.btnOpenBank.Size = new System.Drawing.Size(118, 30);
            this.btnOpenBank.TabIndex = 16;
            this.btnOpenBank.Tag = "bank";
            this.btnOpenBank.UseVisualStyleBackColor = true;
            // 
            // HotkeysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 323);
            this.Controls.Add(this.tlpHotKeys);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "HotkeysForm";
            this.Text = "Hotkeys";
            this.tlpHotKeys.ResumeLayout(false);
            this.tlpHotKeys.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tlpHotKeys;
        private System.Windows.Forms.Button btnConsole;
        private System.Windows.Forms.Label lblConsole;
        private System.Windows.Forms.Button btnToggleHunt;
        private System.Windows.Forms.Button btnToggleAtk;
        private System.Windows.Forms.Label lblToggleAtk;
        private System.Windows.Forms.Label lblToggleHunt;
        private System.Windows.Forms.Button btnOpenBank;
        private System.Windows.Forms.Label lblOpenBank;
    }
}