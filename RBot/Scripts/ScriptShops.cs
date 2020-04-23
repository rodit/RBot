using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RBot.Flash;
using RBot.Shops;
using RBot.Items;

namespace RBot
{
    public class ScriptShops : ScriptableObject
    {
        /// <summary>
		/// A list of items that were available in the last loaded shop.
		/// </summary>
        [ObjectBinding("world.shopinfo.items")]
        public List<ShopItem> ShopItems { get; }
        /// <summary>
		/// A boolean indicated whether a shop is currently loaded or not.
		/// </summary>
		public bool IsShopLoaded => !Bot.IsNull("world.shopinfo");
        /// <summary>
		/// Gets the currently (or last loaded) shop id.
		/// </summary>
        [ObjectBinding("world.shopinfo.ShopID")]
        public int ShopID { get; }
        /// <summary>
		/// Gets a list of items from the currently loaded merge shop.
		/// </summary>
        [ObjectBinding("world.shopinfo.items")]
        public List<MergeItem> MergeItems { get; }

        /// <summary>
		/// Loads the specified shop in game.
		/// </summary>
		/// <param name="id">The id of the shop to be loaded.</param>
		/// <remarks>Loading invalid shop ids will get you kicked. Be sure to only use updated/recent lists.</remarks>
		public void Load(int id)
        {
            if (Bot.Options.SafeTimings)
                Bot.Wait.ForActionCooldown(ScriptWait.GameActions.LoadShop);
            Bot.CallGameFunction("world.sendLoadShopRequest", id);
            if (Bot.Options.SafeTimings)
                Bot.Wait.ForTrue(() => IsShopLoaded, 10);
        }

        /// <summary>
		/// Buys the specified item from the shop with the specified id.
		/// </summary>
		/// <param name="shopId">The shop to buy the item from.</param>
		/// <param name="name">The name of the item to buy.</param>
		/// <remarks>This loads the shop, waits until it is fully loaded, and then sends the buy item request.</remarks>
		public void BuyItem(int shopId, string name)
        {
            Load(shopId);
            BuyItem(name);
        }

        /// <summary>
		/// Buys the specified item from the currently loaded shop.
		/// </summary>
		/// <param name="name">The name of the item to buy.</param>
		public void BuyItem(string name)
        {
            ShopItem item;
            if (IsShopLoaded && (item = ShopItems.Find(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase))) != null)
            {
                if (Bot.Options.SafeTimings)
                    Bot.Wait.ForActionCooldown(ScriptWait.GameActions.BuyItem);
                Bot.SendPacket($"%xt%zm%buyItem%{Bot.Map.RoomID}%{item.ID}%{ShopID}%{item.ShopItemID}%");
                if (Bot.Options.SafeTimings)
                    Bot.Wait.ForTrue(() => Bot.Inventory.Contains(name), 10);
            }
        }

        /// <summary>
		/// Sells the specified item.
		/// </summary>
		/// <param name="name">The name of the item to sell.</param>
		public void SellItem(string name)
        {
            if (Bot.Inventory.TryGetItem(name, out InventoryItem item))
            {
                if (Bot.Options.SafeTimings)
                    Bot.Wait.ForActionCooldown(ScriptWait.GameActions.SellItem);
                Bot.SendPacket($"%xt%zm%sellItem%{Bot.Map.RoomID}%{item.ID}%{item.Quantity}%{item.CharItemID}%");
                if (Bot.Options.SafeTimings)
                    Bot.Wait.ForItemSell(name, item.Quantity);
            }
        }

        /// <summary>
		/// Loads the specified hair shop in game.
		/// </summary>
		/// <param name="id">The id of the hair shop to be loaded.</param>
        [MethodCallBinding("world.sendLoadHairShopRequest", RunMethodPre = true, GameFunction = true)]
        public void LoadHairShop(int id)
        {
            if (Bot.Options.SafeTimings)
                Bot.Wait.ForActionCooldown(ScriptWait.GameActions.LoadHairShop);
        }

        /// <summary>
		/// Loads the armour customizer interface.
		/// </summary>
        [MethodCallBinding("openArmorCustomize", GameFunction = true)]
        public void LoadArmourCustomizer() { }
    }
}
