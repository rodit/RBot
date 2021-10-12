using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Combat.CmdUseSkill2")]
    public class UseSkill2 : ICodeGenerator
    {
        private const string SelfTargeted = "Self-targeted";

        public string Monster { get; set; }
        public string Index { get; set; }
        public int SafeHp { get; set; }
        public int SafeMp { get; set; }
        public bool Wait { get; set; }

        public void GenerateCode(CodegenTextWriter code)
        {
            if (Wait)
            {
                code.WriteLine($"bot.Wait.ForSkillCooldown({Index});");
            }

            code.WithCBlock($"if (100 * bot.Player.Health / bot.Player.MaxHealth > {SafeHp} && 100 * bot.Player.Mana / bot.Player.MaxMana > {SafeMp})", gen => gen
                .WriteLine(Monster == SelfTargeted ? "bot.Player.AttackPlayer(bot.Player.Username);" : $"bot.Player.Attack({Monster.GetCode()});")
                .WriteLine($"bot.Player.UseSkill({Index});"));
        }
    }
}
