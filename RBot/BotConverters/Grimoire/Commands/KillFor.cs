using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Combat.CmdKillFor")]
    public class KillFor : ICodeGenerator
    {
        public string Monster { get; set; }
        public string ItemName { get; set; }
        public ItemType ItemType { get; set; }
        public string Quantity { get; set; }

        public int QuantityInt => int.TryParse(Quantity, out var quant) ? quant : 1;
        public bool Temp => ItemType == ItemType.TempItems;

        public void GenerateCode(CodegenTextWriter code) => code.WriteLine($"bot.Player.KillForItem({Monster.GetCode()}, {ItemName.GetCode()}, {QuantityInt}, {Temp.ToLower()});");
    }
}
