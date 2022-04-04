namespace RBot.Items;

public class MapItem
{
    public MapItem(int mapitem, int questid, string mapfilepath, string mapname)
    {
        MapItemID = mapitem;
        QuestID = questid;
        MapFilePath = mapfilepath;
    }
    /// <summary>
    /// The path where the map file is.
    /// </summary>
    public string MapFilePath { get; set; } = "None";
    /// <summary>
    /// The map where to get the item.
    /// </summary>
    public string MapName { get; set; } = "None";
    /// <summary>
    /// The ID of the map item.
    /// </summary>
    public int MapItemID { get; set; } = 0;
    /// <summary>
    /// The quest where the map item is required.
    /// </summary>
    public int QuestID { get; set; } = 0;

    public override string ToString()
    {
        return $"Item ID [{MapItemID}], Quest [{QuestID}]";
    }
}
