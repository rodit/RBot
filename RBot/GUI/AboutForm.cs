using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows.Forms;

using RBot.Utils;
using System.Diagnostics;

namespace RBot
{
    public partial class AboutForm : HideForm
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            lblRBotVersion.Text = $"RBot Version {Application.ProductVersion}";
            lblBuildDate.Text = $"Build Date: {Properties.Resources.BuildDate}";
        }

        private void lblLinkWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(lblLinkWebsite.Text);
        }

        private void lblLinkProject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(lblLinkProject.Text);
        }

        private void lblLinkDiscord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(lblLinkDiscord.Text);
        }

        private void lblLinkDoc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(lblLinkDoc.Text);
        }
    }
}
