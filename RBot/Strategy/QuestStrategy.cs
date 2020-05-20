using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RBot.Quests;
using RBot.Items;

namespace RBot.Strategy
{
    /// <summary>
    /// Obtains an item by completing a quest of which it is a reward.
    /// This strategy recursively calls StrategyDatabase#Obtain to fulfil the quest's completion requirements.
    /// </summary>
    public class QuestStrategy : ItemStrategy
    {
        public const int DefaultQuestPreference = 5;

        public override int Preference => DefaultQuestPreference;
        /// <summary>
        /// The ID of the quest to complete to obtain the item.
        /// </summary>
        public int QuestID { get; set; }

        /// <summary>
        /// Executes this strategy by obtaining the items required to turn in the quest and then turning in the quest until the required quantity of the item is obtained.
        /// This strategy calls StrategyDatabase#PickupAggregate every time the quest is turned in.
        /// </summary>
        /// <param name="required">The quantity of the item to obtain by completing the quest.</param>
        /// <returns>False if the quest cannot be accepted (if the player does not have the required items to accept it) or if there is no strategy registered to obtain a requirement or if the registered strategy fails for any requirement. True otherwise.</returns>
        public override bool Execute(ScriptInterface bot, int required)
        {
            Quest q = bot.Quests.EnsureLoad(QuestID);
            if (q == null)
                return false;
            foreach (ItemBase accept in q.AcceptRequirements)
            {
                if (bot.Bank.Contains(accept.Name))
                    bot.Bank.ToInventory(accept.Name);
                else if (!bot.Inventory.Contains(accept.Name))
                    return false;
            }
            while ((!TempItem && !bot.Inventory.Contains(Item, required)) || (TempItem && !bot.Inventory.ContainsTempItem(Item, required)))
            {
                bot.Quests.EnsureAccept(QuestID);
                foreach (ItemBase item in q.Requirements)
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

        /// <summary>
        /// Gets a list of items required to turn in the quest.
        /// </summary>
        /// <returns>The list of items required to turn in the quest.</returns>
        public override List<string> GetRequiredItems(ScriptInterface bot)
        {
            return bot.Strategy.GetCachedQuest(QuestID)?.Requirements.Select(x => x.Name).ToList() ?? base.GetRequiredItems(bot);
        }

        public override string ToString()
        {
            return $"Complete Quest[{QuestID}] for {Item}";
        }
    }
}
