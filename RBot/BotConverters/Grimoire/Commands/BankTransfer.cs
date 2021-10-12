using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Item.CmdBankTransfer")]
    public class BankTransfer : ICodeGenerator
    {
        public bool TransferFromBank { get; set; }
        public string ItemName { get; set; }

        public void GenerateCode(CodegenTextWriter code) => code.WriteLine(TransferFromBank ? $"bot.Bank.ToInventory({ItemName.GetCode()});" : $"bot.Inventory.ToBank({ItemName.GetCode()});");
    }
}