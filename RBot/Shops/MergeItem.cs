using System.Collections.Generic;
using Newtonsoft.Json;
using RBot.Items;

namespace RBot.Shops;

public class MergeItem : ShopItem
{
    [JsonProperty("turnin")]
    public List<ItemBase> Requirements { get; set; }
}
