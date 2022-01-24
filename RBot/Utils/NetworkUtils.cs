using System.Net;
using System.Net.Sockets;

namespace RBot.Utils;

public class NetworkUtils
{
    public static int GetAvailablePort()
    {
        int port;
        using (Socket socket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
        {
            socket.Bind(new IPEndPoint(IPAddress.Loopback, 0));
            port = ((IPEndPoint)socket.LocalEndPoint).Port;
        }
        return port;
    }
}
