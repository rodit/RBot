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

        private void CbCell_GotFocus(object sender, EventArgs e) => UpdateCells();

        private void UpdateCells()
		{
			if (Bot.Player.LoggedIn)
			{
				string map = Bot.Map.Name;
				if (map != null && _lastMap != map)
				{
					cbCell.Items.Clear();
					cbCell.Items.AddRange(Bot.Map.Cells.ToArray());
				} 
			}
        }

        private void btnGetCurrent_Click(object sender, EventArgs e)
        {
            UpdateCells();
            cbCell.SelectedItem = Bot.Player.Cell;
            cbPads.SelectedItem = Bot.Player.Pad;
        }

        private async void btnJump_Click(object sender, EventArgs e)
        {
            if (cbCell.SelectedIndex > -1 && cbPads.SelectedIndex > -1)
            {
                string cell = cbCell.SelectedItem as string;
                string pad = cbPads.SelectedItem as string;
                await Task.Run(() => Bot.Player.Jump(cell, pad));
            }
        }
    }
}
