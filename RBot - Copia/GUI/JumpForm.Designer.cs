﻿namespace RBot
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
            this.ucJump = new RBot.JumpUserControl();
            this.ucFastTravel = new RBot.FastTravelUserControl();
            this.tlpJump = new System.Windows.Forms.TableLayoutPanel();
            this.tlpJump.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucJump
            // 
            this.ucJump.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucJump.Location = new System.Drawing.Point(3, 3);
            this.ucJump.Name = "ucJump";
            this.ucJump.Size = new System.Drawing.Size(251, 61);
            this.ucJump.TabIndex = 1;
            // 
            // ucFastTravel
            // 
            this.ucFastTravel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tlpJump.Controls.Add(this.ucJump, 0, 0);
            this.tlpJump.Controls.Add(this.ucFastTravel, 0, 1);
            this.tlpJump.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpJump.Location = new System.Drawing.Point(0, 0);
            this.tlpJump.Name = "tlpJump";
            this.tlpJump.RowCount = 2;
            this.tlpJump.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpJump.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpJump.Size = new System.Drawing.Size(257, 308);
            this.tlpJump.TabIndex = 3;
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
        private JumpUserControl ucJump;
        private FastTravelUserControl ucFastTravel;
        private System.Windows.Forms.TableLayoutPanel tlpJump;
    }
}