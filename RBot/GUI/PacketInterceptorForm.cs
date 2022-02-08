using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

using RBot.Servers;
using RBot.GameProxy;

namespace RBot
{
    public partial class PacketInterceptorForm : HideForm
    {
        private LoggerInterceptor _logger;
        public ListView Interceptor => listPackets;
        public PacketInterceptorForm()
        {
            InitializeComponent();
            cbServers.Click += CbServers_Click;
            listPackets.KeyUp += ListPackets_KeyUp;
            listPackets.View = View.Details;
            listPackets.Scrollable = true;
            _logger = new LoggerInterceptor(listPackets);
            chkLogPackets.Checked = true;
        }

        private void CbServers_Click(object sender, EventArgs e)
        {
            if (cbServers.Items.Count == 0)
                cbServers.Items.AddRange(ServerList.Servers.ToArray());
        }

        private void ListPackets_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C && listPackets.SelectedItems.Count >= 1)
			{
                List<string> packets = new List<string>();
                foreach (ListViewItem item in listPackets.SelectedItems)
                    packets.Add(item.Text);
                
                Clipboard.SetText(string.Join(Environment.NewLine, packets));
			}
        }

        private void lnkClearLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listPackets.Items.Clear();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (Bot.GameProxy.Running)
            {
                Bot.GameProxy.Stop();
                btnConnect.Text = "Connect";
            }
            else
            {
                Server server = cbServers.SelectedItem as Server;
                if (server != null)
                {
                    IPAddress ip = IPAddress.TryParse(server.IP, out IPAddress addr) ? addr : Dns.GetHostEntry(server.IP).AddressList[0];
                    Bot.GameProxy.Destination = new IPEndPoint(ip, 5588);
                    Bot.GameProxy.Start();
                    Bot.Player.Logout();
                    Bot.Player.Login(Bot.Player.Username, Bot.Player.Password);
                    Bot.Player.ConnectIP("127.0.0.1");
                    btnConnect.Text = "Disconnect";
                }
            }
        }

        private void chkLogPackets_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLogPackets.Checked)
                Bot.GameProxy.Interceptors.Add(_logger);
            else
                Bot.GameProxy.Interceptors.Remove(_logger);
        }
    }

    public class LoggerInterceptor : Interceptor
    {
        public int Priority => int.MaxValue;

        private ListView _host;

        public LoggerInterceptor(ListView host)
        {
            _host = host;
        }

        public void Intercept(MessageInfo info, bool outbound)
        {
            _host.Invoke(new Action(() =>
            {
                ListViewItem item = _host.Items.Add(info.Content);
                item.Tag = info;
                item.BackColor = info.Send ? (outbound ? Color.Yellow : Color.CornflowerBlue) : Color.Red;
                _host.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                item.EnsureVisible();
            }));
        }
    }
}
