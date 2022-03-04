using RBot.Items;
using System.Threading.Tasks;

namespace RBot;

public class ScriptEvents : ScriptableObject
{
    /// <summary>
    /// Occurs when the player dies.
    /// </summary>
    public event PlayerDeathEventHandler PlayerDeath;
    /// <summary>
    /// Occurs when the player kills a monster.
    /// </summary>
    public event MonsterKilledEventHandler MonsterKilled;
    /// <summary>
    /// Occurs when a quest is accepted by the script.
    /// </summary>
    public event QuestAcceptedEventHandler QuestAccepted;
    /// <summary>
    /// Occurs when a quest is turned in by the script.
    /// </summary>
    public event QuestTurnInEventHandler QuestTurnedIn;
    /// <summary>
    /// Occurs when the current map changes.
    /// </summary>
    /// <remarks>Note that the MapChanged is fired when you send the join command.<br></br>Before using any Bot.Map method be sure to add a delay.</remarks>
    public event MapChangedEventHandler MapChanged;
    /// <summary>
    /// Occurs when the current cell changes.
    /// </summary>
    public event CellChangedEventHandler CellChanged;
    /// <summary>
    /// Occurs when auto relogin has been triggered (but the relogin has not been carried out yet).
    /// </summary>
    public event ReloginTriggeredEventHandler ReloginTriggered;
    /// <summary>
    /// Occurs when an extension packet is receieved.
    /// </summary>
    /// <remarks>The extension packet is a dynamic object deserialized from JSON.</remarks>
    public event ExtensionPacketEventHandler ExtensionPacketReceived;
    /// <summary>
    /// Occurs when the player turns AFK.
    /// </summary>
    public event AFKEventHandler PlayerAFK;
    /// <summary>
    /// Occurs when the player attempts to buy an item from a shop.
    /// </summary>
    public event TryBuyItemHandler TryBuyItem;
    /// <summary>
    /// Occurs when a counter attack from an Ultra boss starts/fades.
    /// </summary>
    public event CounterAttackHandler CounterAttack;
    /// <summary>
    /// Occurs when an item drops.
    /// </summary>
    public event ItemDroppedHandler ItemDropped;

    public event ScriptStoppingHandler ScriptStopping;

    /// <summary>
    /// Clears all the currently set event handlers.
    /// </summary>
    public void ClearHandlers()
    {
        PlayerDeath = null;
        MonsterKilled = null;
        QuestAccepted = null;
        QuestTurnedIn = null;
        MapChanged = null;
        CellChanged = null;
        ReloginTriggered = null;
        ExtensionPacketReceived = null;
        PlayerAFK = null;
        TryBuyItem = null;
        CounterAttack = null;
        ItemDropped = null;
        ScriptStopping = null;
    }

    public async Task OnScriptStoppedAsync()
    {
        await Task.Run(() => ScriptStopping?.Invoke(Bot));
    }

    public void OnItemDropped(InventoryItem item, bool addedToInv = false, int quantityNow = 0)
    {
        Task.Run(() => ItemDropped?.Invoke(Bot, item, addedToInv, quantityNow));
    }

    public void OnCounterAttack(bool faded)
    {
        Task.Run(() => CounterAttack?.Invoke(Bot, faded));
    }

    public void OnPlayerDeath()
    {
        Task.Run(() => PlayerDeath?.Invoke(Bot));
    }

    public void OnMonsterKilled()
    {
        Task.Run(() => MonsterKilled?.Invoke(Bot));
    }

    public void OnQuestAccepted(int questId)
    {
        Task.Run(() => QuestAccepted?.Invoke(Bot, questId));
    }

    public void OnQuestTurnIn(int questId)
    {
        Task.Run(() => QuestTurnedIn?.Invoke(Bot, questId));
    }

    public void OnMapChanged(string map)
    {
        Task.Run(() => MapChanged?.Invoke(Bot, map));
    }

    public void OnCellChanged(string map, string cell, string pad)
    {
        Task.Run(() => CellChanged?.Invoke(Bot, map, cell, pad));
    }

    public void OnReloginTriggered(bool kicked)
    {
        Task.Run(() => ReloginTriggered?.Invoke(Bot, kicked));
    }

    public void OnExtensionPacket(dynamic packet)
    {
        Task.Run(() => ExtensionPacketReceived?.Invoke(Bot, packet));
    }

    public void OnPlayerAFK()
    {
        Task.Run(() => PlayerAFK?.Invoke(Bot));
    }

    public void OnTryBuyItem(int shopId, int itemId, int shopItemId)
    {
        Task.Run(() => TryBuyItem?.Invoke(Bot, shopId, itemId, shopItemId));
    }

    public delegate void PlayerDeathEventHandler(ScriptInterface bot);
    public delegate void MonsterKilledEventHandler(ScriptInterface bot);
    public delegate void QuestAcceptedEventHandler(ScriptInterface bot, int questId);
    public delegate void QuestTurnInEventHandler(ScriptInterface bot, int questId);
    public delegate void MapChangedEventHandler(ScriptInterface bot, string map);
    public delegate void CellChangedEventHandler(ScriptInterface bot, string map, string cell, string pad);
    public delegate void ReloginTriggeredEventHandler(ScriptInterface bot, bool kicked);
    public delegate void ExtensionPacketEventHandler(ScriptInterface bot, dynamic packet);
    public delegate void AFKEventHandler(ScriptInterface bot);
    public delegate void TryBuyItemHandler(ScriptInterface bot, int shopId, int itemId, int shopItemId);
    public delegate void CounterAttackHandler(ScriptInterface bot, bool faded);
    public delegate void ItemDroppedHandler(ScriptInterface bot, InventoryItem item, bool addedToInv, int quantityNow);
    public delegate bool ScriptStoppingHandler(ScriptInterface bot);
}
