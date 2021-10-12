using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Quest.CmdAcceptQuest", "Grimoire.Botting.Commands.Quest.CmdAcceptQuest2")]
    public class AcceptQuest : ICodeGenerator
    {
        public QuestHolder Quest { get; set; }
        public string QuestID { get; set; }

        public string Id => Quest?.Id.ToString() ?? QuestID;

        public void GenerateCode(CodegenTextWriter code) => code.WriteLine($"bot.Quests.EnsureAccept({Id.GetCode("int")});");
    }

    public class QuestHolder
    {
        public int Id { get; set; }
    }
}