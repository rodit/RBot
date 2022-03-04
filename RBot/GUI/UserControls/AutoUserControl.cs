using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using RBot.Utils;

namespace RBot;

public partial class AutoUserControl : BaseUserControl
{
    internal CancellationTokenSource AutoCTS;
    private Thread AutoThread;
    public AutoUserControl()
    {
        InitializeComponent();

        ScriptDrops.DropsStarted += () => btnStartDrops.CheckedInvoke(() => btnStartDrops.Text = "Stop Drops");
        ScriptDrops.DropsStopped += () => btnStartDrops.CheckedInvoke(() => btnStartDrops.Text = "Start Drops");
        ScriptBoosts.BoostsStarted += () => btnStartBoosts.CheckedInvoke(() => btnStartBoosts.Text = "Stop Boosts");
        ScriptBoosts.BoostsStopped += () => btnStartBoosts.CheckedInvoke(() => btnStartBoosts.Text = "Start Boosts");
        ScriptManager.ScriptStopped += (_) => lblStatus.CheckedInvoke(() => lblStatus.Text = "Status: [None]");
    }    

    internal void ToggleAuto(bool hunt)
    {
        if (AutoThread?.IsAlive ?? false)
        {
            Stop();
            return;
        }

        if (!Bot.Player.LoggedIn || ScriptManager.ScriptRunning)
            return;

        btnStartAttack.Enabled = !hunt;
        btnStartHunt.Enabled = hunt;

        AutoThread = new(() =>
        {
            AutoCTS = new();
            if (hunt)
                _Hunt(AutoCTS.Token);
            else
                _Attack(AutoCTS.Token);
            Bot.Drops.Stop();
            Bot.Skills.StopTimer();
            Bot.Boosts.Stop();
            AutoCTS.Dispose();
            AutoCTS = null;
        });
        AutoThread.Name = "Auto Thread";
        AutoThread.Start();

        lblStatus.Text = hunt ? "Status: [Auto Hunt running]" : "Status: [Auto Attack running]";
    }

    internal void Stop(string message = "Stopped")
    {
        AutoCTS?.Cancel();
        lblStatus.CheckedInvoke(() => lblStatus.Text = $"Status: [{message}]");
        btnStartAttack.CheckedInvoke(() => btnStartAttack.Enabled = true);
        btnStartHunt.CheckedInvoke(() => btnStartHunt.Enabled = true);
        quests.Clear();
    }

    private List<int> quests = new();
    private string target = "";
    private void _Attack(CancellationToken token)
    {
        Debug.WriteLine("Auto attack started.");
        CheckLists();

        Bot.Skills.StartAdvanced(Bot.Inventory.CurrentClass.Name, true);
        Bot.Player.SetSpawnPoint();
        while (!token.IsCancellationRequested)
        {
            Bot.Player.Attack("*");
            if (quests.Count > 0)
                CompleteQuests(token);
        }
        Debug.WriteLine("Auto attack stopped.");
    }

    private void _Hunt(CancellationToken token)
    {
        Debug.WriteLine("Auto hunt started.");
        CheckLists();

        if (Bot.Player.HasTarget)
            target = Bot.Player.Target.Name;
        else
        {
            List<string> monsters = Bot.Monsters.CurrentMonsters.Select(m => m.Name).ToList();
            target = string.Join('|', monsters);
        }

        Bot._Log($"[Auto Hunt] Hunting for {target}");

        Bot.Skills.StartAdvanced(Bot.Inventory.CurrentClass.Name, true);
        while (!token.IsCancellationRequested)
        {
            Bot.Player.Hunt(target);
            if (quests.Count > 0)
                CompleteQuests(token);
        }
        Debug.WriteLine("Auto hunt stopped.");
    }

    private void CheckLists()
    {
        if (lstDrops.Items.Count > 0)
        {
            Bot.Drops.Add(lstDrops.Items.Cast<string>().ToArray());
            Bot.Drops.Start();
        }

        if(lstQuests.Items.Count > 0)
        {
            List<string> questList = lstQuests.Items.Cast<string>().ToList();
            quests.AddRange(questList.Select(q => int.Parse(q)).ToList());
        }

        if (Bot.Boosts.UsingBoosts)
            Bot.Boosts.Start();
    }

    private void CompleteQuests(CancellationToken token)
    {
        string cell = Bot.Player.Cell;
        string pad = Bot.Player.Pad;
        List<int> localQuests = quests;
        foreach (int quest in localQuests)
        {
            if (token.IsCancellationRequested)
                break;
            while (Bot.Quests.CanComplete(quest))
            {
                if (Bot.Player.Cell != "Wait" || Bot.Player.InCombat)
                    Bot.Player.Jump("Wait", "Spawn");
                Bot.Player.ExitCombat();
                Bot.Quests.EnsureComplete(quest, tries: 5);
                Bot.Quests.EnsureAccept(quest);
            }
        }
        if(Bot.Player.Cell == "Wait")
            Bot.Player.Jump(cell, pad);
    }

    private void btnStartAttack_Click(object sender, EventArgs e) => ToggleAuto(false);

    private void btnStartHunt_Click(object sender, EventArgs e) => ToggleAuto(true);

    private void AddToListBox(ListBox listBox, TextBox textBox, string text, bool onlyNums)
    {
        if (string.IsNullOrEmpty(text))
            return;

        if (text.Contains('|') || (onlyNums && text.Contains(',')))
        {
            if (onlyNums && !text.Replace(",", "").Replace("|", "").All(c => int.TryParse(c + "", out int i)))
                return;
            string[] toAdd = onlyNums ? text.Split(new char[] { ',', '|' }, StringSplitOptions.RemoveEmptyEntries).Select(q => q.Trim()).ToArray() : text.Split('|').Select(d => d.Trim()).ToArray();
            listBox.Items.AddRange(toAdd.Except(listBox.Items.Cast<string>()).ToArray());
            if (!onlyNums)
                Bot.Drops.Add(toAdd);
            textBox.Text = "";
            return;
        }
        if (!listBox.Items.Contains(text))
            listBox.Items.Add(text);
        if (!onlyNums)
            Bot.Drops.Add(text);
        textBox.Text = "";
    }

