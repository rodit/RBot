using System;

namespace RBot;

public class ScriptCompileException : Exception
{
    public ScriptCompileException(string error) : base(error) { }
}
