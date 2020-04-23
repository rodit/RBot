using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Newtonsoft.Json;

using RBot.Flash;
using RBot.Servers;
using RBot.Utils;
using RBot.GameProxy;

namespace RBot
{
    public class ScriptInterface
    {
        private static ScriptInterface _instance;
        public static ScriptInterface Instance => _instance ?? (_instance = new ScriptInterface());

        public ScriptOptions Options { get; set; }
        public ScriptWait Wait { get; set; }
        public ScriptPlayer Player { get; set; }
        public ScriptMonsters Monsters { get; set; }
        public ScriptInventory Inventory { get; set; }
        public ScriptBank Bank { get; set; }
        public ScriptMap Map { get; set; }
        public ScriptQuests Quests { get; set; }
        public ScriptShops Shops { get; set; }
        public ScriptRuntimeVars Runtime { get; set; }
        public ScriptBotStats Stats { get; set; }
        public ScriptEvents Events { get; set; }
        public ScriptOptionContainer Config { get; set; }

        public CaptureProxy GameProxy { get; } = new CaptureProxy();

        public bool IsWorldLoaded => !IsNull("world");

        public static bool exit;

        private volatile bool _appExit;
        private volatile bool _waitForLogin;
        private Thread _timerThread;

        public ScriptInterface()
        {
            Options = new ScriptOptions();
            Wait = new ScriptWait();
            Player = new ScriptPlayer();
            Monsters = new ScriptMonsters();
            Inventory = new ScriptInventory();
            Bank = new ScriptBank();
            Map = new ScriptMap();
            Quests = new ScriptQuests();
            Shops = new ScriptShops();
            Runtime = new ScriptRuntimeVars();
            Stats = new ScriptBotStats();
            Events = new ScriptEvents();
            Config = new ScriptOptionContainer();

            _timerThread = new Thread(_TimerThread);
        }

        /// <summary>
        /// Initializes the ScriptInterface instance and its timer thread.
        /// </summary>
        public void Init()
        {
            _timerThread.Start();
        }

        /// <summary>
        /// Prepares for the application to close.
        /// </summary>
        public void Exit()
        {
            exit = true;
            _appExit = true;
            _timerThread.Abort();
            ScriptManager.CurrentScriptThread?.Abort();
        }

        /// <summary>
        /// Returns a value determining whether or not the current script should exit.
        /// </summary>
        /// <returns>Whether the current script should exit.</returns>
        public bool ShouldExit()
        {
            return exit;
        }

        /// <summary>
		/// Schedules the specified action to run after the specified delay in ms. This is done using C# async tasks.
		/// </summary>
		/// <param name="delay">The time to delay the action for in milliseconds.</param>
		/// <param name="action">The action to run. This can be passed as a lambda expression.</param>
        public Task Schedule(int delay, Func<ScriptInterface, Task> action)
        {
            return Task.Delay(delay).ContinueWith(t => action(this));
        }

        /// <summary>
		/// Logs a line of text to the debug log.
		/// </summary>
		/// <param name="text"></param>
		public void Log(string text)
        {
            Forms.Log.AppendScript(text + "\r\n");
        }

        /// <summary>
		/// Sleeps the bot for the specified time period. This method sleeps the script execution thread.
		/// </summary>
		/// <param name="ms">The time in milliseconds for the bot to sleep.</param>
        public void Sleep(int ms)
        {
            Thread.Sleep(ms);
        }

        /// <summary>
		/// Sends the specified packet to the server.
		/// </summary>
		/// <param name="packet">The packet to be sent.</param>
		/// <param name="type">The type of the packet being sent (String, Json). The default is string.</param>
		/// <remarks>Be careful when using this method. Incorrect use of this method may cause you to be kicked (or banned, although very unlikely).</remarks>
		public void SendPacket(string packet, string type = "String")
        {
            CallGameFunction("sfc.send" + type, packet);
        }

        /// <summary>
        /// Sends the specified packet to the client (simulates a response as if the server sent the packet).
        /// </summary>
        /// <param name="packet">The packet to send.</param>
        /// <param name="type">The type of the packet. This can be xml, json or str.</param>
        public void SendClientPacket(string packet, string type = "str")
        {
            FlashUtil.Call("sendClientPacket", packet, type);
        }

