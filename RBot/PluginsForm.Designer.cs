namespace RBot
{
    partial class PluginsForm
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
            this.lbPlugins = new System.Windows.Forms.ListBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnUnload = new System.Windows.Forms.Button();
            this.propsPluginOpts = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // lbPlugins
            // 
            this.lbPlugins.FormattingEnabled = true;
            this.lbPlugins.Location = new System.Drawing.Point(5, 5);
            this.lbPlugins.Name = "lbPlugins";
            this.lbPlugins.Size = new System.Drawing.Size(205, 199);
            this.lbPlugins.TabIndex = 0;
            this.lbPlugins.SelectedIndexChanged += new System.EventHandler(this.lbPlugins_SelectedIndexChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(5, 209);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnUnload
            // 
            this.btnUnload.Enabled = false;
            this.btnUnload.Location = new System.Drawing.Point(110, 209);
            this.btnUnload.Name = "btnUnload";
            this.btnUnload.Size = new System.Drawing.Size(100, 23);
            this.btnUnload.TabIndex = 2;
            this.btnUnload.Text = "Unload";
            this.btnUnload.UseVisualStyleBackColor = true;
            this.btnUnload.Click += new System.EventHandler(this.btnUnload_Click);
            // 
            // propsPluginOpts
            // 
            this.propsPluginOpts.Location = new System.Drawing.Point(220, 5);
            this.propsPluginOpts.Name = "propsPluginOpts";
            this.propsPluginOpts.Size = new System.Drawing.Size(230, 227);
            this.propsPluginOpts.TabIndex = 4;
            // 
            // PluginsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 236);
            this.Controls.Add(this.propsPluginOpts);
            this.Controls.Add(this.btnUnload);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lbPlugins);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "PluginsForm";
            this.Text = "Plugins";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbPlugins;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnUnload;
        private System.Windows.Forms.PropertyGrid propsPluginOpts;
    }
}