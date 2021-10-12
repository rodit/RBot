using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Combat.CmdRest")]
    public class Rest : ICodeGenerator
    {
        public bool Full { get; set; }

        public void GenerateCode(CodegenTextWriter code) => code.WriteLine($"bot.Player.Rest({Full.ToLower()});");
    }
}
