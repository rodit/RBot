﻿using RBot.Factions;
using RBot.Flash;
using RBot.Items;
using RBot.Monsters;
using RBot.Servers;
using RBot.Skills;
using RBot.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Threading;

namespace RBot;

public class ScriptPlayer : ScriptableObject
{
    /// <summary>
    /// Gets the player ID (useful for some packets).
    /// </summary>
    [ObjectBinding("world.myAvatar.uid")]
    public int ID { get; }
    /// <summary>
    /// Gets the player's current XP.
    /// </summary>
    [ObjectBinding("world.myAvatar.objData.intExp")]
    public int XP { get; }
    /// <summary>
    /// Gets the player's required XP to level up.
    /// </summary>
    [ObjectBinding("world.myAvatar.objData.intExpToLevel")]
    public int RequiredXP { get; }
    /// <summary>
    /// The current cell that the player is in.
    /// </summary>
    [ObjectBinding("world.strFrame")]
    public string Cell { get; }
    /// <summary>
    /// The current pad that the player spawned from.
    /// </summary>
    [ObjectBinding("world.strPad")]
    public string Pad { get; }
    /// <summary>
    /// The server to which the player is currently connected.
    /// </summary>
    [ObjectBinding("serverIP", Static = true)]
    public string ServerIP { get; }
    /// <summary>
    /// Checks whether the player is both logged in and alive.
    /// </summary>
    public bool Playing => LoggedIn && Alive;
    /// <summary>
    /// Checks whether the player is logged in.
    /// </summary>
    [CallBinding("isLoggedIn")]
    public bool LoggedIn { get; }
    /// <summary>
    /// Gets the player's username.
    /// </summary>
    [ObjectBinding("loginInfo.strUsername", Static = true)]
    public string Username { get; }
    /// <summary>
    /// Gets the player's password.
    /// </summary>
    /// <remarks>This currently does not always work.</remarks>
    [ObjectBinding("loginInfo.strPassword", Static = true)]
    public string Password { get; }
    /// <summary>
    /// Gets whether the player was kicked from the server.
    /// </summary>
    [CallBinding("isKicked")]
    public bool Kicked { get; }
    /// <summary>
    /// Gets the player's state.
    /// </summary>
    [ObjectBinding("world.myAvatar.dataLeaf.intState", RequireNotNull = "world.myAvatar", DefaultValue = 0)]
    public int State { get; }
    /// <summary>
    /// Checks if the player is in combat.
    /// </summary>
    public bool InCombat => State == 2;
    /// <summary>
    /// Checks if the player is a member (upgrade).
    /// </summary>
    public bool IsMember => Bot.GetGameObject<int>("world.myAvatar.objData.iUpgDays") >= 0;
    /// <summary>
    /// Checks whether the player is alive or not.
    /// </summary>
    public bool Alive => State > 0;
    /// <summary>
    /// Gets the player's current health.
    /// </summary>
    [ObjectBinding("world.myAvatar.dataLeaf.intHP")]
    public int Health { get; }
    /// <summary>
    /// Gets the player's maximum health.
    /// </summary>
    [ObjectBinding("world.myAvatar.dataLeaf.intHPMax")]
    public int MaxHealth { get; }
    /// <summary>
    /// Gets or sets the player's current mana.
    /// </summary>
    [ObjectBinding("world.myAvatar.objData.intMP", "world.myAvatar.dataLeaf.intMP")]
    public int Mana { get; set; }
    /// <summary>
    /// Gets the player's maximum mana.
    /// </summary>
    [ObjectBinding("world.myAvatar.dataLeaf.intMPMax")]
    public int MaxMana { get; }
    /// <summary>
    /// Gets or sets the player's level.
    /// </summary>
    [ObjectBinding("world.myAvatar.dataLeaf.intLevel")]
    public int Level { get; set; }
    /// <summary>
    /// Gets the player's gold.
    /// </summary>
    [ObjectBinding("world.myAvatar.objData.intGold")]
    public int Gold { get; }
    /// <summary>
    /// Gets the player's current class rank.
    /// </summary>
    [ObjectBinding("world.myAvatar.objData.iRank")]
    public int Rank { get; }
    /// <summary>
    /// Checks if the player currently has a target selected.
    /// </summary>
    public bool HasTarget
    {
        get
        {
            Monster m = Target;
            return m?.Alive ?? false;
        }
    }
    /// <summary>
    /// Checks whether the player's avatar is loaded.
    /// </summary>
    public bool Loaded => Bot.GetGameObject<int>("world.myAvatar.items.length") > 0
                        && !Bot.GetGameObject<bool>("world.mapLoadInProgress")
                        && Bot.CallGameFunction<bool>("world.myAvatar.pMC.artLoaded");
    /// <summary>
    /// The player's access level.
    /// </summary>
    [ObjectBinding("world.myAvatar.objData.intAccessLevel")]
    public int AccessLevel { get; set; }
    /// <summary>
    /// Gets/sets whether the player is upgrade or not.
    /// </summary>
    public bool Upgrade
    {
        get
        {
            return Bot.GetGameObject<int>("world.myAvatar.objData.iUpgDays") > 0;
        }
        set
        {
            Bot.SetGameObject("world.myAvatar.objData.iUpg", value ? 1000 : 0);
            Bot.SetGameObject("world.myAvatar.objData.iUpgDays", value ? 1000 : 0);
        }
    }
    /// <summary>
    /// Gets an array containing information about the player's current skills.
    /// </summary>
    [ObjectBinding("world.actions.active")]
    public SkillInfo[] Skills { get; }
    /// <summary>
    /// Checks whether the player is marked as AFK or not.
    /// </summary>
    [ObjectBinding("world.myAvatar.dataLeaf.afk")]
    public bool AFK { get; }
    /// <summary>
    /// The current position of the player.
    /// </summary>
    public PointF Position => new(X, Y);
    /// <summary>
    /// The player's current X coordinate.
    /// </summary>
    [ObjectBinding("world.myAvatar.pMC.x")]
    public float X { get; }
    /// <summary>
    /// The player's current Y coordinate.
    /// </summary>
    [ObjectBinding("world.myAvatar.pMC.y")]
    public float Y { get; }
    /// <summary>
    /// Gets or sets the walking speed of the player. The default value is 8.
    /// </summary>
    [ObjectBinding("world.WALKSPEED")]
    public int WalkSpeed { get; set; }
    /// <summary>
    /// This does nothing at the moment...
    /// </summary>
    [ObjectBinding("world.SCALE")]
    public int Scale { get; set; }
    /// <summary>
    /// The currently targeted monster. If no monster is targeted, null is returned.
    /// </summary>
    [ObjectBinding("world.myAvatar.target.objData", RequireNotNull = "world.myAvatar.target")]
    public Monster Target { get; }
    /// <summary>
    /// Gets an array containing all the names of the factions that the player has some reputation in.
    /// </summary>
    [ObjectBinding("world.myAvatar.factions")]
    public List<Faction> Factions { get; }

