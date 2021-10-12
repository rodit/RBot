using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Item.CmdMapItem", "Grimoire.Botting.Commands.Item.CmdMapItem2")]
    public class MapItem : ICodeGenerator
    {
        public string ItemId { get; set; }

        public void GenerateCode(CodegenTextWriter code) => code.WriteLine($"bot.Map.GetMapItem({ItemId.GetCode("int")});");
    }
}
