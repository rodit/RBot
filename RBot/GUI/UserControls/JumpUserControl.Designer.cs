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
            this.tlpJump = new System.Windows.Forms.TableLayoutPanel();
            this.tlpJump.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnJump
            // 
            this.btnJump.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnJump.Location = new System.Drawing.Point(126, 33);
            this.btnJump.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnJump.Name = "btnJump";
            this.btnJump.Size = new System.Drawing.Size(115, 25);
            this.btnJump.TabIndex = 8;
            this.btnJump.Text = "Jump";
            this.btnJump.UseVisualStyleBackColor = true;
            this.btnJump.Click += new System.EventHandler(this.btnJump_Click);
            // 
            // cbCell
            // 
            this.cbCell.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCell.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCell.FormattingEnabled = true;
            this.cbCell.Location = new System.Drawing.Point(4, 3);
            this.cbCell.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbCell.Name = "cbCell";
            this.cbCell.Size = new System.Drawing.Size(114, 23);
            this.cbCell.TabIndex = 5;
            // 
            // btnGetCurrent
            // 
            this.btnGetCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGetCurrent.Location = new System.Drawing.Point(4, 33);
            this.btnGetCurrent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGetCurrent.Name = "btnGetCurrent";
            this.btnGetCurrent.Size = new System.Drawing.Size(114, 25);
            this.btnGetCurrent.TabIndex = 7;
            this.btnGetCurrent.Text = "Current";
            this.btnGetCurrent.UseVisualStyleBackColor = true;
            this.btnGetCurrent.Click += new System.EventHandler(this.btnGetCurrent_Click);
            // 
            // cbPads
            // 
            this.cbPads.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPads.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPads.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.cbPads.Location = new System.Drawing.Point(126, 3);
            this.cbPads.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbPads.Name = "cbPads";
            this.cbPads.Size = new System.Drawing.Size(115, 23);
            this.cbPads.TabIndex = 6;
            // 
            // tlpJump
            // 
            this.tlpJump.ColumnCount = 2;
            this.tlpJump.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpJump.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpJump.Controls.Add(this.btnJump, 1, 1);
            this.tlpJump.Controls.Add(this.btnGetCurrent, 0, 1);
            this.tlpJump.Controls.Add(this.cbCell, 0, 0);
            this.tlpJump.Controls.Add(this.cbPads, 1, 0);
            this.tlpJump.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpJump.Location = new System.Drawing.Point(0, 0);
            this.tlpJump.Name = "tlpJump";
            this.tlpJump.RowCount = 2;
            this.tlpJump.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpJump.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpJump.Size = new System.Drawing.Size(245, 61);
            this.tlpJump.TabIndex = 9;
            // 
            // JumpUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.tlpJump);
            this.Name = "JumpUserControl";
            this.Size = new System.Drawing.Size(245, 61);
            this.Load += new System.EventHandler(this.JumpUserControl_Load);
            this.tlpJump.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJump;
        private System.Windows.Forms.ComboBox cbCell;
        private System.Windows.Forms.Button btnGetCurrent;
        private System.Windows.Forms.ComboBox cbPads;
        private System.Windows.Forms.TableLayoutPanel tlpJump;
    }
}
