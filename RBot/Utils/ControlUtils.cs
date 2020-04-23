using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBot.Utils
{
    public static class ControlUtils
    {
        public static bool CheckedInvoke(this Control c, Action a)
        {
            bool req = c.InvokeRequired;
            (req ? () => c.Invoke(a) : a)();
            return req;
        }
    }
}
