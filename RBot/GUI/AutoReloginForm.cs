using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RBot.Servers;

namespace RBot
{
    public partial class AutoReloginForm : HideForm
    {
        public AutoReloginForm()
        {
            InitializeComponent();
            Shown += AutoReloginForm_Shown;

            cbServers.Click += CbServers_Click;
            Bot.Options.BindControl("LoginServer", cbServers);
            Bot.Options.BindControl("AutoRelogin", chkRelogin);
            Bot.Options.BindControl("AutoReloginAny", chkReloginAny);
            Bot.Options.BindControl("SafeRelogin", chkSafeRelogin);
        }

        private void AutoReloginForm_Shown(object sender, EventArgs e)
        {
            if (cbServers.Items.Count == 0)
                cbServers.Items.AddRange(ServerList.Servers.ToArray());
        }

        private void CbServers_Click(object sender, EventArgs e)
        {
            if (cbServers.Items.Count == 0)
                cbServers.Items.AddRange(ServerList.Servers.ToArray());
        }
    }
}
