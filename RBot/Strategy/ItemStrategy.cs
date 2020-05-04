using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot.Strategy
{
    public class ItemStrategy
    {
        public string Item { get; set; }
        public bool TempItem { get; set; }
        public virtual int Preference { get; } = 0;

        public virtual bool CanUse(ScriptInterface bot)
        {
            return true;
        }

        public virtual bool Execute(ScriptInterface bot, int required)
        {
            return false;
        }

        public virtual List<string> GetRequiredItems(ScriptInterface bot) => new List<string>();
    }
}
