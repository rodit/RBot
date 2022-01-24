using System;
using System.Net;

namespace RBot.Utils;

public class RBotWebClient : WebClient
{
    protected override WebRequest GetWebRequest(Uri address)
    {
        HttpWebRequest request = base.GetWebRequest(address) as HttpWebRequest;
        request.UserAgent = "RBot/Scripts";
        return request;
    }
}
