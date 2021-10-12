using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Combat.CmdKill")]
    public class Kill : ICodeGenerator
    {
        public string Monster { get; set; }

        public void GenerateCode(CodegenTextWriter code) => code.WriteLine($"bot.Player.Kill({Monster.GetCode()});");
    }
}