        /// <summary>
        /// Checks if the actionscript object at the given path is null.
        /// </summary>
        /// <param name="path">The path of the object to check.</param>
        /// <returns>True if the object at the given path is null (unset).</returns>
        public bool IsNull(string path)
        {
            return FlashUtil.Call<bool>("isNull", path);
        }

        /// <summary>
        /// Gets an actionscript object at the given location as a JSON string.
        /// </summary>
        /// <param name="path">The path of the object to get.</param>
        /// <returns>The value of the object at the given path as a serialzied JSON string.</returns>
        public string GetGameObject(string path)
        {
            return FlashUtil.Call("getGameObject", path);
        }

        /// <summary>
        /// Gets an actionscript object at the given location and deserializes it as JSON to the given type.
        /// </summary>
        /// <typeparam name="T">The type to deserialize the object to.</typeparam>
        /// <param name="path">The path of the object to get (i.e. world.myAvatar.sta.$tha will get your haste stat).</param>
        /// <param name="def">The default value to return if the call/deserialization fails.</param>
        /// <returns>The deserialized value of the object at the given path.</returns>
        public T GetGameObject<T>(string path, T def = default)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(GetGameObject(path));
            }
            catch
            {
                return def;
            }
        }

        /// <summary>
        /// Gets a static actionscript object at the given location as a JSON string.
        /// </summary>
        /// <param name="path">The path of the object to get.</param>
        /// <returns>The value of the object at the given path as a serialzied JSON string.</returns>
        public string GetGameObjectStatic(string path)
        {
            return FlashUtil.Call("getGameObjectS", path);
        }

        /// <summary>
        /// Gets a static actionscript object at the given location and deserializes it as JSON to the given type.
        /// </summary>
        /// <typeparam name="T">The type to deserialize the object to.</typeparam>
        /// <param name="path">The path of the object to get.</param>
        /// <param name="def">The default value to return if the call/deserialization fails.</param>
        /// <returns>The deserialized value of the object at the given path.</returns>
        public T GetGameObjectStatic<T>(string path, T def = default)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(GetGameObjectStatic(path));
            }
            catch
            {
                return def;
            }
        }

        /// <summary>
        /// Sets the value of the actionscript object at the given path.
        /// </summary>
        /// <param name="path">The path of the object to set.</param>
        /// <param name="value">The value to set the object to. This can be a string, any number type or a bool.</param>
        public void SetGameObject(string path, object value)
        {
            FlashUtil.Call("setGameObject", path, value);
        }

        /// <summary>
        /// Calls the actionscript object with the given name at the given location.
        /// </summary>
        /// <param name="path">The path to the object and its function name.</param>
        /// <param name="args">The arguments to pass to the function.</param>
        /// <returns>The value of the object returned by calling the function as a serialzied JSON string.</returns>
        public string CallGameFunction(string path, params object[] args)
        {
            return args.Length > 0 ? FlashUtil.Call("callGameFunction", new object[] { path }.Concat(args).ToArray()) : FlashUtil.Call("callGameFunction0", path);
        }

        /// <summary>
        /// Calls the actionscript object with the given name at the given location.
        /// </summary>
        /// <typeparam name="T">The type to deserialize the return of the function as.</typeparam>
        /// <param name="path">The path to the object and its function name.</param>
        /// <param name="args">The arguments to pass to the function.</param>
        /// <returns>The deserialized value of the object returned by the function.</returns>
        public T CallGameFunction<T>(string path, params object[] args)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(CallGameFunction(path, args));
            }
            catch
            {
                return default;
            }
        }

        /// <summary>
        /// Gets the actionscript object of the array at the given path at the given index in that array.
        /// </summary>
        /// <param name="path">The path to the array.</param>
        /// <param name="index">The index in the array to get the object from.</param>
        /// <returns>The value of the object at the given index in the array as a serialzied JSON string.</returns>
        public string GetArrayObject(string path, int index)
        {
            return FlashUtil.Call("getArrayObject", path, index);
        }

        /// <summary>
        /// Gets the actionscript object of the array at the given path at the given index in that array.
        /// </summary>
        /// <typeparam name="T">The type to deserialize the object in the array as.</typeparam>
        /// <param name="path">The path to the array.</param>
        /// <param name="index">The index in the array to get the object from.</param>
        /// <param name="def">The default value to return if the call/deserialization fails.</param>
        /// <returns>The deserialized value of the object at the given index in the array.</returns>
        public T GetArrayObject<T>(string path, int index, T def = default)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(GetArrayObject(path, index));
            }
            catch
            {
                return def;
            }
        }

        /// <summary>
        /// Selects the members of each object in the array at the given path and puts them into a new array and returns them.
        /// </summary>
        /// <typeparam name="T">The type of object to deserialize the contents of the array as.</typeparam>
        /// <param name="path">The path to the array.</param>
        /// <param name="selector">The name of the field to use to populate the new array.</param>
        /// <returns>A list of deserialized objects from the selected array.</returns>
        public List<T> SelectArrayObjects<T>(string path, string selector)
        {
            try
            {
                return JsonConvert.DeserializeObject<List<T>>(FlashUtil.Call("selectArrayObjects", path, selector));
            }
            catch
            {
                return new List<T>();
            }
        }

        private TimeLimiter _limit = new TimeLimiter();
        private const int _timerDelay = 20;
        private void _TimerThread()
        {
            int accum = 0;

            bool hasLoggedIn = false;
            bool catching = false;

            string lastConnDetail = "";

            while (!_appExit)
            {
                try
                {
                    if (IsWorldLoaded && Player.Playing)
                    {
                        hasLoggedIn = true;
                        ServerList.LastServer = Player.ServerName ?? ServerList.LastServer;

                        if (Options.RestPackets && !Player.InCombat && (Player.Health < Player.MaxHealth || Player.Mana < Player.MaxMana))
                            _limit.LimitedRun("rest", 1000, () => SendPacket("%xt%zm%restRequest%1%%"));

                        if (!catching)
                        {
                            FlashUtil.Call("catchPackets");
                            catching = true;
                        }

                        //TODO: afk event from packets
                        //TODO: death event from packets
                        //TODO: cell change from packets
                        _limit.LimitedRun("opts", 300, () =>
                        {
                            if (Options.Magnetise)
                                FlashUtil.Call("magnetise");
                            if (Options.InfiniteRange)
                                FlashUtil.Call("infiniteRange");
                            if (Options.AggroMonsters)
                                CallGameFunction("world.aggroAllMon");
                            if (Options.SkipCutscenes)
                                FlashUtil.Call("skipCutscenes");
                            if (Options.LagKiller)
                                FlashUtil.Call("killLag", true);
                            if (Options.DisableFX)
                                FlashUtil.Call("disableFX", true);
                            Player.WalkSpeed = Options.WalkSpeed;

                        //TODO: Drops handler
                    });
                    }
                    else if (Options.AutoRelogin && !Player.LoggedIn && hasLoggedIn && !_waitForLogin)
                    {
                        Log("Autorelogin triggered.");
                        if (_reloginTask != null)
                        {
                            Log("Relogin task already running.");
                            _waitForLogin = true;
                            continue;
                        }

                        bool wasRunning = ScriptManager.ScriptRunning;
                        ScriptManager.StopScript();

                        bool kicked = Player.Kicked;

                        _waitForLogin = true;
                        Player.Logout();
                        Events.OnReloginTriggered(kicked);

                        _Relogin(Options.AutoReloginAny || (!Options.SafeRelogin && !kicked) ? 5000 : 70000, wasRunning);
                    }
                    //TODO: conn detail disconnect

                    Thread.Sleep(_timerDelay);
                }
                catch(Exception e)
                {
                    Debug.WriteLine("Error in timer thread: " + e.Message);
                }
            }
        }

        private Task _reloginTask;
        private void _Relogin(int delay, bool startScript)
        {
            Log("Waiting " + delay + "ms for relogin.");
            _reloginTask = Schedule(delay, async _ =>
            {
                Runtime.BankLoaded = false;
                Stats.Relogins++;
                Server server = Options.AutoReloginAny ? ServerList.Servers.Find(x => x.Name != ServerList.LastServer) : Options.LoginServer ?? ServerList.Servers[0];
                Player.Login(Player.Username, Player.Password);
                Player.Connect(server);

                while (_waitForLogin && (!Player.Playing || !IsWorldLoaded))
                    await Task.Delay(1000);
                _waitForLogin = false;

                if (startScript)
                    ScriptManager.StartScript();
                Log("Relogin complete.");
                _reloginTask = null;
            });
        }
    }
}
