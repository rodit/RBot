﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace RBot
{
    public partial class PacketSpammerForm : HideForm
    {
        public PacketSpammerForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ModifierKeys == Keys.Control)
			{
                string[] packets = Clipboard.GetText().Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (packets.Length == 0)
                    return;
                lbPackets.Items.AddRange(packets);
			}
            else if (txtPacket.Text.Trim() != string.Empty)
                lbPackets.Items.Add(txtPacket.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbPackets.SelectedItem != null)
                lbPackets.Items.Remove(lbPackets.SelectedItem);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (packetTimer.Enabled)
                btnStart.PerformClick();
            lbPackets.Items.Clear();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new();
            ofd.Filter = "Packet Spammers (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string line in File.ReadLines(ofd.FileName).Where(l => l.Trim() != string.Empty))
                    lbPackets.Items.Add(line);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lbPackets.Items.Count <= 0)
            {
                MessageBox.Show("Please add some packets to the spammer before saving them.", "No Packets", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using SaveFileDialog sfd = new();
            sfd.Filter = "Packet Spammers (*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(sfd.FileName, Enumerable.Range(0, lbPackets.Items.Count).Select(i => lbPackets.Items[i] as string));
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (packetTimer.Enabled)
            {
                btnStart.Text = "Start";
                packetTimer.Stop();
            }
            else
            {
                btnStart.Text = "Stop";
                _pIndex = 0;
                packetTimer.Start();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            bool json = txtPacket.Text.StartsWith("{");
            if (chkClient.Checked)
                Bot.SendClientPacket(txtPacket.Text, json ? "json" : "str");
            else
                Bot.SendPacket(txtPacket.Text, json ? "Json" : "String");
        }

        private int _pIndex = 0;
        private void packetTimer_Tick(object sender, EventArgs e)
        {
            if (lbPackets.Items.Count == 0)
                btnStart.PerformClick();
            string packet = lbPackets.Items[_pIndex] as string;
            bool json = packet.StartsWith("{");
            if (chkClient.Checked)
                Bot.SendClientPacket(packet, json ? "json" : "str");
            else
                Bot.SendPacket(packet, json ? "Json" : "String");
            _pIndex = (_pIndex + 1) % lbPackets.Items.Count;
        }
    }
}
