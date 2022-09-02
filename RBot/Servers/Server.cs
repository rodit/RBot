﻿using Newtonsoft.Json;
using RBot.Converters;

namespace RBot.Servers;

/// <summary>
/// A class holding information about a game server.
/// </summary>
public class Server
{
    /// <summary>
    /// The name of the game server.
    /// </summary>
    [JsonProperty("sName")]
    public string Name { get; set; }
    /// <summary>
    /// The IP address of the game server.
    /// </summary>
    [JsonProperty("sIP")]
    public string IP { get; set; }
    /// <summary>
    /// The chat level of this server (canned = 0, free = 2).
    /// </summary>
    [JsonProperty("iChat")]
    public int ChatLevel { get; set; }
    /// <summary>
    /// The port this server listens on.
    /// </summary>
    [JsonProperty("iPort")]
    public int Port { get; set; }
    /// <summary>
    /// Indicates whether or not the server is online.
    /// </summary>
    [JsonProperty("bOnline")]
    [JsonConverter(typeof(StringBoolConverter))]
    public bool Online { get; set; }
    /// <summary>
    /// The language of this server (en/pt).
    /// </summary>
    [JsonProperty("sLang")]
    public string Lang { get; set; }
    /// <summary>
    /// The number of players currently on the server.
    /// </summary>
    [JsonProperty("iCount")]
    public int PlayerCount { get; set; }
    /// <summary>
    /// Indicates whether this is an upgrade only server.
    /// </summary>
    [JsonProperty("bUpg")]
    [JsonConverter(typeof(StringBoolConverter))]
    public bool Upgrade { get; set; }

    public override string ToString()
    {
        return $"{Name} - {PlayerCount}";
    }

    public static bool operator ==(Server s0, Server s1)
    {
        return s0?.Name == s1?.Name;
    }

    public static bool operator !=(Server s0, Server s1)
    {
        return s0?.Name != s1?.Name;
    }
}
