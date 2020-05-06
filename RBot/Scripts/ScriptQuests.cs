using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RBot.Flash;
using RBot.Quests;
using RBot.Utils;

namespace RBot
{
    public class ScriptQuests : ScriptableObject
    {
        [ObjectBinding("world.questTree")]
        private Dictionary<int, Quest> _quests { get; }
        /// <summary>
        /// A list of the most recently accessed quests.
        /// </summary>
        public List<Quest> QuestTree => _quests.Values.ToList();
        /// <summary>
        /// A list of the player's currently active quests.
        /// </summary>
        public List<Quest> ActiveQuests => QuestTree.FindAll(x => x.Active);
        /// <summary>
        /// A list of the player's currently active quests which are ready to turn in.
        /// </summary>
        public List<Quest> CompletedQuests => QuestTree.FindAll(x => x.Status == "c");

        /// <summary>
        /// Loads the specified quest.
        /// </summary>
        /// <param name="ids">The id(s) of the quests to load.</param>
        public void Load(params int[] ids)
        {
            Bot.CallGameFunction("world.showQuests", string.Join(",", ids.Select(i => i.ToString())), "q");
        }

        /// <summary>
        /// Accepts the specified quest.
        /// </summary>
        /// <param name="id">The id of the quest.</param>
        public void Accept(int id)
        {
            if (Bot.Options.SafeTimings)
                Bot.Wait.ForActionCooldown(ScriptWait.GameActions.AcceptQuest);
            Bot.CallGameFunction("world.acceptQuest", id);
            if (Bot.Options.SafeTimings)
                Bot.Wait.ForQuestAccept(id);
        }

        /// <summary>
        /// Tries to accept a quest until it is successfully accepted.
        /// </summary>
        /// <param name="id">The id of the quest.</param>
        /// <param name="tries">The maximum number of tries before giving up.</param>
        public bool EnsureAccept(int id, int tries = 100)
        {
            int tried = 0;
            while (!IsInProgress(id) && tried++ < tries)
                Accept(id);
            return !IsInProgress(id);
        }

        /// <summary>
        /// Attempts to turn in the specified quest.
        /// </summary>
        /// <param name="id">The id of the quest.</param>
        /// <param name="itemId">The id of the item chosen when the quest is turned in.</param>
        /// <param name="special">Determines whether the quest is marked 'special' or not.</param>
        /// <remarks>The itemId parameter can be used to acquire a particular item when there is a choice of rewards from the quest. For example, in the Voucher Item: Totem of Nulgath quest, you are given the choice of getting a Totem of Nulgath or 10 Gems of Nulgath.</remarks>
        public void Complete(int id, int itemId = -1, bool special = false)
        {
            if (Bot.Options.SafeTimings)
                Bot.Wait.ForActionCooldown(ScriptWait.GameActions.TryQuestComplete);
            if (Bot.Options.ExitCombatBeforeQuest && Bot.Player.InCombat)
                Bot.Player.Jump(Bot.Player.Cell, Bot.Player.Pad);
            ScriptInterface.Instance.CallGameFunction("world.tryQuestComplete", id, itemId, special);
            if (Bot.Options.SafeTimings)
                Bot.Wait.ForQuestComplete(id);
        }

        /// <summary>
        /// Tries to turn in the specified quest until it is successfully turned in.
        /// </summary>
        /// <param name="id">The id of the quest.</param>
        /// <param name="itemId">The id of the item chosen when the quest is turned in.</param>
        /// <param name="special">Determines whether the quest is marked 'special' or not.</param>
        /// <param name="tries">The maximum number of tries before giving up.</param>
        public bool EnsureComplete(int id, int itemId = -1, bool special = false, int tries = 100)
        {
            if (Bot.Options.ExitCombatBeforeQuest)
                Bot.Player.Jump(Bot.Player.Cell, Bot.Player.Pad);
            int tried = 0;
            while (IsInProgress(id) && tried++ < tries)
                Complete(id, itemId, special);
            return IsInProgress(id);
        }

        /// <summary>
        /// Checks if the specified quest is currently in progress.
        /// </summary>
        /// <param name="id">The id of the quest.</param>
        /// <returns>Whether the specified quest is in progress.</returns>
        [MethodCallBinding("world.isQuestInProgress", GameFunction = true)]
        public bool IsInProgress(int id) => false;

        /// <summary>
        /// Checks if the specified quest can be turned in.
        /// </summary>
        /// <param name="id">The id of the quest.</param>
        /// <returns>Whether the specified quest is ready to turn in or not.</returns>
        public bool CanComplete(int id) => CompletedQuests.Contains(q => q.ID == id);

        /// <summary>
        /// Checks if the specified quest is a completed daily quest.
        /// </summary>
        /// <param name="id">The id of the quest.</param>
        /// <returns>Whether or not the specified quest is a daily quest that the player has already completed.</returns>
        public bool IsDailyComplete(int id)
        {
            Bot.Wait.ForTrue(() => QuestTree.Contains(x => x.ID == id), () => Load(id), 20);
            Quest q = QuestTree.Find(x => x.ID == id);
            return q != null && q.Field != null && Bot.CallGameFunction<int>("world.getAchievement", q.Field, q.Index) != 0;
        }
    }
}
