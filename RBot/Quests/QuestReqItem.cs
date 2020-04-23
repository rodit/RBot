using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using RBot.Items;

namespace RBot.Quests
{
    public class QuestReqItem : ItemBase
    {
        /// <summary>
        /// The quantity of this item required to turn in the quest.
        /// </summary>
        [JsonProperty("iStk")]
        public override int Quantity { get; set; }
    }
}
