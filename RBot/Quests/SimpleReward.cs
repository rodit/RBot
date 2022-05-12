using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using RBot.Items;

namespace RBot.Quests;

public class SimpleReward : ItemBase
{
    /// <summary>
    /// The rate at which this reward drops.
    /// </summary>
    [JsonProperty("iRate")]
    public double Rate { get; set; }
    /// <summary>
    /// The type of the item as an integer ID.
    /// </summary>
    [JsonProperty("iType")]
    public int Type { get; set; }
}
