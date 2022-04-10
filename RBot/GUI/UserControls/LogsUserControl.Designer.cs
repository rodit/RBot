
namespace RBot
{
    partial class LogsUserControl
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
            this.components = new System.ComponentModel.Container();
            this.tlpLogs = new System.Windows.Forms.TableLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.cmsLogs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpLogs.SuspendLayout();
            this.cmsLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpLogs
            // 
            this.tlpLogs.ColumnCount = 2;
            this.tlpLogs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLogs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLogs.Controls.Add(this.btnClear, 0, 1);
            this.tlpLogs.Controls.Add(this.btnSave, 1, 1);
            this.tlpLogs.Controls.Add(this.txtLogs, 0, 0);
            this.tlpLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLogs.Location = new System.Drawing.Point(0, 0);
            this.tlpLogs.Name = "tlpLogs";
            this.tlpLogs.RowCount = 2;
            this.tlpLogs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLogs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpLogs.Size = new System.Drawing.Size(260, 273);
            this.tlpLogs.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Location = new System.Drawing.Point(3, 246);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 24);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(133, 246);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 24);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtLogs
            // 
            this.tlpLogs.SetColumnSpan(this.txtLogs, 2);
            this.txtLogs.ContextMenuStrip = this.cmsLogs;
            this.txtLogs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogs.Location = new System.Drawing.Point(3, 3);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLogs.Size = new System.Drawing.Size(254, 237);
            this.txtLogs.TabIndex = 2;
            this.txtLogs.TextChanged += new System.EventHandler(this.txtLogs_TextChanged);
            // 
            // cmsLogs
            // 
            this.cmsLogs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.cmsLogs.Name = "cmsLogs";
            this.cmsLogs.Size = new System.Drawing.Size(102, 48);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LogsUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.tlpLogs);
            this.Name = "LogsUserControl";
            this.Size = new System.Drawing.Size(260, 273);
            this.Load += new System.EventHandler(this.LogsUserControl_Load);
            this.tlpLogs.ResumeLayout(false);
            this.tlpLogs.PerformLayout();
            this.cmsLogs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpLogs;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtLogs;
        private System.Windows.Forms.ContextMenuStrip cmsLogs;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}
