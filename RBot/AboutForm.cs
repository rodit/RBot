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

namespace RBot
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            lblInfo.Text = $"RBot Version {Application.ProductVersion}\r\nMade by Rodit\r\nBuild Date: {Assembly.GetExecutingAssembly().GetLinkerTime()}";
        }
    }
}
