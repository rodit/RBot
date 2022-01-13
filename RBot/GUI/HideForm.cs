using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBot
{
    public partial class HideForm : Form
    {
        internal FormBorderStyle borderStyle = FormBorderStyle.Sizable;
        internal ScriptInterface Bot => ScriptInterface.Instance;
        public HideForm() : base()
        {
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        protected override void OnShown(EventArgs e)
        {
            BringToFront();
        }

        public virtual new void Show()
        {
            base.Show();
            BringToFront();
        }

        private void cmsTopMost_Click(object sender, EventArgs e)
        {
            TopMost = cmsTopMost.Checked;
        }

        private void cmsLockPos_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle == FormBorderStyle.None ? borderStyle : FormBorderStyle.None;
        }
    }
}
