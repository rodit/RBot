using System.Text;
using System.Text.RegularExpressions;

namespace RBot.Utils;

public static class StringUtils
{
    public static string ToLiteral(this string s)
    {
        StringBuilder literal = new(s.Length + 2);
        literal.Append('"');
        foreach (var c in s)
        {
            switch (c)
            {
                case '\'': literal.Append(@"\'"); break;
                case '\"': literal.Append("\\\""); break;
                case '\\': literal.Append(@"\\"); break;
                case '\0': literal.Append(@"\0"); break;
                case '\a': literal.Append(@"\a"); break;
                case '\b': literal.Append(@"\b"); break;
                case '\f': literal.Append(@"\f"); break;
                case '\n': literal.Append(@"\n"); break;
                case '\r': literal.Append(@"\r"); break;
                case '\t': literal.Append(@"\t"); break;
                case '\v': literal.Append(@"\v"); break;
                default:
                    if (c >= 0x20 && c <= 0x7e)
                    {
                        literal.Append(c);
                    }
                    else
                    {
                        literal.Append(@"\u");
                        literal.Append(((int)c).ToString("x4"));
                    }
                    break;
            }
        }
        literal.Append('"');
        return literal.ToString();
    }

    public static string RemoveLetters(this string text) => Regex.Replace(text, "[^0-9]", "");
}
