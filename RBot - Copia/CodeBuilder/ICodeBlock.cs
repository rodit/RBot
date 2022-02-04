using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot.CodeBuilder
{
    public interface ICodeBlock
    {
        string Name { get; }
        string Code { get; }
    }
}
