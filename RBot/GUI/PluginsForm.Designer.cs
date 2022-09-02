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
            this.tlpPlugins = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPlugins.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPlugins
            // 
            this.tlpPlugins.SetColumnSpan(this.lbPlugins, 2);
            this.lbPlugins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPlugins.FormattingEnabled = true;
            this.lbPlugins.ItemHeight = 15;
            this.lbPlugins.Location = new System.Drawing.Point(4, 3);
            this.lbPlugins.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbPlugins.Name = "lbPlugins";
            this.lbPlugins.Size = new System.Drawing.Size(226, 231);
            this.lbPlugins.TabIndex = 0;
            this.lbPlugins.SelectedIndexChanged += new System.EventHandler(this.lbPlugins_SelectedIndexChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoad.Location = new System.Drawing.Point(4, 240);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(109, 24);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnUnload
            // 
            this.btnUnload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUnload.Enabled = false;
            this.btnUnload.Location = new System.Drawing.Point(121, 240);
            this.btnUnload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUnload.Name = "btnUnload";
            this.btnUnload.Size = new System.Drawing.Size(109, 24);
            this.btnUnload.TabIndex = 2;
            this.btnUnload.Text = "Unload";
            this.btnUnload.UseVisualStyleBackColor = true;
            this.btnUnload.Click += new System.EventHandler(this.btnUnload_Click);
            // 
            // propsPluginOpts
            // 
            this.propsPluginOpts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propsPluginOpts.Location = new System.Drawing.Point(238, 3);
            this.propsPluginOpts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.propsPluginOpts.Name = "propsPluginOpts";
            this.tlpPlugins.SetRowSpan(this.propsPluginOpts, 2);
            this.propsPluginOpts.Size = new System.Drawing.Size(226, 261);
            this.propsPluginOpts.TabIndex = 4;
            // 
            // tlpPlugins
            // 
            this.tlpPlugins.ColumnCount = 3;
            this.tlpPlugins.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPlugins.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPlugins.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlugins.Controls.Add(this.lbPlugins, 0, 0);
            this.tlpPlugins.Controls.Add(this.btnUnload, 1, 1);
            this.tlpPlugins.Controls.Add(this.propsPluginOpts, 2, 0);
            this.tlpPlugins.Controls.Add(this.btnLoad, 0, 1);
            this.tlpPlugins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPlugins.Location = new System.Drawing.Point(0, 0);
            this.tlpPlugins.Name = "tlpPlugins";
            this.tlpPlugins.RowCount = 2;
            this.tlpPlugins.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPlugins.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPlugins.Size = new System.Drawing.Size(468, 267);
            this.tlpPlugins.TabIndex = 5;
            // 
            // PluginsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 267);
            this.Controls.Add(this.tlpPlugins);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "PluginsForm";
            this.Text = "Plugins";
            this.tlpPlugins.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbPlugins;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnUnload;
        private System.Windows.Forms.PropertyGrid propsPluginOpts;
        private System.Windows.Forms.TableLayoutPanel tlpPlugins;
    }
}