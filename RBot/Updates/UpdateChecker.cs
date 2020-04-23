using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using RBot.Utils;

namespace RBot.Updates
{
    public class UpdateChecker
    {
        public const string ApiUrl = "https://api.github.com/repos/rodit/rbot/releases?client_id=726820423be5c752df62&client_secret=63b2a5b1a55fbeade88deab3b6c8914808bad7a6";

        public static async Task<List<UpdateInfo>> GetReleases()
        {
            using (RBotWebClient wc = new RBotWebClient())
                return JsonConvert.DeserializeObject<List<UpdateInfo>>(await wc.DownloadStringTaskAsync(ApiUrl));
        }
    }
}
