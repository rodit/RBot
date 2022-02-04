using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RBot.Items;
using RBot.Monsters;
using RBot.Quests;
using RBot.Shops;
using RBot.Utils;

namespace RBot
{
    public partial class LoadersForm : HideForm
    {
        internal List<object> grabbedList = new();
        internal GrabTypes currentGrab;

        
        public LoadersForm()
        {
            InitializeComponent();
            lbGrab.SelectedIndexChanged += LbGrab_SelectedIndexChanged;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == (Keys.Control | Keys.F))
            {
                txtFilter.Focus();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
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
            if (!lbGrab.Enabled)
                return;

            lbGrab.Items.Clear();
            grabbedList.Clear();
            propsGrabbed.SelectedObject = null;
            lbGrab.SelectionMode = SelectionMode.One;
            currentGrab = (GrabTypes)cbGrabType.SelectedIndex;
            foreach (ToolStripMenuItem ts in cmsGrabber.Items)
            {
                ts.Visible = false;
            }
            switch (currentGrab)
            {
                case GrabTypes.ShopItems:
                    List<MergeItem> merges = Bot.Shops.MergeItems;
                    grabbedList.AddRange(merges?.ToArray() ?? Bot.Shops.ShopItems.ToArray());
                    tsBuy.Visible = true;
                    break;
                case GrabTypes.ShopIDs:
                    grabbedList.AddRange(ShopCache.Loaded.ToArray());
                    tsLoadShop.Visible = true;
                    break;
                case GrabTypes.Quests:
                    grabbedList.AddRange(Bot.Quests.QuestTree.ToArray());
                    lbGrab.SelectionMode = SelectionMode.MultiExtended;
                    tsAccQuest.Visible = true;
                    tsOpenQuest.Visible = true;
                    break;
                case GrabTypes.InventoryItems:
                    grabbedList.AddRange(Bot.Inventory.Items.ToArray());
                    lbGrab.SelectionMode = SelectionMode.MultiExtended;
                    tsToBank.Visible = true;
                    tsEquipItem.Visible = true;
                    tsSell.Visible = true;
                    break;
                case GrabTypes.HouseInventoryItems:
                    grabbedList.AddRange(Bot.Inventory.HouseItems.ToArray());
                    lbGrab.SelectionMode = SelectionMode.MultiExtended;
                    tsToBank.Visible = true;
                    break;
                case GrabTypes.TempInventoryItems:
                    grabbedList.AddRange(Bot.Inventory.TempItems.ToArray());
                    break;
                case GrabTypes.BankItems:
                    grabbedList.AddRange(Bot.Bank.BankItems.ToArray());
                    lbGrab.SelectionMode= SelectionMode.MultiExtended;
                    tsToInv.Visible = true;
                    break;
                case GrabTypes.CellMonsters:
                    grabbedList.AddRange(Bot.Monsters.CurrentMonsters.ToArray());
                    break;
                case GrabTypes.MapMonsters:
                    grabbedList.AddRange(Bot.Monsters.MapMonsters.ToArray());
                    tsTPMonster.Visible = true;
                    break;
            }
            lbGrab.Items.AddRange(grabbedList.ToArray());
        }

        private void lnkIds_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.IDForm.Show();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (grabbedList.Count == 0)
                return;

            lbGrab.BeginUpdate();
            lbGrab.Items.Clear();

            if (string.IsNullOrEmpty(txtFilter.Text))
            {
                lbGrab.Items.AddRange(grabbedList.ToArray());
                lbGrab.EndUpdate();
                return;
            }
            foreach (var item in grabbedList)
            {
                if (item.ToString().ToLower().Contains(txtFilter.Text.ToLower()))
                {
                    lbGrab.Items.Add(item);
                }
            }
            lbGrab.EndUpdate();
        }

        private void tsBuy_Click(object sender, EventArgs e)
        {
            if (lbGrab.SelectedItem is not ItemBase item || lbGrab.SelectedIndex < 0)
                return;

            if (ModifierKeys == Keys.Control)
            {
                using PromptDialog prompt = new($"Buying {item.Name}", "Buy quantity");
                if (prompt.ShowDialog() == DialogResult.Cancel)
                    return;
                if (!int.TryParse(prompt.Result, out int result))
                    return;

                if (result > item.MaxStack)
                    result = item.MaxStack;
                Task.Run(() =>
                {
                    ControlUpdates(false);
                    for (int i = 0; i < result; i++)
                    {
                        Bot.Shops.BuyItem(item.Name);
                        Bot.Sleep(1000);
                    }
                    ControlUpdates(true);
                });
                return;
            }
            Task.Run(() => Bot.Shops.BuyItem(item.Name));
        }

