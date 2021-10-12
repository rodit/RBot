using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Misc.CmdRestart")]
    public class Restart : ICodeGenerator
    {
        public void GenerateCode(CodegenTextWriter code) => code.WriteLine("ScriptManager.RestartScript();");
    }
}