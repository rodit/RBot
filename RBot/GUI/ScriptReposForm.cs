using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

using RBot.Repos;
using RBot.Utils;

namespace RBot
{
    public partial class ScriptReposForm : HideForm
    {
        private EventHandler _lastDownloadHandler;
        private EventHandler _lastLoadHandler;
        private EventHandler _lastDeleteHandler;

        public ScriptReposForm()
        {
            InitializeComponent();

            dataScripts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataScripts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataScripts.CellDoubleClick += DataScripts_CellDoubleClick;
            dataScripts.CellMouseClick += DataScripts_CellMouseClick;
        }

        private void DataScripts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridViewRow row = dataScripts.Rows[e.RowIndex];
                dataScripts.ClearSelection();
                dataScripts.CurrentCell = row.Cells[e.ColumnIndex];
                ScriptInfo script = row.Tag as ScriptInfo;
                bool downloaded = script.Downloaded;
                bool outdated = script.Outdated;
                btnLoad.Visible = btnDelete.Visible = downloaded;
                btnDownload.Visible = outdated || !downloaded;
                btnDownload.Text = outdated ? "Update" : "Download";
                if (_lastDownloadHandler != null)
                {
                    btnDownload.Click -= _lastDownloadHandler;
                    btnLoad.Click -= _lastLoadHandler;
                    btnDelete.Click -= _lastDeleteHandler;
                }
                btnDownload.Click += _lastDownloadHandler = async (s, e) => await _DownloadScript(script, row);
                btnLoad.Click += _lastLoadHandler = (s, e) =>
                {
                    ScriptManager.LoadedScript = script.LocalFile;
                    Forms.Scripts.Text = "Scripts - " + script.FileName;
                };
                btnDelete.Click += _lastDeleteHandler = (s, e) =>
                {
                    File.Delete(script.LocalFile);
                    File.Delete(script.LocalSha);
                    row.DefaultCellStyle.BackColor = Color.White;
                };
                cxtScripts.Show(dataScripts, dataScripts.PointToClient(Cursor.Position));
            }
        }

        private async void DataScripts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            _UIState(false);
            DataGridViewRow row = dataScripts.Rows[e.RowIndex];
            ScriptInfo info = row.Tag as ScriptInfo;
            lblStatus.Text = $"Downloading script {info.FileName}.";
            await _DownloadScript(info, row);
            lblStatus.Text = $"Downloaded {info.FileName}.";
            _UIState(true);
        }

        private async void ScriptReposForm_Load(object sender, EventArgs e)
        {
            await _Refresh();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await _Refresh();
        }

        private async void btnUpdateAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataScripts.Rows)
            {
                ScriptInfo script = row.Tag as ScriptInfo;
                if (script.Outdated)
                    await _DownloadScript(script, row);
            }
        }

        private void _UIState(bool b)
        {
            btnRefresh.Enabled = b;
            btnUpdateAll.Enabled = b;
            dataScripts.Enabled = b;
        }

        private async Task _Refresh()
        {
            _UIState(false);
            dataScripts.Rows.Clear();
            lblStatus.Text = "Fetching repos...";
            List<ScriptRepo> repos = await ScriptFetcher.GetRepos();
            lblStatus.Text = "Fetching scripts...";
            int total = 0;
            foreach (ScriptRepo repo in repos)
            {
                List<ScriptInfo> scripts = await ScriptFetcher.GetScripts(repo);
                lblStatus.Text = $"Found {scripts.Count} scripts.";
                total += scripts.Count;
                foreach (ScriptInfo script in scripts)
                {
                    DataGridViewRow row = dataScripts.Rows[dataScripts.Rows.Add(script.FileName, repo.Author, script.Size)];
                    row.Tag = script;
                    row.DefaultCellStyle.BackColor = script.Downloaded ? (script.Outdated ? Color.Yellow : Color.LightGreen) : Color.White;
                }
            }
            lblStatus.Text = $"Fetched {total} scripts.";
            _UIState(true);
        }

        private async Task _DownloadScript(ScriptInfo info, DataGridViewRow row)
        {
            DirectoryInfo parent = Directory.GetParent(info.LocalFile);
            if (!parent.Exists)
                parent.Create();
            using (RBotWebClient wc = new RBotWebClient())
            {
                await wc.DownloadFileTaskAsync(info.DownloadUrl, info.LocalFile);
                File.WriteAllText(info.LocalShaFile, info.Hash);
                row.DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }
    }
}
