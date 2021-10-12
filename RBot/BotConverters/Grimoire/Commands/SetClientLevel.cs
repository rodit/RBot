using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Misc.CmdSetClientLevel")]
    public class SetClientLevel : ICodeGenerator
    {
        public void GenerateCode(CodegenTextWriter code) => code.WriteLine("bot.Player.Level = 100;");
    }
}