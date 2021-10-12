using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Misc.CmdLoadBot")]
    public class LoadBot : ICodeGenerator
    {
        public string BotFilePath { get; set; }

        public void GenerateCode(CodegenTextWriter code) => code.WriteLine($"ScriptManager.LoadedScript = {BotFilePath.GetCode()};")
            .WriteLine("ScriptManager.RestartScript();");
    }
}
