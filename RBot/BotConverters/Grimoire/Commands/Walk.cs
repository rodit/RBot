using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Map.CmdWalk")]
    public class Walk : ICodeGenerator
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Type { get; set; }

        public void GenerateCode(CodegenTextWriter code) => code.WriteLine(Type == "Random"
            ? "bot.Player.WalkTo(bot.Runtime.Random.Next(150, 700), bot.Runtime.Random.Next(320, 450));"
            : $"bot.Player.WalkTo({X}, {Y});");
    }
}
