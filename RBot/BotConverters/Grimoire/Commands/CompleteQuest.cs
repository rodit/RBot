using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Quest.CmdCompleteQuest", "Grimoire.Botting.Commands.Quest.CmdCompleteQuest2")]
    public class CompleteQuest : ICodeGenerator
    {
        public QuestHolder Quest { get; set; }
        public string QuestID { get; set; }
        public string ItemID { get; set; }

        public string Id => Quest?.Id.ToString() ?? QuestID;

        public void GenerateCode(CodegenTextWriter code) => code.WriteLine($"bot.Quests.EnsureComplete({Id.GetCode("int")}, {ItemID?.GetCode("int") ?? "-1"});");
    }
}
