using System;
using System.Net;
using System.Text;

namespace RBot.Utils;

public class GHWebClient : WebClient
{
    public const string ClientID = "726820423be5c752df62";
    public const string ClientSecret = "63b2a5b1a55fbeade88deab3b6c8914808bad7a6";

    private string _authString = Convert.ToBase64String(Encoding.UTF8.GetBytes(ClientID + ":" + ClientSecret));

    protected override WebRequest GetWebRequest(Uri address)
    {
        HttpWebRequest request = base.GetWebRequest(address) as HttpWebRequest;
        request.UserAgent = "RBot/Scripts";
        request.Headers[HttpRequestHeader.Authorization] = $"Basic {_authString}";
        return request;
    }
}
