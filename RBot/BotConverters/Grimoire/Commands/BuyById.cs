using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Item.CmdBuyById")]
    public class BuyById : ICodeGenerator
    {
        public string ItemID { get; set; }
        public string ShopID { get; set; }

        public void GenerateCode(CodegenTextWriter code) => code.WriteLine($"bot.Shops.BuyItem({ShopID.GetCode("int")}, {ItemID.GetCode("int")});");
    }
}