using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Misc.ClearTemp")]
    public class ClearTemp : ICodeGenerator
    {
        public void GenerateCode(CodegenTextWriter code) => code.WriteLine("bot.Config.SetDefaults();");
    }
}
