using System.ComponentModel;
using System.Xml;

namespace RBot.Skills.UseRules;

/// <summary>
/// A rule which bases whether or not the skill should be used on the player's current health.
/// </summary>
public class HealthUseRule : UseRule
{
    /// <summary>
    /// The minimum health (as a ratio of current to max, from 0 to 1) at which the skill can be used.
    /// </summary>
    [Description("The minimum health at which the skill can be used. This is a value between 0 and 1.")]
    public float MinHealth { get; set; }

    /// <summary>
    /// The maximum health (as a ratio of current to max, from 0 to 1) at which the skill can be used.
    /// </summary>
    [Description("The maximum health at which the skill can be used. This is a value between 0 and 1.")]
    public float MaxHealth { get; set; }

    public HealthUseRule() : this(0f, 1f)
    {
    }

    public HealthUseRule(float min, float max)
    {
        MinHealth = min;
        MaxHealth = max;
    }

    public override bool ShouldUse(ScriptInterface bot)
    {
        float ratio = bot.Player.Health / bot.Player.MaxHealth;
        return ratio >= MinHealth && ratio <= MaxHealth;
    }

    public override void LoadXml(XmlElement e)
    {
        base.LoadXml(e);
        if (float.TryParse(e.GetAttribute("min"), out float min))
            MinHealth = min;
        if (float.TryParse(e.GetAttribute("max"), out float max))
            MaxHealth = max;
    }

    public override void SaveXml(XmlWriter writer)
    {
        base.SaveXml(writer);
        writer.WriteAttributeString("min", MinHealth.ToString());
        writer.WriteAttributeString("max", MaxHealth.ToString());
    }
}
