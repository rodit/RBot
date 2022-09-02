﻿using RBot.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RBot.GameProxy;

/// <summary>
/// Intercepts traffice from the game client to the game server.
/// </summary>
public class CaptureProxy
{
    internal CancellationTokenSource CaptureProxyCTS;
    /// <summary>
    /// The default port for the capture proxy to run on.
    /// </summary>
    public const int DefaultPort = 5588;
    /// <summary>
    /// The destination server for the proxy to relay traffic to and from.
    /// </summary>
    public IPEndPoint Destination { get; set; }
    /// <summary>
    /// The list of packet interceptors.
    /// </summary>
    public List<Interceptor> Interceptors { get; } = new List<Interceptor>();
    /// <summary>
    /// Indicates whether the proxy is running or not.
    /// </summary>
    public bool Running { get; private set; }

    private Thread _thread;
    private readonly TcpListener _listener;
    private TcpClient _forwarder;
    private TcpClient _client;

    public CaptureProxy()
    {
        _listener = new TcpListener(IPAddress.Loopback, DefaultPort);
    }

    /// <summary>
    /// Starts the capture proxy.
    /// </summary>
    public void Start()
    {
        Running = true;
        _thread = new(() =>
        {
            CaptureProxyCTS = new();
            _Listen(CaptureProxyCTS.Token);
            CaptureProxyCTS.Dispose();
            CaptureProxyCTS = null;
        });
        _thread.Name = "Capture Proxy";
        _thread.Start();
    }

    /// <summary>
    /// Stops the capture proxy.
    /// </summary>
    public void Stop()
    {
        _listener?.Stop();
        if (_forwarder?.Connected ?? false)
            _forwarder.Close();
        if (_client?.Connected ?? false)
            _client.Close();
        CaptureProxyCTS?.Cancel();
        Running = false;
    }

    private void _Listen(CancellationToken token)
    {
        _listener.Start();
        while (!token.IsCancellationRequested)
        {
            try
            {
                _client = _listener.AcceptTcpClient();
                _forwarder = new TcpClient();
                _forwarder.Connect(Destination);

                Task.Factory.StartNew(() => _DataInterceptor(_client, _forwarder, true, token));
                Task.Factory.StartNew(() => _DataInterceptor(_forwarder, _client, false, token));
            }
            catch { }
        }
    }

    private async Task _DataInterceptor(TcpClient target, TcpClient destination, bool outbound, CancellationToken token)
    {
        byte[] msgbuf = new byte[4096];
        int read = 0;
        List<byte> cpacket = new();
        while (!token.IsCancellationRequested)
        {
            read = await target.GetStream().ReadAsync(msgbuf, 0, 4096);

            if (read == 0)
                Thread.Sleep(10);

            for (int i = 0; i < read; i++)
            {
                if (token.IsCancellationRequested)
                    break;

                byte b = msgbuf[i];
                if (b > 0)
                {
                    cpacket.Add(b);
                    continue;
                }
                byte[] data = cpacket.ToArray();
                cpacket.Clear();

                MessageInfo message = new(Encoding.UTF8.GetString(data, 0, data.Length));
                Interceptors.OrderBy(i => i.Priority).ForEach(i => i.Intercept(message, outbound));
                if (message.Send)
                {
                    byte[] msg = new byte[message.Content.Length + 1];
                    Buffer.BlockCopy(_ToBytes(message.Content), 0, msg, 0, message.Content.Length);
                    //await destination.GetStream().WriteAsync(msg, 0, msg.Length, token);
                    await destination.GetStream().WriteAsync(msg, token);
                    msg = null;
                }
            }
        }
    }

    private static byte[] _ToBytes(string s)
    {
        return s.Select(c => (byte)c).ToArray();
    }
}