        private void tsSell_Click(object sender, EventArgs e)
        {
            if (lbGrab.SelectedItem is not InventoryItem item)
                return;

            if(lbGrab.SelectedIndices.Count > 1)
            {
                MessageBox.Show($"ATTENTION - {lbGrab.SelectedIndices.Count} items selected! \n Please sell 1 item at a time to prevent losses.", "Selling item - Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using PromptDialog prompt = new($"Selling {item.Name}", $"Sell quantity (Currently has: {(item.Category == ItemCategory.Class ? 1 : item.Quantity)})");
            if (prompt.ShowDialog() == DialogResult.Cancel)
                return;
            if (!int.TryParse(prompt.Result, out int result))
                return;

            if (result > item.Quantity)
                result = item.Quantity;
            Task.Run(() =>
            {
                ControlUpdates(false);
                for (int i = 0; i < result; i++)
                {
                    Bot.Shops.SellItem(item.Name);
                    Bot.Sleep(1000);
                }
                ControlUpdates(true);
            });
        }

        private void tsLoadShop_Click(object sender, EventArgs e)
        {
            if (lbGrab.SelectedItem is not ShopInfo shopInfo || lbGrab.SelectedIndex < 0)
                return;

            Task.Run(() => Bot.Shops.Load(shopInfo.ID));
        }

        private void tsOpenQuest_Click(object sender, EventArgs e)
        {
            if (lbGrab.SelectedItem is not Quest || lbGrab.SelectedIndex < 0)
                return;

            int[] indexes = lbGrab.SelectedIndices.Cast<int>().ToArray();
            Task.Run(() =>
            {
                ControlUpdates(false, "Opening quests...");
                List<int> quests = new();
                foreach (int index in indexes)
                    quests.Add((lbGrab.Items[index] as Quest).ID);
                Bot.Quests.Load(quests.ToArray());
                ControlUpdates(true);
            });
        }

        private void tsAccQuest_Click(object sender, EventArgs e)
        {
            if (lbGrab.SelectedItem is not Quest || lbGrab.SelectedIndex < 0)
                return;

            int[] indexes = lbGrab.SelectedIndices.Cast<int>().ToArray();
            Task.Run(() =>
            {
                ControlUpdates(false, "Accepting quests...");
                foreach (int index in indexes)
                {
                    Bot.Quests.EnsureAccept((lbGrab.Items[index] as Quest).ID, tries: 5);
                    Bot.Sleep(1000);
                }
                ControlUpdates(true);
            });
        }

        private void tsTPMonster_Click(object sender, EventArgs e)
        {
            if (lbGrab.SelectedItem is not Monster monster || lbGrab.SelectedIndex < 0)
                return;

            Task.Run(() => Bot.Player.Jump(monster.Cell, "Left"));
        }

        private void tsToBank_Click(object sender, EventArgs e)
        {
            if (lbGrab.SelectedItem is not InventoryItem || lbGrab.SelectedIndex < 0)
                return;
            int[] indexes = lbGrab.SelectedIndices.Cast<int>().ToArray();
            Task.Run(() =>
            {
                ControlUpdates(false, "Banking items...");
                foreach (int index in indexes)
                {
                    Bot.Inventory.ToBank((lbGrab.Items[index] as InventoryItem).Name);
                    Bot.Sleep(1000);
                }
                ControlUpdates(true);
            });
        }

        private void tsToInv_Click(object sender, EventArgs e)
        {
            if (lbGrab.SelectedItem is not InventoryItem || lbGrab.SelectedIndex < 0)
                return;

            int[] indexes = lbGrab.SelectedIndices.Cast<int>().ToArray();
            Task.Run(() =>
            {
                ControlUpdates(false, "Unbanking items...");
                foreach (int index in indexes)
                {
                    Bot.Inventory.ToBank((lbGrab.Items[index] as InventoryItem).Name);
                    Bot.Sleep(1000);
                }
                ControlUpdates(true);
            });
        }

        private void tsEquipItem_Click(object sender, EventArgs e)
        {
            if (lbGrab.SelectedItem is not InventoryItem || lbGrab.SelectedIndex < 0)
                return;

            int[] indexes = lbGrab.SelectedIndices.Cast<int>().ToArray();
            Task.Run(() =>
            {
                ControlUpdates(false, "Equipping items...");
                foreach (int index in indexes)
                {
                    Bot.Player.EquipItem((lbGrab.Items[index] as InventoryItem).ID);
                    Bot.Sleep(1000);
                }
                ControlUpdates(true);
            });
        }

        private void ControlUpdates(bool enable, string title = "")
        {
            Forms.Loaders.CheckedInvoke(() => Text = enable ? "Loaders" : $"Loaders - {title}");
            lbGrab.CheckedInvoke(() => lbGrab.Enabled = enable);
            cmsGrabber.CheckedInvoke(() => cmsGrabber.Enabled = enable);
            
            if (enable)
                btnGrab.CheckedInvoke(() => btnGrab.PerformClick());
        }
    }

    public enum GrabTypes
    {
        ShopItems,
        ShopIDs,
        Quests,
        InventoryItems,
        HouseInventoryItems,
        TempInventoryItems,
        BankItems,
        CellMonsters,
        MapMonsters
    }
}