namespace RBot.Skills.UseRules;

/// <summary>
/// A class which can be used to define custom use rules by writing a custom method.
/// </summary>
public class CustomUseRule : UseRule
{
    /// <summary>
    /// The method delegate used to check if the skill should be used or not.
    /// </summary>
    public CustomCheckDelegate CustomCheck { get; set; }

    public override bool ShouldUse(ScriptInterface bot)
    {
        return CustomCheck?.Invoke(bot) ?? base.ShouldUse(bot);
    }

    public delegate bool CustomCheckDelegate(ScriptInterface bot);
}
