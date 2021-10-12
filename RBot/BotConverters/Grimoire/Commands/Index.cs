using CodegenCS;
using Newtonsoft.Json;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Misc.CmdIndex")]
    public class Index : ICodeGenerator
    {
        public string Type { get; set; }

        [JsonProperty("AbsIndex")]
        public int Goto { get; set; }

        public void GenerateCode(CodegenTextWriter code) => code.WriteLine($"goto idx_{Goto};");
    }
}
