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

            borderStyle = FormBorderStyle;
        }

        private void btnSetFpsCap_Click(object sender, EventArgs e)
        {
            Bot.Options.SetFPS = (int)numFpsCap.Value;
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
            Bot.SetGameObject("world.myAvatar.pMC.pname.ti.textColor", chkUpgrade.Checked ? 0x8CD5FF : 0xFFFFFF);
        }

        private void chkStaff_CheckedChanged(object sender, EventArgs e)
        {
            Bot.Player.AccessLevel = chkUpgrade.Checked ? 100 : 10;
            Bot.SetGameObject("world.myAvatar.pMC.pname.ti.textColor", chkStaff.Checked ? 0xFECB38 : 0xFFFFFF);
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
            using HotkeysForm hkf = new();
            hkf.ShowDialog();
        }

        private void chkCheckSpace_CheckedChanged(object sender, EventArgs e)
        {
            Check.Enabled = chkCheckSpace.Checked;
            if (!chkCheckSpace.Checked)
            {
                Height = 395;
                InvNA();
            }
            else
            {
                Height = 485;
            }
        }

        private void Check_Tick(object sender, EventArgs e)
        {
            if (Bot.IsWorldLoaded && Bot.Player.Loaded)
            {
                // Inventory
                maxInvLabel.Text = $"Max: {Bot.Inventory.Slots}";
                freeInvLabel.Text = $"Free: {Bot.Inventory.FreeSlots}";
                filledInvLabel.Text = $"Filled: {Bot.Inventory.UsedSlots}";
                // Bank
                maxBankLabel.Text = $"Max: {Bot.Bank.Slots}";
                freeBankLabel.Text = $"Free: {Bot.Bank.FreeSlots}";
                filledBankLabel.Text = $"Filled: {Bot.Bank.UsedSlots}";
            }
            else
            {
                InvNA();
            }
        }

        private void InvNA()
        {
            // Inventory
            maxInvLabel.Text = "Max: N/A";
            freeInvLabel.Text = "Free: N/A";
            filledInvLabel.Text = "Filled: N/A";

            // Bank
            maxBankLabel.Text = "Max: N/A";
            freeBankLabel.Text = "Free: N/A";
            filledBankLabel.Text = "Filled: N/A";
        }
    }
}
