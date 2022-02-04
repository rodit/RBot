using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using RBot.Utils;

namespace RBot
{
    public partial class AboutForm : HideForm
    {
        public AboutForm()
        {
            InitializeComponent();

            foreach (LinkLabel linkLabel in Enumerable.Range(0, Controls.Count).Select(i => Controls[i]).Where(c => c is LinkLabel))
            {
                linkLabel.Click += (s, e) => OpenLink.OpenBrowserLink(linkLabel.Text);
            }
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            lblRBotVersion.Text = $"RBot Version {Application.ProductVersion}";
            lblBuildDate.Text = $"Build Date: {Properties.Resources.BuildDate}";
        }
    }
}
