using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Item.CmdSell")]
    public class Sell : ICodeGenerator
    {
        public string ItemName { get; set; }

        public void GenerateCode(CodegenTextWriter code) => code.WriteLine($"bot.Shops.SellItem({ItemName.GetCode()});");
    }
}
