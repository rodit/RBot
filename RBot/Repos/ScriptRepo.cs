using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot.Repos
{
    public class ScriptRepo
    {
        public string Author { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public string ContentsUrl => $"https://api.github.com/repos/{Username}/{Name}/contents/{Extension}";
    }
}
