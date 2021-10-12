using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Misc.Statements.CmdSetVar", "Grimoire.Botting.Commands.Misc.Statements.CmdUpdateVar")]
    public class SetVar : ICodeGenerator
    {
        public string Value1 { get; set; }
        public string Value2 { get; set; }

        public void GenerateCode(CodegenTextWriter code) => code.WriteLine($"bot.Config.Set(\"{Value1.ToLower().Replace(" ", "_")}\", \"{Value2}\");");
    }
}