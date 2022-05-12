using Newtonsoft.Json;
using RBot.Repos;
using RBot.Utils;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBot;
public partial class GitHubAuthDialog : Form
{
    private DeviceCodeResponse deviceCode { get; set; }
    private TokenResponse token { get; set; }

    public GitHubAuthDialog()
    {
        InitializeComponent();
        btnOpenBrowser.Enabled = false;
        btnAuth.Enabled = false;
    }
    public async Task<DeviceCodeResponse> GetDeviceCode()
    {
        var content = new Dictionary<string, string> { { "client_id", "449f889db3d655d2ef4a" }, { "scope", "public_repo" } };
        var encodedContent = new FormUrlEncodedContent(content);
        var response = await HttpClients.GetGHClient().PostAsync("https://github.com/login/device/code", encodedContent);
        return response.IsSuccessStatusCode
            ? deviceCode = JsonConvert.DeserializeObject<DeviceCodeResponse>(await response.Content.ReadAsStringAsync())
            : deviceCode = null;
    }

    public async Task<TokenResponse> GetAccessToken()
    {
        var content = new Dictionary<string, string>
        {
            { "client_id", "449f889db3d655d2ef4a" },
            { "device_code", deviceCode.DeviceCode },
            { "grant_type", "urn:ietf:params:oauth:grant-type:device_code" }
        };
        var encodedContent = new FormUrlEncodedContent(content);
        var response = await HttpClients.GetGHClient().PostAsync("https://github.com/login/oauth/access_token", encodedContent);
        return response.IsSuccessStatusCode
            ? token = JsonConvert.DeserializeObject<TokenResponse>(await response.Content.ReadAsStringAsync())
            : token = null;
    }

    private async void btnDeviceCode_Click(object sender, EventArgs e)
    {
        btnDeviceCode.Enabled = false;
        await GetDeviceCode();
        if(deviceCode is not null)
        {
            txtUserCode.Text = deviceCode.UserCode;
            Clipboard.SetText(deviceCode.UserCode);
            lblcopy.Text = "Copied. Click Open Browser.";
            btnOpenBrowser.Enabled = true;
            return;
        }
        lblcopy.Text = "Error. Please, wait 10s";
        await Task.Run(async () => { await Task.Delay(10_000); btnDeviceCode.CheckedInvoke(() => btnDeviceCode.Enabled = true); lblcopy.CheckedInvoke(() => lblcopy.Text = ""); });
    }

    private void btnOpenBrowser_Click(object sender, EventArgs e)
    {
        btnOpenBrowser.Enabled = false;
        OpenLink.OpenBrowserLink("https://github.com/login/device");
        lblcopy.Text = "Do the site verification.\r\nOnly click \"Authorize\" after seeing the All set page.";
        btnAuth.Enabled = true;
    }

    private async void btnAuth_Click(object sender, EventArgs e)
    {
        await GetAccessToken();
        if(token is not null)
        {
            HttpClients.UserGitHubClient = new(token.AccessToken);
            AppRuntime.Options.Set("ghtoken", token.AccessToken);
            btnAuth.Enabled = false;
            shouldClose = true;
            lblcopy.Text = "All good to go!";
            return;
        }
        lblcopy.Text = "Error. Please, wait 10s";
        await Task.Run(async () => { await Task.Delay(10_000); btnAuth.CheckedInvoke(() => btnAuth.Enabled = true); lblcopy.CheckedInvoke(() => lblcopy.Text = ""); });
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        CloseMessage();
    }

    private void CloseMessage()
    {
        if (HttpClients.UserGitHubClient is not null)
        {
            Close();
            return;
        }
        if (MessageBox.Show("Without a GitHub authentication, the auto download of scripts is susceptible to rate limits and therefore fail, are you sure you want to skip it?\r\nYou can disable this popup in Options > Application Options and set Ignore GH Authentication to true.", "GitHub Authentication", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
        {
            shouldClose = true;
            Close();
        }
    }
    private bool shouldClose;
    private void GitHubAuthDialog_FormClosing(object sender, FormClosingEventArgs e)
    {
        if(!shouldClose)
        {
            e.Cancel = true;
            CloseMessage();
        }
    }
}
