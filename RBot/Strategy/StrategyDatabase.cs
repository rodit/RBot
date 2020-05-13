using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using RBot.Shops;
using RBot.Quests;
using RBot.Items;

namespace RBot.Strategy
{
    public class StrategyDatabase : ScriptableObject
    {
        /// <summary>
        /// A dictionary mapping room names to custom navigators. Navigators offer a way of transferring a player to a given room.
        /// An example of when to use a custom navigator would be for joining tercessuinotlim as this requires first joining citadel.
        /// </summary>
        public Dictionary<string, INavigator> Navigators { get; } = new Dictionary<string, INavigator>();
        /// <summary>
        /// The list of registered item strategies in the database.
        /// </summary>
        public List<ItemStrategy> ItemStrategies { get; } = new List<ItemStrategy>();

        private Dictionary<int, List<ShopItem>> _shops = new Dictionary<int, List<ShopItem>>();
        private Dictionary<int, List<MergeItem>> _merges = new Dictionary<int, List<MergeItem>>();
        private Dictionary<int, Quest> _quests = new Dictionary<int, Quest>();

        /// <summary>
        /// A list of drops which is built when AggregateDrops is called. Items in this list are picked up during all strategies' execution.
        /// </summary>
        public List<string> DropAggregate { get; } = new List<string>();

        /// <summary>
        /// Gets the navigator to be used to transfer the player to the given map.
        /// </summary>
        /// <param name="map">The name of the map.</param>
        /// <returns>A navigator which has a Navigate method.  If no custom navigator is defined, a default navigator which makes a call to ScriptPlayer#Join is returned.</returns>
        public INavigator GetNavigator(string map)
        {
            return Navigators.TryGetValue(map, out INavigator nav) ? nav : new DefaultNavigator(map);
        }

        /// <summary>
        /// Gets the strategy to obtain the given item with the highest priority.
        /// </summary>
        /// <param name="item">The name of the item to find a strategy for.</param>
        /// <returns>The strategy which can be used to obtain the given item. If no such strategy exists, null is returned.</returns>
        public ItemStrategy GetStrategy(string item)
        {
            return ItemStrategies.FindAll(x => x.Item.Equals(item, StringComparison.OrdinalIgnoreCase)).OrderByDescending(x => x.Preference).FirstOrDefault();
        }

        /// <summary>
        /// Adds the given strategy to the database.
        /// </summary>
        /// <param name="strat">The strategy to add.</param>
        public void Register(ItemStrategy strat)
        {
            ItemStrategies.Add(strat);
        }

        /// <summary>
        /// Loads shop with the given id and registers a BuyItemStrategy for every item in the shop.
        /// </summary>
        /// <param name="id">The id of the shop to create BuyItemStrategy objects for.</param>
        /// <param name="map">The map the player needs to be in to load the shop (prevents disconnects). If this is null, the player will not join a map before loading the shop.</param>
        public void RegisterShop(int id, string map = null)
        {
            if (!_shops.ContainsKey(id))
            {
                if (map != null)
                    Bot.Player.Join(map);
                Bot.Shops.Load(id);
                _shops[id] = Bot.Shops.ShopItems;
                foreach (ShopItem item in _shops[id])
                {
                    Register(new BuyItemStrategy()
                    {
                        ShopID = id,
                        Item = item.Name,
                        Map = map
                    });
                }
            }
        }

        /// <summary>
        /// Loads the given merge shop and registers a MergeItemStrategy for every item in the shop.
        /// </summary>
        /// <param name="id">The id of the shop to create MergeItemStrategy objects for.</param>
        /// <param name="map">The map the player needs to be in to load the shop (prevents disconnects). If this is null, the player will not join a map before loading the shop.</param>
        public void RegisterMerge(int id, string map = null)
        {
            if (!_merges.ContainsKey(id))
            {
                if (map != null)
                    Bot.Player.Join(map);
                Bot.Shops.Load(id);
                _merges[id] = Bot.Shops.MergeItems;
                foreach (MergeItem item in _merges[id])
                {
                    Register(new MergeItemStrategy()
                    {
                        ShopID = id,
                        Item = item.Name,
                        Map = map
                    });
                }
            }
        }

