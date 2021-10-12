using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Item.CmdGetDrop")]
    public class GetDrop : ICodeGenerator
    {
        public string ItemName { get; set; }

        public void GenerateCode(CodegenTextWriter code) => code.WriteLine($"bot.Player.Pickup({ItemName.GetCode()});");
    }
}
