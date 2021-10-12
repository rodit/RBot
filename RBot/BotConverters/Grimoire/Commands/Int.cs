using CodegenCS;
using Newtonsoft.Json;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Misc.CmdInt")]
    public class Int : ICodeGenerator
    {
        public Types Type { get; set; }

        [JsonProperty("Int")]
        public string IntName { get; set; }

        public int Value { get; set; }

        public void GenerateCode(CodegenTextWriter code) => code.WriteLine(Type switch
        {
            Types.Set => $"bot.Config.Set({IntName.GetCode()}, {Value});",
            Types.Lower => $"bot.Config.Set({IntName.GetCode()}, bot.Config.Get<int>({IntName.GetCode()}) - 1);",
            Types.Upper => $"bot.Config.Set({IntName.GetCode()}, bot.Config.Get<int>({IntName.GetCode()}) + 1);",
            _ => $"// Invalid int command {Type} for {IntName}."
        });
    }

    public enum Types
    {
        Set,
        Upper,
        Lower
    }
}
