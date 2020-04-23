namespace RBot
{
    partial class GenericOptionsForm
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
            this.propOptions = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // propOptions
            // 
            this.propOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propOptions.Location = new System.Drawing.Point(0, 0);
            this.propOptions.Name = "propOptions";
            this.propOptions.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.propOptions.Size = new System.Drawing.Size(463, 353);
            this.propOptions.TabIndex = 0;
            // 
            // GenericOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 353);
            this.Controls.Add(this.propOptions);
            this.Name = "GenericOptionsForm";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.GenericOptionsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propOptions;
    }
}