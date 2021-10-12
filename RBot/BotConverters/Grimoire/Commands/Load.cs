using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Item.CmdLoad", "Grimoire.Botting.Commands.Item.CmdLoad2", "Grimoire.Botting.Commands.Item.CmdLoadTravel")]
    public class Load : ICodeGenerator
    {
        public string ShopId { get; set; }

        public void GenerateCode(CodegenTextWriter code) => code.WriteLine($"bot.Shops.Load({ShopId.GetCode("int")});");
    }
}