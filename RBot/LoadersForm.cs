using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RBot.Shops;

namespace RBot
{
    public partial class LoadersForm : HideForm
    {
        public LoadersForm()
        {
            InitializeComponent();

            lbGrab.SelectedIndexChanged += LbGrab_SelectedIndexChanged;
        }

        private void LbGrab_SelectedIndexChanged(object sender, EventArgs e)
        {
            propsGrabbed.SelectedObject = lbGrab.SelectedItem;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (cbLoadType.SelectedIndex == 0 && int.TryParse(txtIds.Text, out int id))
            {
                Task.Run(() =>
                {
                    btnLoad.Enabled = false;
                    Bot.Shops.Load(id);
                    btnLoad.Enabled = true;
                });
            }
            else if (cbLoadType.SelectedIndex == 1 && txtIds.Text.Replace(",", "").All(c => int.TryParse(c + "", out int i)))
                Bot.Quests.Load(txtIds.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray());
        }

        private void btnGrab_Click(object sender, EventArgs e)
        {
            lbGrab.Items.Clear();
            propsGrabbed.SelectedObject = null;
            switch (cbGrabType.SelectedIndex)
            {
                case 0:
                    List<MergeItem> merges = Bot.Shops.MergeItems;
                    lbGrab.Items.AddRange(merges?.ToArray() ?? Bot.Shops.ShopItems.ToArray());
                    break;
                case 1:
                    lbGrab.Items.AddRange(ShopCache.Loaded.ToArray());
                    break;
                case 2:
                    lbGrab.Items.AddRange(Bot.Quests.QuestTree.ToArray());
                    break;
                case 3:
                    lbGrab.Items.AddRange(Bot.Inventory.Items.ToArray());
                    break;
                case 4:
                    lbGrab.Items.AddRange(Bot.Inventory.TempItems.ToArray());
                    break;
                case 5:
                    lbGrab.Items.AddRange(Bot.Bank.BankItems.ToArray());
                    break;
                case 6:
                    lbGrab.Items.AddRange(Bot.Monsters.CurrentMonsters.ToArray());
                    break;
                case 7:
                    lbGrab.Items.AddRange(Bot.Monsters.MapMonsters.ToArray());
                    break;
                case 8:
                    //TODO: map item identifier.
                    break;
            }
        }

        private void lnkIds_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.IDForm.Show();
        }
    }
}
