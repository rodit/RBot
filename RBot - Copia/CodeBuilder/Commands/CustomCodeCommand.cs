using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot.CodeBuilder.Commands
{
    public class CustomCodeCommand : CodeCommand
    {
        public string CustomCode { get; set; }
        public override string Code => CustomCode;
    }
}
