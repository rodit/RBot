using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Misc.CmdGotoLabel")]
    public class GotoLabel : ICodeGenerator
    {
        public string Label { get; set; }

        public void GenerateCode(CodegenTextWriter code) => code.WriteLine($"goto {Label.ToLabel()};");
    }
}