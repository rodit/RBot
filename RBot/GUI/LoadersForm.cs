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

namespace RBot;

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
                btnLoad.CheckedInvoke(() => btnLoad.Enabled = false);
                Bot.Shops.Load(id);
                btnLoad.CheckedInvoke(() => btnLoad.Enabled = true);
            });
            return;
        }
        
        if (cbLoadType.SelectedIndex == 1 && txtIds.Text.Replace(",", "").All(c => int.TryParse(c + "", out int i)))
        {
            Task.Run(() =>
            {
                btnLoad.CheckedInvoke(() => btnLoad.Enabled = false);
                Bot.Quests.Load(txtIds.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray());
                btnLoad.CheckedInvoke(() => btnLoad.Enabled = true);
            });
        }
    }

    private async void btnGrab_Click(object sender, EventArgs e)
    {
        if (!lbGrab.Enabled)
            return;

        currentGrab = (GrabTypes)cbGrabType.SelectedIndex;
        ControlUpdates(false, currentGrab == GrabTypes.GetMapItemID ? "Grabbing map items..." : "");
        lbGrab.Items.Clear();
        lbGrab.SuspendLayout();
        grabbedList.Clear();
        propsGrabbed.SelectedObject = null;
        lbGrab.SelectionMode = SelectionMode.One;
        foreach (ToolStripMenuItem ts in cmsGrabber.Items)
        {
            ts.Visible = false;
        }
        switch (currentGrab)
        {
            case GrabTypes.ShopItems:
                grabbedList.AddRange(Bot.Shops.ShopItems.ToArray());
                tsBuy.Visible = true;
                break;
            case GrabTypes.ShopIDs:
                grabbedList.AddRange(ShopCache.Loaded.ToArray());
                tsLoadShop.Visible = true;
                break;
            case GrabTypes.Quests:
                grabbedList.AddRange(Bot.Quests.QuestTree.ToArray());
                lbGrab.SelectionMode = SelectionMode.MultiExtended;
                tsOpenQuest.Visible = true;
                tsAccQuest.Visible = true;
                break;
            case GrabTypes.InventoryItems:
                grabbedList.AddRange(Bot.Inventory.Items.ToArray());
                lbGrab.SelectionMode = SelectionMode.MultiExtended;
                tsEquipItem.Visible = true;
                tsToBank.Visible = true;
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
                lbGrab.SelectionMode = SelectionMode.MultiExtended;
                tsToInv.Visible = true;
                break;
            case GrabTypes.CellMonsters:
                grabbedList.AddRange(Bot.Monsters.CurrentMonsters.ToArray());
                break;
            case GrabTypes.MapMonsters:
                grabbedList.AddRange(Bot.Monsters.MapMonsters.ToArray());
                tsTPMonster.Visible = true;
                break;
            case GrabTypes.GetMapItemID:
                await Task.Run(() =>
                {
                    var items = Bot.Map.FindMapItems();
                    if(items is not null)
                        grabbedList.AddRange(items.ToArray());
                });
                lbGrab.SelectionMode = SelectionMode.MultiExtended;
                tsGetMapItem.Visible = true;
                tsOpenQuest.Visible = true;
                tsAccQuest.Visible = true;
                break;
        }
        lbGrab.Items.AddRange(grabbedList.ToArray());
        lbGrab.ResumeLayout();
        ControlUpdates(true, grabAfter: false);
    }

    private void lnkIds_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Forms.IDForm.Show();
    }

    private void LoaderTaskRun<T>(Action<T> action, T param, string title, int iterations)
    {
        ControlUpdates(false, title);
        for (int i = 0; i < iterations; i++)
        {
            action.Invoke(param);
            Bot.Sleep(1000);
        }
        ControlUpdates(true);
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
        lbGrab.Items.AddRange(grabbedList.Where(i => i.ToString().Contains(txtFilter.Text, StringComparison.OrdinalIgnoreCase)).ToArray());
        lbGrab.EndUpdate();
    }

    private void tsGetMapItem_Click(object sender, EventArgs e)
    {
        if (lbGrab.SelectedItem is not MapItem item || lbGrab.SelectedIndex < 0)
            return;

        if(ModifierKeys == Keys.Control)
        {
            using PromptDialog prompt = new($"Get Map Item, ID [{item.MapItemID}]", "Quantity");
            if (prompt.ShowDialog() == DialogResult.Cancel)
                return;
            if (!int.TryParse(prompt.Result, out int result))
                return;
            Task.Run(() => LoaderTaskRun(Bot.Map.GetMapItem, item.MapItemID, "Getting map item...", result));
            return;
        }
        Task.Run(() => Bot.Map.GetMapItem(item.MapItemID));
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
            Task.Run(() => LoaderTaskRun(Bot.Shops.BuyItem, item.Name, "Buying item...", result));
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
        Task.Run(() => LoaderTaskRun(Bot.Shops.SellItem, item.Name, "Selling item...", result));
    }

    private void tsLoadShop_Click(object sender, EventArgs e)
    {
        if (lbGrab.SelectedItem is not ShopInfo shopInfo || lbGrab.SelectedIndex < 0)
            return;

        Task.Run(() => Bot.Shops.Load(shopInfo.ID));
    }

    private void tsOpenQuest_Click(object sender, EventArgs e)
    {
        if (lbGrab.SelectedIndex < 0)
            return;

        int[] indexes = lbGrab.SelectedIndices.Cast<int>().ToArray();
        Task.Run(() =>
        {
            ControlUpdates(false, "Opening quests...");
            List<int> quests = new();
            foreach (int index in indexes)
            {
                switch (currentGrab)
                {
                    case GrabTypes.Quests:
                        quests.Add((lbGrab.Items[index] as Quest).ID);
                        break;
                    case GrabTypes.GetMapItemID:
                        quests.Add((lbGrab.Items[index] as MapItem).QuestID);
                        break;
                    default:
                        continue;
                }
            }
            Bot.Quests.Load(quests.ToArray());
            ControlUpdates(true);
        });
    }

    private void tsAccQuest_Click(object sender, EventArgs e)
    {
        if (lbGrab.SelectedIndex < 0)
            return;

        int[] indexes = lbGrab.SelectedIndices.Cast<int>().ToArray();
        Task.Run(() =>
        {
            ControlUpdates(false, "Accepting quests...");
            foreach (int index in indexes)
            {
                switch (currentGrab)
                {
                    case GrabTypes.Quests:
                        Bot.Quests.EnsureAccept((lbGrab.Items[index] as Quest).ID);
                        break;
                    case GrabTypes.GetMapItemID:
                        Bot.Quests.EnsureAccept((lbGrab.Items[index] as MapItem).QuestID);
                        break;
                    default:
                        continue;
                }
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

    private void ControlUpdates(bool enable, string title = "", bool grabAfter = true)
    {
        Forms.Loaders.CheckedInvoke(() => Text = enable ? "Loaders" : $"Loaders{(title == "" ? "" : $" - {title}")}");
        lbGrab.CheckedInvoke(() => lbGrab.Enabled = enable);
        cmsGrabber.CheckedInvoke(() => cmsGrabber.Enabled = enable);
        
        if (enable)
        {
            txtFilter.CheckedInvoke(() => txtFilter.Text = "");
            if(grabAfter)
                btnGrab.CheckedInvoke(() => btnGrab.PerformClick());
        }
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
    MapMonsters,
    GetMapItemID
}
