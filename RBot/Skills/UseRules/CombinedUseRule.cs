using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Xml;

namespace RBot.Skills.UseRules;

/// <summary>
/// A use rule that combines the result of multiple rules in the specified way.
/// </summary>
[Editor(typeof(CombinedSkillEditor), typeof(UITypeEditor))]
public class CombinedUseRule : UseRule
{
    /// <summary>
    /// The rule used to combine the results of the rule set.
    /// </summary>
    [Description("The logical operator used to combine the results of the rule set.")]
    public CombineRule Rule { get; set; } = CombineRule.And;

    /// <summary>
    /// Determines whether or not the combined result should be notted (inversed).
    /// </summary>
    [Description("Determines whether or not the final combined result should undergo a logical NOT operation (the result is inversed).")]
    public bool Not { get; set; } = false;

    /// <summary>
    /// The set of rules whose results should be combined.
    /// </summary>
    [Browsable(false)]
    public List<UseRule> Rules { get; set; } = new List<UseRule>();

    /// <summary>
    /// This combined use rule.
    /// </summary>
    [Description("Allows you to edit the subrules of this combined rule.")]
    [Editor(typeof(CombinedSkillEditor), typeof(UITypeEditor))]
    public CombinedUseRule This => this;

    /// <summary>
    /// Combines the specified rule to this combined rule set.
    /// </summary>
    /// <param name="rule">The rule to combine with this rule set.</param>
    /// <returns>This instance of CombinedUseRule (so you can chain Combine calls).</returns>
    public CombinedUseRule Combine(UseRule rule)
    {
        Rules.Add(rule);
        return this;
    }

    public override bool ShouldUse(ScriptInterface bot)
    {
        if (Rules.Count == 0)
            return true;
        else
            return Rules.Skip(1).Aggregate(Rules[0].ShouldUse(bot), (r0, r1) => _combiners[Rule](bot, r0, r1));
    }

    public override void LoadXml(XmlElement e)
    {
        base.LoadXml(e);
        if (Enum.TryParse<CombineRule>(e.GetAttribute("rule"), out CombineRule rule))
            Rule = rule;
        Not = bool.TryParse(e.GetAttribute("not"), out bool not) && not;
        XmlNodeList nl = e.GetElementsByTagName("subrule");
        foreach (XmlNode node in nl)
        {
            XmlElement el = (XmlElement)node;
            Type type = Type.GetType(el.GetAttribute("type"));
            UseRule subRule = (UseRule)Activator.CreateInstance(type);
            subRule.LoadXml(el);
            Rules.Add(subRule);
        }
    }

    public override void SaveXml(XmlWriter writer)
    {
        base.SaveXml(writer);
        writer.WriteAttributeString("rule", Rule.ToString());
        writer.WriteAttributeString("not", Not.ToString());
        foreach (UseRule subRule in Rules)
        {
            writer.WriteStartElement("subrule");
            writer.WriteAttributeString("type", subRule.GetType().FullName);
            subRule.SaveXml(writer);
            writer.WriteEndElement();
        }
    }

    private static Dictionary<CombineRule, Func<ScriptInterface, bool, UseRule, bool>> _combiners = new()
    {
        { CombineRule.And, (bot, r0, r1) => r0 && r1.ShouldUse(bot) },
        { CombineRule.Or, (bot, r0, r1) => r0 || r1.ShouldUse(bot) },
        { CombineRule.Xor, (bot, r0, r1) => r0 ^ r1.ShouldUse(bot) }
    };

    /// <summary>
    /// The rules that can be used to combine the results of the rule set.
    /// </summary>
    public enum CombineRule
    {
        /// <summary>
        /// The results of the rules will undergo a logical AND.
        /// </summary>
        And,
        /// <summary>
        /// The results of the rules will undergo a logical OR.
        /// </summary>
        Or,
        /// <summary>
        /// The results of the rules will undergo a logical XOR (exclusive or).
        /// </summary>
        Xor
    }
}
