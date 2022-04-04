using Newtonsoft.Json;
using RBot.Flash;
using RBot.Items;
using RBot.Players;
using RBot.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RBot;

public class ScriptMap : ScriptableObject
{
    public Dictionary<string, List<MapItem>> SavedMapItems = new();

    public ScriptMap()
    {
        LoadSavedMapItems();
    }
    /// <summary>
    /// The name of the last map joined in this session.
    /// </summary>
    public string LastMap { get; set; }
    /// <summary>
    /// The file path to the last loaded map SWF.
    /// </summary>
    public string MapFilePath { get; set; }
    /// <summary>
    /// The name of the map SWF file.
    /// </summary>
    public string MapFileName => string.IsNullOrEmpty(MapFilePath) ? "" : MapFilePath.Split(new char[] { '/', '\\' }, StringSplitOptions.RemoveEmptyEntries).Last();
    /// <summary>
    /// The "town" (region of the map) that precedes the file name.
    /// </summary>
    public string MapFileTown => string.IsNullOrEmpty(MapFilePath) ? "" : MapFilePath.Split('/').First();
    /// <summary>
    /// Gets the name of the currently loaded map.
    /// </summary>
    [ObjectBinding("world.strMapName", RequireNotNull = "world")]
    public string Name { get; }
    /// <summary>
    /// Gets the current room's area id.
    /// </summary>
    [ObjectBinding("world.curRoom")]
    public int RoomID { get; }
    /// <summary>
    /// Gets the number of players in the currently loaded map.
    /// </summary>
    [ObjectBinding("world.areaUsers.length")]
    public int PlayerCount { get; }
    /// <summary>
    /// Gets a list of player names in the currently loaded map.
    /// </summary>
    [ObjectBinding("world.areaUsers")]
    public List<string> PlayerNames { get; }
    [ObjectBinding("world.uoTree")]
    private readonly Dictionary<string, PlayerInfo> _players;
    /// <summary>
    /// Gets a list of all players in the current map.
    /// </summary>
    public List<PlayerInfo> Players => _players.Values.ToList();
    /// <summary>
    /// Gets a list of all players in the current cell.
    /// </summary>
    public List<PlayerInfo> CellPlayers => Players.FindAll(p => p.Cell == Bot.Player.Cell);
    /// <summary>
    /// Determines whether a map is currently loaded completely..
    /// </summary>
    public bool Loaded => !Bot.GetGameObject<bool>("world.mapLoadInProgress")
                        && Bot.IsNull("mcConnDetail.stage");
    /// <summary>
    /// Gets a list of all of the cells in the current map.
    /// </summary>
    [ObjectBinding("world.map.currentScene.labels", Select = "name")]
    public List<string> Cells { get; }

    /// <summary>
    /// Gets info about the player with the given username.
    /// </summary>
    /// <param name="username">The username of the player.</param>
    /// <returns>An object holding info for the given player.</returns>
    public PlayerInfo GetPlayer(string username) => Bot.GetGameObject<PlayerInfo>($"world.uoTree[\"{username.ToLower()}\"]");

    public bool TryGetPlayer(string username, out PlayerInfo player)
    {
        return (player = GetPlayer(username)) != null;
    }

    /// <summary>
    /// Reloads the current map.
    /// </summary>
    [MethodCallBinding("world.reloadCurrentMap", GameFunction = true)]
    public void Reload() { }

    /// <summary>
    /// Sends a getMapItem packet for the specified item.
    /// </summary>
    /// <param name="id">The id of the item.</param>
    [MethodCallBinding("world.getMapItem", RunMethodPre = true, GameFunction = true)]
    public void GetMapItem(int id)
    {
        if (Bot.Options.SafeTimings)
            Bot.Wait.ForActionCooldown(ScriptWait.GameActions.GetMapItem);
    }

    /// <summary>
    /// Checks if the specified player exists in the current room.
    /// </summary>
    /// <param name="name">The name of the player.</param>
    /// <returns>Whether the player with the specified name is in the current room.</returns>
    public bool PlayerExists(string name) => PlayerNames.Contains(x => x.ToLower() == name.ToLower());

