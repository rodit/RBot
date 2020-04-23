using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RBot.Options;

namespace RBot.Plugins
{
    /// <summary>
	/// An interface defining an RBot plugin.
	/// </summary>
	public abstract class RPlugin
    {
        /// <summary>
        /// The current instance of the bot.
        /// </summary>
        public ScriptInterface Bot
        {
            get
            {
                return ScriptInterface.Instance;
            }
        }
        /// <summary>
        /// The plugin's container. This is useful for getting options.
        /// </summary>
        public PluginContainer Container
        {
            get
            {
                return PluginManager.GetContainer(this);
            }
        }
        /// <summary>
        /// The name of the plugin.
        /// </summary>
        public abstract string Name { get; }
        /// <summary>
        /// The author of the plugin.
        /// </summary>
        public abstract string Author { get; }
        /// <summary>
        /// The description of the plugin.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// Called when the plugin is loaded.
        /// </summary>
        public abstract void Load();

        /// <summary>
        /// Called when the plugin is unloaded.
        /// </summary>
        public abstract void Unload();

        /// <summary>
        /// A list of options this plugin uses. This is only queried once, before Load is called.
        /// </summary>
        public abstract List<IOption> Options { get; }

        /// <summary>
        /// Indicates what file name the options of this plugin should be stored under. This needs to be unique to your plugin.
        /// </summary>
        public virtual string OptionsStorage => (Author + "_" + Name).Replace(' ', '_').Trim();
    }
}
