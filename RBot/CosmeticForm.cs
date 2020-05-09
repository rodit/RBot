using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RBot.Cosmetics;
using RBot.Players;
using RBot.Utils;

namespace RBot
{
    public partial class CosmeticForm : HideForm
    {
        public CosmeticForm()
        {
            InitializeComponent();
            lbItems.SelectionMode = SelectionMode.MultiExtended;
        }

        private void lnkRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cbPlayer.Items.Clear();
            cbPlayer.Items.AddRange(Bot.Map.Players.ToArray());
            cbPlayer.SelectedItem = cbPlayer.Items.Count > 0 ? cbPlayer.Items[0] : null;
        }

        private void btnGrabCosm_Click(object sender, EventArgs e)
        {
            lbItems.Items.Clear();
            if (cbPlayer.SelectedIndex > -1)
                lbItems.Items.AddRange(CosmeticEquipment.Get(((PlayerInfo)cbPlayer.SelectedItem).EntID).ToArray());
        }

        private void btnCopyAll_Click(object sender, EventArgs e)
        {
            lbItems.Items.Cast<CosmeticEquipment>().ForEach(x => x.Equip());
        }

        private void btnEquipSelected_Click(object sender, EventArgs e)
        {
            lbItems.SelectedItems.Cast<CosmeticEquipment>().ForEach(x => x.Equip());
        }

        private void lnkGrabTarget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbItems.Items.Clear();
            lbItems.Items.AddRange(CosmeticEquipment.Get(Bot.GetGameObject<int>("world.myAvatar.target.uid")).ToArray());
        }
    }
}
