using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RBot.Flash;
using RBot.Items;
using RBot.Utils;

namespace RBot
{
    public class ScriptInventory : ScriptableObject
    {
        /// <summary>
		/// A list of the items in the player's inventory.
		/// </summary>
        [ObjectBinding("world.myAvatar.items")]
		public List<InventoryItem> Items { get; }
        /// <summary>
		/// A list of items in the player's temporary inventory.
		/// </summary>
        [ObjectBinding("world.myAvatar.tempitems")]
		public List<ItemBase> TempItems { get; }

        /// <summary>
		/// Checks whether the player has the specified item in the specified quantity in their inventory.
		/// </summary>
		/// <param name="item">The name of the item to check for.</param>
		/// <param name="quantity">The quantity of the item to check for.</param>
		/// <returns>Whether the player's inventory contains the specified item stack.</returns>
		public bool Contains(string item, int quantity = 1) => quantity == 0 || Items.Contains(i => i.Name.Equals(item, StringComparison.OrdinalIgnoreCase) && i.Quantity >= quantity);

        /// <summary>
		/// Checks whether the player has the specified item in the specified quantity in their temporary inventory.
		/// </summary>
		/// <param name="item">The name of the item to check for.</param>
		/// <param name="quantity">The quantity of the item to check for.</param>
		/// <returns>Whether the player's temporary inventory contains the specified item stack.</returns>
		public bool ContainsTempItem(string item, int quantity = 1) => quantity == 0 || TempItems.Contains(i => i.Name.Equals(item, StringComparison.OrdinalIgnoreCase) && i.Quantity >= quantity);

        /// <summary>
		/// Transfers the speicifed item from the player's inventory to their bank.
		/// </summary>
		/// <param name="item">The name of the item to transfer.</param>
		public void ToBank(string item)
        {
            if (TryGetItem(item, out InventoryItem i))
                ToBank(i);
        }

        /// <summary>
		/// Transfers the speicifed item from the player's inventory to their bank.
		/// </summary>
		/// <param name="item">The item to transfer.</param>
		public void ToBank(InventoryItem item)
        {
            Bot.SendPacket($"%xt%zm%bankFromInv%{Bot.Map.RoomID}%{item.ID}%{item.CharItemID}%");
            if (Bot.Options.SafeTimings)
                Bot.Wait.ForInventoryToBank(item.Name);
        }

        /// <summary>
		/// Gets the quantity of the specified item in the player's inventory.
		/// </summary>
		/// <param name="item">The name of the item.</param>
		/// <returns>The quantity of the specified item.</returns>
		public int GetQuantity(string item) => TryGetItem(item, out InventoryItem i) ? i.Quantity : 0;

        /// <summary>
		/// Gets the quantity of the specified item in the player's temporary inventory.
		/// </summary>
		/// <param name="item">The name of the item.</param>
		/// <returns>The quantity of the specified item.</returns>
		public int GetTempQuantity(string item) => TryGetTempItem(item, out ItemBase i) ? i.Quantity : 0;

        /// <summary>
		/// Gets a reference to the specified item in the player's inventory. This can be used to access other inforation about the item. <see cref="!:Item" />
		/// </summary>
		/// <param name="name">The name of the item.</param>
		/// <returns>A reference to the specified item.</returns>
		public InventoryItem GetItemByName(string name) => Items.Find(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        /// <summary>
		/// Gets a reference to the specified item in the player's inventory. This can be used to access other inforation about the item. <see cref="!:Item" />
		/// </summary>
		/// <param name="id">The id of the item.</param>
		/// <returns>A reference to the specified item.</returns>
		public InventoryItem GetItemById(int id) => Items.Find(x => x.ID == id);

        /// <summary>
		/// Gets a reference to the specified item in the player's temporary inventory. This can be used to access other inforation about the item. <see cref="!:TempItem" />
		/// </summary>
		/// <param name="name">The name of the item.</param>
		/// <returns>A reference to the specified temporary item.</returns>
		public ItemBase GetTempItemByName(string name) => TempItems.Find(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        /// <summary>
        /// Attempts to get the item by the given id and sets the out parameter to this value.
        /// </summary>
        /// <param name="id">The id of the item to get.</param>
        /// <param name="item">The item object to set.</param>
        /// <returns>True if the item with the given name exists in the player's inventory.</returns>
        public bool TryGetItem(int id, out InventoryItem item)
        {
            item = GetItemById(id);
            return item != null;
        }

        /// <summary>
        /// Attempts to get the item by the given name and sets the out parameter to this value.
        /// </summary>
        /// <param name="name">The name of the item to get.</param>
        /// <param name="item">The item object to set.</param>
        /// <returns>True if the item with the given name exists in the player's inventory.</returns>
        public bool TryGetItem(string name, out InventoryItem item)
        {
            item = GetItemByName(name);
            return item != null;
        }

        /// <summary>
        /// Attempts to get the temporary item by the given name and sets the out parameter to this value.
        /// </summary>
        /// <param name="name">The name of the temp item to get.</param>
        /// <param name="item">The item object to set.</param>
        /// <returns>True if the temp item with the given name exists in the player's temp inventory.</returns>
        public bool TryGetTempItem(string name, out ItemBase item)
        {
            item = GetTempItemByName(name);
            return item != null;
        }
    }
}
