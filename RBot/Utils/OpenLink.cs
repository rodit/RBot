using System.Diagnostics;

namespace RBot.Utils;

public class OpenLink
{
    public static void OpenBrowserLink(string link)
    {
        var ps = new ProcessStartInfo("explorer", link)
        {
            UseShellExecute = true,
            Verb = "open"
        };
        Process.Start(ps);
    }
}
