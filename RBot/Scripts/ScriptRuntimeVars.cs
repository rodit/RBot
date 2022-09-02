using System;
using System.Collections.Generic;

namespace RBot;

public class ScriptRuntimeVars : ScriptableObject
{
    /// <summary>
    /// A list of required items that will not be banked via BankAllCoinItems. This method also moves the item from the bank to inventory.
    /// </summary>
    /// <remarks>The bank must be loaded for this to work properly.</remarks>
    public List<string> RequiredItems { get; } = new List<string>();

    /// <summary>
    /// A boolean indicating whether the player's bank is loaded or not. This resets on relogin.
    /// </summary>
    public bool BankLoaded { get; set; } = false;

    /// <summary>
    /// A random instance for the script.
    /// </summary>
    public Random Random { get; set; } = new Random();

    /// <summary>
    /// Marks the specified item as required. It is moved from the bank to the inventory and will not be moved into the bank via BankAllCoinItems.
    /// </summary>
    /// <param name="item">The item to mark as required.</param>
    public void Require(string item)
    {
        RequiredItems.Add(item.ToLower());
        if (Bot.Bank.Contains(item))
            ScriptInterface.Instance.Bank.ToInventory(item);
    }
}
