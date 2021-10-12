using CodegenCS;
using Newtonsoft.Json;
using System.Linq;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("*")]
    public class Unsupported : ICodeGenerator
    {
        [JsonProperty("$type")]
        public string Type { get; set; }

        public void GenerateCode(CodegenTextWriter code) => code.WriteLine($"; // Unsupported command {Type.Replace(", Grimoire", "").Split('.').Last()}.");
    }
}
