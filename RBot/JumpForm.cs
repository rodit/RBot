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
    public partial class JumpForm : HideForm
    {
        private string _lastMap = "";

        public JumpForm()
        {
            InitializeComponent();
            GotFocus += CbCell_GotFocus;
            cbCell.GotFocus += CbCell_GotFocus;
        }

        private void CbCell_GotFocus(object sender, EventArgs e)
        {
            string map = Bot.Map.Name;
            if (map != null && _lastMap != map)
            {
                cbCell.Items.Clear();
                cbCell.Items.AddRange(Bot.Map.Cells.ToArray());
            }
        }

        private void btnGetCurrent_Click(object sender, EventArgs e)
        {
            cbCell.SelectedItem = Bot.Player.Cell;
            cbPads.SelectedItem = Bot.Player.Pad;
        }

        private void btnJump_Click(object sender, EventArgs e)
        {
            if (cbCell.SelectedIndex > -1 && cbPads.SelectedIndex > -1)
                Bot.Player.Jump(cbCell.SelectedItem as string, cbPads.SelectedItem as string);
        }
    }
}
