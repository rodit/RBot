using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RBot.CodeBuilder.Commands
{
    public abstract class CodeCommand : ICodeBlock
    {
        [Browsable(false)]
        public string Name => GetType().Name.Split(new string[] { "Command" }, StringSplitOptions.RemoveEmptyEntries)[0];
        [Browsable(false)]
        public abstract string Code { get; }

        public override string ToString()
        {
            return $"{Name}[{string.Join(", ", GetType().GetProperties().Where(p => p.Name != "Code" && p.Name != "Name").Select(p => p.GetValue(this)))}]";
        }
    }
}
