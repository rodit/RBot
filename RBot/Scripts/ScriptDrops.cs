using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot
{
    public class ScriptDrops : ScriptableObject
    {
        private List<string> _add = new List<string>();
        private List<string> _rem = new List<string>();

        /// <summary>
		/// The interval, in milliseconds, at which to pickup the desired drops.
		/// </summary>
		public int Interval { get; set; } = 1000;
        /// <summary>
		/// The list of items to pickup every interval.
		/// </summary>
		public List<string> Pickup { get; } = new List<string>();
        /// <summary>
		/// Whether or not to reject drops not in the pickup list.
		/// </summary>
		public bool RejectElse { get; set; }
        /// <summary>
		/// Whether or not the drop grabber is enabled.
		/// </summary>
		public bool Enabled { get; set; }

        /// <summary>
		/// Starts the drop grabber.
		/// </summary>
		public void Start()
        {
            Enabled = true;
        }

        /// <summary>
        /// Stops the drop grabber.
        /// </summary>
        public void Stop()
        {
            Enabled = false;
        }

        /// <summary>
		/// Adds the specified item to the list of items to be picked up.
		/// </summary>
		/// <param name="item">The name of the item to add to the pickup list.</param>
		public void Add(string item)
        {
            lock (_add)
                _add.Add(item);
        }

        /// <summary>
        /// Removes the specified item from the list of items to be picked up.
        /// </summary>
        /// <param name="item">The name of the item to be removed from the pickup list.</param>
        public void Remove(string item)
        {
            lock (_rem)
                _rem.Add(item);
        }

        internal void Poll()
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
        }

        internal void Update()
        {
            if (Pickup.Count > 0)
            {
                Bot.Player.Pickup(Pickup.ToArray());
                if (RejectElse)
                    Bot.Player.RejectExcept(Pickup.ToArray());
            }
        }
    }
}
