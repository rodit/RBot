namespace RBot.BotConverters
{
    public static class Extensions
    {
        public static string ToLower(this bool b)
        {
            return b.ToString().ToLower();
        }
    }
}