    /// <summary>
    /// Gets a list of drops available.
    /// </summary>
    public List<InventoryItem> CurrentDropInfos { get; private set; } = new();
    /// <summary>
    /// Gets a list of item names currently on the drop stack.
    /// </summary>
    public List<string> CurrentDrops => CurrentDropInfos.Select(x => x.Name.Trim()).ToList();

    /// <summary>
    /// Checks if the given skill has cooled down.
    /// </summary>
    /// <param name="index">The index of the skill to check.</param>
    /// <returns>Whether the given skill has cooled down.</returns>
    [MethodCallBinding("canUseSkill")]
    public bool CanUseSkill(int index) => false;

    /// <summary>
    /// Picks up the specified list of items.
    /// </summary>
    /// <param name="items">The names of the items to pick up.</param>
    public void Pickup(params string[] items)
    {
        CheckScriptTermination();
        foreach (var item in items)
        {
            GetDrop(item);
            if (Bot.Options.SafeTimings)
                Bot.Wait.ForPickup(item);
        }
    }

    internal void _Pickup(params string[] items)
    {
        foreach (var item in items)
        {
            GetDrop(item);
            if (Bot.Options.SafeTimings)
                Bot.Wait.ForPickup(item);
        }
    }

    /// <summary>
    /// Picks up the specified list of items, without waiting for the items to be picked up. This method disregards the SafeTimings option.
    /// </summary>
    /// <param name="items"></param>
    public void PickupFast(params string[] items)
    {
        CheckScriptTermination();
        foreach (var item in items)
            GetDrop(item);
    }

    /// <summary>
    /// Picks up all AC item in the drop stack.
    /// </summary>
    public void PickupACItems()
    {
        CheckScriptTermination();
        _PickupACItems();
    }

    internal void _PickupACItems()
    {
        _Pickup(CurrentDropInfos.Where(d => d.Coins).Select(d => d.Name).ToArray());
    }

    /// <summary>
    /// Sends a getDrop packet to pickup the desired item if it exists in the drop stack.
    /// </summary>
    /// <param name="item">Name of the item to be picked up</param>
    public void GetDrop(string item)
    {
        if (!CurrentDrops.Contains(item, StringComparer.OrdinalIgnoreCase))
            return;

        var drop = CurrentDropInfos.Find(d => d.Name.ToLower() == item.ToLower());
        Bot.SendPacket($"%xt%zm%getDrop%{Bot.Map.RoomID}%{drop.ID}%");
        CurrentDropInfos.Remove(drop);
    }

    /// <summary>
    /// Sends a getDrop packet to pickup the desired item by it's ID.
    /// </summary>
    /// <param name="id">ID of the item to be picked up</param>
    public void GetDrop(int id)
    {
        Bot.SendPacket($"%xt%zm%getDrop%{Bot.Map.RoomID}%{id}%");
        CurrentDropInfos.Remove(CurrentDropInfos.SingleOrDefault(d => d.ID == id));
    }

    /// <summary>
    /// Rejects all drops except those in the specified list.
    /// </summary>
    /// <param name="items">The list of items to not reject.</param>
    public void RejectExcept(params string[] items)
    {
        if (Bot.Options.AcceptACDrops)
            _PickupACItems();
        CheckScriptTermination();
        _RejectExcept();
    }

    internal void _RejectExcept(params string[] items)
    {
        string whitelist = CreateWhitelistString(items);
        FlashUtil.Call("rejectExcept", whitelist);
    }

