using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Item.CmdWhitelist")]
    public class Whitelist : ICodeGenerator
    {
        public string Item { get; set; }

        public WhitelistState State { get; set; }

        public void GenerateCode(CodegenTextWriter code) => code.WriteLine(State switch
        {
            WhitelistState.On => "bot.Drops.Start();",
            WhitelistState.Off => "bot.Drops.Stop();",
            WhitelistState.Add => $"bot.Drops.Add({Item.GetCode()});",
            WhitelistState.Remove => $"bot.Drops.Remove({Item.GetCode()});",
            WhitelistState.Clear => "$bot.Drops.Clear();",
            _ => $"// Unsupported whitelist state {State} for item {Item}."
        });
    }

    public enum WhitelistState
    {
        On,
        Off,
        Clear,
        Add,
        Remove
    }
}
