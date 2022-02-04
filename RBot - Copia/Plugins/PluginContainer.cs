using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using RBot.Options;

namespace RBot.Plugins
{
    public class PluginContainer
    {
        /// <summary>
        /// A container managing this plugin's options.
        /// </summary>
        public OptionContainer Options = new();
        /// <summary>
        /// This container's plugin.
        /// </summary>
        public RPlugin Plugin { get; private set; }
        /// <summary>
        /// The file at which the plugin's options are saved.
        /// </summary>
        public string OptionsFile => Path.Combine("plugins", "options", this.Plugin.OptionsStorage + ".cfg");

        public PluginContainer(RPlugin plugin)
        {
            Plugin = plugin;
            Options.Options.AddRange(plugin.Options);
            Options.OptionsFile = OptionsFile;
        }

        public override string ToString()
        {
            return Plugin.Name;
        }
    }
}
