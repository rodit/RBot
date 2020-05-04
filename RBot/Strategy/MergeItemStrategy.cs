using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RBot.Items;
using RBot.Shops;

namespace RBot.Strategy
{
    public class MergeItemStrategy : BuyItemStrategy
    {
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

        public override List<string> GetRequiredItems(ScriptInterface bot)
        {
            return bot.Strategy.GetCachedMerge(ShopID, Item)?.Requirements.Select(x => x.Name).ToList() ?? new List<string>();
        }
    }
}
