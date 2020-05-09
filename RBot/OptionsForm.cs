using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBot
{
    public partial class OptionsForm : HideForm
    {
        public OptionsForm()
        {
            InitializeComponent();

            Bot.Options.BindControl("InfiniteRange", chkInfiniteRange);
            Bot.Options.BindControl("AggroMonsters", chkAggro);
            Bot.Options.BindControl("Magnetise", chkMagnet);
            Bot.Options.BindControl("PrivateRooms", chkPrivRooms);
            Bot.Options.BindControl("SkipCutscenes", chkSkipCutscenes);
            Bot.Options.BindControl("LagKiller", chkLagKiller);
            Bot.Options.BindControl("HidePlayers", chkHidePlayers);
            Bot.Options.BindControl("DisableFX", chkDisableFX);
            Bot.Options.BindControl("DisableCollisions", chkDisableCols);
            Bot.Options.BindControl("WalkSpeed", numWalkSpeed);
        }

        private void btnSetFpsCap_Click(object sender, EventArgs e)
        {
            Bot.SetGameObject("stage.frameRate", (int)numFpsCap.Value);
        }

        private void btnSetName_Click(object sender, EventArgs e)
        {
            Bot.Options.CustomName = txtCustomName.Text;
        }

        private void btnSetGuild_Click(object sender, EventArgs e)
        {
            Bot.Options.CustomGuild = txtCustomGuild.Text;
        }

        private void chkUpgrade_CheckedChanged(object sender, EventArgs e)
        {
            Bot.Player.Upgrade = chkUpgrade.Checked;
        }

        private void chkStaff_CheckedChanged(object sender, EventArgs e)
        {
            Bot.Player.AccessLevel = chkUpgrade.Checked ? 100 : 10;
        }

        private void chkFpsCounter_CheckedChanged(object sender, EventArgs e)
        {
            Bot.CallGameFunction("world.toggleFPS");
        }

        private void chkAcceptAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAcceptAll.Checked)
                chkRejectAll.Checked = false;
            dropTimer.Enabled = chkAcceptAll.Checked;
        }

        private void chkRejectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRejectAll.Checked)
                chkAcceptAll.Checked = false;
            dropTimer.Enabled = chkRejectAll.Checked;
        }

        private void dropTimer_Tick(object sender, EventArgs e)
        {
            if (chkAcceptAll.Checked)
                Bot.Player.PickupAll();
            else if (chkRejectAll.Checked)
                Bot.Player.RejectAll();
        }

        private void btnReloadMap_Click(object sender, EventArgs e)
        {
            Bot.Map.Reload();
        }

        private void btnHotkeys_Click(object sender, EventArgs e)
        {
            using (HotkeysForm hkf = new HotkeysForm())
                hkf.ShowDialog();
        }
    }
}
