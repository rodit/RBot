namespace RBot
{
    partial class JumpUserControl
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
            this.btnJump = new System.Windows.Forms.Button();
            this.cbCell = new System.Windows.Forms.ComboBox();
            this.btnGetCurrent = new System.Windows.Forms.Button();
            this.cbPads = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnJump
            // 
            this.btnJump.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJump.Location = new System.Drawing.Point(125, 32);
            this.btnJump.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnJump.Name = "btnJump";
            this.btnJump.Size = new System.Drawing.Size(115, 23);
            this.btnJump.TabIndex = 8;
            this.btnJump.Text = "Jump";
            this.btnJump.UseVisualStyleBackColor = true;
            this.btnJump.Click += new System.EventHandler(this.btnJump_Click);
            // 
            // cbCell
            // 
            this.cbCell.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCell.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCell.FormattingEnabled = true;
            this.cbCell.Location = new System.Drawing.Point(5, 5);
            this.cbCell.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbCell.Name = "cbCell";
            this.cbCell.Size = new System.Drawing.Size(115, 23);
            this.cbCell.TabIndex = 5;
            // 
            // btnGetCurrent
            // 
            this.btnGetCurrent.Location = new System.Drawing.Point(5, 32);
            this.btnGetCurrent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGetCurrent.Name = "btnGetCurrent";
            this.btnGetCurrent.Size = new System.Drawing.Size(115, 23);
            this.btnGetCurrent.TabIndex = 7;
            this.btnGetCurrent.Text = "Current";
            this.btnGetCurrent.UseVisualStyleBackColor = true;
            this.btnGetCurrent.Click += new System.EventHandler(this.btnGetCurrent_Click);
            // 
            // cbPads
            // 
            this.cbPads.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPads.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPads.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
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
            this.cbPads.Location = new System.Drawing.Point(125, 5);
            this.cbPads.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbPads.Name = "cbPads";
            this.cbPads.Size = new System.Drawing.Size(115, 23);
            this.cbPads.TabIndex = 6;
            // 
            // JumpUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnJump);
            this.Controls.Add(this.cbCell);
            this.Controls.Add(this.btnGetCurrent);
            this.Controls.Add(this.cbPads);
            this.Name = "JumpUserControl";
            this.Size = new System.Drawing.Size(245, 61);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJump;
        private System.Windows.Forms.ComboBox cbCell;
        private System.Windows.Forms.Button btnGetCurrent;
        private System.Windows.Forms.ComboBox cbPads;
    }
}
