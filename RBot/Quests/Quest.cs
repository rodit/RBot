using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using RBot.Converters;
using RBot.Items;

namespace RBot.Quests
{
    public class Quest
    {
        /// <summary>
        /// The ID of the quest.
        /// </summary>
        [JsonProperty("QuestID")]
        public int ID { get; set; }
        /// <summary>
        /// The slot of the quest.
        /// </summary>
        [JsonProperty("iSlot")]
        public int Slot { get; set; }
        /// <summary>
        /// The name of the quest.
        /// </summary>
        [JsonProperty("sName")]
        public string Name { get; set; }
        /// <summary>
        /// The description of the quest.
        /// </summary>
        [JsonProperty("sDesc")]
        public string Description { get; set; }
        /// <summary>
        /// The description of the quest after completion.
        /// </summary>
        [JsonProperty("sEndText")]
        public string EndText { get; set; }
        /// <summary>
        /// Whether this quest can only be completed once/
        /// </summary>
        [JsonProperty("bOnce")]
        [JsonConverter(typeof(StringBoolConverter))]
        public bool Once { get; set; }
        /// <summary>
        /// The field of the quest.
        /// </summary>
        [JsonProperty("sField")]
        public string Field { get; set; }
        /// <summary>
        /// The index of the quest.
        /// </summary>
        [JsonProperty("iIndex")]
        public int Index { get; set; }
        /// <summary>
        /// The amount of gold this quest gives as a reward.
        /// </summary>
        [JsonProperty("iGold")]
        public int Gold { get; set; }
        /// <summary>
        /// The amount of XP this quest gives as a reward.
        /// </summary>
        [JsonProperty("iExp")]
        public int XP { get; set; }
        /// <summary>
        /// The status of the quest.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
        /// <summary>
        /// Indicates whether the quest is active or not.
        /// </summary>
        public bool Active => Status != null;
        /// <summary>
        /// The items required in the player's inventory to accept the quest.
        /// </summary>
        [JsonProperty("oReqd")]
        [JsonConverter(typeof(DictionaryListConverter<int, ItemBase>))]
        public List<ItemBase> AcceptRequirements { get; set; }
        /// <summary>
        /// The items used to turn in the quest.
        /// </summary>
        [JsonProperty("oItems")]
        [JsonConverter(typeof(DictionaryListConverter<int, QuestReqItem>))]
        public List<QuestReqItem> Requirements { get; set; }
        /// <summary>
        /// The items given as a reward for completing the quest.
        /// </summary>
        [JsonProperty("oRewards")]
        [JsonConverter(typeof(QuestRewardConverter))]
        public List<ItemBase> Rewards { get; set; }
        /// <summary>
        /// Item drop rates are mapped to their IDs in this list.
        /// </summary>
        [JsonProperty("reward")]
        public List<SimpleReward> SimpleRewards { get; set; }

        public override string ToString()
        {
            return $"{Name} [{ID}]";
        }
    }
}
