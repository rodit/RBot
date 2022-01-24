using Newtonsoft.Json;

namespace RBot;

public class ScriptableObject
{
    [JsonIgnore]
    internal static ScriptInterface Bot => ScriptInterface.Instance;

    internal static void CheckScriptTermination() => ScriptManager.ScriptCTS?.Token.ThrowIfCancellationRequested();
}
