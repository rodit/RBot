using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Item.CmdBankSwap")]
    public class BankSwap : ICodeGenerator
    {
        public string BankItemName { get; set; }
        public string InventoryItemName { get; set; }

        public void GenerateCode(CodegenTextWriter code) => code.WriteLine($"bot.Bank.Swap({InventoryItemName.GetCode()}, {BankItemName.GetCode()});");
    }
}