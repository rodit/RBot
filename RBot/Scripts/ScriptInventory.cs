using RBot.Flash;
using RBot.Items;
using RBot.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RBot;

public class ScriptInventory : ScriptableObject
{
    /// <summary>
    /// A list of the items in the player's inventory.
    /// </summary>
    [ObjectBinding("world.myAvatar.items")]
    public List<InventoryItem> Items { get; }
    /// <summary>
    /// The total number of inventory slots the player has.
    /// </summary>
    [ObjectBinding("world.myAvatar.objData.iBagSlots")]
    public int Slots { get; }
    /// <summary>
    /// The number of inventory slots that are currently in use.
    /// </summary>
    [ObjectBinding("world.myAvatar.items.length")]
    public int UsedSlots { get; }
    /// <summary>
    /// The number of free inventory slots the player has.
    /// </summary>
    public int FreeSlots => Slots - UsedSlots;
    /// <summary>
    /// A list of items in the player's temporary inventory.
    /// </summary>
    [ObjectBinding("world.myAvatar.tempitems")]
    public List<ItemBase> TempItems { get; }

    /// <summary>
    /// A list of house items in the player's house inventory.
    /// </summary>
    [ObjectBinding("world.myAvatar.houseitems")]
    public List<InventoryItem> HouseItems { get; }

    /// <summary>
    /// A reference object of the player's current class.
    /// </summary>
    public InventoryItem CurrentClass => Items.Find(i => i.Equipped && i.Category == ItemCategory.Class);

    /// <summary>
    /// Checks whether the player has the specified item in the specified quantity in their inventory.
    /// </summary>
    /// <param name="item">The name of the item to check for.</param>
    /// <param name="quantity">The quantity of the item to check for.</param>
    /// <returns>Whether the player's inventory contains the specified item stack.</returns>
    public bool Contains(string item, int quantity = 1) => quantity == 0 || Items.Any(i => i.Name.Equals(item, StringComparison.OrdinalIgnoreCase) && (i.Quantity >= quantity || i.Category == ItemCategory.Class));

    /// <summary>
    /// Checks whether the player has the specified item in the specified quantity in their temporary inventory.
    /// </summary>
    /// <param name="item">The name of the item to check for.</param>
    /// <param name="quantity">The quantity of the item to check for.</param>
    /// <returns>Whether the player's temporary inventory contains the specified item stack.</returns>
    public bool ContainsTempItem(string item, int quantity = 1) => quantity == 0 || TempItems.Any(i => i.Name.Equals(item, StringComparison.OrdinalIgnoreCase) && i.Quantity >= quantity);

    /// <summary>
    /// Checks whether the player has the specified house item.
    /// </summary>
    /// <param name="item">Name of the house item to check for.</param>
    /// <returns></returns>
    public bool ContainsHouseItem(string item) => HouseItems.Any(i => i.Name.Equals(item, StringComparison.OrdinalIgnoreCase));

    /// <summary>
    /// Transfers the specified item from the player's inventory to their bank.
    /// </summary>
    /// <param name="item">The name of the item to transfer.</param>
    public void ToBank(string item)
    {
        if (TryGetItem(item, out InventoryItem i))
            ToBank(i);
    }

    /// <summary>
    /// Transfers the specified item from the player's house inventory to their bank.
    /// </summary>
    /// <param name="item">The name of the house item to transfer.</param>
    public void HouseItemToBank(string item)
    {
        if (TryGetHouseItem(item, out InventoryItem i))
            ToBank(i);
    }

