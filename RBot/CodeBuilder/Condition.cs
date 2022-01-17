using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot.CodeBuilder
{
    public class Condition : ICodeBlock
    {
        public static List<string> CompareOperators = new()
        {
            "==",
            "!=",
            ">",
            "<",
            ">=",
            "<="
        };

        public string Name => "Condition";

        public ICodeBlock Left { get; set; }
        public ICodeBlock Right { get; set; }
        public string Compare { get; set; }

        public string Code => $"{Left.Code} {Compare} {Right.Code}";
    }
}
