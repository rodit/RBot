using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Misc.CmdGotoPlayer")]
    public class GotoPlayer : ICodeGenerator
    {
        public string PlayerName { get; set; }

        public void GenerateCode(CodegenTextWriter code) => code.WriteLine($"bot.Player.Goto({PlayerName.GetCode()});");
    }
}