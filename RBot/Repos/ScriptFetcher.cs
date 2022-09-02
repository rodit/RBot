using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RBot.Utils;

namespace RBot.Repos;

public class ScriptFetcher
{
    public const string BaseUrl = "https://raw.githubusercontent.com/brenohenrike/rbot/master/repos";
    public const string DebugUrl = "https://raw.githubusercontent.com/brenohenrike/rbot/master/debugrepos";

    public static async Task<List<ScriptRepo>> GetRepos()
    {
        using var response = await HttpClients.Default.GetAsync(BaseUrl);
        return (await response.Content.ReadAsStringAsync()).Split('\n').Select(l => l.Trim().Split('|')).Where(p => p.Length == 4).Select(p => new ScriptRepo()
        {
            Username = p[0],
            Name = p[1],
            Extension = p[2],
            Author = p[3]
        }).ToList();
    }

    public static async Task<List<ScriptInfo>> GetScripts(ScriptRepo repo)
    {
        await repo.GetLastCommitRecursiveTree();
        using var treeResponse = await HttpClients.GetGHClient().GetAsync(repo.RecursiveTreeUrl);
        var treeInfos = JsonConvert.DeserializeObject<ScriptTree>(await treeResponse.Content.ReadAsStringAsync()).TreeInfo?
                                   .Where(i => i.Type == "tree") ?? null;
        
        var requests = treeInfos?.Select(i => HttpClients.GetGHClient().GetAsync(repo.GetContentUrl(i.Path)))
                                .ToList() ?? new();
        requests.Add(HttpClients.GetGHClient().GetAsync(repo.ContentsUrl));
        await Task.WhenAll(requests);

        var contents = requests.Select(request => request.Result)
                               .Select(result => result.Content.ReadAsStringAsync());
        await Task.WhenAll(contents);
        return contents.Select(content => content.Result)
                        .Select(t => JsonConvert.DeserializeObject<List<ScriptInfo>>(t))
                        .SelectMany(l => l)
                        .Where(s => s.FileName.EndsWith(".cs"))
                        .Distinct()
                        .ToList();
    }
}
