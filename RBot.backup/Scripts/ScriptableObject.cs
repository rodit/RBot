using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot
{
    public class ScriptableObject
    {
        [JsonIgnore]
        public ScriptInterface Bot => ScriptInterface.Instance;
    }
}
