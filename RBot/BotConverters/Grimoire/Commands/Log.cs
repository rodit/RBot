using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Misc.CmdLog")]
    public class Log : ICodeGenerator
    {
        public string Text { get; set; }
        public bool Debug { get; set; }
        private bool Clear { get; set; }

        public void GenerateCode(CodegenTextWriter code)
        {
            var text = Clear
                ? "[CLEAR]"
                : Text.Replace("{USERNAME}", "{bot.Player.Username}")
                    .Replace("{MAP}", "{bot.Map.Name}")
                    .Replace("{ROOM_ID}", "{bot.Map.RoomID}")
                    .Replace("{ROOM_NUM}", "")
                    .Replace("{GOLD}", "{bot.Player.Gold}")
                    .Replace("{LEVEL}", "{bot.Player.Level}")
                    .Replace("{CELL}", "{bot.Player.Cell}")
                    .Replace("{PAD}", "{bot.Player.Pad}")
                    .Replace("{HEALTH}", "{bot.Player.Health}")
                    .Replace("{MANA}", "{bot.Player.Mana}")
                    .Replace("{TIME}", "{DateTime.Now:HH:mm:ss}")
                    .Replace("{TIME: 12}", "{DateTime.Now:hh:mm:ss tt}")
                    .Replace("{TIME: 24}", "{DateTime.Now:HH:mm:ss}");

            code.WriteLine($"bot.Log($\"{text}\");");
        }
    }
}