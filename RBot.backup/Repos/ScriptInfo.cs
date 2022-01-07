using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Newtonsoft.Json;

namespace RBot.Repos
{
    public class ScriptInfo
    {
        public ScriptRepo Parent { get; set; }
        [JsonProperty("name")]
        public string FileName { get; set; }
        [JsonProperty("sha")]
        public string Hash { get; set; }
        [JsonProperty("size")]
        public int Size { get; set; }
        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }
        public string LocalFile => Path.Combine("Scripts", ".repos", Parent.Username, Parent.Name, FileName);
        public string LocalShaFile => Path.Combine("Scripts", ".repos", Parent.Username, Parent.Name, FileName + ".sha");
        public string LocalSha => File.Exists(LocalShaFile) ? File.ReadAllText(LocalShaFile) : null;
        public bool Downloaded => File.Exists(LocalFile);
        public bool Outdated => Downloaded && LocalSha != Hash;
    }
}
