using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot.Shops
{
    public class ShopCache
    {
        public static List<ShopInfo> Loaded = new List<ShopInfo>();
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
