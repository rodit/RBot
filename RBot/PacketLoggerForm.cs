using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

using RBot.Flash;

namespace RBot
{
    public partial class PacketLoggerForm : HideForm
    {
        public PacketLoggerForm()
        {
            InitializeComponent();

            lbPackets.KeyUp += LbPackets_KeyUp;
        }

        private void LbPackets_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C && lbPackets.SelectedItems.Count >= 1)
			{
                List<string> packets = new List<string>();
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

        private void FlashUtil_FlashCall(AxShockwaveFlashObjects.AxShockwaveFlash flash, string function, params object[] args)
        {
            if (function == "packet")
                lbPackets.Items.Add(args[0]);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbPackets.Items.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lbPackets.Items.Count > 0)
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Packet Spammers (*.txt)|*.txt";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllLines(sfd.FileName, Enumerable.Range(0, lbPackets.Items.Count).Select(i => lbPackets.Items[i] as string));
                    }
                }
            }
        }
    }
}
