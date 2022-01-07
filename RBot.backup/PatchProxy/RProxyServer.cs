using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;

using Titanium.Web.Proxy;
using Titanium.Web.Proxy.EventArguments;
using Titanium.Web.Proxy.Models;

using RBot.Utils;

namespace RBot.PatchProxy
{
    public class RProxyServer
    {
        public const int DefaultPort = 43831;

        public static RProxyServer Instance { get; set; }

        public int Port { get; set; } = DefaultPort;

        private ProxyServer _server;
        private ExplicitProxyEndPoint _ep;
        private Dictionary<string, List<Patch>> _patches = new Dictionary<string, List<Patch>>();

        public RProxyServer(int port)
        {
            _server = new ProxyServer(false);
            _ep = new ExplicitProxyEndPoint(IPAddress.Any, port == 0 ? NetworkUtils.GetAvailablePort() : port, false);
            Port = _ep.Port;
            _server.AddEndPoint(_ep);
            _server.CertificateManager.RootCertificate = new X509Certificate2();
            _server.BeforeRequest += _server_BeforeRequest;
            _server.BeforeResponse += _server_BeforeResponse;
        }

        public void Start()
        {
            List<Patch> cList = null;
            if (File.Exists("patch.txt"))
            {
                foreach (string line in File.ReadLines("patch.txt").Select(l => l.Trim()))
                {
                    if (line.StartsWith("["))
                        _patches[line.Substring(1, line.Length - 2)] = cList = new List<Patch>();
                    else if (!line.StartsWith(";") && line != string.Empty)
                        cList.Add(new Patch(line));
                }
            }
            _server.Start();
        }

        private async Task _server_BeforeRequest(object sender, SessionEventArgs e)
        {
            if (!e.HttpClient.IsHttps)
                e.HttpClient.Request.Url = e.HttpClient.Request.Url.Replace("http://", "https://");
        }

        private async Task _server_BeforeResponse(object sender, SessionEventArgs e)
        {
            byte[] data = await e.GetResponseBody();
            data = e.HttpClient.Response.StatusCode == 301 ? await Fix301(e) : data;
            if (_patches.TryGetValue(e.HttpClient.Request.Url, out List<Patch> patches) && patches.Count > 0)
            {
                Debug.WriteLine($"{patches.Count} patches found for {e.HttpClient.Request.Url}.");
                string tmpFile = Path.Combine("tmp", Path.GetRandomFileName() + ".swf");
                File.WriteAllBytes(tmpFile, data);

                ProcessStartInfo psi = new ProcessStartInfo("tools/swfdecompress.exe", tmpFile);
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;
                psi.WorkingDirectory = Environment.CurrentDirectory;
                Process.Start(psi).WaitForExit();

                data = File.ReadAllBytes(tmpFile);
                File.Delete(tmpFile);
                patches.ForEach(p =>
                {
                    Debug.WriteLine($"Patch {(p.Apply(data) ? "successful" : "unsuccessful")}.");
                });
            }
            if (AppRuntime.Options.Get<bool>("proxy.cache.disable"))
            {
                e.HttpClient.Response.Headers.RemoveHeader("Cache-Control");
                e.HttpClient.Response.Headers.AddHeader("Cache-Control", "no-store");
            }
            e.SetResponseBody(data);
        }

        private async Task<byte[]> Fix301(SessionEventArgs e)
        {
            byte[] data = null;
            using (RBotWebClient wc = new RBotWebClient())
            {
                try
                {
                    data = await wc.DownloadDataTaskAsync(e.HttpClient.Response.Headers.GetHeaders("Location")[0].Value);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
            e.HttpClient.Response.StatusCode = 200;
            e.HttpClient.Response.Headers.RemoveHeader("Location");
            return data;
        }
    }
}
