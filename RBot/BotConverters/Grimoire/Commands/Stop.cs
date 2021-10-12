using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Misc.CmdStop")]
    public class Stop : ICodeGenerator
    {
        public void GenerateCode(CodegenTextWriter code) => code.WriteLine("ScriptManager.StopScript();");
    }
}