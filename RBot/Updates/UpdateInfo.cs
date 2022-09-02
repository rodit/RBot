﻿using System;
using Newtonsoft.Json;

namespace RBot.Updates;

public class UpdateInfo
{
    [JsonProperty("html_url")]
    public string URL { get; set; }
    [JsonProperty("tag_name")]
    public string Version { get; set; }
    public Version ParsedVersion => System.Version.Parse(Version);
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("prerelease")]
    public bool Prerelease { get; set; }
    [JsonProperty("created_at")]
    public DateTime Time { get; set; }

    public override string ToString()
    {
        return $"{Name} [{Version}]";
    }
}
