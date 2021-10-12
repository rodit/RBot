using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Misc.CmdLabel")]
    public class Label : ICodeGenerator
    {
        public string Name { get; set; }

        public void GenerateCode(CodegenTextWriter code) => code.WriteLine($"{Name.ToLabel()}:");
    }
}
