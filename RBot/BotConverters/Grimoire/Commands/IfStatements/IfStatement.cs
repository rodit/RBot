using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands.IfStatements
{
    public abstract class IfStatement : ICodeGenerator
    {
        public string Tag { get; set; }
        public string Value1 { get; set; }
        public string Value2 { get; set; }

        public abstract string Statement { get; }

        public void GenerateCode(CodegenTextWriter code) => code.Write($"if ({Statement}) ");
    }
}
