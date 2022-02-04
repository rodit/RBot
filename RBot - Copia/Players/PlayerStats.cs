using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace RBot.Players
{
    public class PlayerStats
    {
        [JsonProperty("$tha")]
        public float Haste { get; set; }
    }
}
