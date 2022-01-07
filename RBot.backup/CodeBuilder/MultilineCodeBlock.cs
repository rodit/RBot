using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot.CodeBuilder
{
    public class MultilineCodeBlock : ICodeBlock
    {
        public string Name => "Multiline Block";

        public List<ICodeBlock> Blocks { get; } = new List<ICodeBlock>();

        public string Code => string.Join("\n", Blocks.Select(b => b.Code));
    }
}
