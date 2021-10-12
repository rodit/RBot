using CodegenCS;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RBot.BotConverters.Grimoire.Commands;
using RBot.BotConverters.Grimoire.Commands.IfStatements;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace RBot.BotConverters.Grimoire
{
    public class GrimoireConverter : IBotConverter
    {
        private const string DefaultImports = @"using System;
using System.Collections.Generic;
using RBot;
using RBot.Options;";

        private const string IndexType = "Grimoire.Botting.Commands.Misc.CmdIndex";

        private const string OptionsReplace = "$$$ OPTIONS $$$";

        private const string OptionDescription = "Grim variable.";

        private readonly Dictionary<string, Type> _generators = new Dictionary<string, Type>();

        public GrimoireConverter()
        {
            foreach (var type in typeof(GrimoireConverter).Assembly.GetTypes().Where(t => !t.IsInterface && t.GetInterface(nameof(ICodeGenerator)) != null))
            {
                AddGenerator(type);
            }
        }

        public void AddGenerator(Type type)
        {
            var attrib = type.GetCustomAttribute<MapAttribute>();
            if (attrib != null)
            {
                foreach (var cls in attrib.Types)
                {
                    AddGenerator(cls, type);
                }
            }
        }

        public void AddGenerator(string commandClass, Type type)
        {
            _generators.Add(commandClass, type);
        }

        public string Convert(string path)
        {
            FieldExtensions.Variables.Clear();

            var bot = JObject.Parse(File.ReadAllText(path));
            var fileName = Path.GetFileNameWithoutExtension(path);
            var author = bot["Author"]?.ToObject<string>() ?? "Unknown";

            var commands = (bot["Commands"]?["$values"] as JArray ?? new JArray()).OfType<JObject>().ToList();
            var index = 0;
            var indexRefs = new List<int>();
            foreach (var command in commands)
            {
                if (command.TryGetValue("$type", out var type) && type.ToString().StartsWith(IndexType)
                                                               && command.TryGetValue("Index", out var indexToken))
                {
                    var indexType = command["Type"]?.ToString() ?? "0";
                    var idx = indexToken.ToObject<int>();

                    var refIndex = indexType switch
                    {
                        "0" => index - idx - 1,
                        "1" => index + idx - 1,
                        "2" => idx - 1,
                        _ => -1
                    };
                    command["AbsIndex"] = JToken.Parse(refIndex.ToString());
                    if (refIndex >= 0 && refIndex < commands.Count)
                    {
                        indexRefs.Add(refIndex);
                    }
                }

                index++;
            }

            using var code = new CodegenTextWriter()
                .WriteLine($"// Converted from {fileName}")
                .WriteLine($"// Author: {author}")
                .WriteLine($"// Description: {bot["Description"] ?? "None"}")
                .WriteLine()
                .WriteLine(DefaultImports)
                .WithCBlock("public class Script", gen => gen
                    .WriteLine($"public string OptionsStorage = \"{author}_{fileName}\";")
                    .WriteLine("public bool DontPreconfigure = true;")
                    .DecreaseIndent()
                    .WriteLine(OptionsReplace)
                    .IncreaseIndent()
                    .WriteLine()
                    .WithCBlock("public void ScriptMain(ScriptInterface bot)", main =>
                    {
                        main.WriteOption<bool>("SafeTimings", true)
                            .WriteOption<bool>("RestPackets", true)
                            .WriteOption<bool>("ExitCombatBeforeQuest", bot["ExitCombatBeforeQuest"])
                            .WriteOption<bool>("InfiniteRange", bot["InfiniteAttackRange"])
                            .WriteOption<bool>("SkipCutscenes", bot["SkipCutscenes"]);

                        var serializer = new JsonSerializer { MetadataPropertyHandling = MetadataPropertyHandling.Ignore };
                        var defaultGeneratorType = _generators["*"];
                        var commandIndex = -1;
                        var ifStack = 0;
                        var postIfGenerators = new List<ICodeGenerator>();
                        foreach (var command in commands)
                        {
                            var grimType = (command["$type"] ?? string.Empty).ToString().Split(',')[0];
                            var generatorType = _generators.TryGetValue(grimType, out var type) ? type : defaultGeneratorType;
                            var generator = (ICodeGenerator)command.ToObject(generatorType, serializer);

                            if (indexRefs.Contains(commandIndex))
                            {
                                main.WriteLine($"idx_{commandIndex}:");
                            }

                            var ifStatement = generator is IfStatement;
                            if (ifStatement)
                            {
                                ifStack++;
                                generator.GenerateCode(main);
                                main.WriteLine()
                                    .WriteLine("{")
                                    .IncreaseIndent();
                            }
                            else
                            {
                                if (ifStack > 0 && generator is Label)
                                {
                                    postIfGenerators.Add(generator);
                                }
                                else
                                {
                                    generator!.GenerateCode(main);
                                    if (ifStack > 0)
                                    {
                                        ifStack--;
                                        main.DecreaseIndent()
                                            .WriteLine("}");

                                        if (ifStack == 0)
                                        {
                                            postIfGenerators.ForEach(g => g.GenerateCode(main));
                                            postIfGenerators.Clear();
                                        }
                                    }
                                }
                            }

                            commandIndex++;
                        }
                    }));

            using var options = new CodegenTextWriter();
            if (FieldExtensions.Variables.Count > 0)
            {
                options.IncreaseIndent()
                    .WithCBlock("public List<IOption> Options = new List<IOption>()", block =>
                    {
                        var variables = FieldExtensions.Variables;
                        for (var i = 0; i < variables.Count; i++)
                        {
                            var variable = variables[i];
                            block.WriteLine($"new Option<{variable.Type}>(\"{variable.Name.ToLower().Replace(" ", "_")}\", \"{variable.Name}\", \"{OptionDescription}\")"
                                            + (i == variables.Count - 1 ? string.Empty : ","));
                        }
                    }).Write(";");
            }

            return code.GetContents().Replace(OptionsReplace, options.GetContents()).FixIndices();
        }
    }

    public static class CodeExtensions
    {
        public static string FixIndices(this string contents)
        {
            return Regex.Replace(contents, @"( *)(if \(.*\))\s+{\s+(idx_.*:)", m =>
            {
                var space = m.Groups[1].Value;
                var ifStatement = m.Groups[2].Value;
                var label = m.Groups[3].Value;
                return $"{space}{label}\n{space}{ifStatement}\n{space}{{";
            });
        }

        public static CodegenTextWriter WriteOption<T>(this CodegenTextWriter code, string optionName, JToken value)
        {
            if (value != null)
            {
                try
                {
                    var val = value.ToObject<T>();
                    if (val is string)
                    {
                        code.WriteLine($"bot.Options.{optionName} = \"{value}\";");
                    }
                    else
                    {
                        code.WriteLine($"bot.Options.{optionName} = {value.ToString().ToLower()};");
                    }
                }
                catch
                {
                    // ignored
                }
            }

            return code;
        }
    }
}
