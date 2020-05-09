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
        public Dictionary<string, INavigator> Navigators { get; } = new Dictionary<string, INavigator>();
        public List<ItemStrategy> ItemStrategies { get; } = new List<ItemStrategy>();

        private Dictionary<int, List<ShopItem>> _shops = new Dictionary<int, List<ShopItem>>();
        private Dictionary<int, List<MergeItem>> _merges = new Dictionary<int, List<MergeItem>>();
        private Dictionary<int, Quest> _quests = new Dictionary<int, Quest>();

        public List<string> DropAggregate { get; } = new List<string>();

        public INavigator GetNavigator(string map)
        {
            return Navigators.TryGetValue(map, out INavigator nav) ? nav : new DefaultNavigator(map);
        }

        public ItemStrategy GetStrategy(string item)
        {
            return ItemStrategies.FindAll(x => x.Item.Equals(item, StringComparison.OrdinalIgnoreCase)).OrderByDescending(x => x.Preference).FirstOrDefault();
        }

        public void Register(ItemStrategy strat)
        {
            ItemStrategies.Add(strat);
        }

        public void RegisterShop(int id, string map = null)
        {
            if (!_shops.ContainsKey(id))
            {
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

        public void RegisterMerge(int id, string map = null)
        {
            if (!_merges.ContainsKey(id))
            {
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

        public ShopItem GetCachedShop(int shop, string name)
        {
            return _shops.TryGetValue(shop, out List<ShopItem> items) ? items.Find(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) : null;
        }

        public MergeItem GetCachedMerge(int shop, string name)
        {
            return _merges.TryGetValue(shop, out List<MergeItem> items) ? items.Find(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) : null;
        }

        public Quest GetCachedQuest(int id)
        {
            return _quests.TryGetValue(id, out Quest q) ? q : null;
        }

        public void AggregateDrops(string item)
        {
            DropAggregate.Clear();
            ItemStrategy strat = GetStrategy(item);
            if (strat != null)
                DropAggregate.AddRange(strat.GetRequiredItems(Bot));
        }

        public void PickupAggregate()
        {
            string[] drops = Bot.Player.CurrentDrops.Where(x => DropAggregate.Find(y => y.Equals(x, StringComparison.OrdinalIgnoreCase)) != null).ToArray();
            Bot.Player.Pickup(drops);
            Bot.Player.RejectExcept(drops);
        }

        public bool Obtain(string item, int quantity)
        {
            if (Bot.Bank.Contains(item))
                Bot.Bank.ToInventory(item);
            return GetStrategy(item)?.Execute(Bot, quantity) ?? false;
        }
    }
}
