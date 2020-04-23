namespace RBot
{
    partial class JumpForm
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
            this.cbCell = new System.Windows.Forms.ComboBox();
            this.cbPads = new System.Windows.Forms.ComboBox();
            this.btnJump = new System.Windows.Forms.Button();
            this.btnGetCurrent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbCell
            // 
            this.cbCell.FormattingEnabled = true;
            this.cbCell.Location = new System.Drawing.Point(12, 12);
            this.cbCell.Name = "cbCell";
            this.cbCell.Size = new System.Drawing.Size(138, 21);
            this.cbCell.TabIndex = 0;
            // 
            // cbPads
            // 
            this.cbPads.FormattingEnabled = true;
            this.cbPads.Items.AddRange(new object[] {
            "Spawn",
            "Center",
            "Left",
            "Right",
            "Up",
            "Down",
            "Top",
            "Bottom"});
            this.cbPads.Location = new System.Drawing.Point(156, 12);
            this.cbPads.Name = "cbPads";
            this.cbPads.Size = new System.Drawing.Size(138, 21);
            this.cbPads.TabIndex = 1;
            // 
            // btnJump
            // 
            this.btnJump.Location = new System.Drawing.Point(156, 39);
            this.btnJump.Name = "btnJump";
            this.btnJump.Size = new System.Drawing.Size(138, 23);
            this.btnJump.TabIndex = 2;
            this.btnJump.Text = "Jump";
            this.btnJump.UseVisualStyleBackColor = true;
            this.btnJump.Click += new System.EventHandler(this.btnJump_Click);
            // 
            // btnGetCurrent
            // 
            this.btnGetCurrent.Location = new System.Drawing.Point(12, 39);
            this.btnGetCurrent.Name = "btnGetCurrent";
            this.btnGetCurrent.Size = new System.Drawing.Size(138, 23);
            this.btnGetCurrent.TabIndex = 3;
            this.btnGetCurrent.Text = "Get Current";
            this.btnGetCurrent.UseVisualStyleBackColor = true;
            this.btnGetCurrent.Click += new System.EventHandler(this.btnGetCurrent_Click);
            // 
            // JumpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 73);
            this.Controls.Add(this.btnGetCurrent);
            this.Controls.Add(this.btnJump);
            this.Controls.Add(this.cbPads);
            this.Controls.Add(this.cbCell);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "JumpForm";
            this.Text = "Jump";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCell;
        private System.Windows.Forms.ComboBox cbPads;
        private System.Windows.Forms.Button btnJump;
        private System.Windows.Forms.Button btnGetCurrent;
    }
}