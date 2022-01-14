using System.Collections.Generic;
using System.Linq;

namespace RBot.Shops
{
    public class ShopCache
    {
        public static List<ShopInfo> Loaded = new();

        public static void OnLoaded(int id, string name)
        {
            if (Loaded.All(s => s.ID != id))
            {
                Loaded.Add(new ShopInfo(id, name));
            }
        }
    }

    public class ShopInfo
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ShopInfo(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name} [{ID}]";
        }
    }
}
