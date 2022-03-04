using RBot.Items;
using System;
using System.Collections.Generic;
using System.Threading;

namespace RBot;

public class ScriptWait : ScriptableObject
{
    /// <summary>
    /// The duration, in milliseconds, for which the thread will sleep before re-checking whether the awaited condition is met.
    /// </summary>
    public static int WAIT_SLEEP = 250;

    public AutoResetEvent ItemBuyEvent = new(false);
    public AutoResetEvent ItemSellEvent = new(false);
    public AutoResetEvent BankLoadEvent = new(false);

    /// <summary>
    /// Whether to override all Wait timeouts with each the defined ActionTimeout. By default they will not change the behaviour of the bot.<br/>
    /// Methods mentioned in each ActionTimeout are used by SafeTimings.
    /// </summary>
    public bool OverrideTimeout { get; set; } = false;

    /// <summary>
    /// The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.<br/>
    /// This will override any action timeout made by the Player:<br/>
    /// <see cref="ForPlayerPosition(float, float, int)"/>;<br/>
    /// <see cref="ForCombatExit(int)"/>.
    /// </summary>
    public int PlayerActionTimeout { get; set; } = 10;

    /// <summary>
    /// The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.<br/>
    /// This will override any action timeout related to monsters:<br/>
    /// <see cref="ForMonsterSpawn(string, int)"/>.
    /// </summary>
    public int MonsterActionTimeout { get; set; } = 10;

    /// <summary>
    /// The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.
    /// This will override any action timeout related to maps:<br/>
    /// <see cref="ForMapLoad(string, int)"/>;<br/>
    /// <see cref="ForCellChange(string)"/>.
    /// </summary>
    public int MapActionTimeout { get; set; } = 20;

    /// <summary>
    /// The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.
    /// This will override any action timeout related to drops:<br/>
    /// <see cref="ForPickup(string, int)"/>;<br/>
    /// <see cref="ForDrop(string, int)"/>.
    /// </summary>
    public int DropActionTimeout { get; set; } = 10;

    /// <summary>
    /// The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.
    /// This will override any action timeout related to items:<br/>
    /// <see cref="ForItemBuy(int)"/>;<br/>
    /// <see cref="ForItemSell(int)"/>;<br/>
    /// <see cref="ForItemEquip(string, int)"/>;<br/>
    /// <see cref="ForItemEquip(int, int)"/>;<br/>
    /// <see cref="ForBankToInventory(string, int)"/>;<br/>
    /// <see cref="ForInventoryToBank(string, int)"/>.
    /// </summary>
    public int ItemActionTimeout { get; set; } = 14;

    /// <summary>
    /// The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.
    /// This will override any action timeout related to quests:<br/>
    /// <see cref="ForQuestAccept(int, int)"/>;<br/>
    /// <see cref="ForQuestComplete(int, int)"/>.
    /// </summary>
    public int QuestActionTimeout { get; set; } = 14;

    /// <summary>
    /// The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.
    /// This will override any action timeout related to game actions:<br/>
    /// <see cref="ForActionCooldown(GameActions, int)"/>;<br/>
    /// <see cref="ForActionCooldown(string, int)"/>.
    /// </summary>
    public int GameActionTimeout { get; set; } = 40;

    /// <summary>
    /// Waits until the player has reached a specified position.
    /// </summary>
    /// <param name="x">The x-coordinate the player should be at.</param>
    /// <param name="y">The y-coordinate the player should be out.</param>
    /// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
    public bool ForPlayerPosition(float x, float y, int timeout = 10)
    {
        return ForTrue(() => !Bot.Player.Playing || (Bot.Player.X == x && Bot.Player.Y == y), OverrideTimeout ? PlayerActionTimeout : timeout);
    }

    /// <summary>
    /// Waits until the player is no longer in combat.
    /// </summary>
    /// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
    public bool ForCombatExit(int timeout = 10)
    {
        return ForTrue(() => !Bot.Player.Playing || !Bot.Player.InCombat, OverrideTimeout ? PlayerActionTimeout : timeout);
    }

    /// <summary>
    /// Waits until the currently targeted monster has been killed.
    /// </summary>
    /// <remarks>This actually waits for the player to have no target selected, so may not accurately reflect when the current monster is killed.</remarks>
    public bool ForMonsterDeath(int timeout = -1)
    {
        return ForTrue(() => !Bot.Player.Playing || !Bot.Player.HasTarget, () =>
        {
            Bot.Player.UntargetSelf();
            Bot.Player.ApproachTarget();
        }, timeout, WAIT_SLEEP / 5);
    }

