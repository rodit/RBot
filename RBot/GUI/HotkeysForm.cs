using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RBot.Utils;

namespace RBot
{
    public partial class HotkeysForm : Form
    {
        private Dictionary<string, Button> _buttons = new Dictionary<string, Button>();

        private string _cBinding;

        public HotkeysForm()
        {
            InitializeComponent();

            foreach (Button b in Enumerable.Range(0, tlpHotKeys.Controls.Count).Select(i => tlpHotKeys.Controls[i]).Where(c => c is Button))
            {
                if (b.Tag != null)
                {
                    b.Click += (s, e) => _Bind(b.Tag as string);
                    _buttons[b.Tag as string] = b;
                    b.Text = ((Keys)AppRuntime.Options.Get<int>($"binding.{b.Tag as string}")).ToString();
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (_cBinding != null)
            {
                AppRuntime.Options.Set($"binding.{_cBinding}", (int)keyData);
                _buttons[_cBinding].Text = keyData.ToString();
                _cBinding = null;
                Text = "Hotkeys";
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _Bind(string action)
        {
            _cBinding = action;
            Text = "Hotkeys - Waiting for Binding...";
        }
    }
}
