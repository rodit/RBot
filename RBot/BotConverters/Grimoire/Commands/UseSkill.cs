using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Combat.CmdUseSkill")]
    public class UseSkill : ICodeGenerator
    {
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

            code.WithCBlock($"if (({SafeHp} == 100 || 100 * bot.Player.Health / bot.Player.MaxHealth > {SafeHp}) && ({SafeMp} == 100 || 100 * bot.Player.Mana / bot.Player.MaxMana > {SafeMp}))", gen => gen
                .WriteLine($"bot.Player.UseSkill({Index});"));
        }
    }
}
