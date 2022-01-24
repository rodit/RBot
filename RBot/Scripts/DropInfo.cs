using Newtonsoft.Json;

namespace RBot;

public class DropInfo
{
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("count")]
    public int Count { get; set; }

    public override bool Equals(object obj)
    {
        return obj is DropInfo && (obj as DropInfo).Name == Name;
    }
}
