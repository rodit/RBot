using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot.Strategy
{
    public class DropStrategy : ItemStrategy
    {
        public const int DropDefaultPreference = 10;

        public string Map { get; set; }
        public string Monsters { get; set; }
        public override int Preference => DropDefaultPreference;

        public override bool Execute(ScriptInterface bot, int required)
        {
            bot.Strategy.GetNavigator(Map).Navigate(bot);
            string[] all = new string[] { Item }.Concat(bot.Strategy.DropAggregate).ToArray();
            int[] quantities = new int[] { required }.Concat(Enumerable.Range(0, bot.Strategy.DropAggregate.Count).Select(i => 0)).ToArray();
            bot.Player.HuntForItems(Monsters, all, quantities, TempItem, false);
            bot.Strategy.PickupAggregate();
            return true;
        }
    }
}
