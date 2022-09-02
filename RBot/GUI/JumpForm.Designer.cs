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
            this.ucFastTravel = new RBot.FastTravelUserControl();
            this.tlpJump = new System.Windows.Forms.TableLayoutPanel();
            this.ucJump = new RBot.JumpUserControl();
            this.tlpJump.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucFastTravel
            // 
            this.ucFastTravel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucFastTravel.Location = new System.Drawing.Point(3, 70);
            this.ucFastTravel.MinimumSize = new System.Drawing.Size(245, 239);
            this.ucFastTravel.Name = "ucFastTravel";
            this.ucFastTravel.Size = new System.Drawing.Size(251, 239);
            this.ucFastTravel.TabIndex = 2;
            // 
            // tlpJump
            // 
            this.tlpJump.ColumnCount = 1;
            this.tlpJump.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpJump.Controls.Add(this.ucFastTravel, 0, 1);
            this.tlpJump.Controls.Add(this.ucJump, 0, 0);
            this.tlpJump.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpJump.Location = new System.Drawing.Point(0, 0);
            this.tlpJump.Name = "tlpJump";
            this.tlpJump.RowCount = 2;
            this.tlpJump.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tlpJump.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78F));
            this.tlpJump.Size = new System.Drawing.Size(257, 308);
            this.tlpJump.TabIndex = 3;
            // 
            // ucJump
            // 
            this.ucJump.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucJump.Location = new System.Drawing.Point(3, 3);
            this.ucJump.Name = "ucJump";
            this.ucJump.Size = new System.Drawing.Size(251, 61);
            this.ucJump.TabIndex = 3;
            // 
            // JumpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 308);
            this.Controls.Add(this.tlpJump);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(273, 347);
            this.Name = "JumpForm";
            this.Text = "Jump";
            this.tlpJump.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FastTravelUserControl ucFastTravel;
        private System.Windows.Forms.TableLayoutPanel tlpJump;
        private JumpUserControl ucJump;
    }
}