using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace RBot.Skills;

internal class AdvancedSkillProvider : ISkillProvider
{
    public bool CanSerialize { get; } = true;
    public AdvancedSkillCommand Root { get; set; } = new AdvancedSkillCommand();
    public bool ResetOnTarget { get; set; } = false;
    public SkillMode Mode { get; set; } = SkillMode.Wait;

    public int GetNextSkill(ScriptInterface bot, out SkillMode mode)
    {
        mode = Mode;
        return Root.GetNextSkill(bot);
    }

    public void Load(string skills)
    {
        foreach (string command in skills.ToLower().Split('|').Select(s => s.Trim()).ToList())
        {
            if (command.Contains("reset") && command.Contains("true"))
                ResetOnTarget = true;
            else if (command.Contains("mode") && command.Contains("opt"))
                Mode = SkillMode.Optimistic;
            else if (command.Contains("timeout"))
                continue;
            else
            {
                if(int.TryParse(command.AsSpan(0, 1).ToString(), out int skill))
                {
                    Root.Skills.Add(skill);
                    Root.UseRule.Add(command.Length <= 1 ? "" : command[1..]);
                }
            }
        }
    }

    public void Save(string file)
    {

    }

    public void OnTargetReset(ScriptInterface bot)
    {
        if (ResetOnTarget && !bot.Player.HasTarget)
            Root.Reset();
    }
    public bool? ShouldUseSkill(ScriptInterface bot) => Root.ShouldUse(bot);
    public void Stop(ScriptInterface bot) => Root.Reset();
}

public class AdvancedSkillCommand
{
    public List<int> Skills { get; set; } = new List<int>();
    public List<string> UseRule { get; set; } = new List<string>();

    private int _Index = 0;

    public int GetNextSkill(ScriptInterface bot)
    {
        int skill = Skills[_Index];
        _Index++;
        if (_Index >= Skills.Count)
            _Index = 0;

        return skill;
    }

    public bool? ShouldUse(ScriptInterface bot)
    {
        if (string.IsNullOrWhiteSpace(UseRule[_Index]))
            return true;
        string[] useRules = UseRule[_Index].Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
        bool shouldUse = true;
        bool skip = UseRule[_Index].Contains('s');
        foreach (string useRule in useRules)
        {
            if(!bot.Player.Alive)
                return false;
            if (!int.TryParse(RemoveLetters(useRule), out int result))
                return true;
            if (result > 100)
                result = 100;

            if (useRule.Contains('h'))
            {
                shouldUse = useRule.Contains('>') ? HealthUseRule(bot, true, result) : HealthUseRule(bot, false, result);
            }
            else if (useRule.Contains('m'))
            {
                shouldUse = useRule.Contains('>') ? ManaUseRule(bot, true, result) : ManaUseRule(bot, false, result);
            }
            else if (useRule.Contains('w'))
                WaitUseRule(bot, result);

            if (skip && !shouldUse)
                return null;
            if (!shouldUse)
                break;
        }
        return shouldUse;
    }

    private string RemoveLetters(string userule) => Regex.Replace(userule, "[^0-9.]", "");

    private bool HealthUseRule(ScriptInterface bot, bool greater, int health)
    {
        if(bot.Player.Health == 0 || bot.Player.MaxHealth == 0)
            return false;
        int ratio = (int)(bot.Player.Health / (double)bot.Player.MaxHealth * 100.0);
        return greater ? ratio >= health : ratio <= health;
    }

    private bool ManaUseRule(ScriptInterface bot, bool greater, int mana)
    {
        return greater ? bot.Player.Mana >= mana : bot.Player.Mana <= mana;
    }

    private void WaitUseRule(ScriptInterface bot, int time) => Thread.Sleep(time);

    public void Reset() => _Index = 0;
}
