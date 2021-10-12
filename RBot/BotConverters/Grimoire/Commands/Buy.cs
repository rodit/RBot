using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Item.CmdBuy")]
    public class Buy : ICodeGenerator
    {
        public int ShopId { get; set; }
        public string ItemName { get; set; }

        public void GenerateCode(CodegenTextWriter code) => code.WriteLine($"bot.Shops.BuyItem({ShopId}, {ItemName.GetCode()});");
    }
}