    /// <summary>
    /// Rejects all drops except those in the specified list, without waiting for the items to be picked up. This method disregards the SafeTimings option.
    /// </summary>
    /// <param name="items"></param>
    public void RejectExceptFast(params string[] items)
    {
        if (Bot.Options.AcceptACDrops)
            PickupACItems();
        FlashUtil.Call("rejectExcept", CreateWhitelistString(items));
    }

    /// <summary>
    /// Checks if a drop of the specified item exists.
    /// </summary>
    /// <param name="name">The name of the item.</param>
    /// <returns>Whether a drop of the specified item exists.</returns>
    public bool DropExists(string name) => CurrentDrops.Contains(x => name == "*" || x.Equals(name, StringComparison.OrdinalIgnoreCase));

    /// <summary>
    /// Picks up all available drops.
    /// </summary>
    /// <param name="skipWait">Whether the SafeTimings option is ignored.</param>
    public void PickupAll(bool skipWait = false)
    {
        CheckScriptTermination();
        _PickupAll(skipWait);
    }

    internal void _PickupAll(bool skipWait = false)
    {
        CurrentDropInfos.ToList().ForEach(d => GetDrop(d.Name));
        CurrentDropInfos.Clear();
        if (Bot.Options.SafeTimings && !skipWait)
            Bot.Wait._ForPickup("*");
    }

    /// <summary>
    /// Rejects all availble drops.
    /// </summary>
    /// <param name="skipWait">Whether the SafeTimings option is ignored.</param>
    public void RejectAll(bool skipWait = false)
    {
        if (Bot.Options.AcceptACDrops)
            _PickupACItems();
        CheckScriptTermination();
        _RejectAll();
    }

    internal void _RejectAll(bool skipWait = false)
    {
        FlashUtil.Call("rejectExcept", "");
        if (Bot.Options.SafeTimings && !skipWait)
            Bot.Wait._ForPickup("*");
    }


    /// <summary>
    /// Walks the player to the specified x and y coordinates.
    /// </summary>
    /// <param name="x">The x coordinate.</param>
    /// <param name="y">The y coordinate.</param>
    /// <param name="speed">The speed at which to move the player's avatar.</param>
    [MethodCallBinding("walkTo", RunMethodPost = true)]
    public void WalkTo(int x, int y, int speed = 8)
    {
        CheckScriptTermination();
        if (Bot.Options.SafeTimings)
            Bot.Wait.ForPlayerPosition(x, y);
    }

    /// <summary>
    /// Sets the player's respawn point to the current cell and pad.
    /// </summary>
    public void SetSpawnPoint()
    {
        SetSpawnPoint(Cell, Pad);
    }

    /// <summary>
    /// Sets the player's respawn point to the given cell and pad.
    /// </summary>
    [MethodCallBinding("world.setSpawnPoint", GameFunction = true)]
    public void SetSpawnPoint(string cell, string pad) { }

    /// <summary>
    /// Loads the player's bank so it can be used in the script.
    /// </summary>
    public void LoadBank(bool waitForLoad = true)
    {
        CheckScriptTermination();
        Bot.SendPacket($"%xt%zm%loadBank%{Bot.Map.RoomID}%All%");
        if (waitForLoad)
            Bot.Wait.ForBankLoad(20);
    }

    /// <summary>
    /// Logs into the game with the specified username and password.
    /// </summary>
    /// <param name="username">The username to login with.</param>
    /// <param name="password">The password to login with.</param>
    [MethodCallBinding("login", GameFunction = true)]
    public void Login(string username, string password) { }

    /// <summary>
    /// Connects to the game server with the specified name.
    /// </summary>
    /// <param name="serverName">The name of the server to connect to (e.g. Artix)</param>
    public void Connect(string serverName)
    {
        Server s = ServerList.Servers.Find(x => x.Name.Equals(serverName, StringComparison.OrdinalIgnoreCase));
        if (s != null)
            Connect(s);
    }

    /// <summary>
    /// Connects to the specified game server.
    /// </summary>
    /// <param name="server">The server to connect to.</param>
    public void Connect(Server server)
    {
        ConnectIP(server.IP);
    }

    /// <summary>
    /// Connects to the game server with the specified IP address.
    /// </summary>
    /// <param name="ip">The IP address of the server to connec to.</param>
    [MethodCallBinding("connectTo", GameFunction = true)]
    public void ConnectIP(string ip) { }

    /// <summary>
    /// Logs in and connects to the specified server.
    /// </summary>
    public void Reconnect(string serverName, int loginDelay = 2000)
    {
        Login(Username, Password);
        Thread.Sleep(loginDelay);
        Connect(serverName);
    }

    /// <summary>
    /// Logs out of the game.
    /// </summary>
    [MethodCallBinding("logout", RunMethodPost = true, GameFunction = true)]
    public void Logout()
    {
        Bot.CallGameFunction("gotoAndPlay", "Login");
    }

