using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot.CodeBuilder
{
    public class MultilineCodeBlock : ICodeBlock
    {
        private static readonly List<ICodeBlock> codeBlocks = new();

        public string Name => "Multiline Block";

        public List<ICodeBlock> Blocks { get; } = codeBlocks;

        public string Code => string.Join("\n", Blocks.Select(b => b.Code));
    }
}
