using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Misc.CmdChange")]
    public class Change : ICodeGenerator
    {
        public bool Guild { get; set; }
        public string Text { get; set; }

        public void GenerateCode(CodegenTextWriter code) => code.WriteLine($"bot.Options.{(Guild ? "CustomGuild" : "CustomName")} = {Text.GetCode()};");
    }
}