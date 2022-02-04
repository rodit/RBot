using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using Newtonsoft.Json;

namespace RBot.Cosmetics;

public class CosmeticEquipment : ScriptableObject
{
    private static Dictionary<EquipType, string> _cosMap = new()
    {
        { EquipType.Helm, "he" },
        { EquipType.Cape, "ba" },
        { EquipType.Armor, "co" },
        { EquipType.Class, "ar" },
        { EquipType.Pet, "pe" },
        { EquipType.Weapon, "Weapon" }
    };

    private static Dictionary<string, EquipType> _backMap = _cosMap.ToDictionary(kvp => kvp.Value, kvp => kvp.Key);

    public EquipType Slot { get; set; }
    [JsonProperty("ItemID")]
    public int ID { get; set; }
    [JsonProperty("sLink")]
    public string Link { get; set; }
    [JsonProperty("sMeta")]
    public string Meta { get; set; }
    [JsonProperty("sFile")]
    public string SWFFile { get; set; }
    [JsonProperty("sType")]
    public string Type { get; set; }

    public void Equip()
    {
        string slot = _cosMap[Slot];
        dynamic equip = new ExpandoObject();
        equip.sFile = SWFFile;
        equip.sLink = Link;
        equip.sType = Type;
        equip.sMeta = Meta;
        if (ID != 0)
            equip.ItemID = ID;
        Bot.SetGameObject($"world.myAvatar.objData.eqp.{slot}", equip);
        Bot.CallGameFunction("world.myAvatar.loadMovieAtES", slot, SWFFile, Link);
    }

    public override string ToString()
    {
        return $"{Slot}: {SWFFile}";
    }

    public static List<CosmeticEquipment> Get(int id)
    {
        Dictionary<string, CosmeticEquipment> items = ScriptInterface.Instance.GetGameObject<Dictionary<string, CosmeticEquipment>>($"world.avatars.{id}.objData.eqp") ?? new Dictionary<string, CosmeticEquipment>();
        return items.Select(kvp => (kvp.Value.Slot = _backMap.TryGetValue(kvp.Key, out EquipType slot) ? slot : EquipType.None) != EquipType.None ? kvp.Value : null).Where(x => x != null).ToList();
    }
}
