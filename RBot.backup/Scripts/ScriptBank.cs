using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RBot.Items;
using RBot.Flash;

namespace RBot
{
    public class ScriptBank : ScriptableObject
    {
        /// <summary>
        /// A list of all of the items in the player's bank.
        /// </summary>
        /// <remarks>The bank must be loaded for this list to be accurate (or at all complete).</remarks>
        [ObjectBinding("world.bankinfo.items")]
        public List<InventoryItem> BankItems { get; }
        /// <summary>
        /// The total number of bank slots the player has.
        /// </summary>
        [ObjectBinding("world.myAvatar.objData.iBankSlots")]
        public int Slots { get; }
        /// <summary>
        /// The number of bank slots that are currently in use.
        /// </summary>
        [ObjectBinding("world.myAvatar.iBankCount")]
        public int UsedSlots { get; }
        /// <summary>
        /// The number of free bank slots the player has.
        /// </summary>
        public int FreeSlots => Slots - UsedSlots;

        /// <summary>
        /// Checks whether the player has the specified item in the specified quantity in their bank.
        /// </summary>
        /// <param name="item">The name of the item to check for.</param>
        /// <param name="quantity">The quantity of the item to check for.</param>
        /// <returns>Whether the player's bank contains the specified item stack.</returns>
        public bool Contains(string item, int quantity = 1) => quantity == 0 || (TryGetItem(item, out InventoryItem i) && (i.Quantity >= quantity || i.Category == ItemCategory.Class));

        /// <summary>
        /// Gets the bank item with the specified name.
        /// </summary>
        /// <param name="name">The name of the item to get.</param>
        /// <returns>The item with the specified name or null if it doesn't exist.</returns>
        public InventoryItem GetItemByName(string name) => BankItems.Find(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        /// <summary>
        /// Attempts to get the item by the given name in the bank and store it in the out parameter.
        /// </summary>
        /// <param name="name">The name of the item to get.</param>
        /// <param name="item">The item object to set to the bank item.</param>
        /// <returns>True if the item with the given name exists in the player's bank.</returns>
        public bool TryGetItem(string name, out InventoryItem item)
        {
            item = GetItemByName(name);
            return item != null;
        }

        /// <summary>
        /// Swaps the specified items between the player's inventory and the bank.
        /// </summary>
        /// <param name="invItem">The name of the item in the player's inventory to be transferred to the bank.</param>
        /// <param name="bankItem">The name of the item in the bank to be transferred to the player's inventory.</param>
        public void Swap(string invItem, string bankItem)
        {
            if (TryGetItem(bankItem, out InventoryItem bank) && Bot.Inventory.TryGetItem(invItem, out InventoryItem inv))
            {
                Bot.SendPacket($"%xt%zm%bankSwapInv%{Bot.Map.RoomID}%{inv.ID}%{inv.CharItemID}%{bank.ID}%{bank.CharItemID}%");
                if (Bot.Options.SafeTimings)
                    Bot.Wait.ForInventoryToBank(invItem);
            }
        }

        /// <summary>
        /// Transfers the specified item from the bank to the player's inventory.
        /// </summary>
        /// <param name="item">The name of the item to transfer.</param>
        public void ToInventory(string item)
        {
            if (TryGetItem(item, out InventoryItem i))
            {
                Bot.SendPacket($"%xt%zm%bankToInv%{Bot.Map.RoomID}%{i.ID}%{i.CharItemID}%");
                if (Bot.Options.SafeTimings)
                    Bot.Wait.ForBankToInventory(item);
            }
        }
    }
}
