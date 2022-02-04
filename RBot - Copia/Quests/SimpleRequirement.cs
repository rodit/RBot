using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace RBot.Quests
{
    public class SimpleRequirement
    {
        [JsonProperty("ItemID")]
        public int ID { get; set; }
        [JsonProperty("iQty")]
        public int Quantity { get; set; }
    }
}
