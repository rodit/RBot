using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot.Strategy
{
    public class BuyItemStrategy : ItemStrategy
    {
        public string Map { get; set; }
        public int ShopID { get; set; }

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
