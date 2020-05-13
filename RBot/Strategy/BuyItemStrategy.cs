using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot.Strategy
{
    /// <summary>
    /// Buys an item from a shop to obtain it.
    /// </summary>
    public class BuyItemStrategy : ItemStrategy
    {
        public const int DefaultBuyPreference = 3;

        /// <summary>
        /// The map to join before loading the shop to buy the item.
        /// </summary>
        public string Map { get; set; }
        /// <summary>
        /// The ID of the shop to load and buy the item from.
        /// </summary>
        public int ShopID { get; set; }
        public override int Preference => DefaultBuyPreference;

        /// <summary>
        /// Executes the strategy by joining the map (if it's not null), loading the shop, and buying the specified item the required number of times.
        /// </summary>
        /// <returns>True if the player's inventory contains the required quantity of the given item after the strategy has executed.</returns>
        public override bool Execute(ScriptInterface bot, int required)
        {
            if (Map != null)
                bot.Strategy.GetNavigator(Map).Navigate(bot);

            while (!bot.Inventory.Contains(Item, required))
                bot.Shops.BuyItem(ShopID, Item);

            return bot.Inventory.Contains(Item, required);
        }
    }
}
