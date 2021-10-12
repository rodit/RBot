using CodegenCS;
using Newtonsoft.Json;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Misc.CmdPacket")]
    public class Packet : ICodeGenerator
    {
        [JsonProperty("Packet")]
        public string Content { get; set; }

        public bool Client { get; set; }

        public void GenerateCode(CodegenTextWriter code)
        {
            var content = Content.Replace("{ROOM_ID}", "{bot.Map.RoomID}")
                .Replace("{ROOM_NUMBER}", "0")
                .Replace("PLAYERNAME", "{bot.Player.Username}")
                .Replace("{GETMAP}", "{bot.Map.Name}");

            code.WriteLine($"bot.{(Client ? "SendClientPacket" : "SendPacket")}($\"{content}\");");
        }
    }
}
