using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Combat.CmdAttack")]
    public class Attack : ICodeGenerator
    {
        public string Monster { get; set; }

        public void GenerateCode(CodegenTextWriter code) => code.WriteLine($"bot.Player.Attack({Monster.GetCode()});");
    }
}
