using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot
{
    public class ScriptEvents : ScriptableObject
    {
        /// <summary>
        /// Occurs when the player dies.
        /// </summary>
        public event PlayerDeathEventHandler PlayerDeath;
        /// <summary>
        /// Occurs when the player kills a monster.
        /// </summary>
        public event MonsterKilledEventHandler MonsterKilled;
        /// <summary>
        /// Occurs when a quest is accepted by the script.
        /// </summary>
        public event QuestAcceptedEventHandler QuestAccepted;
        /// <summary>
        /// Occurs when a quest is turned in by the script.
        /// </summary>
        public event QuestTurnInEventHandler QuestTurnedIn;
        /// <summary>
        /// Occurs when the current map changes.
        /// </summary>
        public event MapChangedEventHandler MapChanged;
        /// <summary>
        /// Occurs when the current cell changes.
        /// </summary>
        public event CellChangedEventHandler CellChanged;
        /// <summary>
        /// Occurs when auto relogin has been triggered (but the relogin has not been carried out yet).
        /// </summary>
        public event ReloginTriggeredEventHandler ReloginTriggered;
        /// <summary>
        /// Occurs when an extension packet is receieved.
        /// </summary>
        /// <remarks>The extension packet is a dynamic object deserialized from JSON.</remarks>
        public event ExtensionPacketEventHandler ExtensionPacketReceived;
        /// <summary>
        /// Occurs when the player turns AFK.
        /// </summary>
        public event AFKEventHandler PlayerAFK;
        /// <summary>
        /// Occurs when the player attempts to buy an item from a shop.
        /// </summary>
        public event TryBuyItemHandler TryBuyItem;

        /// <summary>
        /// Clears all the currently set event handlers.
        /// </summary>
        public void ClearHandlers()
        {
            PlayerDeath = null;
            MonsterKilled = null;
            QuestAccepted = null;
            QuestTurnedIn = null;
            MapChanged = null;
            CellChanged = null;
            ReloginTriggered = null;
            ExtensionPacketReceived = null;
        }

        public void OnPlayerDeath()
        {
            PlayerDeath?.Invoke(Bot);
        }

        public void OnMonsterKilled()
        {
            MonsterKilled?.Invoke(Bot);
        }

        public void OnQuestAccepted(int questId)
        {
            QuestAccepted?.Invoke(Bot, questId);
        }

        public void OnQuestTurnIn(int questId)
        {
            QuestTurnedIn?.Invoke(Bot, questId);
        }

        public void OnMapChanged(string map)
        {
            MapChanged?.Invoke(Bot, map);
        }

        public void OnCellChanged(string map, string cell, string pad)
        {
            CellChanged?.Invoke(Bot, map, cell, pad);
        }

        public void OnReloginTriggered(bool kicked)
        {
            ReloginTriggered?.Invoke(Bot, kicked);
        }

        public void OnExtensionPacket(dynamic packet)
        {
            ExtensionPacketReceived?.Invoke(Bot, packet);
        }

        public void OnPlayerAFK()
        {
            PlayerAFK?.Invoke(Bot);
        }

        public void OnTryBuyItem(int shopId, int itemId, int shopItemId)
        {
            TryBuyItem?.Invoke(Bot, shopId, itemId, shopItemId);
        }

        public delegate void PlayerDeathEventHandler(ScriptInterface bot);
        public delegate void MonsterKilledEventHandler(ScriptInterface bot);
        public delegate void QuestAcceptedEventHandler(ScriptInterface bot, int questId);
        public delegate void QuestTurnInEventHandler(ScriptInterface bot, int questId);
        public delegate void MapChangedEventHandler(ScriptInterface bot, string map);
        public delegate void CellChangedEventHandler(ScriptInterface bot, string map, string cell, string pad);
        public delegate void ReloginTriggeredEventHandler(ScriptInterface bot, bool kicked);
        public delegate void ExtensionPacketEventHandler(ScriptInterface bot, dynamic packet);
        public delegate void AFKEventHandler(ScriptInterface bot);
        public delegate void TryBuyItemHandler(ScriptInterface bot, int shopId, int itemId, int shopItemId);
    }
}
