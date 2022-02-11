using RBot.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
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
        }

        private async void Events_MapChanged(ScriptInterface bot, string map)
        {
            if (!Bot.Player.LoggedIn)
                return;

            await Task.Delay(500);
            if (map != null && _lastMap != map)
            {
                cbCell.CheckedInvoke(() => cbCell.Items.Clear());
                cbCell.CheckedInvoke(() => cbCell.Items.AddRange(Bot.Map.Cells.Except(cbCell.Items.Cast<string>()).Distinct().ToArray()));
                _lastMap = map;
            }
        }

        private void btnGetCurrent_Click(object sender, EventArgs e)
        {
            if (ModifierKeys == Keys.Shift)
                Clipboard.SetText($"\"{Bot.Map.Name}\", \"{Bot.Player.Cell}\", \"{Bot.Player.Pad}\"");
            else if (ModifierKeys == Keys.Control)
                Clipboard.SetText($"\"{Bot.Player.Cell}\", \"{Bot.Player.Pad}\"");
            else
            {
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

        private void JumpUserControl_Load(object sender, EventArgs e)
        {
            if(!DesignMode)
                Bot.Events.MapChanged += Events_MapChanged;
        }
    }
}
