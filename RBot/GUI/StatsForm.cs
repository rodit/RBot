using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RBot
{
    public partial class StatsForm : HideForm
    {
        public StatsForm()
        {
            InitializeComponent();

            GotFocus += StatsForm_GotFocus;
        }

        private void StatsForm_GotFocus(object sender, EventArgs e)
        {
            statsTimer.Start();
        }

        public override void Show()
        {
            base.Show();
            statsTimer.Start();
        }

        public new void Hide()
        {
            base.Hide();
            statsTimer.Stop();
        }

        private void statsTimer_Tick(object sender, EventArgs e)
        {
            lblStats.Text = $"Kills: {Bot.Stats.Kills}\r\nDeaths: {Bot.Stats.Deaths}\r\nQuests (A/C): {Bot.Stats.QuestsAccepted}/{Bot.Stats.QuestsCompleted}\r\nPickups: {Bot.Stats.Drops}\r\nRelogins: {Bot.Stats.Relogins}\r\nTime: {DateTime.UtcNow - Process.GetCurrentProcess().StartTime.ToUniversalTime()}";
        }

        private void lnkReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Bot.Stats = new ScriptBotStats();
        }
    }
}
