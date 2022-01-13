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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aAAAAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpUserControl1 = new RBot.JumpUserControl();
            this.fastTravelUserControl1 = new RBot.FastTravelUserControl();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aAAAAToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 26);
            // 
            // aAAAAToolStripMenuItem
            // 
            this.aAAAAToolStripMenuItem.Name = "aAAAAToolStripMenuItem";
            this.aAAAAToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.aAAAAToolStripMenuItem.Text = "AAAAA";
            // 
            // jumpUserControl1
            // 
            this.jumpUserControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.jumpUserControl1.Location = new System.Drawing.Point(0, 0);
            this.jumpUserControl1.Name = "jumpUserControl1";
            this.jumpUserControl1.Size = new System.Drawing.Size(244, 61);
            this.jumpUserControl1.TabIndex = 1;
            // 
            // fastTravelUserControl1
            // 
            this.fastTravelUserControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fastTravelUserControl1.Location = new System.Drawing.Point(0, 55);
            this.fastTravelUserControl1.Name = "fastTravelUserControl1";
            this.fastTravelUserControl1.Size = new System.Drawing.Size(244, 220);
            this.fastTravelUserControl1.TabIndex = 2;
            // 
            // JumpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 275);
            this.Controls.Add(this.fastTravelUserControl1);
            this.Controls.Add(this.jumpUserControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "JumpForm";
            this.Text = "Jump";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aAAAAToolStripMenuItem;
        private JumpUserControl jumpUserControl1;
        private FastTravelUserControl fastTravelUserControl1;
    }
}