    public bool Relogin(Server server = null)
    {
        CheckScriptTermination();
        bool autoRelogSwitch = Bot.Options.AutoRelogin;
        Bot.Options.AutoRelogin = false;
        Bot.Sleep(2000);
        Logout();
        Bot.Stats.Relogins++;
        Login(Username, Password);
        Bot.Sleep(1500);
        if (server is null && !string.IsNullOrEmpty(AppRuntime.Options.Get<string>("relogin.server")))
            server = ServerList.Servers.Find(s => s.Name.ToLower() == AppRuntime.Options.Get<string>("relogin.server").ToLower());
        if (server is null)
            server = Bot.Options.AutoReloginAny ? ServerList.Servers.Find(x => x.IP != ServerList.LastServerIP) : Bot.Options.LoginServer ?? ServerList.Servers[0];
        Connect(server);
        Bot.Wait.ForTrue(() => Playing && Bot.IsWorldLoaded, 30);
        Bot.Options.AutoRelogin = autoRelogSwitch;
        return Playing;
    }

    /// <summary>
    /// Untargets the player if they are currently targeted.
    /// </summary>
    [MethodCallBinding("untargetSelf")]
    public void UntargetSelf() { }

    /// <summary>
    /// Deselects the currently selected target.
    /// </summary>
    [MethodCallBinding("world.cancelTarget", RunMethodPost = true, GameFunction = true)]
    public void CancelTarget()
    {
        if (Bot.Options.SafeTimings)
            Bot.Wait.ForMonsterDeath();
    }

    /// <summary>
    /// Walks towards (approaches) the currently selected target.
    /// </summary>
    [MethodCallBinding("world.approachTarget", GameFunction = true)]
    public void ApproachTarget() { }

    [MethodCallBinding("world.cancelAutoAttack", GameFunction = true)]
    public void CancelAutoAttack() { }

    /// <summary>
    /// Attacks the specified monster.
    /// </summary>
    /// <param name="name">The name of the monster to attack.</param>
    /// <remarks>This will not wait until the monster is killed, but simply select it and start attacking it.</remarks>
    [MethodCallBinding("attackMonsterName")]
    public void Attack(string name) { }

    /// <summary>
    /// Attacks the specified instance of a monster.
    /// </summary>
    /// <param name="monster">The monster to attack.</param>
    /// <remarks>This will not wait until the monster is killed, but simply select it and start attacking it.</remarks>
    public void Attack(Monster monster)
    {
        Attack(monster.MapID);
    }

    /// <summary>
    /// Attacks the monster with the specified map id.
    /// </summary>
    /// <param name="id">The map id of the monster to attack.</param>
    /// <remarks>This will not wait until the monster is killed, but simply select it and start attacking it.</remarks>
    [MethodCallBinding("attackMonsterID")]
    public void Attack(int id) { }

    private int _lastHuntTick;
    /// <summary>
    /// Looks for the enemy in the current map and kills it. This method disregards ScriptOptions#HuntPriority.
    /// </summary>
    /// <param name="name">The name of the enemy to hunt.</param>
    public void Hunt(string name) => _Hunt(name, null);

    /// <summary>
    /// Hunts monsters with a priority. If there is no priority, this has the same behaviour as just Hunt.
    /// If a priority is specified, monsters in the map are sorted by the given priority. Once sorted, the
    /// monster in the current cell which best matches the priority is killed. Otherwise, a cell jump is
    /// awaited and done based on ScriptOptions#HuntDelay.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="priority"></param>
    public void HuntWithPriority(string name, HuntPriorities priority) => _HuntWithPriority(name, priority, null);

    private void _Hunt(string name, CancellationToken? token)
    {
        CheckScriptTermination();
        Bot.Lite.UntargetSelf = true;
        Bot.Lite.UntargetDead = true;
        string[] names = name.Split('|');
        _lastHuntTick = Environment.TickCount;
        while (!token?.IsCancellationRequested ?? true)
        {
            CheckScriptTermination();
            List<string> cells = names.SelectMany(n => Bot.Monsters.GetLivingMonsterCells(n)).Distinct().ToList();
            foreach (string cell in cells)
            {
                CheckScriptTermination();
                if (token?.IsCancellationRequested ?? false)
                    break;
                if (!cells.Contains(Bot.Player.Cell) && (!token?.IsCancellationRequested ?? true))
                {
                    if (Environment.TickCount - _lastHuntTick < Bot.Options.HuntDelay)
                        Bot.Sleep(Bot.Options.HuntDelay - Environment.TickCount + _lastHuntTick);
                    Jump(cell, "Left");
                    _lastHuntTick = Environment.TickCount;
                }
                foreach (string mon in names)
                {
                    CheckScriptTermination();
                    if (token?.IsCancellationRequested ?? false)
                        break;
                    if (Bot.Monsters.Exists(mon) && (!token?.IsCancellationRequested ?? true))
                    {
                        _Kill(mon, token);
                        return;
                    }
                }
                Bot.Sleep(200);
            }
        }
    }

