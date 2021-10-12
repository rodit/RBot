using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Misc.CmdBlank", "Grimoire.Botting.Commands.Misc.CmdBlank2", "Grimoire.Botting.Commands.Misc.CmdBlank3")]
    public class Blank : ICodeGenerator
    {
        public string Text { get; set; }

        public void GenerateCode(CodegenTextWriter code) => code.WriteLine(string.IsNullOrWhiteSpace(Text) ? "// Blank" : $"// {Text}");
    }
}
