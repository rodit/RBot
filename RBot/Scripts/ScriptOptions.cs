using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

using PostSharp.Patterns.Model;

using RBot.Servers;
using RBot.Flash;

namespace RBot
{
    public delegate void OptionChangedHandler(string name, object value);

    [NotifyPropertyChanged]
    public class ScriptOptions : ScriptableObject
    {
        private Dictionary<string, Control> _bindings = new Dictionary<string, Control>();
        private Dictionary<string, OptionChangedHandler> _handlers = new Dictionary<string, OptionChangedHandler>();
        private Dictionary<string, bool> _ignore = new Dictionary<string, bool>();

        /// <summary>
		/// A rest packet will be sent every second, causing the player to heal when not in combat.
		/// </summary>
        public bool RestPackets { get; set; }
        /// <summary>
		/// When safe timings are enabled, the bot will wait for any action called to be completed with a timeout of (generally) 5 seconds (i.e. picking a drop) before continuing execution. It is strongly recommended that this is turned on.
		/// </summary>
		/// <remarks>This option does not ensure actions are carried out successfully, as it is quite possible that the 5 second timeout is reached before an action is completed.</remarks>
        public bool SafeTimings { get; set; }
        /// <summary>
		/// The bot will ensure the player is not in combat before attempting to turn in a quest.
		/// </summary>
        public bool ExitCombatBeforeQuest { get; set; }
        /// <summary>
		/// Determines whether cutsenes should be skipped.
		/// </summary>
        [CallBinding("skipCutscenes", UseValue = false, Get = false)]
        public bool SkipCutscenes { get; set; }
        /// <summary>
		/// Determines whether to join only private rooms or not.
		/// </summary>
        public bool PrivateRooms { get; set; }
        /// <summary>
		/// When enabled, this will cause all targeted monsters to teleport to you.
		/// </summary>
        [CallBinding("magnetize", UseValue = false, Get = false)]
        public bool Magnetise { get; set; }
        /// <summary>
		/// Disables drawing the world to (somewhat) reduce lag and CPU usage.
		/// </summary>
		/// <remarks>It is much more effective to minimize the game to reduce CPU usage than to enable this option. For the lowest CPU usage, try both.</remarks>
        [CallBinding("killLag", Get = false)]
        public bool LagKiller { get; set; }
        /// <summary>
		/// Determines whether all monsters in the room should be aggroed (provoked). They will all attack you at the same time.
		/// </summary>
		/// <remarks>Having this option enabled keeps you in combat at all times, sometimes making it impossible to turn in quests.</remarks>
        public bool AggroMonsters { get; set; }
        /// <summary>
		/// Enabling this option allows you to attack targets from any range (without moving).
		/// </summary>
        [CallBinding("infiniteRange", UseValue = false, Get = false)]
        public bool InfiniteRange { get; set; }
        /// <summary>
		/// Disables all player combat animations (improves framerate).
		/// </summary>
        [CallBinding("disableFX", Get = false)]
        public bool DisableFX { get; set; }
        /// <summary>
        /// Enables the auto-relogin feature. If enabled, when the player is logged out of the game, they will automatically be logged back in with the configured username and password, to the configured server.
        /// </summary>
        public bool AutoRelogin { get; set; }
        /// <summary>
		/// Re-logs into any server that wasn't the last one. This ensures the re-log is successful.
		/// </summary>
        public bool AutoReloginAny { get; set; }
        /// <summary>
		/// When enabled, there will be a 1 minute 15 second delay before the player is re-logged in.
		/// </summary>
        public bool SafeRelogin { get; set; }
        /// <summary>
		/// Disables all collisions in the game.
		/// </summary>
        public bool DisableCollisions { get; set; }
        /// <summary>
		/// When enabled, calls to ScriptPlayer#Join will be redirected to ScriptPlayer#JoinGlitched automatically.
		/// </summary>
		public bool GlitchedRooms { get; set; }
        /// <summary>
		/// When enabled, all player avatars are hidden.
		/// </summary>
        [CallBinding("hidePlayers", Get = false)]
        public bool HidePlayers { get; set; }
        /// <summary>
		/// The server to relogin to.
		/// </summary>
		public Server LoginServer { get; set; }

