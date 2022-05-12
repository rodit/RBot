using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RBot.Utils;

namespace RBot.Updates;

public class UpdateChecker
{
    public static readonly string[] ReleaseUrls = { "https://api.github.com/repos/brenohenrike/rbot/releases", "https://api.github.com/repos/rodit/rbot/releases" };

    public static async Task<List<UpdateInfo>> GetReleases()
    {
        var releaseSearch = ReleaseUrls.Select(url => HttpClients.GetGHClient().GetAsync(url));
        await Task.WhenAll(releaseSearch);
        var releases = releaseSearch.Select(r => r.Result.Content.ReadAsStringAsync());
        await Task.WhenAll(releases);
        return releases.Select(r => r.Result).Select(r => JsonConvert.DeserializeObject<List<UpdateInfo>>(r)).SelectMany(r => r).ToList();
    }
}
