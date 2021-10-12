using CodegenCS;

namespace RBot.BotConverters.Grimoire.Commands
{
    [Map("Grimoire.Botting.Commands.Misc.CmdClientMessage")]
    public class ClientMessage : ICodeGenerator
    {
        public string Messages { get; set; }
        public bool IsWarning { get; set; }

        public void GenerateCode(CodegenTextWriter code) => code.WriteLine($"bot.SendClientPacket(\"%xt%{(IsWarning ? "warning" : "server")}%-1%{Messages}%\");");
    }
}