    private void _HuntWithPriority(string name, HuntPriorities priority, CancellationToken? token)
    {
        if (priority == HuntPriorities.None)
        {
            _Hunt(name, token);
            return;
        }

        Bot.Lite.UntargetSelf = true;
        Bot.Lite.UntargetDead = true;
        _lastHuntTick = Environment.TickCount;
        while (!token?.IsCancellationRequested ?? true)
        {
            CheckScriptTermination();
            string[] names = name.Split('|').Select(x => x.ToLower()).ToArray();
            IOrderedEnumerable<Monster> ordered = Bot.Monsters.MapMonsters.OrderBy(x => 0);
            if (priority.HasFlag(HuntPriorities.HighHP))
                ordered = ordered.OrderByDescending(x => x.HP);
            else if (priority.HasFlag(HuntPriorities.LowHP))
                ordered = ordered.OrderBy(x => x.HP);
            if (priority.HasFlag(HuntPriorities.Close))
                ordered = ordered.OrderBy(x => x.Cell == Cell ? 0 : 1);
            List<Monster> targets = ordered.Where(m => names.Any(n => n == "*" || n.Trim().Equals(m.Name.Trim(), StringComparison.OrdinalIgnoreCase)) && m.Alive).ToList();
            foreach (Monster target in targets)
            {
                CheckScriptTermination();
                if (token?.IsCancellationRequested ?? false)
                    break;
                bool sameCell = Bot.Monsters.Exists(target.Name);
                if (sameCell || CanJumpForHunt())
                {
                    if (!sameCell && (!token?.IsCancellationRequested ?? true))
                    {
                        if (Cell == target.Cell)
                            continue;
                        Jump(target.Cell, "Left");
                        _lastHuntTick = Environment.TickCount;
                    }
                    _Kill(target, token);
                    return;
                }
            }
            Bot.Sleep(200);
        }
    }

    /// <summary>
    /// Hunts the specified monster for a specific item.
    /// </summary>
    /// <param name="name">The name of the monster to kill.</param>
    /// <param name="item">The item to collect.</param>
    /// <param name="quantity">The quantity of the item that must be collected before stopping the killing of the monster.</param>
    /// <param name="tempItem">Whether or not the item being collected is a temporary (quest) item.</param>
    /// <param name="rejectElse">Whether or not to reject items which are not the 'item' paramater.</param>
    public void HuntForItem(string name, string item, int quantity, bool tempItem = false, bool rejectElse = true)
    {
        HuntCTS = new();
        this.item = (item, quantity, tempItem);
        Bot.Events.ItemDropped += ItemHunted;
        while (!Bot.ShouldExit()
            && (tempItem || !Bot.Inventory.Contains(item, quantity))
            && (!tempItem || !Bot.Inventory.ContainsTempItem(item, quantity)))
        {
            _HuntWithPriority(name, Bot.Options.HuntPriority, HuntCTS.Token);
            if (rejectElse)
                RejectExcept(item);
        }
        Bot.Events.ItemDropped -= ItemHunted;
        HuntCTS.Dispose();
        HuntCTS = null;
        CancelTarget();
        CancelAutoAttack();
        Jump(Cell, Pad);
        Bot.Wait.ForCombatExit();
    }

    private (string name, int quantity, bool isTemp) item = ("", 0, false);
    private CancellationTokenSource HuntCTS;

    private void ItemHunted(ScriptInterface bot, ItemBase item, bool addedToInv, int quantityNow)
    {
        if (item.Name != this.item.name)
            return;

        if (addedToInv && !item.Temp && quantityNow >= this.item.quantity)
        {
            HuntCTS?.Cancel();
            return;
        }
        Pickup(item.Name);
        int quant = this.item.isTemp ? bot.Inventory.GetTempQuantity(item.Name) : bot.Inventory.GetQuantity(item.Name);
        if (quant >= this.item.quantity)
            HuntCTS?.Cancel();
    }

    /// <summary>
    /// Hunts the specified monsters for a specific item.
    /// </summary>
    /// <param name="names">The array of names of monsters to kill.</param>
    /// <param name="item">The item to collect.</param>
    /// <param name="quantity">The quantity of the item that must be collected before stopping the killing of the monster.</param>
    /// <param name="tempItem">Whether or not the item being collected is a temporary (quest) item.</param>
    /// <param name="rejectElse">Whether or not to reject items which are not the 'item' paramater.</param>
    public void HuntForItem(string[] names, string item, int quantity, bool tempItem = false, bool rejectElse = true)
    {
        HuntForItem(ConvertToNamesString(names), item, quantity, tempItem, rejectElse);
    }

    /// <summary>
    /// Hunts the specified monsters for a specific item.
    /// </summary>
    /// <param name="names">The list of names of monsters to kill.</param>
    /// <param name="item">The item to collect.</param>
    /// <param name="quantity">The quantity of the item that must be collected before stopping the killing of the monster.</param>
    /// <param name="tempItem">Whether or not the item being collected is a temporary (quest) item.</param>
    /// <param name="rejectElse">Whether or not to reject items which are not the 'item' paramater.</param>
    public void HuntForItem(List<string> names, string item, int quantity, bool tempItem = false, bool rejectElse = true)
    {
        HuntForItem(ConvertToNamesString(names), item, quantity, tempItem, rejectElse);
    }

    /// <summary>
    /// Hunts the specified monster until the desired items are collected in the desired quantities.
    /// </summary>
    /// <param name="name">The name of the monster to kill.</param>
    /// <param name="items">The items to collect.</param>
    /// <param name="quantities">The quantities of the items that must be collected before stopping the killing of the monster.</param>
    /// <param name="tempItems">Whether or not each item being collected is a temporary (quest) item.</param>
    /// <param name="rejectElse">Whether or not to reject items which are not contained in the 'items' array.</param>
    public void HuntForItems(string name, string[] items, int[] quantities, bool[] tempItems, bool rejectElse)
    {
        if (items.Length != quantities.Length)
        {
            Bot.Log("Item count does not match quantity count.");
            return;
        }
        bool[] temp = tempItems ?? new bool[tempItems.Length];
        for (int i = 0; i < items.Length; i++)
        {
            HuntForItem(name, items[i], quantities[i], temp[i], false);
            if (rejectElse)
                RejectExcept(items);
        }
    }