    internal bool _ForMonsterDeath(CancellationToken? token, int timeout = -1)
    {
        return ForTrueOrCancel(() => !Bot.Player.Playing || !Bot.Player.HasTarget, () =>
        {
            Bot.Player.UntargetSelf();
            Bot.Player.ApproachTarget();
        }, token, timeout, WAIT_SLEEP / 5);
    }

    /// <summary>
    /// Waits until the specified monster is present in the current cell.
    /// </summary>
    /// <param name="name">The name of the monster to wait for.</param>
    /// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP / 2 milliseconds) before the wait is cancelled.</param>
    public bool ForMonsterSpawn(string name, int timeout = 10)
    {
        return ForTrue(() => !Bot.Player.Playing || Bot.Monsters.Exists(name), OverrideTimeout ? MonsterActionTimeout : timeout);
    }

    /// <summary>
    /// Waits until the player is fully rested (has maximum HP and mana).
    /// </summary>
    /// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
    public bool ForFullyRested(int timeout = -1)
    {
        return ForTrue(() => !Bot.Player.Playing || (Bot.Player.Health >= Bot.Player.MaxHealth && Bot.Player.Mana >= Bot.Player.MaxMana), timeout);
    }

    /// <summary>
    /// Waits until a map is fully loaded.
    /// </summary>
    /// <param name="map">The name of the map to wait for.</param>
    /// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
    /// <returns>Whether or not the timeout was reached.</returns>
    public bool ForMapLoad(string map, int timeout = 20)
    {
        string name = map.Split('-')[0].ToLower();
        bool b0 = ForTrue(() => Bot.Map.Name.Equals(name, StringComparison.OrdinalIgnoreCase), OverrideTimeout ? MapActionTimeout : timeout);
        return b0 && ForTrue(() => !Bot.Player.Playing || Bot.Map.Loaded, OverrideTimeout ? MapActionTimeout : timeout);
    }

    /// <summary>
    /// Waits for the current cell to change to the specified one.
    /// </summary>
    /// <param name="cell">The name of the cell to wait for.</param>
    /// <remarks>Changing between cells should be instant, so this wait is usually not necessary at all.</remarks>
    public bool ForCellChange(string cell)
    {
        return ForTrue(() => !Bot.Player.Playing || Bot.Player.Cell.Equals(cell, StringComparison.OrdinalIgnoreCase), OverrideTimeout ? MapActionTimeout : WAIT_SLEEP / 4);
    }

    /// <summary>
    /// Waits for a drop of the specified item to be picked up.
    /// </summary>
    /// <param name="item">The name of the item to wait for.</param>
    /// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
    /// <remarks>This actually waits for no drops of the specified item to be available, so can be used even when you do not expect the drop to exist.</remarks>
    public bool ForPickup(string item, int timeout = 10)
    {
        return ForTrue(() => !Bot.Player.Playing || !Bot.Player.DropExists(item), OverrideTimeout ? DropActionTimeout : timeout);
    }

    internal bool _ForPickup(string item, int timeout = 10)
    {
        return _ForTrue(() => !Bot.Player.Playing || !Bot.Player.DropExists(item), null, OverrideTimeout ? DropActionTimeout : timeout);
    }

    /// <summary>
    /// Waits for a drop of the specified item to exist.
    /// </summary>
    /// <param name="item">The name of the item to wait for.</param>
    /// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
    public bool ForDrop(string item, int timeout = 10)
    {
        return ForTrue(() => !Bot.Player.Playing || Bot.Player.DropExists(item), OverrideTimeout ? DropActionTimeout : timeout);
    }

    /// <summary>
    /// Waits for an item to be bought.
    /// </summary>
    /// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
    public bool ForItemBuy(int timeout = 10)
    {
        return ItemBuyEvent.WaitOne((OverrideTimeout ? ItemActionTimeout : timeout) * WAIT_SLEEP);
    }

    /// <summary>
    /// Waits for an item to be sold.
    /// </summary>
    /// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
    public bool ForItemSell(int timeout = 10)
    {
        return ItemSellEvent.WaitOne((OverrideTimeout ? ItemActionTimeout : timeout) * WAIT_SLEEP);
    }

    /// <summary>
    /// Waits for the specified item to be equipped.
    /// </summary>
    /// <param name="id">The id of the item to wait for.</param>
    /// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
    public bool ForItemEquip(int id, int timeout = 10)
    {
        return ForTrue(() => !Bot.Player.Playing || (Bot.Inventory.TryGetItem(id, out InventoryItem i) && i.Equipped), OverrideTimeout ? ItemActionTimeout : timeout);
    }

    /// <summary>
    /// Waits for the specified item to be equipped.
    /// </summary>
    /// <param name="item">The name of the item to wait for.</param>
    /// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
    public bool ForItemEquip(string item, int timeout = 10)
    {
        return ForTrue(() => !Bot.Player.Playing || !Bot.Inventory.TryGetItem(item, out InventoryItem i) || i.Equipped, OverrideTimeout ? ItemActionTimeout : timeout);
    }

