namespace RBot
{
    partial class HideForm
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
            this.DefaultFormCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsTopMost = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsLockPos = new System.Windows.Forms.ToolStripMenuItem();
            this.DefaultFormCMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // DefaultFormCMS
            // 
            this.DefaultFormCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsTopMost,
            this.cmsLockPos});
            this.DefaultFormCMS.Name = "contextMenuStrip1";
            this.DefaultFormCMS.Size = new System.Drawing.Size(181, 70);
            // 
            // cmsTopMost
            // 
            this.cmsTopMost.CheckOnClick = true;
            this.cmsTopMost.Name = "cmsTopMost";
            this.cmsTopMost.Size = new System.Drawing.Size(180, 22);
            this.cmsTopMost.Text = "Top Most";
            this.cmsTopMost.ToolTipText = "Makes this window the top";
            this.cmsTopMost.Click += new System.EventHandler(this.cmsTopMost_Click);
            // 
            // cmsLockPos
            // 
            this.cmsLockPos.CheckOnClick = true;
            this.cmsLockPos.Name = "cmsLockPos";
            this.cmsLockPos.Size = new System.Drawing.Size(180, 22);
            this.cmsLockPos.Text = "Lock Position";
            this.cmsLockPos.ToolTipText = "Removes the resizing controls.";
            this.cmsLockPos.Click += new System.EventHandler(this.cmsLockPos_Click);
            // 
            // HideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 186);
            this.ContextMenuStrip = this.DefaultFormCMS;
            this.Name = "HideForm";
            this.Text = "HideForm";
            this.DefaultFormCMS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip DefaultFormCMS;
        private System.Windows.Forms.ToolStripMenuItem cmsTopMost;
        private System.Windows.Forms.ToolStripMenuItem cmsLockPos;
    }
}