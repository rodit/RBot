using Newtonsoft.Json;
using RBot.Items;

namespace RBot.Shops;

public class ShopItem : ItemBase
{
    /// <summary>
    /// The shop specific item id of this item.
    /// </summary>
    [JsonProperty("ShopItemID")]
    public int ShopItemID { get; set; }
    /// <summary>
    /// The cost of the item.
    /// </summary>
    [JsonProperty("iCost")]
    public int Cost { get; set; }
    /// <summary>
    /// The level of the shop item.
    /// </summary>
    [JsonProperty("iLvl")]
    public int Level { get; set; }
}
