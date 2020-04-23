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
        public string ContentsUrl => $"https://api.github.com/repos/{Username}/{Name}/contents/?client_id=726820423be5c752df62&client_secret=63b2a5b1a55fbeade88deab3b6c8914808bad7a6";
    }
}
