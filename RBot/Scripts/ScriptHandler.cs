using System;

namespace RBot;

public class ScriptHandler
{
    public string Name { get; set; }
    public int Ticks { get; set; }
    public Func<ScriptInterface, bool> Function { get; set; }
}
