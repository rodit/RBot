using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBot
{
    public partial class BaseUserControl : UserControl
    {
        internal ScriptInterface Bot => ScriptInterface.Instance;
        public BaseUserControl() : base() { }
    }
}
