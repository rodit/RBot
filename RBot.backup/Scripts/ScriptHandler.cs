using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot
{
    public class ScriptHandler
    {
        public string Name { get; set; }
        public int Ticks { get; set; }
        public Func<ScriptInterface, bool> Function { get; set; }
    }
}
