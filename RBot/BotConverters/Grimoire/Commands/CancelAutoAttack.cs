using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Combat.CmdCancelAutoAttack")]
    public class CancelAutoAttack : ICodeGenerator
    {
        public void GenerateCode(CodegenTextWriter code) => code.WriteLine("bot.Player.CancelAutoAttack();");
    }
}