    /// <summary>
    /// Waits for the specified item to have moved from the bank to the main inventory.
    /// </summary>
    /// <param name="item">The name of the item to wait for.</param>
    /// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
    public bool ForBankToInventory(string item, int timeout = 14)
    {
        return ForTrue(() => !Bot.Player.Playing || !Bot.Bank.Contains(item), OverrideTimeout ? ItemActionTimeout : timeout, WAIT_SLEEP / 2);
    }

    /// <summary>
    /// Waits for the specified item to have moved from the main inventory to the bank.
    /// </summary>
    /// <param name="item">The name of the item to wait for.</param>
    /// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
    public bool ForInventoryToBank(string item, int timeout = 14)
    {
        return ForTrue(() => !Bot.Player.Playing || !Bot.Inventory.Contains(item), OverrideTimeout ? ItemActionTimeout : timeout, WAIT_SLEEP / 2);
    }

    /// <summary>
    /// Waits for the bank to be loaded. If the bank is already loaded, this method does not wait at all.
    /// </summary>
    /// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
    public bool ForBankLoad(int timeout = 20)
    {
        return BankLoadEvent.WaitOne(timeout * WAIT_SLEEP);
    }

    /// <summary>
    /// Waits for the specified quest to be accepted.
    /// </summary>
    /// <param name="id">The id of the quest to be accepted.</param>
    /// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
    public bool ForQuestAccept(int id, int timeout = 14)
    {
        return ForTrue(() => !Bot.Player.Playing || Bot.Quests.IsInProgress(id), OverrideTimeout ? QuestActionTimeout : timeout, WAIT_SLEEP / 2);
    }

    /// <summary>
    /// Waits for the specified quest to be completed.
    /// </summary>
    /// <param name="id">The id of the quest to be completed.</param>
    /// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
    /// <remarks>This actually waits until the quest is no longer in progress so does not guarentee that the quest has been completed; it could have never been accepted in the first place.</remarks>
    public bool ForQuestComplete(int id, int timeout = 10)
    {
        return ForTrue(() => !Bot.Player.Playing || !Bot.Quests.IsInProgress(id), OverrideTimeout ? QuestActionTimeout : timeout, WAIT_SLEEP / 2);
    }

    /// <summary>
    /// Waits for the specified skill to cooldown.
    /// </summary>
    /// <param name="index">The index of the skill.</param>
    /// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
    public bool ForSkillCooldown(int index, int timeout = 50)
    {
        return ForTrue(() => Bot.Player.CanUseSkill(index), timeout, WAIT_SLEEP);
    }

    /// <summary>
    /// Waits for the specified function to return the specified value.
    /// </summary>
    /// <param name="func">The function to poll.</param>
    /// <param name="val">The value to wait for.</param>
    /// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
    public bool For(Func<object> func, object val, int timeout = 10)
    {
        return ForTrue(() => func() == val, timeout);
    }

    /// <summary>
    /// Waits for the specified function to return true.
    /// </summary>
    /// <param name="pred">The function to poll.</param>
    /// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
    /// <param name="sleepOverride">The time to sleep between polling the predicate function (-1 = WAIT_SLEEP).</param>
    public bool ForTrue(Func<bool> pred, int timeout, int sleepOverride = -1)
    {
        return ForTrue(pred, null, timeout, sleepOverride);
    }

    /// <summary>
    /// Waits for the specified function to return true.
    /// </summary>
    /// <param name="pred">The function to poll.</param>
    /// <param name="loopFunc">A function to run in between polling the predicate function.</param>
    /// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP or sleepOverride milliseconds) before the wait is cancelled.</param>
    /// <param name="sleepOverride">The time to sleep between polling the predicate function (-1 = WAIT_SLEEP).</param>
    public bool ForTrue(Func<bool> pred, Action loopFunc, int timeout, int sleepOverride = -1)
    {
        int counter = 0;
        while (!pred() && !Bot.ShouldExit())
        {
            CheckScriptTermination();
            if (timeout > 0 && counter >= timeout)
                return false;
            loopFunc?.Invoke();
            Thread.Sleep(sleepOverride == -1 ? WAIT_SLEEP : sleepOverride);
            counter++;
        }
        if (Bot.ShouldExit())
            Thread.Sleep(1000);
        return true;
    }

    internal bool ForTrueOrCancel(Func<bool> pred, Action loopFunc, CancellationToken? token, int timeout, int sleepOverride = -1)
    {
        int counter = 0;
        while (!pred() && !Bot.ShouldExit() && (!token?.IsCancellationRequested ?? true))
        {
            CheckScriptTermination();
            if (timeout > 0 && counter >= timeout)
                return false;
            loopFunc?.Invoke();
            if(!token?.IsCancellationRequested ?? true)
                Thread.Sleep(sleepOverride == -1 ? WAIT_SLEEP : sleepOverride);
            counter++;
        }
        if (Bot.ShouldExit())
            Thread.Sleep(1000);
        return true;
    }

