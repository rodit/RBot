using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RBot.Skills.UseRules
{
    /// <summary>
    /// A base class extended to use a set of rules to determine whether a skill should be used or not.
    /// </summary>
    public class UseRule
    {
        /// <summary>
        /// A rule which always allows the skill to be used.
        /// </summary>
        public static UseRule Always { get; } = new UseRule();

        /// <summary>
        /// Determines whether the skill should be used or not.
        /// </summary>
        /// <param name="bot">The current ScriptInterface instance.</param>
        /// <returns>Whether or not the skill should be used.</returns>
        public virtual bool ShouldUse(ScriptInterface bot)
        {
            return true;
        }

        /// <summary>
        /// Loads this rule from an xml element.
        /// </summary>
        /// <param name="e">The element to load this rule from.</param>
        public virtual void LoadXml(XmlElement e)
        {

        }

        /// <summary>
        /// Saves this rule to an xml writer.
        /// </summary>
        /// <param name="writer">The xml writer to write to.</param>
        public virtual void SaveXml(XmlWriter writer)
        {

        }
    }
}
