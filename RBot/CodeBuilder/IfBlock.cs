using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot.CodeBuilder
{
    public class IfBlock : MultilineCodeBlock
    {
        public string Name => "If Block";

        public Condition Condition { get; set; } = new Condition();
        public new string Code => $"if({Condition.Code})\n{{\n    {base.Code}\n}}";
    }
}
