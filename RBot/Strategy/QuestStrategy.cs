using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RBot.Quests;
using RBot.Items;

namespace RBot.Strategy
{
    public class QuestStrategy : ItemStrategy
    {
        public const int DefaultQuestPreference = 5;

        public int QuestID { get; set; }

        public override bool Execute(ScriptInterface bot, int required)
        {
            Quest q = bot.Strategy.GetCachedQuest(QuestID);
            if (q == null)
                return false;
            foreach (ItemBase accept in q.AcceptRequirements)
            {
                if (bot.Bank.Contains(accept.Name))
                    bot.Bank.ToInventory(accept.Name);
                else if (!bot.Inventory.Contains(accept.Name))
                    return false;
            }
            while (!(!TempItem && bot.Inventory.Contains(Item, required)) || !(TempItem && bot.Inventory.ContainsTempItem(Item, required)))
            {
                bot.Quests.EnsureAccept(QuestID);
                foreach (QuestReqItem item in q.Requirements)
                {
                    if (!bot.Strategy.Obtain(item.Name, item.Quantity))
                        return false;
                }
                bot.Quests.EnsureComplete(QuestID);
                bot.Wait.ForDrop(Item);
                bot.Player.Pickup(Item);
                bot.Strategy.PickupAggregate();
            }
            return true;
        }

        public override List<string> GetRequiredItems(ScriptInterface bot)
        {
            return bot.Strategy.GetCachedQuest(QuestID)?.Requirements.Select(x => x.Name).ToList() ?? base.GetRequiredItems(bot);
        }
    }
}
