using System.IO;
using RBot.Options;

namespace RBot;

public class ScriptOptionContainer : OptionContainer
{
    /// <summary>
    /// The name of the file used to store this scripts options. This should be unique to your script to prevent option name clashes.
    /// </summary>
    /// <remarks>Transient options are reset when the script is restarted (including auto-relogins).</remarks>
    public string Storage { get; set; } = "default";

    public override string OptionsFile => Path.Combine("options", Storage + ".cfg");

    /// <summary>
    /// Opens the script option window and waits for the user to save the options.
    /// </summary>
    public void Configure()
    {
        SetDefaults();
        Load();
        using GenericOptionsForm gof = new() { Container = this };
        gof.ShowDialog();
    }
}
