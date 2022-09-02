using System;

namespace RBot;

public class ScriptBotStats
{
    /// <summary>
    /// The number of monsters killed by the bot.
    /// </summary>
    public int Kills { get; set; }
    /// <summary>
    /// The number of quests accepted (not unique).
    /// </summary>
    public int QuestsAccepted { get; set; }
    /// <summary>
    /// The number of quests completed and turned in (not unique).
    /// </summary>
    public int QuestsCompleted { get; set; }
    /// <summary>
    /// The number of times the player has died.
    /// </summary>
    public int Deaths { get; set; }
    /// <summary>
    /// The number of times the player has been relogged in.
    /// </summary>
    public int Relogins { get; set; }
    /// <summary>
    /// The number of drops picked up.
    /// </summary>
    public int Drops { get; set; }
}
