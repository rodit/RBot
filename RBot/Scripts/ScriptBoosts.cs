using RBot.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace RBot;

public class ScriptBoosts : ScriptableObject
{
    private Thread BoostsThread;
    internal CancellationTokenSource BoostsCTS;

    public static event Action BoostsStarted;
    public static event Action BoostsStopped;

    /// <summary>
    /// Whether the boost thread is enabled.
    /// </summary>
    public bool Enabled => BoostsThread?.IsAlive ?? false;

    /// <summary>
    /// Whether it will use <see cref="ClassBoostID"/>
    /// </summary>
    public bool UseClassBoost { get; set; } = false;
    /// <summary>
    /// The Class Boost ID to be used.
    /// </summary>
    public int ClassBoostID { get; set; }

    /// <summary>
    /// Whether it will use <see cref="ExperienceBoostID"/>
    /// </summary>
    public bool UseExperienceBoost { get; set; } = false;
    /// <summary>
    /// The XP Boost ID to be used.
    /// </summary>
    public int ExperienceBoostID { get; set; }

    /// <summary>
    /// Whether it will use <see cref="GoldBoostID"/>
    /// </summary>
    public bool UseGoldBoost { get; set; } = false;
    /// <summary>
    /// The Gold Boost ID to be used.
    /// </summary>
    public int GoldBoostID { get; set; }

    /// <summary>
    /// Whether it will use <see cref="ReputationBoostID"/>
    /// </summary>
    public bool UseReputationBoost { get; set; } = false;
    /// <summary>
    /// The REP Boost ID to be used.
    /// </summary>
    public int ReputationBoostID { get; set; }

    /// <summary>
    /// Whether it is using any of the boost types.
    /// </summary>
    public bool UsingBoosts => UseClassBoost || UseExperienceBoost || UseGoldBoost || UseReputationBoost;

    /// <summary>
    /// Get and set <see cref="ClassBoostID"/> to the first boost found in the player's inventory.
    /// </summary>
    public void SetClassBoostID() => ClassBoostID = GetBoostID(BoostType.Class);

    /// <summary>
    /// Get and set <see cref="GoldBoostID"/> to the first boost found in the player's inventory.
    /// </summary>
    public void SetGoldBoostID() => GoldBoostID = GetBoostID(BoostType.Gold);

    /// <summary>
    /// Get and set <see cref="ExperienceBoostID"/> to the first boost found in the player's inventory.
    /// </summary>
    public void SetExperienceBoostID() => ExperienceBoostID = GetBoostID(BoostType.Experience);

    /// <summary>
    /// Get and set <see cref="ReputationBoostID"/> to the first boost found in the player's inventory.
    /// </summary>
    public void SetReputationBoostID() => ReputationBoostID = GetBoostID(BoostType.Reputation);

    /// <summary>
    /// Get and set all four boost types to the first boost found in the player's inventory.
    /// </summary>
    public void SetAllBoostsIDs()
    {
        SetClassBoostID();
        SetGoldBoostID();
        SetExperienceBoostID();
        SetReputationBoostID();
    }

    /// <summary>
    /// Return the ID of the first boost found in the player's inventory.
    /// </summary>
    /// <param name="boostType">The type of the boost to search for.</param>
    /// <returns>The ID of the boost.</returns>
    public int GetBoostID(BoostType boostType)
    {
        return boostType switch
        {
            BoostType.Gold => SearchBoost("gold"),
            BoostType.Class => SearchBoost("class"),
            BoostType.Reputation => SearchBoost("rep"),
            BoostType.Experience => SearchBoost("xp"),
            _ => 0,
        };
    }

    internal int SearchBoost(string name) 
        => (Bot.Inventory.Items?
            .Where(i => i.Category == ItemCategory.ServerUse)
            .Where(i => i.Name.ToLower().Contains(name.ToLower()))
            .FirstOrDefault())?.ID ?? 0;

    /// <summary>
    /// Start the boost thread.
    /// </summary>
    public void Start()
    {
        if (BoostsThread?.IsAlive ?? false)
            return;

        BoostsStarted?.Invoke();
        BoostsThread = new(() =>
        {
            BoostsCTS = new();
            Poll(BoostsCTS.Token);
            BoostsCTS.Dispose();
            BoostsCTS = null;
        });
        BoostsThread.Name = "Drops Thread";
        BoostsThread.Start();
    }

    private void Poll(CancellationToken token)
    {
        while (!token.IsCancellationRequested)
        {
            _UseBoost(UseGoldBoost, GoldBoostID, BoostType.Gold);

            _UseBoost(UseClassBoost, ClassBoostID, BoostType.Class);

            _UseBoost(UseExperienceBoost, ExperienceBoostID, BoostType.Experience);

            _UseBoost(UseReputationBoost, ReputationBoostID, BoostType.Reputation);
        }
    }

    private void _UseBoost(bool useBoost, int id, BoostType boostType)
    {
        if (!useBoost || id == 0 || Bot.Player.IsBoostActive(boostType))
            return;

        Bot.Player.UseBoost(id);
        Thread.Sleep(1000);
    }

    /// <summary>
    /// Stops the boost thread.
    /// </summary>
    public void Stop()
    {
        BoostsStopped?.Invoke();
        BoostsCTS?.Cancel();
    }
}