        /// <summary>
		/// The command to run when the current script exits. This will not run if the script is stopped by the user.
		/// </summary>
		/// <remarks>Nothing will be run if this is null.</remarks>
        public string RunOnExit { get; set; }
        /// <summary>
		/// Sets a persistent, custom player name (client side).
		/// </summary>
        [ObjectBinding("world.myAvatar.objData.strUsername", "world.rootClass.ui.mcPortrait.strName.text", "world.myAvatar.pMC.pname.ti.text", Get = false)]
        public string CustomName { get; set; }
        /// <summary>
		/// Sets a persistent, custom guild name (client side).
		/// </summary>
        [ObjectBinding("world.myAvatar.pMC.pname.tg.text", Get = false)]
        public string CustomGuild { get; set; }

        /// <summary>
		/// An option to constantly modify the player's walk speed (the ScriptManager's timer thread will update the ingame value).
		/// </summary>
        [ObjectBinding("world.WALKSPEED", Get = false)]
        public int WalkSpeed { get; set; } = 8;
        /// <summary>
		/// The time in ms that the game is allowed to load before logging the user out (triggering a relogin if enabled).
		/// </summary>
		public int LoadTimeout { get; set; } = 16000;
        /// <summary>
		/// The minimum time between jumping between rooms when hunting for enemies (in milliseconds). The default is 1000ms.
		/// </summary>
		public int HuntDelay { get; set; } = 1000;
        /// <summary>
		/// How many kills hunt should wait for before picking up drops.
		/// </summary>
		public int HuntBuffer { get; set; } = 1;
        /// <summary>
        /// The priority mode for hunting.
        /// </summary>
        public HuntPriorities HuntPriority { get; set; } = HuntPriorities.None;

        /// <summary>
		/// Overrides the haste stat on the client side. This reduces skill cooldowns. This is capped at 0.5 (50%).
		/// </summary>
        [ObjectBinding("world.myAvatar.dataLeaf.sta.$tha", Get = false)]
        public float HasteOverride { get; set; }

        public ScriptOptions()
        {
            ((INotifyPropertyChanged)this).PropertyChanged += ScriptOptions_PropertyChanged;

            BindHandler("DisableCollisions", (n, v) =>
            {
                if ((bool)v)
                {
                    Bot.SetGameObject("world.arrSolid", new object[0]);
                    Bot.SetGameObject("world.arrSolidR", new object[0]);
                }
            });
        }

        private void ScriptOptions_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            object val = GetValue(e.PropertyName);
            if (_bindings.TryGetValue(e.PropertyName, out Control c))
            {
                Action a = () =>
                {
                    if (c is TextBox)
                        (c as TextBox).Text = val.ToString();
                    else if (c is CheckBox)
                        (c as CheckBox).Checked = (bool)val;
                    else if (c is ComboBox)
                        (c as ComboBox).SelectedValue = val;
                    else if (c is NumericUpDown)
                        (c as NumericUpDown).Value = (int)val;
                };
                (c.InvokeRequired ? () => c.Invoke(a) : a)();
            }
            if (_handlers.TryGetValue(e.PropertyName, out OptionChangedHandler h))
                h.Invoke(e.PropertyName, val);
        }

        public object GetValue(string name)
        {
            return typeof(ScriptOptions).GetProperty(name).GetValue(this);
        }

        public void SetValue(string name, object value)
        {
            typeof(ScriptOptions).GetProperty(name).SetValue(this, value);
        }

        public void BindControl(string key, Control control, bool autoSet = true)
        {
            _bindings[key] = control;
            if (autoSet)
            {
                switch (control)
                {
                    case TextBox tb:
                        tb.TextChanged += _GenerateHandler(key, () => tb.Text);
                        break;
                    case CheckBox cb:
                        cb.CheckedChanged += _GenerateHandler(key, () => cb.Checked);
                        break;
                    case ComboBox combo:
                        combo.SelectedValueChanged += _GenerateHandler(key, () => combo.SelectedValue);
                        break;
                    case NumericUpDown num:
                        num.ValueChanged += (s, e) => _GenerateHandler(key, () => (int)num.Value);
                        break;
                }
            }
        }

        private EventHandler _GenerateHandler(string key, Func<object> value)
        {
            return (s, e) =>
            {
                if (_ignore.TryGetValue(key, out bool b) && b)
                    _ignore[key] = false;
                else
                    SetValue(key, value());
            };
        }

        public void BindHandler(string key, OptionChangedHandler handler)
        {
            _handlers[key] = handler;
        }
    }
}
