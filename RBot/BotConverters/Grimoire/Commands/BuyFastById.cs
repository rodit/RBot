namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Item.CmdBuyFastByID")]
    public class BuyFastById : ICodeGenerator
    {
        public string ItemID { get; set; }
        public string ShopID { get; set; }

        public string GenerateCode() => $"bot.Shops.BuyItem({ShopID}, {ItemID});";
    }
}
