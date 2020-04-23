using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RBot.Skills.UseRules
{
    /// <summary>
	/// A rule which bases whether or not the skill should be used on the player's current mana.
	/// </summary>
	public class ManaUseRule : UseRule
    {
        /// <summary>
        /// The minimum mana (as a ratio of current to max, from 0 to 1) at which the skill can be used.
        /// </summary>
        [Description("The minimum mana at which the skill can be used. This is a value between 0 and 1.")]
        public float MinMana { get; set; }

        /// <summary>
        /// The maximum mana (as a ratio of current to max, from 0 to 1) at which the skill can be used.
        /// </summary>
        [Description("The maximum mana at which the skill can be used. This is a value between 0 and 1.")]
        public float MaxMana { get; set; }

        public ManaUseRule() : this(0f, 1f)
        {
        }

        public ManaUseRule(float min, float max)
        {
            MinMana = min;
            MaxMana = max;
        }

        public override bool ShouldUse(ScriptInterface bot)
        {
            float ratio = bot.Player.Mana / bot.Player.MaxMana;
            return ratio >= MinMana && ratio <= MaxMana;
        }

        public override void LoadXml(XmlElement e)
        {
            base.LoadXml(e);
            if (float.TryParse(e.GetAttribute("min"), out float min))
                MinMana = min;
            if (float.TryParse(e.GetAttribute("max"), out float max))
                MaxMana = max;
        }

        public override void SaveXml(XmlWriter writer)
        {
            base.SaveXml(writer);
            writer.WriteAttributeString("min", MinMana.ToString());
            writer.WriteAttributeString("max", MaxMana.ToString());
        }
    }
}
