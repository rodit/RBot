using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using RBot.Utils;

namespace RBot.Strategy
{
    public class WikiParser
    {
        private const string ShopRegex = "location:\\s*<a href=\"(.*?)\"[^>]*?>(.*)<\\/a> - <a[^>]*?>(.*)<\\/a>Price:\\s*([\\d,]*)\\s*(?:AC|Gold)";

        public static async Task<List<WikiItem>> FindMethods(string url)
        {
            using RBotWebClient wc = new();
            string html = await wc.DownloadStringTaskAsync(url);
            string stripped = Regex.Replace(html, "(?!<a.*>|<\\/a>)(<.*?>)|((?! )\\s)", string.Empty);
            List<WikiItem> methods = new();
            Regex shop = new(ShopRegex, RegexOptions.IgnoreCase);
            Match match = shop.Match(html);
            if (match.Success)
            {
                methods.Add(new ShopReference()
                {
                    Url = match.Groups[1].Value,
                    Name = match.Groups[2].Value,
                    Price = int.TryParse(match.Groups[3].Value.Replace(",", ""), out int i) ? i : 0,
                    Coins = match.Groups[4].Value == "AC"
                });
            }
            return methods;
        }
    }

    public class WikiItem
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class ShopReference : WikiItem
    {
        public int Price { get; set; }
        public bool Coins { get; set; }
    }
}
