using System;
using System.Collections.Generic;
using System.Linq;

using RBot.Flash;
using RBot.Players;
using RBot.Utils;

namespace RBot
{
    public class ScriptMap : ScriptableObject
    {
        /// <summary>
		/// Gets the name of the currently loaded map.
		/// </summary>
		public string Name => Bot.GetGameObject("ui.mcInterface.areaList.title.t1.text").Split(' ').Last().Split('-')[0];
        /// <summary>
		/// Gets the current room's area id.
		/// </summary>
        [ObjectBinding("world.curRoom")]
        public int RoomID { get; }
        /// <summary>
        /// Gets the number of players in the currently loaded map.
        /// </summary>
        [ObjectBinding("world.areaUsers.length")]
        public int PlayerCount { get; }
        /// <summary>
		/// Gets a list of player names in the currently loaded map.
		/// </summary>
        [ObjectBinding("world.areaUsers")]
        public List<string> PlayerNames { get; }
        [ObjectBinding("world.uoTree")]
        private Dictionary<string, PlayerInfo> _players;
        /// <summary>
		/// Gets a list of all players in the current map.
		/// </summary>
		public List<PlayerInfo> Players => _players.Values.ToList();
        /// <summary>
		/// Gets a list of all players in the current cell.
		/// </summary>
		public List<PlayerInfo> CellPlayers => Players.FindAll(p => p.Cell == Bot.Player.Cell);
        /// <summary>
		/// Determines whether a map is currently loaded completely..
		/// </summary>
		public bool Loaded => Bot.GetGameObject<bool>("world.mapLoadInProgress")
                            && Bot.IsNull("mcConnDetail.stage")
                            && !Bot.IsNull("world.monswf")
                            && !Bot.IsNull("world.mondef")
                            && Bot.GetGameObject<int>("world.monswf.length") == Bot.GetGameObject<int>("world.mondef.length");
        /// <summary>
		/// Gets a list of all of the cells in the current map.
		/// </summary>
        [ObjectBinding("world.map.currentScene.labels", Select = "name")]
        public List<string> Cells { get; }

        /// <summary>
		/// Gets info about the player with the given username.
		/// </summary>
		/// <param name="username">The username of the player.</param>
		/// <returns>An object holding info for the given player.</returns>
		public PlayerInfo GetPlayer(string username) => Bot.GetGameObject<PlayerInfo>("world.uoTree." + username.ToLower());

        /// <summary>
		/// Reloads the current map.
		/// </summary>
        [MethodCallBinding("world.reloadCurrentMap", GameFunction = true)]
        public void Reload() { }

        /// <summary>
		/// Sends a getMapItem packet for the specified item.
		/// </summary>
		/// <param name="id">The id of the item.</param>
        [MethodCallBinding("world.getMapItem", RunMethodPre = true, GameFunction = true)]
        public void GetMapItem(int id)
        {
            if (Bot.Options.SafeTimings)
                Bot.Wait.ForActionCooldown(ScriptWait.GameActions.GetMapItem);
        }

        /// <summary>
		/// Checks if the specified player exists in the current room.
		/// </summary>
		/// <param name="name">The name of the player.</param>
		/// <returns>Whether the player with the specified name is in the current room.</returns>
		public bool PlayerExists(string name) => PlayerNames.Contains(x => x.ToLower() == name.ToLower());
    }
}
