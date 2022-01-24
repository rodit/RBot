using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RBot.Utils;

namespace RBot.Updates;

public class UpdateChecker
{
    public const string ApiUrl = "https://api.github.com/repos/brenohenrike/rbot/releases";

    public static async Task<List<UpdateInfo>> GetReleases()
    {
        using GHWebClient wc = new();
        return JsonConvert.DeserializeObject<List<UpdateInfo>>(await wc.DownloadStringTaskAsync(ApiUrl));
    }
}
