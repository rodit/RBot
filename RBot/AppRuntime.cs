﻿using RBot.Options;
using RBot.Repos;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RBot;

public static class AppRuntime
{
    public static OptionContainer Options { get; set; } = new OptionContainer()
    {
        OptionsFile = "rbot.cfg",
    };

    public static void Init()
    {
        Options.Options.AddRange(new List<IOption>()
        {
            new Option<bool>("proxy.enabled", "Proxy Enabled", "Enables the proxy used to load and patch the game's SWF files. This can cause loading/login issues."),
            new Option<int>("proxy.port", "Proxy Port", "The port that the patch proxy will bind to. Port 0 finds an available port."),
            new Option<bool>("proxy.cache.disable", "Disable Cache", "Disables caching of network responses when using the proxy.", true),
            new Option<bool>("updates.check", "Check for Updates", "When enabled, RBot will check for updates and notify you of new versions on launch.", true),
            new Option<bool>("updates.beta", "Check for Prereleases", "Update checks will also check for prerelease versions."),
            new Option<bool>("updates.scripts", "Check for Script updates", "When enabled, RBot will check for script updates and notify you of new changes on launch.", true),
            new Option<bool>("updates.autodownloadscripts", "Download Scripts on launch", "When enabled, RBot will download new/updated scripts on launch.", true),
            new Option<string>("relogin.server", "Relogin Server", "The server which the bot will try to re-login to when needed.\r\nNote that this option has priority over any other setting for auto-relogin.", ""),

            new Option<int>("binding.start", "", "", (int)Keys.F10),
            new Option<int>("binding.stop", "", "", (int)Keys.F11),
            new Option<int>("binding.toggle", "", "", (int)Keys.F12),
            new Option<int>("binding.load", "", "", (int)Keys.F9),
            new Option<int>("binding.bank", "", "", (int)Keys.F2),
            new Option<int>("binding.console", "", "", (int)Keys.F3),
            new Option<int>("binding.attack", "", "", (int)Keys.F5),
            new Option<int>("binding.hunt", "", "", (int)Keys.F6),
            new Option<string>("travel", "", "", ""),

            new Option<bool>("ignoregh", "Ignore GH Authentication", "Ignores the check for an GitHub account authentication. Not authenticating limits the Get Scripts function.", false),
            new Option<string>("ghtoken", "","",""),

            new Option<string>("client.swf", "Client SWF", "The SWF file to be loaded as the game client.", ""),
        });

        Options.SetDefaults();
        Options.Load();
        Options.Save();
    }
}