    /// <summary>
    /// Transfers the specified item from the player's inventory to their bank.
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
    /// Gets a reference to the specified item in the player's inventory. This can be used to access other information about the item. <see cref="!:Item" />
    /// </summary>
    /// <param name="name">The name of the item.</param>
    /// <returns>A reference to the specified item.</returns>
    public InventoryItem GetItemByName(string name) => Items.Find(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

    /// <summary>
    /// Gets a reference to the specified house item in the player's house inventory. This can be used to access other information about the item.
    /// </summary>
    /// <param name="name">The name of the house item</param>
    /// <returns>A reference to the specified house item.</returns>
    public InventoryItem GetHouseItemByName(string name) => HouseItems.Find(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

    /// <summary>
    /// Gets a reference to the specified item in the player's inventory. This can be used to access other information about the item. <see cref="!:Item" />
    /// </summary>
    /// <param name="id">The id of the item.</param>
    /// <returns>A reference to the specified item.</returns>
    public InventoryItem GetItemById(int id) => Items.Find(x => x.ID == id);

    /// <summary>
    /// Gets a reference to the specified house item in the player's house inventory. This can be used to access other information about the item.
    /// </summary>
    /// <param name="id">The id of the item.</param>
    /// <returns>A reference to the specified house item.</returns>
    public InventoryItem GetHouseItemById(int id) => HouseItems.Find(x => x.ID == id);

    /// <summary>
    /// Gets a reference to the specified item in the player's temporary inventory. This can be used to access other information about the item.
    /// </summary>
    /// <param name="name">The name of the item.</param>
    /// <returns>A reference to the specified temporary item.</returns>
    public ItemBase GetTempItemByName(string name) => TempItems.Find(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

    /// <summary>
    /// Gets a reference to the specified temporary item in the player's temporary inventory. This can be used to access other information about the item.
    /// </summary>
    /// <param name="id">The id of the item.</param>
    /// <returns>A reference to the specified temporary item.</returns>
    public ItemBase GetTempItemById(int id) => TempItems.Find(x => x.ID == id);

    /// <summary>
    /// Attempts to get the item by the given id and sets the out parameter to this value.
    /// </summary>
    /// <param name="id">The id of the item to get.</param>
    /// <param name="item">The item object to set.</param>
    /// <returns>True if the item with the given name exists in the player's inventory.</returns>
    public bool TryGetItem(int id, out InventoryItem item)
    {
        return (item = GetItemById(id)) != null;
    }

    /// <summary>
    /// Attempts to get the item by the given name and sets the out parameter to this value.
    /// </summary>
    /// <param name="name">The name of the item to get.</param>
    /// <param name="item">The item object to set.</param>
    /// <returns>True if the item with the given name exists in the player's inventory.</returns>
    public bool TryGetItem(string name, out InventoryItem item)
    {
        return (item = GetItemByName(name)) != null;
    }

    /// <summary>
    /// Attempts to get the item by the given id and sets the out parameter to this value.
    /// </summary>
    /// <param name="id">The id of the item to get.</param>
    /// <param name="houseItem">The item object to set.</param>
    /// <returns>True if the item with the given name exists in the player's house inventory.</returns>
    public bool TryGetHouseItem(int id, out InventoryItem houseItem)
    {
        return (houseItem = GetHouseItemById(id)) != null;
    }

    /// <summary>
    /// Attempts to get the house item by the given name and sets the out parameter to this value.
    /// </summary>
    /// <param name="name">The name of the item to get.</param>
    /// <param name="houseItem">The item object to set.</param>
    /// <returns>True if the item with the given name exists in the player's house inventory.</returns>
    public bool TryGetHouseItem(string name, out InventoryItem houseItem)
    {
        return (houseItem = GetHouseItemByName(name)) != null;
    }

    /// <summary>
    /// Attempts to get the temporary item by the given name and sets the out parameter to this value.
    /// </summary>
    /// <param name="name">The name of the temp item to get.</param>
    /// <param name="item">The item object to set.</param>
    /// <returns>True if the temp item with the given name exists in the player's temp inventory.</returns>
    public bool TryGetTempItem(string name, out ItemBase item)
    {
        return (item = GetTempItemByName(name)) != null;
    }

    /// <summary>
    /// Checks if the given item is equipped.
    /// </summary>
    /// <param name="name">The name of the item.</param>
    /// <returns>True if the given item is equipped.</returns>
    public bool IsEquipped(string name)
    {
        return TryGetItem(name, out var item) && item.Equipped;
    }

    /// <summary>
    /// Checks if the given house item is equipped.
    /// </summary>
    /// <param name="name">The name of the item.</param>
    /// <returns>True if the given house item is equipped.</returns>
    public bool IsHouseItemEquipped(string name)
    {
        return TryGetHouseItem(name, out var item) && item.Equipped;
    }

    public bool IsMaxStack(string name)
    {
        return TryGetItem(name, out var item) && item.Quantity >= item.MaxStack;
    }

    /// <summary>
    /// Transfers all AC (coin) items that are not equipped from the player's inventory to the bank.
    /// </summary>
    public void BankAllCoinItems()
    {
        if (Bot.Player.Playing)
            Items.Where(i => i.Coins && !i.Equipped && i.Name.ToLower() != "treasure potion" && !Bot.Runtime.RequiredItems.Contains(i.Name.ToLower())).ForEach(ToBank);
    }
}
