using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot.Strategy
{
    /// <summary>
    /// Obtains an item by hunting a monster or monsters that drop it.
    /// </summary>
    public class DropStrategy : ItemStrategy
    {
        public const int DropDefaultPreference = 10;

        /// <summary>
        /// The map where the monsters dropping the item reside.
        /// </summary>
        public string Map { get; set; }
        /// <summary>
        /// The name(s) of the monster(s) which drop the item. The names are separated by a | character.
        /// </summary>
        public string Monsters { get; set; }
        public override int Preference => DropDefaultPreference;

        /// <summary>
        /// Executes the drop strategy by joining the map and using HuntForItems combining the DropAggregate list and the item this strategy is meant to obtain.
        /// </summary>
        /// <param name="required">The number of the item to acquire.</param>
        /// <returns>True always as HuntForItems' reliability is assumed.</returns>
        public override bool Execute(ScriptInterface bot, int required)
        {
            bot.Strategy.GetNavigator(Map).Navigate(bot);
            string[] all = new string[] { Item }.Concat(bot.Strategy.DropAggregate).ToArray();
            int[] quantities = new int[] { required }.Concat(Enumerable.Range(0, bot.Strategy.DropAggregate.Count).Select(i => 0)).ToArray();
            bot.Player.HuntForItems(Monsters, all, quantities, TempItem, false);
            bot.Strategy.PickupAggregate();
            return true;
        }

        public override string ToString()
        {
            return $"Kill {Monsters.Replace('|', ',')} for {Item + (TempItem ? " [T]" : string.Empty)} @ {Map}";
        }
    }
}
