using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot.Strategy
{
    /// <summary>
    /// An interface implemented to perform custom navigation logic to transfer a player to a map.
    /// </summary>
    public interface INavigator
    {
        /// <summary>
        /// This method should implement the logic to transfer the player to a map.
        /// </summary>
        void Navigate(ScriptInterface bot);
    }

    /// <summary>
    /// A default navigator implementation that simply calls ScriptPlayer#Join to join the given map.
    /// </summary>
    public class DefaultNavigator : INavigator
    {
        /// <summary>
        /// The name of the map to join.
        /// </summary>
        public string Map { get; set; }
        /// <summary>
        /// The name of the cell to jump to when the map is joined.
        /// </summary>
        public string Cell { get; set; }
        /// <summary>
        /// The name of the pad to jump to when the map is joined.
        /// </summary>
        public string Pad { get; set; }

        public DefaultNavigator(string map, string cell = "Enter", string pad = "Spawn")
        {
            Map = map;
            Cell = cell;
            Pad = pad;
        }

        /// <summary>
        /// Calls ScriptPlayer#Join in order to join the given map.
        /// </summary>
        public void Navigate(ScriptInterface bot)
        {
            bot.Player.Join(Map, Cell, Pad);
        }
    }
}
