using Newtonsoft.Json;
using RBot.Converters;

namespace RBot.Items;

public class InventoryItem : ItemBase
{
    /// <summary>
    /// The character (instance) ID of this item.
    /// </summary>
    [JsonProperty("CharItemID")]
    public int CharItemID { get; set; }
    /// <summary>
    /// Indicates if the item is equipped.
    /// </summary>
    [JsonProperty("bEquip")]
    [JsonConverter(typeof(StringBoolConverter))]
    public bool Equipped { get; set; }
    /// <summary>
    /// The meta value of the item. This is used to link buffs (xp boosts etc).
    /// </summary>
    [JsonProperty("sMeta")]
    public string Meta { get; set; }
    /// <summary>
    /// The level of the item.
    /// </summary>
    [JsonProperty("iLvl")]
    public int Level { get; set; }
    /// <summary>
    /// The enhancement level of the item.
    /// </summary>
    [JsonProperty("EnhLvl")]
    public virtual int EnhancementLevel { get; set; }
}
