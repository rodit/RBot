using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBot
{
    public partial class JumpUserControl : BaseUserControl
    {
        private string _lastMap = "";
        public JumpUserControl()
        {
            InitializeComponent();
            Enter += UpdateCells;
            cbCell.GotFocus += UpdateCells;
        }

        private void btnGetCurrent_Click(object sender, EventArgs e)
        {
            if (ModifierKeys == Keys.Shift)
                Clipboard.SetText($"\"{Bot.Map.Name}\", \"{Bot.Player.Cell}\", \"{Bot.Player.Pad}\"");
            else if (ModifierKeys == Keys.Control)
                Clipboard.SetText($"\"{Bot.Player.Cell}\", \"{Bot.Player.Pad}\"");
            else
            {
                UpdateCells(sender, e);
                cbCell.SelectedItem = Bot.Player.Cell;
                cbPads.SelectedItem = Bot.Player.Pad;
            }
        }

        private async void btnJump_Click(object sender, EventArgs e)
        {
            if (ModifierKeys == Keys.Control)
                await Task.Run(() => Bot.Player.Jump("Enter", "Spawn"));
            else if (cbCell.SelectedIndex > -1 && cbPads.SelectedIndex > -1)
            {
                string cell = cbCell.SelectedItem as string;
                string pad = cbPads.SelectedItem as string;
                await Task.Run(() => Bot.Player.Jump(cell, pad));
            }
        }

        private void UpdateCells(object sender, EventArgs e)
        {
            if (Bot.Player.LoggedIn)
            {
                string map = Bot.Map.Name;
                if (map != null && _lastMap != map)
                {
                    cbCell.Items.Clear();
                    cbCell.Items.AddRange(Bot.Map.Cells.ToArray());
                    _lastMap = map;
                }
            }
        }
    }
}
