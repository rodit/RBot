using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Map.Yulgar")]
    public class Yulgar : ICodeGenerator
    {
        public void GenerateCode(CodegenTextWriter code) => code.WriteLine("bot.Player.Jump(bot.Player.Cell, bot.Player.Pad);")
            .WriteLine("bot.Player.Join(\"yulgar\");")
            .WriteLine("bot.Player.WalkTo(bot.Runtime.Random.Next(150, 700), bot.Runtime.Random.Next(320, 450));")
            .WriteLine("ScriptManager.StopScript();");
    }
}