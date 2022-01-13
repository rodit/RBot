using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RBot.Options;
using RBot.Plugins;

namespace RBot
{
    public partial class PluginsForm : HideForm
    {
        public PluginsForm()
        {
            InitializeComponent();

            PluginManager.PluginLoaded += PluginManager_PluginLoaded;
            PluginManager.PluginUnloaded += PluginManager_PluginUnloaded;

            borderStyle = FormBorderStyle;
        }

        private void PluginManager_PluginUnloaded(PluginContainer container)
        {
            lbPlugins.Items.Remove(container);
        }

        private void PluginManager_PluginLoaded(PluginContainer container)
        {
            lbPlugins.Items.Add(container);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "RBot Plugins (*.dll)|*.dll";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Exception ex = PluginManager.Load(ofd.FileName);
                    if (ex != null)
                        MessageBox.Show($"Error while loading plugin:\r\n{ex}", "Plugin Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUnload_Click(object sender, EventArgs e)
        {
            PluginContainer container = lbPlugins.SelectedItem as PluginContainer;
            if (container != null)
                PluginManager.Unload(container.Plugin);
        }

        private void lbPlugins_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUnload.Enabled = lbPlugins.SelectedIndex > -1;
            propsPluginOpts.SelectedObject = lbPlugins.SelectedIndex > -1 ? new OptionPropertyGridAdapter((lbPlugins.SelectedItem as PluginContainer).Options) : null;
        }
    }
}
