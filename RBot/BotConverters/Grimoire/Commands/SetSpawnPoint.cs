using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Map.CmdSetSpawn")]
    public class SetSpawnPoint : ICodeGenerator
    {
        public void GenerateCode(CodegenTextWriter code) => code.WriteLine("bot.Player.SetSpawnPoint();");
    }
}