using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot.CodeBuilder.Commands
{
    public class SendClientPacketCommand : CodeCommand
    {
        public string Packet { get; set; }
        public override string Code => $"bot.SendClientPacket(\"{Packet}\");";
    }
}