    /// <summary>
    /// Hunts the specified monster until the desired items are collected in the desired quantities.
    /// </summary>
    /// <param name="name">The name of the monster to kill.</param>
    /// <param name="items">The items to collect.</param>
    /// <param name="quantities">The quantities of the items that must be collected before stopping the killing of the monster.</param>
    /// <param name="tempItems">Whether or not the items being collected are temporary (quest) items.</param>
    /// <param name="rejectElse">Whether or not to reject items which are not contained in the 'items' array.</param>
    public void HuntForItems(string name, string[] items, int[] quantities, bool tempItems = false, bool rejectElse = true)
    {
        HuntForItems(name, items, quantities, Enumerable.Range(0, items.Length).Select(i => tempItems).ToArray(), rejectElse);
    }

    /// <summary>
    /// Hunts the specified monster until the desired items are collected in the desired quantities.
    /// </summary>
    /// <param name="names">The names of the monsters to kill.</param>
    /// <param name="items">The item to collect.</param>
    /// <param name="quantities">The quantities of the items that must be collected before stopping the killing of the monster.</param>
    /// <param name="tempItems">Whether or not each item being collected is a temporary (quest) item.</param>
    /// <param name="rejectElse">Whether or not to reject items which are not contained in the 'items' array.</param>
    public void HuntForItems(string[] names, string[] items, int[] quantities, bool[] tempItems, bool rejectElse)
    {
        HuntForItems(ConvertToNamesString(names), items, quantities, tempItems, rejectElse);
    }

    /// <summary>
    /// Hunts the specified monster until the desired items are collected in the desired quantities.
    /// </summary>
    /// <param name="names">The names of the monsters to kill.</param>
    /// <param name="items">The items to collect.</param>
    /// <param name="quantities">The quantities of the items that must be collected before stopping the killing of the monster.</param>
    /// <param name="tempItems">Whether or not the items being collected are temporary (quest) items.</param>
    /// <param name="rejectElse">Whether or not to reject items which are not contained in the 'items' array.</param>
    public void HuntForItems(string[] names, string[] items, int[] quantities, bool tempItems = false, bool rejectElse = true)
    {
        HuntForItems(names, items, quantities, Enumerable.Range(0, items.Length).Select(i => tempItems).ToArray(), rejectElse);
    }

    /// <summary>
    /// Hunts the specified monster until the desired items are collected in the desired quantities.
    /// </summary>
    /// <param name="names">The names of the monsters to kill.</param>
    /// <param name="items">The items to collect.</param>
    /// <param name="quantities">The quantities of the items that must be collected before stopping the killing of the monster.</param>
    /// <param name="tempItems">Whether or not each item being collected is a temporary (quest) item.</param>
    /// <param name="rejectElse">Whether or not to reject items which are not contained in the 'items' array.</param>
    public void HuntForItems(List<string> names, string[] items, int[] quantities, bool[] tempItems, bool rejectElse)
    {
        HuntForItems(ConvertToNamesString(names), items, quantities, tempItems, rejectElse);
    }

    /// <summary>
    /// Hunts the specified monster until the desired items are collected in the desired quantities.
    /// </summary>
    /// <param name="names">The names of the monsters to kill.</param>
    /// <param name="items">The items to collect.</param>
    /// <param name="quantities">The quantities of the items that must be collected before stopping the killing of the monster.</param>
    /// <param name="tempItems">Whether or not the items being collected are temporary (quest) items.</param>
    /// <param name="rejectElse">Whether or not to reject items which are not contained in the 'items' array.</param>
    public void HuntForItems(List<string> names, string[] items, int[] quantities, bool tempItems = false, bool rejectElse = true)
    {
        HuntForItems(names, items, quantities, Enumerable.Range(0, items.Length).Select(i => tempItems).ToArray(), rejectElse);
    }

    private bool CanJumpForHunt()
    {
        return Environment.TickCount - _lastHuntTick >= Bot.Options.HuntDelay;
    }

    internal string saveCell = "Enter", savePad = "Spawn";

    /// <summary>
    /// Attacks the specified monster and waits until it is killed (if SafeTimings are enabled).
    /// </summary>
    /// <param name="name">The name of the monster to kill.</param>
    public void Kill(string name) => _Kill(name, null);

    internal void _Kill(string name, CancellationToken? token)
    {
        if (Bot.Options.SafeTimings)
            Bot.Wait.ForMonsterSpawn(name, 30);
        Attack(name);
        if (token is null)
        {
            Bot.Wait.ForMonsterDeath();
            return;
        }
        Bot.Wait._ForMonsterDeath((CancellationToken)token);
    }

    /// <summary>
    /// Attacks the specified instance of a monster and waits until it is killed (if SafeTimings are enabled).
    /// </summary>
    /// <param name="monster">The monster to kill.</param>
    public void Kill(Monster monster) => _Kill(monster, null);

