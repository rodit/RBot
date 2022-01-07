namespace RBot
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsoleForm));
            this.btnRun = new System.Windows.Forms.Button();
            this.chkAsync = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Location = new System.Drawing.Point(73, 187);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(304, 23);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run (Ctrl+Enter)";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // chkAsync
            // 
            this.chkAsync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAsync.AutoSize = true;
            this.chkAsync.Location = new System.Drawing.Point(12, 191);
            this.chkAsync.Name = "chkAsync";
            this.chkAsync.Size = new System.Drawing.Size(55, 17);
            this.chkAsync.TabIndex = 2;
            this.chkAsync.Text = "Async";
            this.chkAsync.UseVisualStyleBackColor = true;
            // 
            // ConsoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 218);
            this.Controls.Add(this.chkAsync);
            this.Controls.Add(this.btnRun);
            this.Name = "ConsoleForm";
            this.ShowIcon = false;
            this.Text = "Run";
            this.Load += new System.EventHandler(this.ConsoleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.CheckBox chkAsync;
    }
}