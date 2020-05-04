using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot.Strategy
{
    public interface INavigator
    {
        void Navigate(ScriptInterface bot);
    }

    public class DefaultNavigator : INavigator
    {
        public string Map { get; set; }
        public string Cell { get; set; }
        public string Pad { get; set; }

        public DefaultNavigator(string map, string cell = "Enter", string pad = "Spawn")
        {
            Map = map;
            Cell = cell;
            Pad = pad;
        }

        public void Navigate(ScriptInterface bot)
        {
            bot.Player.Join(Map, Cell, Pad);
        }
    }
}
