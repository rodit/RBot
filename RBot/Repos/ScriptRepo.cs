using Newtonsoft.Json;
using RBot.Utils;
using System;
using System.Threading.Tasks;

namespace RBot.Repos;

public class ScriptRepo
{
    public string Author { get; set; }
    public string Username { get; set; }
    public string Name { get; set; }
    public string Extension { get; set; }
    public string ContentsUrl => $"https://api.github.com/repos/{Username}/{Name}/contents/{Extension}";
    public string CommitsUrl => $"https://api.github.com/repos/{Username}/{Name}/commits";
    public string RecursiveTreeUrl { get; private set; } = "";

    public async Task<string> GetLastCommitRecursiveTree()
    {
        using var response = await HttpClients.GetGHClient().GetAsync(CommitsUrl);
        dynamic commits = JsonConvert.DeserializeObject(await response.Content.ReadAsStringAsync());
        return RecursiveTreeUrl = $"https://api.github.com/repos/{Username}/{Name}/git/trees/{Convert.ToString(commits[0].sha)}?recursive=true";
    }

    public string GetContentUrl(string extension) => $"https://api.github.com/repos/{Username}/{Name}/contents/{extension}";
}
