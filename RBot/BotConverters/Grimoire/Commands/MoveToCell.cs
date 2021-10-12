using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Map.CmdMoveToCell")]
    public class MoveToCell : ICodeGenerator
    {
        public string Cell { get; set; }
        public string Pad { get; set; }

        public void GenerateCode(CodegenTextWriter code) => code.WriteLine($"bot.Player.Jump({Cell.GetCode()}, {Pad.GetCode()});");
    }
}