    private void btnAddDrop_Click(object sender, EventArgs e)
    {
        if(ModifierKeys == Keys.Control)
        {
            AddToListBox(lstDrops, txtDrop, string.Join('|', GetQuestItems(false)), false);
            return;
        }

        if(ModifierKeys == Keys.Alt)
        {
            AddToListBox(lstDrops, txtDrop, string.Join('|', GetQuestItems(true)), false);
            return;
        }
        AddToListBox(lstDrops, txtDrop, txtDrop.Text, false);
    }

    private List<string> GetQuestItems(bool all)
    {
        List<string> items = new();
        Bot.Quests.ActiveQuests.ForEach(quest =>
        {
            items.AddRange(quest.AcceptRequirements.Where(i => !i.Temp).Select(i => i.Name).ToList());
            items.AddRange(quest.Requirements.Where(i => !i.Temp).Select(i => i.Name).ToList());
            if(all)
                items.AddRange(quest.Rewards.Where(i => !i.Temp).Select(i => i.Name).ToList());
        });
        return items;
    }

    private void btnAddQuest_Click(object sender, EventArgs e)
    {
        if (ModifierKeys == Keys.Control)
        {
            AddToListBox(lstQuests, txtQuest, string.Join(',', Bot.Quests.ActiveQuests.Select(q => q.ID).ToArray()), true);
            return;
        }

        if(ModifierKeys == Keys.Alt)
        {
            AddToListBox(lstQuests, txtQuest, string.Join(',', Bot.Quests.QuestTree.Select(q => q.ID).ToArray()), true);
            return;
        }
        AddToListBox(lstQuests, txtQuest, txtQuest.Text, true);
    }

    private void txtDrops_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
            AddToListBox(lstDrops, txtDrop, txtDrop.Text, false);
        }
    }

    private void txtQuest_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
            AddToListBox(lstQuests, txtQuest, txtDrop.Text, true);
        }
    }

    private void btnStartDrops_Click(object sender, EventArgs e)
    {
        if (Bot.Drops.Enabled)
        {
            Bot.Drops.Stop();
            return;
        }
        Bot.Drops.Start();
    }

    private void btnStartBoosts_Click(object sender, EventArgs e)
    {
        if (Bot.Boosts.Enabled)
        {
            Bot.Boosts.Stop();
            return;
        }
        Bot.Boosts.Start();
    }

    private void RemoveFromListBox(ListBox listBox, bool drops, bool all)
    {
        if (all)
        {
            if (drops)
                Bot.Drops.Remove(listBox.Items.Cast<string>().ToArray());
            listBox.Items.Clear();
            return;
        }

        if (listBox.SelectedItem == null || listBox.SelectedIndex < 0)
            return;

        listBox.BeginUpdate();
        ListBox.SelectedIndexCollection indexes = listBox.SelectedIndices;
        List<string> dropsToRemove = new();
        for(int i = indexes.Count - 1; i >= 0; i--)
        {
            if(drops)
                dropsToRemove.Add(listBox.Items[indexes[i]].ToString());
            listBox.Items.RemoveAt(indexes[i]);

        }
        if(drops)
            Bot.Drops.Remove(dropsToRemove.ToArray());
        listBox.SelectedIndex = - 1;
        listBox.EndUpdate();
    }

    private void deleteDrops_Click(object sender, EventArgs e) => RemoveFromListBox(lstDrops, true, false);

    private void deleteAllDrops_Click(object sender, EventArgs e) => RemoveFromListBox(lstDrops, true, true);

    private void deleteQuests_Click(object sender, EventArgs e) => RemoveFromListBox(lstQuests, false, false);

    private void deleteAllQuests_Click(object sender, EventArgs e) => RemoveFromListBox(lstQuests, false, true);

    private void lstDrops_KeyDown(object sender, KeyEventArgs e)
    {
        if(e.KeyCode == Keys.Delete && e.Control)
        {
            e.SuppressKeyPress = true;
            RemoveFromListBox(lstDrops, true, true);
            return;
        }

        if (e.KeyCode == Keys.Delete)
        {
            e.SuppressKeyPress = true;
            RemoveFromListBox(lstDrops, true, false);
            return;
        }

    }

    private void lstQuests_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Delete && e.Control)
        {
            e.SuppressKeyPress = true;
            RemoveFromListBox(lstQuests, false, true);
            return;
        }

        if (e.KeyCode == Keys.Delete)
        {
            e.SuppressKeyPress = true;
            RemoveFromListBox(lstQuests, false, false);
            return;
        }
    }

    private void Boost_CheckedChanged(object sender, EventArgs e)
    {
        bool toggle = ((CheckBox)sender).Checked;
        switch(((CheckBox)sender).Tag)
        {
            case "class":
                Bot.Boosts.SetClassBoostID();
                Bot.Boosts.UseClassBoost = toggle;
                break;
            case "gold":
                Bot.Boosts.SetGoldBoostID();
                Bot.Boosts.UseClassBoost = toggle;
                break;
            case "xp":
                Bot.Boosts.SetExperienceBoostID();
                Bot.Boosts.UseExperienceBoost = toggle;
                break;
            case "rep":
                Bot.Boosts.SetReputationBoostID();
                Bot.Boosts.UseReputationBoost = toggle;
                break;
        }
    }
}
