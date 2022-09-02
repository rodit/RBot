namespace RBot
{
    partial class PromptDialog
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
            this.tlpDialogPrompt = new System.Windows.Forms.TableLayoutPanel();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            this.tlpDialogPrompt.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpDialogPrompt
            // 
            this.tlpDialogPrompt.ColumnCount = 2;
            this.tlpDialogPrompt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDialogPrompt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDialogPrompt.Controls.Add(this.txtInput, 0, 1);
            this.tlpDialogPrompt.Controls.Add(this.btnCancel, 0, 2);
            this.tlpDialogPrompt.Controls.Add(this.btnConfirm, 1, 2);
            this.tlpDialogPrompt.Controls.Add(this.lblHint, 0, 0);
            this.tlpDialogPrompt.Location = new System.Drawing.Point(0, 0);
            this.tlpDialogPrompt.Name = "tlpDialogPrompt";
            this.tlpDialogPrompt.RowCount = 3;
            this.tlpDialogPrompt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpDialogPrompt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpDialogPrompt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpDialogPrompt.Size = new System.Drawing.Size(250, 90);
            this.tlpDialogPrompt.TabIndex = 0;
            // 
            // txtInput
            // 
            this.tlpDialogPrompt.SetColumnSpan(this.txtInput, 2);
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Location = new System.Drawing.Point(3, 33);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(244, 23);
            this.txtInput.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(3, 63);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 24);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfirm.Location = new System.Drawing.Point(128, 63);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(119, 24);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.tlpDialogPrompt.SetColumnSpan(this.lblHint, 2);
            this.lblHint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHint.Location = new System.Drawing.Point(3, 0);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(244, 30);
            this.lblHint.TabIndex = 4;
            this.lblHint.Text = "Hint placeholder text.";
            this.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PromptDialog
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(250, 90);
            this.Controls.Add(this.tlpDialogPrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PromptDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prompt";
            this.tlpDialogPrompt.ResumeLayout(false);
            this.tlpDialogPrompt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpDialogPrompt;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblHint;
    }
}