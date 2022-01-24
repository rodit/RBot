using System.Collections.Generic;
using RBot.Flash;

namespace RBot.Servers;

/// <summary>
/// Holds a list of game servers.
/// </summary>
/// <remarks>This can only be used once the user has logged in.</remarks>
public class ServerList
{
    /// <summary>
    /// The name of the last server the player was connected to.
    /// </summary>
    public static string LastServerIP { get; set; }

    /// <summary>
    /// The list of available game servers.
    /// </summary>
    [ObjectBinding("serialCmd.servers")]
    public static List<Server> Servers { get; }
}
