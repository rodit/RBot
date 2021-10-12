using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Item.CmdEquip")]
    public class Equip : ICodeGenerator
    {
        public string ItemName { get; set; }
        public bool Safe { get; set; }

        public void GenerateCode(CodegenTextWriter code)
        {
            if (Safe)
            {
                code.WriteLine("bot.Player.Jump(bot.Player.Cell, bot.Player.Pad);")
                    .WriteLine("bot.Sleep(1000);");
            }

            code.WriteLine($"bot.Player.EquipItem({ItemName.GetCode()});");
        }
    }
}