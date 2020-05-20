using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot.CodeBuilder.Commands
{
    public class SendPacketCommand : CodeCommand
    {
        public string Packet { get; set; }
        public override string Code => $"bot.SendPacket(\"{Packet}\");";
    }
}
