﻿using System;
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

            foreach (LinkLabel linkLabel in Enumerable.Range(0, Controls.Count).Select(i => Controls[i]).Where(c => c is LinkLabel))
            {
                linkLabel.Click += (s, e) => Process.Start(linkLabel.Text);
            }

            borderStyle = FormBorderStyle;
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            lblRBotVersion.Text = $"RBot Version {Application.ProductVersion}";
            lblBuildDate.Text = $"Build Date: {Properties.Resources.BuildDate}";
        }
    }
}
