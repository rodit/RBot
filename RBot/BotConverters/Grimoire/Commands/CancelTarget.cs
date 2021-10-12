using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Combat.CmdCancelTarget")]
    public class CancelTarget : ICodeGenerator
    {
        public void GenerateCode(CodegenTextWriter code) => code.WriteLine("bot.Player.CancelTarget()");
    }
}