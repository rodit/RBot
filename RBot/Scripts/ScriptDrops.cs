using RBot.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
namespace RBot
{
    public class ScriptDrops : ScriptableObject
    {
        public static CancellationTokenSource DropsCTS;
        private Thread DropsThread;
        private List<string> _add = new();
        private List<string> _rem = new();

        /// <summary>
		/// The interval, in milliseconds, at which to pickup the desired drops.
		/// </summary>
		public int Interval { get; set; } = 1000;
        /// <summary>
		/// The list of items to pickup every interval.
		/// </summary>
		public List<string> Pickup { get; } = new();
        /// <summary>
		/// Whether or not to reject drops not in the pickup list.
		/// </summary>
		public bool RejectElse { get; set; }
        /// <summary>
		/// Whether or not the drop grabber is enabled.
		/// </summary>
		public bool Enabled => DropsThread?.IsAlive ?? false;

        /// <summary>
		/// Starts the drop grabber.
		/// </summary>
		public void Start()
        {
            if (!DropsThread?.IsAlive ?? true)
            {
                DropsThread = new Thread(() =>
                {
                    DropsCTS = new();
                    Poll(DropsCTS.Token);
                    DropsCTS.Dispose();
                });
                DropsThread.Name = "Drops Thread";
                DropsThread.Start(); 
            }
        }

        /// <summary>
        /// Stops the drop grabber.
        /// </summary>
        public void Stop()
        {
            DropsCTS?.Cancel();
        }

        /// <summary>
		/// Adds the specified item to the list of items to be picked up.
		/// </summary>
		/// <param name="item">The name of the item to add to the pickup list.</param>
		public void Add(params string[] items)
        {
            lock (_add)
                _add.AddRange(items);
        }

        /// <summary>
        /// Clears all drops from the pickup list.
        /// </summary>
        public void Clear()
        {
            lock (_rem)
                _rem.AddRange(Pickup);
        }

        /// <summary>
        /// Removes the specified item from the list of items to be picked up.
        /// </summary>
        /// <param name="item">The name of the item to be removed from the pickup list.</param>
        public void Remove(params string[] items)
        {
            lock (_rem)
                _rem.AddRange(items);
        }

        internal void Poll(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                if (_add.Count > 0)
                {
                    Pickup.AddRange(_add.Where(s => !Pickup.Contains(s)));
                    lock (_add)
                        _add.Clear();
                }
                if (_rem.Count > 0)
                {
                    Pickup.RemoveAll(_rem.Contains);
                    lock (_rem)
                        _rem.Clear();
                }
                if (Pickup.Count > 0)
                {
                    Bot.Player._Pickup(Pickup.ToArray());
                    if (RejectElse)
                        Bot.Player._RejectExcept(Pickup.ToArray());
                }
                if(!token.IsCancellationRequested)
                    Thread.Sleep(Interval);
            }
        }
    }
}
