using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using AxShockwaveFlashObjects;
using RBot.Flash;
using System.Runtime.CompilerServices;
using RBot.Utils;

namespace RBot
{
    public partial class PacketLoggerForm : HideForm
    {
        public bool LoggerEnabled => chkEnabled.Checked;
        public PacketLoggerForm()
        {
            InitializeComponent();

            lbPackets.KeyUp += LbPackets_KeyUp;
        }

        public void ToggleLogger(bool enable)
        {
            chkEnabled.CheckedInvoke(() => chkEnabled.Checked = enable);
        }

        private void PacketLoggerForm_Load(object sender, EventArgs e)
        {
            lbPackets.DataSource = Packets;
        }

        public BindingList<string> Packets = new();

        private void LbPackets_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C && lbPackets.SelectedItems.Count >= 1)
			{
                List<string> packets = new();
			    foreach (var item in lbPackets.SelectedItems)
			        packets.Add(item.ToString());
                Clipboard.SetText(string.Join(Environment.NewLine, packets));
			}
        }

        private void chkEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnabled.Checked)
                FlashUtil.FlashCall += FlashUtil_FlashCall;
            else
                FlashUtil.FlashCall -= FlashUtil_FlashCall;
        }

        private void FlashUtil_FlashCall(AxShockwaveFlash flash, string function, params object[] args)
        {
            if (function != "packet")
                return;
            if (chklbFilters.CheckedItems.Count == 0)
            {
                Packets.Add(args[0].ToString());
                lbPackets.SelectedIndex = lbPackets.Items.Count - 1;
                return;
            }

            // TODO Linq that shit
            string[] packet = args[0].ToString().Split(new[] { '%' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (int index in chklbFilters.CheckedIndices)
            {
                if (index == 0 && packet.Length >= 3 &&
                    (packet[2] == "gar" || packet[2] == "aggroMon"))
                    return;
                else if (index == 1 && packet.Length >= 3 &&
                    (packet[2] == "retrieveUserData" || packet[2] == "retrieveUserDatas"))
                    return;
                else if (index == 2 && packet.Length >= 5 &&
                    packet[4] == "tfer")
                    return;
                else if (index == 3 && packet.Length >= 3 &&
                    packet[2] == "moveToCell")
                    return;
                else if (index == 4 && packet.Length >= 3 &&
                    packet[2] == "mv" || packet[2] == "mtcid")
                    return;
                else if (index == 5 && packet.Length >= 3 &&
                    packet[2] == "getMapItem")
                    return;
                else if (index == 6 && packet.Length >= 3 &&
                    (packet[2] == "getQuest" || packet[2] == "acceptQuest" || packet[2] == "tryQuestComplete" || packet[2] == "updateQuest"))
                    return;
                else if (index == 7 && packet.Length >= 3 &&
                    (packet[2] == "loadShop" || packet[2] == "buyItem" || packet[2] == "sellItem"))
                    return;
                else if (index == 8 && packet.Length >= 3 &&
                    packet[2] == "equipItem")
                    return;
                else if (index == 9 && packet.Length >= 3 &&
                    packet[2] == "getDrop")
                    return;
                else if (index == 10 && packet.Length >= 3 &&
                    (packet[2] == "message" || packet[2] == "cc" || packet[2] == "whisper" || packet[2] == "party" || packet[2] == "guild"))
                    return;
                else if (index == 11 && packet.Length >= 3 &&
                    (packet[2] == "restRequest" || packet[2] == "crafting" || packet[2] == "setHomeTown" || packet[2] == "afk" || packet[2] == "summonPet"))
                    return;
            }
            Packets.Add(args[0].ToString());
            lbPackets.SelectedIndex = lbPackets.Items.Count - 1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Packets.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Packets.Count == 0)
                return;

            using SaveFileDialog sfd = new();
            sfd.Filter = "Packet Spammers (*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(sfd.FileName, Packets);
            }
        }

        private void clearSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbPackets.ClearSelected();
        }
    }
}
