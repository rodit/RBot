using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using RBot.Items;

namespace RBot
{
    public class ScriptWait : ScriptableObject
    {
        /// <summary>
		/// The duration, in milliseconds, for which the thread will sleep before re-checking whether the awaited condition is met.
		/// </summary>
		public static int WAIT_SLEEP = 250;

        /// <summary>
		/// Waits until the player has reached a specified position.
		/// </summary>
		/// <param name="x">The x-coordinate the player should be at.</param>
		/// <param name="y">The y-coordinate the player should be out.</param>
		/// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
        public bool ForPlayerPosition(float x, float y, int timeout = 10)
        {
            return ForTrue(() => !Bot.Player.Playing || (Bot.Player.X == x && Bot.Player.Y == y), timeout);
        }

        /// <summary>
        /// Waits until the player is no longer in combat.
        /// </summary>
        /// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
        public bool ForCombatExit(int timeout = 10)
        {
            return ForTrue(() => !Bot.Player.Playing || !Bot.Player.InCombat, timeout);
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
            }, timeout);
        }

        /// <summary>
		/// Waits until the specified monster is present in the current cell.
		/// </summary>
		/// <param name="name">The name of the monster to wait for.</param>
		/// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP / 2 milliseconds) before the wait is cancelled.</param>
		public bool ForMonsterSpawn(string name, int timeout = 10)
        {
            return ForTrue(() => !Bot.Player.Playing || Bot.Monsters.Exists(name), timeout);
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
            bool b0 = ForTrue(() => Bot.Map.Name.Equals(name, StringComparison.OrdinalIgnoreCase), timeout);
            return b0 && ForTrue(() => !Bot.Player.Playing || Bot.Map.Loaded, timeout);
        }

        /// <summary>
		/// Waits for the current cell to change to the specified one.
		/// </summary>
		/// <param name="cell">The name of the cell to wait for.</param>
		/// <remarks>Changing between cells should be instant, so this wait is usually not necessary at all.</remarks>
		public bool ForCellChange(string cell)
        {
            return ForTrue(() => Bot.Player.Cell.Equals(cell, StringComparison.OrdinalIgnoreCase), WAIT_SLEEP / 4);
        }

        /// <summary>
		/// Waits for a drop of the specified item to be picked up.
		/// </summary>
		/// <param name="item">The name of the item to wait for.</param>
		/// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
		/// <remarks>This actually waits for no drops of the specified item to be available, so can be used even when you do not expect the drop to exist.</remarks>
		public bool ForPickup(string item, int timeout = 10)
        {
            return ForTrue(() => !Bot.Player.Playing || !Bot.Player.DropExists(item), timeout);
        }

        /// <summary>
		/// Waits for a drop of the specified item to exist.
		/// </summary>
		/// <param name="item">The name of the item to wait for.</param>
		/// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
		public bool ForDrop(string item, int timeout = 10)
        {
            return ForTrue(() => !Bot.Player.Playing || Bot.Player.DropExists(item), timeout);
        }

        /// <summary>
		/// Waits for the specified item to be sold.
		/// </summary>
		/// <param name="item">The name of the item to wait for.</param>
		/// <param name="quantity">The quantity of the item being sold (any quantity should work, as you can only sell entire stacks).</param>
		/// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
		public bool ForItemSell(string item, int quantity, int timeout = 10)
        {
            //TODO: wait for packet.
            return false;
        }

        /// <summary>
		/// Waits for the specified item to be equipped.
		/// </summary>
		/// <param name="id">The id of the item to wait for.</param>
		/// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
		public bool ForItemEquip(int id, int timeout = 10)
        {
            return ForTrue(() => !Bot.Player.Playing || (Bot.Inventory.TryGetItem(id, out InventoryItem i) && i.Equipped), timeout);
        }

        /// <summary>
		/// Waits for the specified item to be equipped.
		/// </summary>
		/// <param name="item">The name of the item to wait for.</param>
		/// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
		public bool ForItemEquip(string item, int timeout = 10)
        {
            return ForTrue(() => !Bot.Player.Playing || !Bot.Inventory.TryGetItem(item, out InventoryItem i) || i.Equipped, timeout);
        }

        /// <summary>
		/// Waits for the specified item to have moved from the bank to the main inventory.
		/// </summary>
		/// <param name="item">The name of the item to wait for.</param>
		/// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
		public bool ForBankToInventory(string item, int timeout = 14)
        {
            return ForTrue(() => !Bot.Player.Playing || !Bot.Bank.Contains(item), timeout, WAIT_SLEEP / 2);
        }

        /// <summary>
		/// Waits for the specified item to have moved from the main inventory to the bank.
		/// </summary>
		/// <param name="item">The name of the item to wait for.</param>
		/// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
		public bool ForInventoryToBank(string item, int timeout = 14)
        {
            return ForTrue(() => !Bot.Player.Playing || !Bot.Inventory.Contains(item), timeout, WAIT_SLEEP / 2);
        }

        /// <summary>
		/// Waits for the bank to be loaded. If the bank is already loaded, this method does not wait at all.
		/// </summary>
		/// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
		public bool ForBankLoad(int timeout = 20)
        {
            return ForTrue(() => Bot.Runtime.BankLoaded, timeout);
        }

        /// <summary>
		/// Waits for the specified quest to be accepted.
		/// </summary>
		/// <param name="id">The id of the quest to be accepted.</param>
		/// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
		public bool ForQuestAccept(int id, int timeout = 14)
        {
            return ForTrue(() => !Bot.Player.Playing || Bot.Quests.IsInProgress(id), timeout, WAIT_SLEEP / 2);
        }

        /// <summary>
		/// Waits for the specified quest to be completed.
		/// </summary>
		/// <param name="id">The id of the quest to be completed.</param>
		/// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
		/// <remarks>This actually waits until the quest is no longer in progress so does not guarentee that the quest has been completed; it could have never been accepted in the first place.</remarks>
		public bool ForQuestComplete(int id, int timeout = 10)
        {
            return ForTrue(() => !Bot.Player.Playing || !Bot.Quests.IsInProgress(id), timeout, WAIT_SLEEP / 2);
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
		/// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
        /// <param name="sleepOverride">The time to sleep between polling the predicate function (-1 = WAIT_SLEEP).</param>
        public bool ForTrue(Func<bool> pred, Action loopFunc, int timeout, int sleepOverride = -1)
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
            return true;
        }

        /// <summary>
		/// Waits for the specified game action to be available.
		/// </summary>
		/// <param name="action">The game action to wait for.</param>
		/// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
		public bool ForActionCooldown(GameActions action, int timeout = 40)
        {
            return ForActionCooldown(lockedActions[action], timeout);
        }

        /// <summary>
        /// Waits for the specified game action (as a string) to be available.
        /// </summary>
        /// <param name="action">The game action to wait for.</param>
        /// <param name="timeout">The number of times the thread should be slept (for WAIT_SLEEP milliseconds) before the wait is cancelled.</param>
        public bool ForActionCooldown(string action, int timeout = 40)
        {
            return ForTrue(() => IsCooledDown(action), timeout);
        }

        /// <summary>
		/// Checks whether the given game action is cooled down or not.
		/// </summary>
		/// <param name="action">The game action to check.</param>
		/// <returns>True if the given game action has cooled down, false otherwise.</returns>
		public bool IsCooledDown(string action)
        {
            long time = new DateTimeOffset(DateTime.Now).ToUnixTimeMilliseconds();
            dynamic locked = Bot.GetGameObject<object>("world.lock." + action, null);
            return time - locked.ts >= locked.cd;
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
}
