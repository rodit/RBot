using RBot.Flash;
using RBot.Quests;
using RBot.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RBot;

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
        CheckScriptTermination();
        Bot.CallGameFunction("world.showQuests", string.Join(",", ids.Select(i => i.ToString())), "q");
    }

    internal void _Load(params int[] ids) => Bot.CallGameFunction("world.showQuests", string.Join(",", ids.Select(i => i.ToString())), "q");

    /// <summary>
    /// Loads the quest with the specified id and waits until it's in the quest tree.
    /// </summary>
    /// <param name="id">The ID of the quest to load.</param>
    /// <returns>The quest with the given ID.</returns>
    public Quest EnsureLoad(int id)
    {
        Load(id);
        Quest q = null;
        Bot.Wait.ForTrue(() => TryGetQuest(id, out q), 20);
        return q;
    }

    /// <summary>
    /// Tries to get the quest with the given ID if it is loaded.
    /// </summary>
    /// <param name="id">The ID of the quest to get.</param>
    /// <param name="quest">The quest object to set as the result.</param>
    /// <returns>True if the quest is loaded and quest was set succesfully.</returns>
    public bool TryGetQuest(int id, out Quest quest) => (quest = QuestTree.Find(x => x.ID == id)) != null;

    /// <summary>
    /// Accepts the specified quest.
    /// </summary>
    /// <param name="id">The id of the quest.</param>
    public void Accept(int id)
    {
        CheckScriptTermination();
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
        CheckScriptTermination();
        if (Bot.Options.SafeTimings)
            Bot.Wait.ForActionCooldown(ScriptWait.GameActions.TryQuestComplete);
        if (Bot.Options.ExitCombatBeforeQuest && Bot.Player.InCombat)
            Bot.Player.Jump(Bot.Player.Cell, Bot.Player.Pad);
        ScriptInterface.Instance.CallGameFunction("world.tryQuestComplete", id, itemId, special);
        if (Bot.Options.SafeTimings)
            Bot.Wait.ForQuestComplete(id);
    }

    /// <summary>
    /// Tries to turn in the specified quest until it is successfully turned in (no longer in progress).
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
        do
        {
            Complete(id, itemId, special);
        } while (IsInProgress(id) && tried++ < tries);

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
    /// Send a Client-side packet that makes the game think you have completed a questline up to a certain point
    /// </summary>
    /// <param name="QuestID">Quest ID of the quest you want the game to think you have compelted</param>
    public void UpdateQuest(int QuestID)
    {
        Quest Data = Bot.Quests.EnsureLoad(QuestID);
        Bot.SendClientPacket(string.Format("{\"t\":\"xt\",\"b\":{\"r\":-1,\"o\":{\"cmd\":\"updateQuest\",\"iValue\":{0},\"iIndex\":{1}}}}", Data.Value + 1, Data.Slot), "json");
    }

    /// <summary>
    /// Send a Client-side packet that makes the game think you have completed a questline up to a certain point
    /// </summary>
    /// <param name="Value">Value property of the quest you want it to think you have completed</param>
    /// <param name="Slot">Slot property of the questline you want it to think you have progressed</param>
    public void UpdateQuest(int Value, int Slot)
    {
        Bot.SendClientPacket(string.Format("{\"t\":\"xt\",\"b\":{\"r\":-1,\"o\":{\"cmd\":\"updateQuest\",\"iValue\":{0},\"iIndex\":{1}}}}", Value + 1, Slot), "json");
    }

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
        var quest = EnsureLoaded(id);
        return quest != null && quest.Field != null && Bot.CallGameFunction<int>("world.getAchievement", quest.Field, quest.Index) != 0;
    }

    /// <summary>
    /// Checks if a storyline quest is unlocked.
    /// </summary>
    /// <param name="id">The id of the quest.</param>
    /// <returns>Whether or not the quest is unlocked.</returns>
    public bool IsUnlocked(int id)
    {
        var quest = EnsureLoad(id);
        return quest.Slot < 0 || Bot.CallGameFunction<int>("world.getQuestValue", quest.Slot) >= quest.Value - 1;
    }

    /// <summary>
    /// Performs all checks to see if a quest can be accepted/turned in.
    /// </summary>
    /// <param name="id">The id of the quest.</param>
    /// <returns>Whether or not the quest can be accepted.</returns>
    public bool IsAvailable(int id)
    {
        var quest = EnsureLoaded(id);
        return quest != null
               && !IsDailyComplete(quest.ID)
               && IsUnlocked(quest.ID)
               && (!quest.Upgrade || Bot.Player.Upgrade)
               && Bot.Player.Level >= quest.Level
               && (quest.RequiredClassID <= 0 || Bot.CallGameFunction<int>("world.myAvatar.getCPByID", quest.RequiredClassID) >= quest.RequiredClassPoints)
               && (quest.RequiredFactionId <= 1 || Bot.CallGameFunction<int>("world.myAvatar.getRep", quest.RequiredFactionId) >= quest.RequiredFactionRep)
               && quest.AcceptRequirements.All(r => Bot.Inventory.Contains(r.Name, r.Quantity));
    }

    private Quest EnsureLoaded(int id)
    {
        Bot.Wait.ForTrue(() => QuestTree.Contains(x => x.ID == id), () => Load(id), 20);
        return QuestTree.Find(q => q.ID == id);
    }
}