    internal bool _ForTrue(Func<bool> pred, Action loopFunc, int timeout, int sleepOverride = -1)
    {
        int counter = 0;
        while (!pred() && !Bot.ShouldExit())
        {
            if (timeout > 0 && counter >= timeout)
                return false;
            loopFunc?.Invoke();
            Thread.Sleep(sleepOverride == -1 ? WAIT_SLEEP : sleepOverride);
            counter++;
        }
        if (Bot.ShouldExit())
            Thread.Sleep(1000);
        return true;
    }

    /// <summary>
    /// Waits for the specified game action to be available.
    /// </summary>
    /// <param name="action">The game action to wait for.</param>
    /// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
    public bool ForActionCooldown(GameActions action, int timeout = 40)
    {
        return ForActionCooldown(lockedActions[action], OverrideTimeout ? GameActionTimeout : timeout);
    }

    /// <summary>
    /// Waits for the specified game action (as a string) to be available.
    /// </summary>
    /// <param name="action">The game action to wait for.</param>
    /// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
    public bool ForActionCooldown(string action, int timeout = 40)
    {
        return ForTrue(() => IsCooledDown(action), OverrideTimeout ? GameActionTimeout : timeout);
    }

    /// <summary>
    /// Checks whether the given game action is cooled down or not.
    /// </summary>
    /// <param name="action">The game action to check.</param>
    /// <returns>True if the given game action has cooled down, false otherwise.</returns>
    public bool IsCooledDown(GameActions action)
    {
        return IsCooledDown(lockedActions[action]);
    }

    /// <summary>
    /// Checks whether the given game action is cooled down or not.
    /// </summary>
    /// <param name="action">The game action to check.</param>
    /// <returns>True if the given game action has cooled down, false otherwise.</returns>
    public bool IsCooledDown(string action)
    {
        long time = new DateTimeOffset(DateTime.Now).ToUnixTimeMilliseconds();
        dynamic locked = Bot.GetGameObject<object>("world.lock." + action);
        CheckScriptTermination();
        return locked == null || time - (long)locked.ts >= (long)locked.cd;
    }

    private static readonly Dictionary<GameActions, string> lockedActions = new Dictionary<GameActions, string>
        {
            { GameActions.LoadShop, "loadShop" },
            { GameActions.LoadEnhShop, "loadEnhShop" },
            { GameActions.LoadHairShop, "loadHairShop" },
            { GameActions.EquipItem, "equipItem" },
            { GameActions.UnequipItem, "unequipItem" },
            { GameActions.BuyItem, "buyItem" },
            { GameActions.SellItem, "sellItem" },
            { GameActions.GetMapItem, "getMapItem" },
            { GameActions.TryQuestComplete, "tryQuestComplete" },
            { GameActions.AcceptQuest, "acceptQuest" },
            { GameActions.DoIA, "doIA" },
            { GameActions.Rest, "rest" },
            { GameActions.Who, "who" },
            { GameActions.Transfer, "tfer" }
        };

    /// <summary>
    /// An enumeration of actions that the game requires to be cooled down before use.
    /// </summary>
    public enum GameActions
    {
        /// <summary>
        /// Loading a shop.
        /// </summary>
        LoadShop,
        /// <summary>
        /// Loading an enhancement shop.
        /// </summary>
        LoadEnhShop,
        /// <summary>
        /// Loading a hair shop.
        /// </summary>
        LoadHairShop,
        /// <summary>
        /// Equipping an item.
        /// </summary>
        EquipItem,
        /// <summary>
        /// Unequipping an ite.
        /// </summary>
        UnequipItem,
        /// <summary>
        /// Buying an item.
        /// </summary>
        BuyItem,
        /// <summary>
        /// Selling an item.
        /// </summary>
        SellItem,
        /// <summary>
        /// Getting a map item (i.e. via the getMapItem packet).
        /// </summary>
        GetMapItem,
        /// <summary>
        /// Sending a quest completion packet.
        /// </summary>
        TryQuestComplete,
        /// <summary>
        /// Accepting a quest.
        /// </summary>
        AcceptQuest,
        /// <summary>
        /// I don't know... Ask Biney.
        /// </summary>
        DoIA,
        /// <summary>
        /// Resting.
        /// </summary>
        Rest,
        /// <summary>
        /// I don't know...
        /// </summary>
        Who,
        /// <summary>
        /// Joining another map.
        /// </summary>
        Transfer
    }
}
