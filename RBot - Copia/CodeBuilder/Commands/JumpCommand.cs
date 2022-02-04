using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot.CodeBuilder.Commands
{
    public class JumpCommand : CodeCommand
    {
        public string Cell { get; set; }
        public string Pad { get; set; }
        public override string Code => $"bot.Player.Jump(\"{Cell}\", \"{Pad}\");";
    }
}
