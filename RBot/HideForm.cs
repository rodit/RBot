using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBot
{
    public class HideForm : Form
    {
        public ScriptInterface Bot => ScriptInterface.Instance;

        public HideForm() : base()
        {
            
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

        public new void Show()
        {
            base.Show();
            BringToFront();
        }
    }
}
