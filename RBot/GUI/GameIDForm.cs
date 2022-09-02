﻿using RBot.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Dynamic;
using RBot.Quests;
using System.Threading;
using Newtonsoft.Json;
using static System.Collections.Generic.Dictionary<int, RBot.Quests.Quest>;

namespace RBot;

public partial class GameIDForm : HideForm
{
    private List<QuestData> _quests;

    public GameIDForm()
    {
        InitializeComponent();
    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        if (keyData.HasFlag(Keys.Control))
        {
            if (keyData.HasFlag(Keys.C))
                (keyData.HasFlag(Keys.Alt) ? btnCopyName : btnCopyID).PerformClick();
            else if (keyData.HasFlag(Keys.L))
                btnLoad.PerformClick();
            return true;
        }

        return base.ProcessCmdKey(ref msg, keyData);
    }

    private async void GameIDForm_Load(object sender, EventArgs e)
    {
        await Task.Run(_UpdateList);
        txtFilter.Enabled = true;
        txtFilter.Text = "";
    }

    private void txtFilter_TextChanged(object sender, EventArgs e)
    {
        lbQuests.Items.Clear();
        lbQuests.Items.AddRange(_quests.Where(q => q.ToString().ToLower().Contains(txtFilter.Text.ToLower())).ToArray());
    }

    private void btnCopyID_Click(object sender, EventArgs e)
    {
        QuestData[] data = lbQuests.SelectedItems.Cast<QuestData>().ToArray();
        if (data.Length > 0)
            Clipboard.SetText(string.Join(",", data.Select(q => q.ID.ToString())));
    }

    private void btnCopyName_Click(object sender, EventArgs e)
    {
        QuestData[] data = lbQuests.SelectedItems.Cast<QuestData>().ToArray();
        if (data.Length > 0)
            Clipboard.SetText(string.Join(",", data.Select(q => q.Name)));
    }

    private void btnLoad_Click(object sender, EventArgs e)
    {
        QuestData[] data = lbQuests.SelectedItems.Cast<QuestData>().ToArray();
        if (data.Length > 0)
            Bot.Quests.Load(data.Select(q => q.ID).ToArray());
    }

    private async void lnkUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        if (Bot.Player.LoggedIn)
        {
            lnkUpdate.Enabled = false;
            await Task.Run(() =>
            {
                AutoResetEvent wait = new(false);
                using StreamWriter writer = new("Quests.txt", true);
                int start = lbQuests.Items.Count > 0 ? ((QuestData)lbQuests.Items[^1]).ID + 1 : 1;
                for (int i = start; i < 15000; i += 29)
                {
                    Bot.SetGameObject("world.questTree", new ExpandoObject());
                    this.CheckedInvoke(() => Text = $"Loading Quests {i}-{i + 29}...");
                    Bot.Quests.Load(Enumerable.Range(i, 29).ToArray());
                    List<Quest> quests = new();
                    void packetListener(ScriptInterface bot, dynamic packet)
                    {
                        if (packet["params"].type == "json" && packet["params"].dataObj.cmd == "getQuests")
                        {
                            ValueCollection col = JsonConvert.DeserializeObject<Dictionary<int, Quest>>(JsonConvert.SerializeObject(packet["params"].dataObj.quests)).Values;
                            quests = col.ToList();
                        }
                        wait.Set();
                    }
                    Bot.Events.ExtensionPacketReceived += packetListener;
                    wait.WaitOne(10000);
                    Bot.Events.ExtensionPacketReceived -= packetListener;
                    if (quests.Count == 0)
                        break;
                    quests.OrderBy(q => q.ID).ForEach(q => writer.WriteLine($"{q.ID}|{q.Name}"));
                    writer.Flush();
                    Bot.Sleep(1500);
                }
            });
            Text = "Reloading list...";
            await Task.Run(_UpdateList);
            Text = "IDs";
            lnkUpdate.Enabled = true;
        }
        else
            MessageBox.Show("You must be logged in to update the quest list.");
    }

    private void _UpdateList()
    {
        if (!File.Exists("Quests.txt"))
            File.Create("Quests.txt").Close();
        _quests = File.ReadLines("Quests.txt")?.Select(l => l.Trim().Split(new char[] { '|' }, 2)).Where(l => l.Length == 2).Select(l => new QuestData(int.Parse(l[0]), l[1])).ToList() ?? null;

        if (_quests is null || _quests.Count == 0)
            return;

        lbQuests.CheckedInvoke(() =>
        {
            int selected = lbQuests.SelectedIndex;
            lbQuests.Items.Clear();
            lbQuests.Items.AddRange(_quests.ToArray());
            if (selected > -1 && selected < lbQuests.Items.Count)
                lbQuests.SelectedIndex = selected;
        });
    }
}

public class QuestData
{
    public int ID { get; set; }
    public string Name { get; set; }

    public QuestData(int id, string name)
    {
        ID = id;
        Name = name;
    }

    public override string ToString()
    {
        return $"{Name} [{ID}]";
    }
}
