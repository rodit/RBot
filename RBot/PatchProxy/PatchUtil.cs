using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot.PatchProxy
{
    public class PatchUtil
    {
        public static byte[] StringToByteArrayFastest(string hex, int minLength = -1)
        {
            byte[] arr = new byte[(minLength == -1) ? (hex.Length >> 1) : minLength];
            for (int i = 0; i < hex.Length >> 1; i++)
                arr[i] = (byte)((GetHexVal(hex[i << 1]) << 4) + GetHexVal(hex[(i << 1) + 1]));
            if (minLength > -1)
                for (int j = hex.Length >> 1; j < minLength; j++)
                    arr[j] = 2;
            return arr;
        }

        public static int GetHexVal(char hex)
        {
            return hex - ((hex < ':') ? '0' : 'W');
        }

        public static int FindBytes(byte[] src, byte[] find)
        {
            int index = -1;
            int matchIndex = 0;
            for (int i = 0; i < src.Length; i++)
            {
                if (src[i] == find[matchIndex])
                {
                    if (matchIndex == find.Length - 1)
                    {
                        index = i - matchIndex;
                        break;
                    }
                    matchIndex++;
                }
                else
                    matchIndex = src[i] == find[0] ? 1 : 0;
            }
            return index;
        }
    }
}
