using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using RBot.Repos;
using RBot.Utils;

namespace RBot;

public partial class ScriptReposForm : HideForm
{
    private DataGridViewRow[] currentRows = null;

    public ScriptReposForm()
    {
        InitializeComponent();

        dataScripts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataScripts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataScripts.CellDoubleClick += DataScripts_CellDoubleClick;
    }

    private async void DataScripts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
            return;
        var row = dataScripts.Rows[e.RowIndex];
        var info = row.Tag as ScriptInfo;
        await _DownloadScript(info, row);
    }

    private async void ScriptReposForm_Load(object sender, EventArgs e)
    {
        await _Refresh();
    }

    private async void btnRefresh_Click(object sender, EventArgs e)
    {
        await _Refresh();
    }

    private async Task _DownloadScripts(params Tuple<ScriptInfo, DataGridViewRow>[] scripts)
    {
        _UIState(false);
        if(scripts.Length == 1)
        {
            var info = scripts[0].Item1;
            var row = scripts[0].Item2;
            if(!info.Downloaded || info.Outdated)
            {
                statStatus.Text = $"Downloading {info.FileName}.";
                await _DownloadScript(info, row);
                statStatus.Text = $"Downloaded {info.FileName}.";
            }
            _UIState(true);
            return;
        }
        var downloads = scripts.Where(s => !s.Item1.Downloaded || s.Item1.Outdated).Select(s => _DownloadScript(s.Item1, s.Item2)).ToList();
        int count = downloads.Count;
        statStatus.Text = $"Downloading {count} scripts.";
        await Task.WhenAll(downloads);
        statStatus.Text = $"Downloaded {count} scripts.";
        _UIState(true);
        _UpdateStatusValue();
    }

    private async void btnDownload_Click(object sender, EventArgs e)
    {
        if (dataScripts.SelectedRows.Count == 0)
            return;

        var scripts = dataScripts.SelectedRows.Cast<DataGridViewRow>()
                                              .Select(r => new Tuple<ScriptInfo, DataGridViewRow>(r.Tag as ScriptInfo, r))
                                              .ToArray();

        await _DownloadScripts(scripts);
    }
    private void btnLoad_Click(object sender, EventArgs e)
    {
        if (dataScripts.SelectedRows.Count == 0 || dataScripts.SelectedRows.Count > 1)
            return;

        var info = dataScripts.SelectedRows[0].Tag as ScriptInfo;
        if (!info.Downloaded)
            statStatus.Text = $"Script \"{info.FileName}\" not found.";
        if(info.Downloaded)
        {
            Forms.Scripts.LoadScript(info.LocalFile);
            statStatus.Text = $"Loaded {info.FileName}.";
        }
    }

    private async void btnDelete_Click(object sender, EventArgs e)
    {
        if (dataScripts.SelectedRows.Count == 0)
            return;

        var scripts = dataScripts.SelectedRows.Cast<DataGridViewRow>()
                                              .Select(r => new Tuple<ScriptInfo, DataGridViewRow>(r.Tag as ScriptInfo, r))
                                              .ToArray();
        await _DeleteScripts(scripts);
    }

    private async Task _DeleteScripts(params Tuple<ScriptInfo, DataGridViewRow>[] scripts)
    {
        _UIState(false);
        if (scripts.Length == 1)
        {
            var info = scripts[0].Item1;
            var row = scripts[0].Item2;
            if (info.Downloaded)
            {
                statStatus.Text = $"Deleting {info.FileName}.";
                await _DeleteScript(info, row);
                statStatus.Text = $"Deleted {info.FileName}.";
            }
            _UIState(true);
            _UpdateStatusValue();
            return;
        }
        var downloads = scripts.Where(s => s.Item1.Downloaded).Select(s => _DeleteScript(s.Item1, s.Item2)).ToList();
        int count = downloads.Count;
        statStatus.Text = $"Deleting {count} scripts.";
        await Task.WhenAll(downloads);
        statStatus.Text = $"Deleted {count} scripts.";
        statStatus.Text = $"Deleted {count} scripts.";
        _UIState(true);
        _UpdateStatusValue();
    }

    private async void btnUpdateAll_Click(object sender, EventArgs e)
    {
        _UIState(false);
        int count = await _DownloadAllWhere(s => s.Item1.Outdated);
        statStatus.Text = $"Updated {count} scripts.";
        _UIState(true);
        _UpdateStatusValue();
    }

    private async void btnDownloadAll_Click(object sender, EventArgs e)
    {
        _UIState(false);
        int count = await _DownloadAllWhere(s => !s.Item1.Downloaded || s.Item1.Outdated);
        statStatus.Text = $"Downloaded {count} scripts.";
        _UIState(true);
        _UpdateStatusValue();
    }

    internal async Task<int> _DownloadAllWhere(Func<Tuple<ScriptInfo, DataGridViewRow>, bool> pred)
    {
        var toUpdate = dataScripts.Rows.Cast<DataGridViewRow>()
                                       .Select(r => new Tuple<ScriptInfo, DataGridViewRow>(r.Tag as ScriptInfo, r))
                                       .Where(pred);
        int count = toUpdate.Count();
        statStatus.Text = $"Downloading {count} scripts.";
        await Task.WhenAll(toUpdate.Select(s => _DownloadScript(s.Item1, s.Item2)));
        return count;
    }

    private void _UIState(bool b)
    {
        btnDownloadAll.CheckedInvoke(() => btnDownloadAll.Enabled = b);
        btnUpdateAll.CheckedInvoke(() => btnUpdateAll.Enabled = b);
        dataScripts.CheckedInvoke(() => dataScripts.Enabled = b);
        btnRefresh.CheckedInvoke(() => btnRefresh.Enabled = b);
        txtFilter.CheckedInvoke(() => txtFilter.Enabled = b);
    }

    internal async Task _Refresh()
    {
        _UIState(false);
        dataScripts.SuspendLayout();
        dataScripts.Rows.Clear();
        statStatus.Text = "Fetching repos...";
        List<ScriptRepo> repos = await ScriptFetcher.GetRepos();
        statStatus.Text = "Fetching scripts...";
        int total = 0;
        foreach (ScriptRepo repo in repos)
        {
            List<ScriptInfo> scripts = await ScriptFetcher.GetScripts(repo);
            statStatus.Text = $"Found {scripts.Count} scripts.";
            total += scripts.Count;
            foreach (ScriptInfo script in scripts)
            {
                DataGridViewRow row = dataScripts.Rows[dataScripts.Rows.Add(script.FileName, repo.Author, script.RelativePath, script.Size)];
                row.Tag = script;
                row.DefaultCellStyle.BackColor = script.Downloaded ? (script.Outdated ? Color.Yellow : Color.LightGreen) : Color.White;
            }
        }
        statStatus.Text = $"Fetched {total} scripts.";
        currentRows = new DataGridViewRow[dataScripts.RowCount];
        dataScripts.Rows.CopyTo(currentRows, 0);
        dataScripts.PerformLayout();
        _UIState(true);
        _UpdateStatusValue();
    }

    int downloaded, outdated, total = 0;
    private void _UpdateStatusValue()
    {
        var infos = dataScripts.Rows.Cast<DataGridViewRow>().Select(r => (ScriptInfo)r.Tag);
        downloaded = infos.Count(s => s.Downloaded);
        outdated = infos.Count(s => s.Outdated);
        total = infos.Count();
        statDownloaded.Text = $"Downloaded: {downloaded}/{total}";
        statOutdated.Text = $"Outdated: {outdated}";
    }

    internal bool MissingScripts => downloaded < total || outdated > 0;

    private async Task _DownloadScript(ScriptInfo info, DataGridViewRow row)
    {
        DirectoryInfo parent = Directory.GetParent(info.LocalFile);
        if (!parent.Exists)
            parent.Create();
        using (var response = await HttpClients.Default.GetAsync(info.DownloadUrl))
        using (Stream streamToReadFrom = await response.Content.ReadAsStreamAsync())
        using (var fileStream = new FileStream(info.LocalFile, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite, 4096, true))
        {
            streamToReadFrom.Seek(0, SeekOrigin.Begin);
            await streamToReadFrom.CopyToAsync(fileStream);
        }
        DirectoryInfo sha = Directory.GetParent(info.LocalShaFile);
        if (!sha.Exists)
            sha.Create();
        await File.WriteAllTextAsync(info.LocalShaFile, info.Hash);
        row.DefaultCellStyle.BackColor = Color.LightGreen;
    }

    private void ScriptReposForm_ResizeEnd(object sender, EventArgs e)
    {
        dataScripts.ResumeLayout();
    }

    private async Task _DeleteScript(ScriptInfo info, DataGridViewRow row)
    {
        await Task.Run(() =>
        {
            File.Delete(info.LocalShaFile);
            File.Delete(info.LocalFile);
            row.DefaultCellStyle.BackColor = Color.White;
        });
    }

    private void txtFilter_TextChanged(object sender, EventArgs e)
    {
        if (currentRows is null || currentRows.Length < 1)
            return;

        dataScripts.SuspendLayout();
        dataScripts.Rows.Clear();

        if (string.IsNullOrEmpty(txtFilter.Text))
        {
            dataScripts.Rows.AddRange(currentRows);
            dataScripts.PerformLayout();
            statStatus.Text = $"Current showing {dataScripts.Rows.Count} scripts.";
            return;
        }
        dataScripts.Rows.AddRange(currentRows.Where(i => ((ScriptInfo)i.Tag).ToString().Contains(txtFilter.Text, StringComparison.OrdinalIgnoreCase)).ToArray());
        statStatus.Text = $"Current showing {dataScripts.Rows.Count} scripts.";
        dataScripts.PerformLayout();
    }
}
