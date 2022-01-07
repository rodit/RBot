using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using CoreHook;

namespace RBot.PatchProxy
{
    public class WinINetProxyHook
    {
        private static LocalHook _hook;

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr InternetOpen(string lpszAgent, int dwAccessType, string lpszProxyName, string lpszProxyBypass, int dwFlags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true)]
        private delegate IntPtr InternetOpenDelegate(string lpszAgent, int dwAccessType, string lpszProxyName, string lpszProxyBypass, int dwFlags);

        private static IntPtr InternetOpenHooked(string lpszAgent, int dwAccessType, string lpszProxyName, string lpszProxyBypass, int dwFlags)
        {
            return InternetOpen(lpszAgent, (int)WINHTTP_ACCESS_TYPES.WINHTTP_ACCESS_TYPE_NAMED_PROXY, $"http://localhost:{RProxyServer.Instance.Port}", null, (dwFlags & -129 & -65537) | 67108864);
        }

        public static void Hook()
        {
            IntPtr dummy = InternetOpen("browser", (int)WINHTTP_ACCESS_TYPES.WINHTTP_ACCESS_TYPE_NAMED_PROXY, null, null, 0);
            _hook = LocalHook.Create(LocalHook.GetProcAddress("wininet.dll", "InternetOpenW"), new InternetOpenDelegate(InternetOpenHooked), null);
            _hook.ThreadACL.SetInclusiveACL(new int[1]);
        }

        public static void Unhook()
        {
            _hook.Dispose();
        }

        public enum WINHTTP_ACCESS_TYPES : int
        {
            WINHTTP_ACCESS_TYPE_DEFAULT_PROXY,
            WINHTTP_ACCESS_TYPE_NO_PROXY,
            WINHTTP_ACCESS_TYPE_NAMED_PROXY = 3
        }
    }
}
