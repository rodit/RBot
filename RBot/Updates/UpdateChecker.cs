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
        public const string ApiUrl = "https://api.github.com/repos/rodit/rbot/releases";

        public static async Task<List<UpdateInfo>> GetReleases()
        {
            using (GHWebClient wc = new GHWebClient())
                return JsonConvert.DeserializeObject<List<UpdateInfo>>(await wc.DownloadStringTaskAsync(ApiUrl));
        }
    }
}
