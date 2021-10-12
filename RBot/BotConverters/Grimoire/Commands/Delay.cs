using CodegenCS;
using Newtonsoft.Json;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Misc.CmdDelay")]
    public class Delay : ICodeGenerator
    {
        [JsonProperty("Delay")]
        public int DelayLength { get; set; }

        public void GenerateCode(CodegenTextWriter code) => code.WriteLine($"bot.Sleep({DelayLength});");
    }
}