    internal void _Kill(Monster monster, CancellationToken? token)
    {
        if (Bot.Options.SafeTimings)
            Bot.Wait.ForTrue(() => Bot.Monsters.CurrentMonsters.Contains(m => m.MapID == monster.MapID && m.Alive), 30);
        Attack(monster.MapID);
        if (token is null)
        {
            Bot.Wait.ForMonsterDeath();
            return;
        }
        Bot.Wait._ForMonsterDeath((CancellationToken)token);
    }

    /// <summary>
    /// Kills the specified monster until the desired item is collected in the desired quantity.
    /// </summary>
    /// <param name="name">The name of the monster to kill.</param>
    /// <param name="item">The item to collect.</param>
    /// <param name="quantity">The quantity of the item that must be collected before stopping the killing of the monster.</param>
    /// <param name="tempItem">Whether or not the item being collected is a temporary (quest) item.</param>
    /// <param name="rejectElse">Whether or not to reject items which are not the 'item' paramater.</param>
    public void KillForItem(string name, string item, int quantity, bool tempItem = false, bool rejectElse = true)
    {
        saveCell = Cell;
        savePad = Pad;
        while (!Bot.ShouldExit()
            && (tempItem || !Bot.Inventory.Contains(item, quantity))
            && (!tempItem || !Bot.Inventory.ContainsTempItem(item, quantity)))
        {
            if (Cell != saveCell)
                Jump(saveCell, savePad);
            Attack(name);
            Pickup(item);
            if (rejectElse)
                RejectExcept(item);
        }
        saveCell = savePad = "";
    }

    /// <summary>
    /// Kills the specified monster until the desired items are collected in the desired quantities.
    /// </summary>
    /// <param name="name">The name of the monster to kill.</param>
    /// <param name="items">The item to collect.</param>
    /// <param name="quantities">The quantities of the items that must be collected before stopping the killing of the monster.</param>
    /// <param name="tempItems">Whether or not the items being collected are temporary (quest) items.</param>
    /// <param name="rejectElse">Whether or not to reject items which are not contained in the 'items' array.</param>
    public void KillForItems(string name, string[] items, int[] quantities, bool tempItems = false, bool rejectElse = true)
    {
        if (items.Length != quantities.Length)
        {
            Bot.Log("Item count does not match quantity count.");
            return;
        }
        saveCell = Cell;
        savePad = Pad;
        while (!Bot.ShouldExit()
            && Enumerable.Range(0, items.Length).All(i => (!tempItems && Bot.Inventory.Contains(items[i], quantities[i]))
            || (tempItems && Bot.Inventory.ContainsTempItem(items[i], quantities[i]))))
        {
            if (Cell != saveCell)
                Jump(saveCell, savePad);
            Attack(name);
            Pickup(items);
            if (rejectElse)
                RejectExcept(items);
        }
    }

    /// <summary>
    /// Attacks the specified player. If not in PVP mode, this will only target the player, and not attack them.
    /// </summary>
    /// <param name="name">The name of the player to attack.</param>
    [MethodCallBinding("attackPlayer")]
    public void AttackPlayer(string name) { }

    /// <summary>
    /// Attacks the specified player and waits until they are killed (if SafeTiings are enabled). This should only be used in PVP.
    /// </summary>
    /// <param name="name">The name of the player to kill.</param>
    public void KillPlayer(string name)
    {
        AttackPlayer(name);
        if (Bot.Options.SafeTimings)
            Bot.Wait.ForMonsterDeath();
    }

    /// <summary>
    /// Uses the skill with the specified index (1-4).
    /// </summary>
    /// <param name="index">The index of the skill.</param>
    [MethodCallBinding("useSkill")]
    public void UseSkill(int index) { }

    /// <summary>
    /// Jumps the player to the specified cell and pad.
    /// </summary>
    /// <param name="cell">The cell to jump to.</param>
    /// <param name="pad">The pad to jump to.</param>
    /// <param name="clientOnly">If true, the client will not send a moveToCell packet to the server.</param>
    [MethodCallBinding("world.moveToCell", RunMethodPost = true, GameFunction = true)]
    public void Jump(string cell, string pad, bool clientOnly = false)
    {
        if (Bot.Options.SafeTimings)
            Bot.Wait.ForCellChange(cell);
        saveCell = cell;
        savePad = pad;
    }

    internal string LastJoin { get; set; } = null;
    /// <summary>
    /// Joins the specified map, ignoring whether or not you are in that map.
    /// </summary>
    /// <param name="map">The name of the map.</param>
    public void JoinIgnore(string map)
    {
        Join(map, "Enter", "Spawn", true);
    }

    /// <summary>
    /// Joins the specified map, and jumps to the specified cell and pad.
    /// </summary>
    /// <param name="map">The name of the map.</param>
    /// <param name="cell">The cell to jump to.</param>
    /// <param name="pad">The pad to jump to.</param>
    /// <param name="ignoreCheck">If set to true, the bot will not check if the player is already in the given room.</param>
    public void Join(string map, string cell = "Enter", string pad = "Spawn", bool ignoreCheck = false)
    {
        _Join(map, cell, pad, ignoreCheck, 0);
    }

