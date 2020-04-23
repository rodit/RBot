using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RBot.Skills
{
    public class PatternSkillProvider : ISkillProvider
    {
        public bool CanSerialize => true;

        /// <summary>
        /// The root command of this pattern skill provider.
        /// </summary>
        public RepeatCommand Root { get; } = new RepeatCommand();
        /// <summary>
        /// If true, the pattern provider will reset when a new monster is targetted. This is true by default.
        /// </summary>
        public bool ResetOnTarget { get; set; } = true;

        public bool ShouldUseSkill(ScriptInterface bot)
        {
            return true;
        }

        public int GetNextSkill(ScriptInterface bot, out SkillMode mode)
        {
            mode = SkillMode.Wait;
            return Root.GetNextSkill(bot);
        }

        public void OnTargetReset(ScriptInterface bot)
        {
            if (ResetOnTarget)
                Root.Reset();
        }

        public void Stop(ScriptInterface bot)
        {
            Root.Reset();
        }

        public void Load(string file)
        {
            Stack<RepeatCommand> stack = new Stack<RepeatCommand>();
            stack.Push(Root);
            foreach (string line in File.ReadLines(file).Select(l => l.Trim().ToLower()))
            {
                string[] parts = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                string cmd = parts[0];
                if (parts.Length == 2)
                {
                    switch (cmd)
                    {
                        case "pattern":
                            stack.Peek().Commands.Add(new PatternCommand() { Skills = parts[1].ToCharArray().Select(c => c - '0').ToArray() });
                            break;
                        case "repeat":
                            RepeatCommand rc = new RepeatCommand()
                            {
                                Count = int.Parse(parts[1])
                            };
                            stack.Peek().Commands.Add(rc);
                            stack.Push(rc);
                            break;
                        case "resetontarget":
                            ResetOnTarget = bool.TryParse(parts[1], out bool b) && b;
                            break;
                    }
                }
                else if (cmd == "end")
                    stack.Pop();
            }
        }

        public void Save(string file)
        {
            using (StreamWriter writer = new StreamWriter(File.OpenWrite(file)))
            {
                writer.WriteLine("resetontarget " + ResetOnTarget);
                _WriteCommands(writer, Root);
            }
        }

        private void _WriteCommands(StreamWriter writer, RepeatCommand root, int indent = 0)
        {
            string pref = new string(Enumerable.Range(0, indent * 4).Select(i => ' ').ToArray());
            foreach (ISkillCommand command in Root.Commands)
            {
                switch (command)
                {
                    case PatternCommand pc:
                        writer.Write(pref + "pattern ");
                        writer.WriteLine(pc.Skills.SelectMany(i => i.ToString()).ToArray());
                        break;
                    case RepeatCommand rc:
                        writer.WriteLine(pref + "repeat " + rc.Count);
                        _WriteCommands(writer, root, indent + 1);
                        writer.WriteLine(pref + "end");
                        break;
                }
            }
        }
    }

    public interface ISkillCommand
    {
        bool Complete { get; }

        int GetNextSkill(ScriptInterface bot);
        void Reset();
    }

    public class PatternCommand : ISkillCommand
    {
        public int[] Skills { get; set; }

        private int _index;

        public bool Complete => _index == Skills.Length;

        public int GetNextSkill(ScriptInterface bot)
        {
            int skill = Skills[_index];
            _index++;
            return skill;
        }

        public void Reset()
        {
            _index = 0;
        }
    }

    public class RepeatCommand : ISkillCommand
    {
        public List<ISkillCommand> Commands { get; } = new List<ISkillCommand>();
        public int Count { get; set; }

        private int _cIndex = 0;
        private int _runs = 0;

        public bool Complete => Count != -1 && _runs >= Count;

        public int GetNextSkill(ScriptInterface bot)
        {
            if(_cIndex >= Commands.Count)
            {
                _cIndex = 0;
                _runs++;
                if (Complete)
                    return -1;
            }

            ISkillCommand command = Commands[_cIndex];
            if (command.Complete)
            {
                command.Reset();
                _cIndex++;
                return GetNextSkill(bot);
            }

            return command.GetNextSkill(bot);
        }

        public void Reset()
        {
            _cIndex = 0;
            _runs = 0;
            Commands.ForEach(c => c.Reset());
        }
    }
}
