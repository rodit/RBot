using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RBot.Updates;

namespace RBot
{
    public partial class UpdatesForm : HideForm
    {
        private UpdateInfo latest;

        public UpdatesForm()
        {
            InitializeComponent();
        }

        private async void UpdatesForm_Load(object sender, EventArgs e)
        {
            await RefreshVersions();
        }

        private async Task RefreshVersions()
        {
            lnkRefresh.Enabled = false;

            lblStatus.Text = "Loading...";

            cbReleases.Items.Clear();
            List<UpdateInfo> infos = await UpdateChecker.GetReleases();
            if (infos == null || infos.Count == 0)
            {
                lnkDownload.Visible = false;
                lblLatestVersion.Text = "No versions found.";
                lblStatus.Text = "Unknown";
            }
            else
            {
                infos = infos.OrderByDescending(x => x.ParsedVersion).ToList();
                latest = infos.First(x => AppRuntime.Options.Get<bool>("updates.beta") || !x.Prerelease);
                lblLatestVersion.Text = $"Latest Version: {latest.ParsedVersion}\r\n{latest.Name}\r\nTime: {latest.Time}";
                bool newer = latest.ParsedVersion.CompareTo(Version.Parse(Application.ProductVersion)) > 0;
                lblStatus.Text = newer ? "Update available." : "You have the latest version.";
                lnkDownload.Visible = newer;
                cbReleases.Items.AddRange(infos.ToArray());
            }

            lnkRefresh.Enabled = true;
        }

        private void lnkDownload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(latest.URL);
        }

        private async void lnkRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            await RefreshVersions();
        }

        private void lnkDownloadSelected_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cbReleases.SelectedItem is UpdateInfo info)
                Process.Start(info.URL);
        }

        private void cbReleases_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbReleases.SelectedItem is UpdateInfo info)
            {
                lblUpdateInfo.Text = $"{info.Name}\r\nVersion: {info.Version}\r\nPrerelease: {info.Prerelease}\r\nTime: {info.Time}";
                lnkDownloadSelected.Visible = true;
                Height = 265;
            }
            else
            {
                lblUpdateInfo.Text = "No update selected.";
                lnkDownloadSelected.Visible = false;
                Height = 194;
            }
        }
    }
}
