using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using RBot.Items;

namespace RBot.Shops
{
    public class MergeItem : ShopItem
    {
        [JsonProperty("turnin")]
        public List<ItemBase> Requirements { get; set; }
    }
}