    private void _Join(string map, string cell = "Enter", string pad = "Spawn", bool ignoreCheck = false, int iteration = 0)
    {
        CheckScriptTermination();
        LastJoin = map;
        if (Playing && Loaded && (ignoreCheck || !Bot.Map.Name.Equals(map, StringComparison.OrdinalIgnoreCase)))
        {
            if (Bot.Options.PrivateRooms || map.Contains("-1e9"))
                map = map.Split('-')[0] + "-100000";
            if (Bot.Options.SafeTimings)
                Bot.Wait.ForActionCooldown(ScriptWait.GameActions.Transfer);
            JoinPacket(map, cell, pad);
            if (Bot.Options.SafeTimings)
            {
                if (!Bot.Wait.ForMapLoad(map, 20) && iteration < 2)
                {
                    Jump(Cell, Pad);
                    Thread.Sleep(ScriptWait.WAIT_SLEEP * 10);
                    _Join(map, cell, pad, false, ++iteration);
                }
                else
                    Jump(cell, pad);
            }
        }
    }

    internal void JoinPacket(string map, string cell, string pad)
    {
        Bot.SendPacket($"%xt%zm%cmd%{Bot.Map.RoomID}%tfer%{Username}%{map}%{cell}%{pad}%");
    }

    /// <summary>
    /// Goes to the specified player (equivilent to using the /goto command).
    /// </summary>
    /// <param name="name">The name of the player.</param>
    [MethodCallBinding("world.goto", GameFunction = true)]
    public void Goto(string name) { }

    /// <summary>
    /// Equips the specified item.
    /// </summary>
    /// <param name="id">The id of the item to equip.</param>
    public void EquipItem(int id)
    {
        CheckScriptTermination();
        if (Bot.Options.SafeTimings)
            Bot.Wait.ForActionCooldown(ScriptWait.GameActions.EquipItem);
        dynamic item = new ExpandoObject();
        item.ItemID = id;
        Bot.CallGameFunction("world.sendEquipItemRequest", item);
        if (Bot.Options.SafeTimings)
            Bot.Wait.ForItemEquip(id);
    }

    /// <summary>
    /// Equips the specified item. This will do nothing if the item is not in the player's inventory.
    /// </summary>
    /// <param name="name">The name of the item to equip.</param>
    public void EquipItem(string name)
    {
        if (Bot.Inventory.TryGetItem(name, out InventoryItem item))
            EquipItem(item.ID);
    }

    /// <summary>
    /// Displays the bank to the user.
    /// </summary>
    [MethodCallBinding("world.toggleBank", GameFunction = true)]
    public void OpenBank() { }

    /// <summary>
    /// Rests the player (equivilent to clicking the rest button on the UI).
    /// </summary>
    /// <param name="full">If true, the bot will wait until the player's HP and MP are full.</param>
    public void Rest(bool full = false, int timeout = -1)
    {
        CheckScriptTermination();
        if (Bot.Options.SafeTimings)
            Bot.Wait.ForActionCooldown(ScriptWait.GameActions.Rest);
        Bot.CallGameFunction("world.rest");
        if (full)
            Bot.Wait.ForTrue(() => Health >= MaxHealth && Mana >= MaxMana, timeout);
    }

    public void ExitCombat()
    {
        CheckScriptTermination();
        if (Bot.Player.State == 1)
            return;
        bool aggro = Bot.Options.AggroMonsters;
        Bot.Options.AggroAllMonsters = Bot.Options.AggroAllMonsters = false;
        Bot.Player.CancelAutoAttack();
        Bot.Player.CancelTarget();
        Bot.Player.Jump(Bot.Player.Cell, Bot.Player.Pad);
        Bot.Sleep(300);
        Bot.Player.Jump(Bot.Player.Cell, Bot.Player.Pad);
        Bot.Wait.ForCombatExit();
        Bot.Options.AggroMonsters = aggro;
    }

    /// <summary>
    /// Checks if the specified boost is active.
    /// </summary>
    /// <param name="boost">The type of boost to check.</param>
    /// <returns>Whether the specified boost is active or not.</returns>
    public bool IsBoostActive(BoostType boost) => Bot.GetGameObject("world.myAvatar.objData." + _boostMap[boost], 0) > 0;

    /// <summary>
    /// Uses the specified boost.
    /// </summary>
    /// <param name="id">The id of the boost.</param>
    public void UseBoost(int id)
    {
        Bot.SendPacket($"%xt%zm%serverUseItem%{Bot.Map.RoomID}%+%{id}%");
    }

    /// <summary>
    /// Gets the players rank of the given faction.
    /// </summary>
    /// <param name="name">The name of the faction.</param>
    /// <returns>The player's faction rank, or 0 if the player has no rep in that faction.</returns>
    public int GetFactionRank(string name)
    {
        return Factions.FirstOrDefault(f => f.Name.Equals(name, StringComparison.OrdinalIgnoreCase))?.Rank ?? 0;
    }

    private string ConvertToNamesString(IEnumerable<string> names)
    {
        return string.Join("|", names);
    }

    private string CreateWhitelistString(string[] items)
    {
        return string.Join(",", items).ToLower();
    }

    private static Dictionary<BoostType, string> _boostMap = new()
    {
        { BoostType.Gold, "iBoostG" },
        { BoostType.Class, "iBoostCP" },
        { BoostType.Reputation, "iBoostRep" },
        { BoostType.Experience, "iBoostXP" }
    };
}