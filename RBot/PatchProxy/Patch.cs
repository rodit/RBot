using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot.PatchProxy
{
    public class Patch
    {
        public byte[] Find;
        public byte[] Replace;
        public int Count;

        public Patch(string line)
        {
            string[] parts = line.Split(':');
            Count = parts.Length == 2 ? int.Parse(parts[0]) : 1;
            parts = line.Split('=');
            Find = PatchUtil.StringToByteArrayFastest(parts[0]);
            Replace = PatchUtil.StringToByteArrayFastest(parts[1], Find.Length);
        }

        public bool Apply(byte[] data)
        {
            return Enumerable.Range(0, Count).All(i =>
            {
                int index = PatchUtil.FindBytes(data, Find);
                if (index > -1)
                    Buffer.BlockCopy(Replace, 0, data, index, Replace.Length);
                return index > -1;
            });
        }
    }
}
