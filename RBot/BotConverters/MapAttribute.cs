using System;

namespace RBot.BotConverters
{
    [AttributeUsage(AttributeTargets.Class)]
    public class MapAttribute : Attribute
    {
        public string[] Types { get; set; }

        public MapAttribute(params string[] types)
        {
            Types = types;
        }
    }
}
