using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using RBot.Flash;
using RBot.Skills;
using RBot.Skills.UseRules;

namespace RBot
{
    public class ScriptSkills : ScriptableObject
    {
        private ISkillProvider _provider;
        private Thread _skillThread;
        private bool _exit;

        /// <summary>
        /// This provider is always used over any set through SetProvider.
        /// </summary>
        public ISkillProvider OverrideProvider { get; set; }
        /// <summary>
        /// The default provider used if no override is set. Calling ScriptSkills#Add will add to this provider.
        /// </summary>
        public SimpleSkillProvider BaseProvider { get; } = new SimpleSkillProvider();
        /// <summary>
        /// Determines whether the skill timer is currently running.
        /// </summary>
        public bool TimerRunning => _skillThread != null;
        /// <summary>
        /// The interval, in milliseconds, at which to use skills, if they are available.
        /// </summary>
        public int SkillTimer { get; set; } = 100;
        /// <summary>
        /// The timeout in multiples of SkillTimer milliseconds before skipping the current unavailable skill when using SkillMode.Wait.
        /// </summary>
        public int SkillTimeout { get; set; } = -1;

        public ScriptSkills()
        {
            _provider = BaseProvider;
        }

        /// <summary>
        /// Starts the skill timer which uses the registered skills at the set interval. <see cref="P:RBot.ScriptSkills.SkillTimer" />
        /// </summary>
        /// <remarks>The skill timer is automatically stopped (and its thread destroyed) when the bot is stopped.</remarks>
        public void StartTimer()
        {
            if (_skillThread == null)
            {
                _exit = false;
                _provider = OverrideProvider ?? BaseProvider;
                _skillThread = new Thread(_Timer) { Name = "Skill Timer" };
                _skillThread.Start();
            }
        }

        /// <summary>
        /// Stops the skill timer.
        /// </summary>
        public void StopTimer()
        {
            _exit = true;
            _provider?.Stop(Bot);
            _skillThread?.Join(1000);
            if (_skillThread?.IsAlive ?? false)
                _skillThread.Abort();
            _skillThread = null;
        }

        /// <summary>
        /// Sets the current skill provider.
        /// </summary>
        /// <param name="provider"></param>
        public void SetProvider(ISkillProvider provider)
        {
            _provider = provider;
        }

        /// <summary>
        /// Registers the specified skill to be used by the timer.
        /// </summary>
        /// <param name="index">The index of the skill to be added to the timer. This ranges from 1 to 4.</param>
        /// <param name="useThresh">The threshhold in which the skill should be used. This is a value representing the ratio between the player's current health and maximum health. A useThresh of 0.8 would cause the skill to be used when the player's health is below 80%.</param>
        /// <remarks>It is important that skills are not added while the skill timer is running, or a concurrency exception is likely to occur.</remarks>
        public void Add(int index, float useThresh = 1f)
        {
            Add(index, new HealthUseRule(0f, useThresh));
        }

        /// <summary>
        /// Registers the specified skill to be used by the timer with the specified use rule.
        /// </summary>
        /// <param name="index">The index of the skill to add to the timer. This ranges from 1 to 4.</param>
        /// <param name="rule">The rule used to determine whether or not this skill should be used.</param>
        public void Add(int index, UseRule rule)
        {
            if (index > 0 && index < 5)
            {
                BaseProvider.Skills.Add(new SimpleSkill()
                {
                    Index = index,
                    Rule = rule
                });
            }
        }

        /// <summary>
        /// Removes a skill from the skill timer.
        /// </summary>
        /// <param name="index">The index of the skill to be removed from the timer. This ranges from 1 to 4.</param>
        /// <remarks>It is important that skills are not removed while the skill timer is running, or a concurrency exception is likely to occur.</remarks>
        public void Remove(int index)
        {
            BaseProvider.Skills.RemoveAll(x => x.Index == index);
        }

        /// <summary>
        /// Clears all skills from the skill timer.
        /// </summary>
        /// <remarks>It is important that skills are not cleared while the skill timer is running, or a concurrency exception is likely to occur.</remarks>
        public void Clear()
        {
            BaseProvider.Skills.Clear();
        }

        /// <summary>
        /// Sets the current skill provider to the base provider and restarts the skill timer.
        /// </summary>
        public void UseBaseProvider()
        {
            StopTimer();
            OverrideProvider = BaseProvider;
            StartTimer();
        }

        /// <summary>
        /// Loads skills from the specified skills xml file.
        /// </summary>
        /// <param name="xml">The skill definition file path.</param>
        public void LoadSkills(string xml)
        {
            OverrideProvider = new SimpleSkillProvider();
            OverrideProvider.Load(xml);
        }

        /// <summary>
        /// Loads the specified skill definition file and restarts the skill timer.
        /// </summary>
        /// <param name="xml">The skill definition file path.</param>
        public void StartSkills(string xml)
        {
            StopTimer();
            LoadSkills(xml);
            StartTimer();
        }

        /// <summary>
        /// Loads skills from the specified skill pattern definition file.
        /// </summary>
        /// <param name="def">The skill pattern definition file path.</param>
        public void LoadPattern(string def)
        {
            OverrideProvider = new PatternSkillProvider();
            OverrideProvider.Load(def);
        }

        /// <summary>
        /// Loads the specified skill pattern definition file and restarts the skill timer.
        /// </summary>
        /// <param name="def">The skill pattern definition file path.</param>
        public void StartPattern(string def)
        {
            StopTimer();
            LoadPattern(def);
            StartTimer();
        }

        private void _Timer()
        {
            while (!_exit)
            {
                if (Bot.Player.HasTarget)
                    _Poll();
                _provider?.OnTargetReset(Bot);
                Thread.Sleep(SkillTimer);
            }
        }

        private void _Poll()
        {
            if (_provider?.ShouldUseSkill(Bot) ?? false)
            {
                int skill = _provider.GetNextSkill(Bot, out SkillMode mode);
                switch (mode)
                {
                    case SkillMode.Optimistic:
                        Bot.Player.UseSkill(skill);
                        break;
                    case SkillMode.Wait:
                        Bot.Wait.ForTrue(() => Bot.Player.CanUseSkill(skill), SkillTimeout, SkillTimer);
                        Bot.Player.UseSkill(skill);
                        break;
                }
            }
        }
    }
}