        /// <summary>
        /// Loads the given quest and registers a QuestStrategy for each reward of the quest.
        /// </summary>
        /// <param name="id">The id of the quest to register.</param>
        public void RegisterQuest(int id)
        {
            if (!_quests.ContainsKey(id))
            {
                Quest q = Bot.Quests.EnsureLoad(id);
                _quests[id] = q;
                foreach (ItemBase reward in q.Rewards)
                {
                    Register(new QuestStrategy()
                    {
                        QuestID = id,
                        Item = reward.Name
                    });
                }
            }
        }

        /// <summary>
        /// Registers a DropStrategy with the given parameters.
        /// </summary>
        /// <param name="map">The name of the map where the monster exists.</param>
        /// <param name="monsters">The name of the monster(s) (separated by |) to kill for the drop.</param>
        /// <param name="drop">The name of the drop obtained through killing the monsters.</param>
        /// <param name="temp">Whether or not the drop is a temporary item.</param>
        public void RegisterDrop(string map, string monsters, string drop, bool temp = false)
        {
            Register(new DropStrategy()
            {
                Map = map,
                Monsters = monsters,
                Item = drop,
                TempItem = temp
            });
        }

        /// <summary>
        /// Gets a cached shop item. Shop items are cached when RegisterShop is called.
        /// </summary>
        /// <param name="shop">The id of the shop.</param>
        /// <param name="name">The name of the cached item to get.</param>
        /// <returns>The cached ShopItem object or null if the item was not cached.</returns>
        public ShopItem GetCachedShop(int shop, string name)
        {
            return _shops.TryGetValue(shop, out List<ShopItem> items) ? items.Find(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) : null;
        }

        /// <summary>
        /// Gets a cached merge shop item. Merge shop items are cached when RegisterMerge is called.
        /// </summary>
        /// <param name="shop">The id of the shop.</param>
        /// <param name="name">The name of the cached item to get.</param>
        /// <returns>The cached MergeItem object or null if the item was not cached.</returns>
        public MergeItem GetCachedMerge(int shop, string name)
        {
            return _merges.TryGetValue(shop, out List<MergeItem> items) ? items.Find(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) : null;
        }
        
        /// <summary>
        /// Gets a cached Quest object. Quests are cached when RegisterQuest is called.
        /// </summary>
        /// <param name="id">The id of the quest.</param>
        /// <returns>The cached Quest object or null if the quest has not been cached.</returns>
        public Quest GetCachedQuest(int id)
        {
            return _quests.TryGetValue(id, out Quest q) ? q : null;
        }

        /// <summary>
        /// Aggregates all drops based on all strategies that will be used to obtain the given item.
        /// This should be called before Obtain for maximum efficiency. The drop names that are aggregated are picked up (through PickupAggregate) during all strategies' execution.
        /// </summary>
        /// <param name="item"></param>
        public void AggregateDrops(string item)
        {
            DropAggregate.Clear();
            ItemStrategy strat = GetStrategy(item);
            if (strat != null)
                DropAggregate.AddRange(strat.GetRequiredItems(Bot));
        }

        /// <summary>
        /// Picks up all aggregated drop names in the list generated by AggregateDrops. This is called automatically during each strategy's execution and does not need to be called manually.
        /// </summary>
        public void PickupAggregate()
        {
            string[] drops = Bot.Player.CurrentDrops.Where(x => DropAggregate.Find(y => y.Equals(x, StringComparison.OrdinalIgnoreCase)) != null).ToArray();
            Bot.Player.Pickup(drops);
            Bot.Player.RejectExcept(drops);
        }

        /// <summary>
        /// Obtains the specified item in the specified quantity using the registered strategies with the highest priorities.
        /// </summary>
        /// <param name="item">The name of the item to obtain.</param>
        /// <param name="quantity">The quantity of the item to obtain.</param>
        /// <returns>True if the item was successfully obtained through strategies. False if no strategy was found for the given item, or if any intermediate strategy was unsuccessful in its execution.</returns>
        public bool Obtain(string item, int quantity)
        {
            if (Bot.Bank.Contains(item))
                Bot.Bank.ToInventory(item);
            return GetStrategy(item)?.Execute(Bot, quantity) ?? false;
        }
    }
}
