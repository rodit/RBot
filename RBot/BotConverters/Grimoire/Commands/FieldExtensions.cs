using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RBot.BotConverters.Grimoire.Commands
{
    public static class FieldExtensions
    {
        private static readonly Dictionary<string, GrimVariable> _variables = new Dictionary<string, GrimVariable>();

        public static List<GrimVariable> Variables => _variables.Values.ToList();

        public static void Reset()
        {
            _variables.Clear();
        }

        public static string ToLabel(this string label)
        {
            return Regex.Replace(label.Replace(" ", "_"), "[^a-zA-Z0-9_]", "") + "_" + Math.Abs(label.GetHashCode());
        }

        public static bool IsVar(this string str)
        {
            return Regex.IsMatch(str, @"\[([^\)]*)\]");
        }

        public static string GetCode(this object field, string varType = "string", bool forceVar = false)
        {
            if (field is string str)
            {
                if (str.IsVar() || forceVar)
                {
                    var varName = forceVar ? str : Regex.Replace(str, @"[\[\]']+", "");
                    _variables[varName] = new GrimVariable { Name = varName, Type = varType };
                    return $"bot.Config.Get<{varType}>(\"{varName.ToLower().Replace(" ", "_")}\")";
                }

                switch (varType)
                {
                    case "string":
                        return $"\"{field}\"";
                    case "int" when str == "*":
                        return "1";
                }
            }

            return field.ToString();
        }
    }
}
