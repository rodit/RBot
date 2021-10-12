using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Map.CmdJoin", "Grimoire.Botting.Commands.Map.CmdJoin2", "Grimoire.Botting.Commands.Map.CmdTravel")]
    public class Join : ICodeGenerator
    {
        public string Map { get; set; }
        public string Room { get; set; }
        public string Cell { get; set; }
        public string Pad { get; set; }

        public string MapName
        {
            get
            {
                if (Map.IsVar())
                {
                    return Map;
                }

                var mapClean = Map.Replace("Packet", "").Replace("Glitch", "").Trim();
                var parts = mapClean.Split('-');
                return $"{parts[0]}-{(parts.Length == 2 ? parts[1] : Room ?? "1e9")}";
            }
        }

        public void GenerateCode(CodegenTextWriter code) => code.WriteLine($"bot.Player.Join({MapName.GetCode()}, {Cell.GetCode()}, {Pad.GetCode()});");
    }
}
