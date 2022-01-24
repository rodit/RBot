using RBot.GameProxy;
using RBot.Servers;
using System;
using System.Collections.Generic;
using System.Net;

namespace RBot;

public class ScriptInterceptor : ScriptableObject
{
    private List<Interceptor> interceptors = new();

    /// <summary>
    /// Starts interceping the given packets, when they are received it will invoke the given action.
    /// </summary>
    /// <param name="toIntercept">A list of packets to listen for.</param>
    /// <param name="onlyInbound">Whether it should check packets from client to server.</param>
    /// <param name="action">The action it will perform when the packet is intercepted.</param>
    /// <param name="server">The server to login, if null will use the players current server.</param>
    public void StartIntercepting(List<string> toIntercept, bool onlyInbound, Action action, Server server = null)
    {
        if (!Bot.GameProxy.Running)
        {
            if (server == null)
                server = ServerList.Servers.Find(s => s.IP == Bot.Player.ServerIP) ?? ServerList.Servers[0];

            IPAddress ip = IPAddress.TryParse(server.IP, out IPAddress addr) ? addr : Dns.GetHostEntry(server.IP).AddressList[0];
            Bot.GameProxy.Destination = new IPEndPoint(ip, 5588);
            Bot.GameProxy.Start();
            Bot.Player.Logout();
            Bot.Player.Login(Bot.Player.Username, Bot.Player.Password);
            Bot.Player.ConnectIP("127.0.0.1");
        }
        ScriptLogInterceptor logInterceptor = new(toIntercept, onlyInbound);
        logInterceptor.Intercepted += (_) => action.Invoke();
        interceptors.Add(logInterceptor);
        Bot.GameProxy.Interceptors.Add(logInterceptor);
        
    }
    /// <summary>
    /// Stops all the script interceptors
    /// </summary>
    public void StopIntercepting()
    {
        foreach (Interceptor interceptor in interceptors)
        {
            ((ScriptLogInterceptor)interceptor).ClearEvents();
            Bot.GameProxy.Interceptors.Remove(interceptor);
        }
    }
}

public class ScriptLogInterceptor : Interceptor
{
    public int Priority => 0;

    public delegate void InterceptedEventHandler(ScriptInterface bot);
    public event InterceptedEventHandler Intercepted;
    private readonly List<string> ToIntercept = new();
    private readonly bool OnlyInbound;

    public ScriptLogInterceptor(List<string> toIntercept, bool onlyInbound)
    {
        ToIntercept = toIntercept;
        OnlyInbound = onlyInbound;
    }

    public void Intercept(MessageInfo message, bool outbound)
    {
        if (OnlyInbound && outbound)
            return;

        foreach(var packet in ToIntercept)
        {
            if (message.Content == packet)
                OnIntercepted();
        }
    }

    public void OnIntercepted()
    {
        Intercepted?.Invoke(ScriptInterface.Instance);
    }

    public void ClearEvents()
    {
        Intercepted = null;
    }
}
