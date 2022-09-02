﻿using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RBot.Items;

[DataContract]
[JsonConverter(typeof(StringEnumConverter))]
public enum ItemCategory
{
    Sword,
    Axe,
    Dagger,
    Gun,
    HandGun,
    Rifle,
    Bow,
    Mace,
    Gauntlet,
    Polearm,
    Staff,
    Wand,
    Whip,
    Class,
    Armor,
    Helm,
    Cape,
    Pet,
    Amulet,
    Necklace,
    Note,
    Resource,
    Item,
    Misc,
    [EnumMember(Value = "Quest Item")]
    QuestItem,
    [EnumMember(Value = "Server Use")]
    ServerUse,
    House,
    [EnumMember(Value = "Wall Item")]
    WallItem,
    [EnumMember(Value = "Floor Item")]
    FloorItem,
    Enhancement,
    Unknown
}
