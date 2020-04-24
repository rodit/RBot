using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Dynamic;
using System.Diagnostics;

using AxShockwaveFlashObjects;
using System.Security;

using RBot.Utils;

namespace RBot.Flash
{
    public delegate void FlashCallHandler(AxShockwaveFlash flash, string function, params object[] args);
    public delegate void FlashErrorHandler(AxShockwaveFlash flash, Exception e, string function, params object[] args);

    public class FlashUtil
    {
        public static AxShockwaveFlash Flash;

        public static event FlashCallHandler FlashCall;
        public static event FlashErrorHandler FlashError;

        public static string Call(string function, params object[] args)
        {
            return Call<string>(function, args);
        }

        public static T Call<T>(string function, params object[] args)
        {
            try
            {
                return (T)Call(function, typeof(T), args);
            }
            catch
            {
                return default;
            }
        }

        public static object Call(string function, Type type, params object[] args)
        {
            try
            {
                StringBuilder req = new StringBuilder().Append($"<invoke name=\"{function}\" returntype=\"xml\">");
                if (args.Length > 0)
                {
                    req.Append("<arguments>");
                    args.ForEach(o => req.Append(ToFlashXml(o)));
                    req.Append("</arguments>");
                }
                req.Append("</invoke>");
                string result = Flash.CallFunction(req.ToString());
                XElement el = XElement.Parse(result);
                return el == null || el.FirstNode == null ? default : Convert.ChangeType(el.FirstNode.ToString(), type);
            }
            catch (Exception e)
            {
                FlashError?.Invoke(Flash, e, function, args);
                return default;
            }
        }

        public static string ToFlashXml(object o)
        {
            switch (o)
            {
                case null:
                    return "<null/>";
                case bool _:
                    return $"<{o.ToString().ToLower()}/>";
                case double _:
                case float _:
                case long _:
                case int _:
                    return $"<number>{o}</number>";
                case ExpandoObject _:
                    StringBuilder sb = new StringBuilder().Append("<object>");
                    foreach (KeyValuePair<string, object> kvp in o as IDictionary<string, object>)
                        sb.Append($"<property id=\"{kvp.Key}\">{ToFlashXml(kvp.Value)}</property>");
                    return sb.Append("</object>").ToString();
                default:
                    if (o is Array)
                    {
                        StringBuilder _sb = new StringBuilder().Append("<array>");
                        int k = 0;
                        foreach (object el in o as Array)
                            _sb.Append($"<property id=\"{k++}\">{ToFlashXml(el)}</property>");
                        return _sb.Append("</array>").ToString();
                    }
                    return $"<string>{SecurityElement.Escape(o.ToString())}</string>";
            }
        }

        public static object FromFlashXml(XElement el)
        {
            switch (el.Name.ToString())
            {
                case "number":
                    return int.TryParse(el.Value, out int i) ? i : float.TryParse(el.Value, out float f) ? f : 0;
                case "true":
                    return true;
                case "false":
                    return false;
                case "null":
                    return null;
                case "array":
                    return el.Elements().Select(e => FromFlashXml(e)).ToArray();
                case "object":
                    dynamic d = new ExpandoObject();
                    el.Elements().ForEach(e => d[e.Attribute("id").Value] = FromFlashXml(e.Elements().First()));
                    return d;
                default:
                    return el.Value;
            }
        }

        public static void CallHandler(object sender, _IShockwaveFlashEvents_FlashCallEvent e)
        {
            XElement el = XElement.Parse(e.request);
            string name = el.Attribute("name").Value;
            object[] args = el.Elements().Select(x => FromFlashXml(x)).ToArray();
            FlashCall?.Invoke(Flash, name, args);
        }
    }
}
