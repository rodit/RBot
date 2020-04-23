using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;

namespace RBot
{
    public class ScriptCompileException : Exception
    {
        public ScriptCompileException(string error) : base(error)
        {

        }
    }
}
