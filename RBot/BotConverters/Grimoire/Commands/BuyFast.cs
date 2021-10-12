using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Item.CmdBuyFast")]
    public class BuyFast : ICodeGenerator
    {
        public string ItemName { get; set; }

        public void GenerateCode(CodegenTextWriter code) => code.WriteLine($"bot.Shops.BuyItem({ItemName.GetCode()});");
    }
}
