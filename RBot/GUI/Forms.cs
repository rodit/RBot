using RBot.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot;

public class Forms
{
    public static MainForm Main { get; set; }
    public static ScriptsForm Scripts { get; set; } = new ScriptsForm();
    public static OptionsForm Options { get; set; } = new OptionsForm();
    public static AutoReloginForm AutoRelogin { get; set; } = new AutoReloginForm();
    public static LogForm Log { get; set; } = new LogForm();
    public static ConsoleForm Console { get; set; } = new ConsoleForm();
    public static SkillsForm Skills { get; set; } = new SkillsForm();
    public static AdvancedSkillForm AdvancedSkills { get; set; } = new AdvancedSkillForm();
    public static PacketSpammerForm PacketSpammer { get; set; } = new PacketSpammerForm();
    public static PacketLoggerForm PacketLogger { get; set; } = new PacketLoggerForm();
    public static PacketInterceptorForm PacketInterceptor { get; set; } = new PacketInterceptorForm();
    public static LoadersForm Loaders { get; set; } = new LoadersForm();
    public static JumpForm Jump { get; set; } = new JumpForm();
    public static AS3InjectorForm Injector { get; set; } = new AS3InjectorForm();
    public static AboutForm About { get; set; } = new AboutForm();
    public static UpdatesForm Updates { get; set; } = new UpdatesForm();
    public static PluginsForm Plugins { get; set; } = new PluginsForm();
    public static ScriptReposForm Repos { get; set; } = new ScriptReposForm();
    public static StatsForm Stats { get; set; } = new StatsForm();
    public static CosmeticForm Cosmetics { get; set; } = new CosmeticForm();
    public static GameIDForm IDForm { get; set; } = new GameIDForm();
}
