using CodegenCS;
using Newtonsoft.Json;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Misc.CmdToggleProvoke", "Grimoire.Botting.Commands.Misc.CmdToggleProvokeInMap")]
    public class ToggleProvoke : ICodeGenerator
    {
        [JsonProperty("$type")]
        private string CmdType { get; set; }

        public string OptionName => CmdType.Contains("InMap") ? "AggroAllMonsters" : "AggroMonsters";
        public int Type { get; set; }

        public void GenerateCode(CodegenTextWriter code) => code.WriteLine(Type switch
        {
            0 => $"bot.Options.{OptionName} = false;",
            1 => $"bot.Options.{OptionName} = true;",
            2 => $"bot.Options.{OptionName} = !bot.Options.{OptionName};",
            _ => $"// Unsupported ToggleProvoke type {Type}."
        });
    }
}
