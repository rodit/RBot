﻿namespace RBot
{
    partial class ConsoleForm
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
            this.btnRun = new System.Windows.Forms.Button();
            this.chkAsync = new System.Windows.Forms.CheckBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.tlpConsole = new System.Windows.Forms.TableLayoutPanel();
            this.tlpConsole.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRun.Location = new System.Drawing.Point(70, 225);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(380, 24);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run (Ctrl+Enter)";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // chkAsync
            // 
            this.chkAsync.AutoSize = true;
            this.chkAsync.Checked = true;
            this.chkAsync.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAsync.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkAsync.Location = new System.Drawing.Point(4, 225);
            this.chkAsync.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkAsync.Name = "chkAsync";
            this.chkAsync.Size = new System.Drawing.Size(58, 24);
            this.chkAsync.TabIndex = 2;
            this.chkAsync.Text = "Async";
            this.chkAsync.UseVisualStyleBackColor = true;
            // 
            // txtCode
            // 
            this.txtCode.AcceptsReturn = true;
            this.txtCode.AcceptsTab = true;
            this.tlpConsole.SetColumnSpan(this.txtCode, 2);
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCode.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCode.Location = new System.Drawing.Point(3, 3);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(448, 216);
            this.txtCode.TabIndex = 3;
            this.txtCode.Text = "bot.Log(\"Test\");";
            // 
            // tlpConsole
            // 
            this.tlpConsole.ColumnCount = 2;
            this.tlpConsole.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpConsole.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpConsole.Controls.Add(this.txtCode, 0, 0);
            this.tlpConsole.Controls.Add(this.btnRun, 1, 1);
            this.tlpConsole.Controls.Add(this.chkAsync, 0, 1);
            this.tlpConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpConsole.Location = new System.Drawing.Point(0, 0);
            this.tlpConsole.Name = "tlpConsole";
            this.tlpConsole.RowCount = 2;
            this.tlpConsole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpConsole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpConsole.Size = new System.Drawing.Size(454, 252);
            this.tlpConsole.TabIndex = 4;
            // 
            // ConsoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 252);
            this.Controls.Add(this.tlpConsole);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ConsoleForm";
            this.ShowIcon = false;
            this.Text = "Run";
            this.tlpConsole.ResumeLayout(false);
            this.tlpConsole.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.CheckBox chkAsync;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TableLayoutPanel tlpConsole;
    }
}