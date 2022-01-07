using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot.Strategy
{
    /// <summary>
    /// A class with virtual methods that is used to define a strategy which is followed to obtain a given item in a given quantity.
    /// </summary>
    public class ItemStrategy
    {
        /// <summary>
        /// The name of the item that this strategy obtains.
        /// </summary>
        public string Item { get; set; }
        /// <summary>
        /// Whether or not the item obtained by this strategy is a temporary item.
        /// </summary>
        public bool TempItem { get; set; }
        /// <summary>
        /// The preference of this strategy. Strategies with higher preferences are chosen first.
        /// </summary>
        public virtual int Preference { get; } = 0;

        /// <summary>
        /// Checks whether this strategy can be used in the given circumstances.
        /// THIS METHOD IS CURRENTLY UNUSED.
        /// </summary>
        /// <returns>True if this strategy can be used, false otherwise.</returns>
        public virtual bool CanUse(ScriptInterface bot)
        {
            return true;
        }

        /// <summary>
        /// Called to execute this strategy and obtain the required item in the required quantity.
        /// </summary>
        /// <param name="required">The quantity of the item to obtain.</param>
        /// <returns>True if the item was successfully obtained, false otherwise.</returns>
        public virtual bool Execute(ScriptInterface bot, int required)
        {
            return false;
        }

        /// <summary>
        /// Gets a list of required items for this strategy. The list returned is used to build the drop aggregate when StrategyDatabase#AggregateDrops is called.
        /// </summary>
        /// <returns>A list of items to add to the drop aggregate.</returns>
        public virtual List<string> GetRequiredItems(ScriptInterface bot) => new List<string>();
    }
}
