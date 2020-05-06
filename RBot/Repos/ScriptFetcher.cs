using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using RBot.Utils;

namespace RBot.Repos
{
    public class ScriptFetcher
    {
        public const string BaseUrl = "https://raw.githubusercontent.com/rodit/rbot-scripts/master/repos";

        public static async Task<List<ScriptRepo>> GetRepos()
        {
            using (GHWebClient wc = new GHWebClient())
            {
                return (await wc.DownloadStringTaskAsync(BaseUrl)).Split('\n').Select(l => l.Trim().Split('|')).Where(p => p.Length == 3).Select(p => new ScriptRepo()
                {
                    Username = p[0],
                    Name = p[1],
                    Author = p[2]
                }).ToList();
            }
        }

        public static async Task<List<ScriptInfo>> GetScripts(ScriptRepo repo)
        {
            using (GHWebClient wc = new GHWebClient())
            {
                return JsonConvert.DeserializeObject<List<ScriptInfo>>(await wc.DownloadStringTaskAsync(repo.ContentsUrl)).Where(x => x.FileName.EndsWith(".cs") && (x.Parent = repo) != null).ToList();
            }
        }
    }
}