    private Dictionary<string, List<MapItem>> LoadSavedMapItems()
    {
        if (!File.Exists(Path.Combine(cachePath, "0SavedMaps.json")))
            return null;

        return SavedMapItems = JsonConvert.DeserializeObject<Dictionary<string, List<MapItem>>>(File.ReadAllText(Path.Combine(cachePath, "0SavedMaps.json")));
    }

    private static string cachePath => Path.Combine(Environment.CurrentDirectory, "tools\\cache");
    /// <summary>
    /// Search for map items in the current map.
    /// </summary>
    /// <returns>A list of the current map items.</returns>
    /// <remarks>Returns null if <see cref="MapFilePath"/> or the file of the map isn't found.</remarks>
    public List<MapItem> FindMapItems()
    {
        if (string.IsNullOrEmpty(Bot.Map.MapFilePath))
            return null;

        if (!Directory.Exists(cachePath))
            Directory.CreateDirectory(cachePath);

        if(SavedMapItems is not null && SavedMapItems.ContainsKey(MapFileName))
            return SavedMapItems[MapFileName];
        List<string> files = new();
        files = Directory.GetFiles(cachePath).ToList();
        var sw = Stopwatch.StartNew();
        if (files.Count > 0 && files.Contains(Path.Combine(cachePath, MapFileName)))
            return !DecompileSWF(MapFileName) ? null : ParseMapSWFData();

        return !DownloadMapSWF(MapFileName) ? null : !DecompileSWF(MapFileName) ? null : ParseMapSWFData();

        void SaveMapItemInfo(List<MapItem> info)
        {
            SavedMapItems.Add(MapFileName, info);
            File.WriteAllText(Path.Combine(cachePath, "0SavedMaps.json"), JsonConvert.SerializeObject(SavedMapItems, Formatting.Indented));
        }

        List<MapItem> ParseMapSWFData()
        {
            if (!Directory.Exists($"{cachePath}\\tmp\\scripts\\town_fla"))
                return null;
            sw.Restart();
            List<MapItem> items = new();
            List<string> MainTimelineText = new();
            string[] files = Array.Empty<string>();
            try
            {
                MainTimelineText = File.ReadAllLines($"{cachePath}\\tmp\\scripts\\town_fla\\MainTimeline.as").ToList();
                files = Directory.GetFiles($"{cachePath}\\tmp\\scripts", "*APOP*", SearchOption.TopDirectoryOnly) ?? Array.Empty<string>();
                var mapItemLines = MainTimelineText.Select((l, i) => new Tuple<string, int>(l, i)).Where((l, i) => l.Item1.Contains("mapitem", StringComparison.OrdinalIgnoreCase) || l.Item1.Contains("itemdrop", StringComparison.OrdinalIgnoreCase));
                foreach ((string mapItemLine, int index) in mapItemLines)
                {
                    try
                    {
                        string questID, mapItem;
                        switch (mapItemLine.Contains("getmapitem", StringComparison.OrdinalIgnoreCase))
                        {
                            case true:
                                questID = MainTimelineText.Skip(index - 5).Take(10).Where(l => l.Contains("isquestinprogress", StringComparison.OrdinalIgnoreCase)).First().ToLower().Split("isquestinprogress")[1].Split(')')[0].RemoveLetters() ?? "";
                                mapItem = mapItemLine.RemoveLetters();
                                break;
                            case false:
                                questID = MainTimelineText.Skip(index - 5).Take(10).Where(l => l.Contains("questnum", StringComparison.OrdinalIgnoreCase) || (l.Contains("intquest", StringComparison.OrdinalIgnoreCase) && !l.Contains("intquestval", StringComparison.OrdinalIgnoreCase))).First().Split('=')[1].RemoveLetters() ?? "";
                                mapItem = mapItemLine.Split('=')[1].RemoveLetters();
                                break;
                        }
                        if (!string.IsNullOrEmpty(questID))
                            AddMapItem(int.Parse(mapItem), int.Parse(questID), MapFilePath, LastMap);
                    }
                    catch { }
                }

                List<string> linesToParse = new();
                for (int i = 0; i < files.Length; i++)
                {
                    bool take = false;
                    foreach (string line in File.ReadLines(files[i]).Reverse())
                    {
                        if (!take && !line.Contains("getmapitem", StringComparison.OrdinalIgnoreCase))
                            continue;
                        if (take && line.Contains("isquestinprogress", StringComparison.OrdinalIgnoreCase))
                        {
                            linesToParse.Add(line.Trim().ToLower());
                            take = false;
                            continue;
                        }
                        if (line.Contains("getmapitem", StringComparison.OrdinalIgnoreCase))
                        {
                            linesToParse.Add(line.Trim().ToLower());
                            take = true;
                            continue;
                        }
                    }
                }

                if (linesToParse.Count > 0)
                {
                    foreach ((string mapItem, string questID) in linesToParse.PairUp())
                    {
                        if (mapItem is null || questID is null)
                            continue;
                        AddMapItem(int.Parse(mapItem.RemoveLetters()), int.Parse(questID.Split("isquestinprogress")[1].Split(')')[0].RemoveLetters()), MapFilePath, LastMap);
                    }
                }
                Directory.Delete($"{cachePath}\\tmp\\", true);

                void AddMapItem(int mapitem, int questid, string mapfilepath, string mapname)
                {
                    if (!items.Contains(i => i.MapItemID == mapitem))
                        items.Add(new MapItem(mapitem, questid, mapfilepath, mapname));
                }
            }
            catch (Exception ex)
            {
                if (ex is FileNotFoundException || ex is DirectoryNotFoundException)
                    ControlUtils.ShowErrorMessage("Could not find one or more files to read.", "Get Map Item");
                else if (ex is PathTooLongException)
                    ControlUtils.ShowErrorMessage($"The path for the file is too long.\r\n{cachePath}\\tmp\\scripts\\town_fla\\MainTimeline.as", "Get Map Item");
                else if (ex is UnauthorizedAccessException)
                    ControlUtils.ShowErrorMessage("The program don't have permission to access the file", "Get Map Item");
                else
                    ControlUtils.ShowErrorMessage($"An error ocurred.\r\nMessage: {ex.Message}\r\nStackTrace:{ex.StackTrace}", "Get Map Item");
            }
            if (items.Count > 0)
            {
                items = items.OrderBy(i => i.MapItemID).ToList();
                SaveMapItemInfo(items);
            }
            Debug.WriteLine($"Parsing took {sw.Elapsed:s\\.ff}s");
            return items;
        }

        bool DownloadMapSWF(string fileName)
        {
            sw.Restart();
            Task.Run(async () =>
            {
                byte[] fileBytes = await HttpClients.GitHubClient.GetByteArrayAsync($"https://game.aq.com/game/gamefiles/maps/{Bot.Map.MapFilePath}");
                await File.WriteAllBytesAsync(Path.Combine(cachePath, fileName), fileBytes);
            }).Wait();
            Debug.WriteLine($"Download of \"{fileName}\" took {sw.Elapsed:s\\.ff}s");
            return File.Exists($"{cachePath}\\{fileName}");
        }

        bool DecompileSWF(string fileName)
        {
            sw.Restart();
            var decompile = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardError = true,
                    FileName = "powershell.exe",
                    WorkingDirectory = cachePath,
                    Arguments = $"/c {Path.Combine(Environment.CurrentDirectory, "tools\\ffdec")}\\ffdec.bat -export script \"tmp\" \"{fileName}\""
                }
            };
            decompile.Start();
            string error = decompile.StandardError.ReadToEnd();
            decompile.WaitForExit();
            if (!string.IsNullOrEmpty(error))
                Debug.WriteLine($"Error while decompiling the SWF: {error}");
            else
                Debug.WriteLine($"Decompilation of \"{fileName}\" took {sw.Elapsed:s\\.ff}s");
            return Directory.Exists($"{cachePath}\\tmp");
        }
    }
}
