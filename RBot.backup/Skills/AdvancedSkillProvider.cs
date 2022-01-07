using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace RBot.Skills
{
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
			string[] commands = skills.ToLower().Trim().Split('|');
			foreach (string command in commands)
			{
				if (command.Contains("reset"))
				{
					if (command.Contains("true"))
						ResetOnTarget = true;
				}
				else if (command.Contains("mode"))
				{
					if (command.Contains("opt"))
						Mode = SkillMode.Optimistic;
				}
				else if (command.Contains("timeout"))
					continue;
				else
				{
					int.TryParse(command.Trim().Substring(0, 1), out int skill);
					string useRules;
					if (command.Trim().Length <= 1)
						useRules = "";
					else
						useRules = command.Substring(2).Trim();

					Root.Skills.Add(skill);
					Root.UseRule.Add(useRules);
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
			bool skip = UseRule[_Index].Contains("s");
			foreach (string useRule in useRules)
			{
				int.TryParse(RemoveLetters(useRule), out int result);
				if (useRule.Contains("h"))
				{
					if (result > 100)
						result = 100;
					if (useRules.Contains(">"))
						shouldUse = HealthUseRule(bot, true, result);
					else
						shouldUse = HealthUseRule(bot, false, result);
				}
				else if (useRule.Contains("m"))
				{
					if (result > 100)
						result = 100;
					if (useRules.Contains(">"))
						shouldUse = ManaUseRule(bot, true, result);
					else
						shouldUse = ManaUseRule(bot, false, result);
				}
				else if (useRule.Contains("w"))
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
			float ratio = (float)bot.Player.Health / (float)bot.Player.MaxHealth * 100.0f;
			if (greater)
				return health >= ratio;
			return health <= ratio;
		}

		private bool ManaUseRule(ScriptInterface bot, bool greater, int mana)
		{
			if (greater)
				return bot.Player.Mana >= mana;
			return bot.Player.Mana <= mana;
		}

		private void WaitUseRule(ScriptInterface bot, int time) => Thread.Sleep(time);

		public void Reset() => _Index = 0;
	}
}
