using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RBot.Items;
using RBot.Shops;

namespace RBot.Strategy
{
    /// <summary>
    /// Obtains an item by buying it from a merge shop.
    /// This strategy recursively calls StrategyDatabase#Obtain to obtain merge requirements.
    /// </summary>
    public class MergeItemStrategy : BuyItemStrategy
    {
        /// <summary>
        /// Executes the merge item strategy by joining the map (if it's not null), loading the merge shop, and buying the specified merge item until the required amount is in the player's inventory.
        /// </summary>
        /// <param name="bot"></param>
        /// <param name="required"></param>
        /// <returns></returns>
        public override bool Execute(ScriptInterface bot, int required)
        {
            if (Map != null)
                bot.Strategy.GetNavigator(Map).Navigate(bot);

            bot.Shops.Load(ShopID);

            MergeItem merge = bot.Shops.MergeItems.Find(x => x.Name.Equals(Item, StringComparison.OrdinalIgnoreCase));
            if (merge == null)
                return false;
            while (!bot.Inventory.Contains(Item, required))
            {
                foreach (ItemBase item in merge.Requirements)
                {
                    if (!bot.Strategy.Obtain(item.Name, item.Quantity))
                        return false;
                }
                bot.Shops.BuyItem(merge.Name);
            }

            return bot.Inventory.Contains(Item, required);
        }

        /// <summary>
        /// Gets a list of items required to merge the item this strategy obtains.
        /// </summary>
        /// <returns>The list of required items for this merge.</returns>
        public override List<string> GetRequiredItems(ScriptInterface bot)
        {
            return bot.Strategy.GetCachedMerge(ShopID, Item)?.Requirements.Select(x => x.Name).ToList() ?? new List<string>();
        }

        public override string ToString()
        {
            return $"Merge {Item} using Shop[{ShopID}] @ {Map ?? "anywhere"}";
        }
    }
}
