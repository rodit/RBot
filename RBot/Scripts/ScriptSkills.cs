using RBot.Flash;
using RBot.Skills;
using RBot.Skills.UseRules;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

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
            BaseProvider.Load("Skills/Generic.xml");
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

        /// <summary>
        /// Loads the specified skills of the desired class name from AdvancedSkills.txt and restarts the skill timer.
        /// </summary>
        /// <param name="className">Name of the class to use</param>
        /// <param name="autoEquip">Whether to equip the class, useful if you want to use multiple skill sets for 1 class</param>
        /// <param name="useMode">Some classes can have different use modes: <br></br>
        /// <see cref="ClassUseMode.Base"/> - Default combo; <br></br>
        /// <see cref="ClassUseMode.Atk"/>  - Full damage combo; <br></br>
        /// <see cref="ClassUseMode.Def"/>  - Defensive combo; <br></br>
        /// <see cref="ClassUseMode.Farm"/> - Farming combo; <br></br>
        /// <see cref="ClassUseMode.Solo"/> - Soloing combo; <br></br>
        /// <see cref="ClassUseMode.Supp"/> - Support combo; </param>
        /// <remarks>If skills from the desired class doesn't exist, generic skills will be used instead.</remarks>
        public void StartAdvanced(string className, bool autoEquip, ClassUseMode useMode = ClassUseMode.Base)
        {
            StopTimer();
            LoadAdvanced(className, autoEquip, useMode);
            StartTimer();
        }

        /// <summary>
        /// Loads the specified skills from the string and restarts the skill timer.
        /// </summary>
        /// <param name="skills">String of the skills (Use the Skills > Advanced and convert the desired skill sequence)</param>
        /// <param name="skillTimeout">The timeout in multiples of SkillTimer milliseconds before skipping the current unavailable skill when using SkillMode.Wait.</param>
        public void StartAdvanced(string skills, int skillTimeout = -1)
        {
            StopTimer();
            LoadAdvanced(skills, skillTimeout);
            StartTimer();
        }

        /// <summary>
        /// Loads the specified skills of the desired class name from AdvancedSkills.txt.
        /// </summary>
        /// <param name="className">Name of the class to use</param>
        /// <param name="autoEquip">Whether to equip the class, useful if you want to use multiple skill sets for 1 class.</param>
        /// <param name="useMode">Some classes can have different use modes: <br></br>
        /// <see cref="ClassUseMode.Base"/> - Default combo; <br></br>
        /// <see cref="ClassUseMode.Atk"/>  - Full damage combo; <br></br>
        /// <see cref="ClassUseMode.Def"/>  - Defensive combo; <br></br>
        /// <see cref="ClassUseMode.Farm"/> - Farming combo; <br></br>
        /// <see cref="ClassUseMode.Solo"/> - Soloing combo; <br></br>
        /// <see cref="ClassUseMode.Supp"/> - Support combo; </param>
        /// <remarks>If skills from the desired class doesn't exist, generic skills will be used instead.</remarks>
        public void LoadAdvanced(string className, bool autoEquip, ClassUseMode useMode = ClassUseMode.Base)
        {
            OverrideProvider = new AdvancedSkillProvider();
            if (autoEquip)
                Bot.Player.EquipItem(className);
            List<AdvancedSkill> skills = Forms.AdvancedSkills.LoadedSkills?.Where(s => s.ClassName.ToLower() == className.ToLower()).ToList();
            if (skills == null || skills.Count == 0)
            {
                OverrideProvider.Load("1 | 2 | 3 | 4 | Mode Optimistic");
                SkillTimeout = -1;
            }
            else
            {
                AdvancedSkill skill = skills.Find(s => s.UseMode == useMode) ?? skills.FirstOrDefault();
                OverrideProvider.Load(skill.Skills);
                SkillTimeout = skill.SkillTimeout;
            }
        }

        /// <summary>
        /// Loads the specified skill sequence.
        /// </summary>
        /// <param name="skills">String of the skills (Use the Skills > Advanced and convert the desired skill sequence)</param>
        /// <param name="skillTimeout">The timeout in multiples of SkillTimer milliseconds before skipping the current unavailable skill when using SkillMode.Wait.</param>
        public void LoadAdvanced(string skills, int skillTimeout = -1)
        {
            OverrideProvider = new AdvancedSkillProvider();
            SkillTimeout = skillTimeout;
            OverrideProvider.Load(skills);
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

        private int _lastRank = -1;
        private SkillInfo[] _lastSkills;
        private void _Poll()
        {
            int rank = Bot.Player.Rank;
            if (rank > _lastRank && _lastRank != -1)
            {
                using (FlashArray<object> skills = FlashObject<object>.Create("world.actions.active").ToArray())
                {
                    int k = 0;
                    foreach (FlashObject<object> skill in skills)
                    {
                        using (FlashObject<long> ts = skill.GetChild<long>("ts"))
                            ts.Value = _lastSkills[k++].LastUse;
                    }
                }
            }
            _lastRank = rank;
            _lastSkills = Bot.Player.Skills;
            if (_provider?.ShouldUseSkill(Bot) == true)
            {
                int skill = _provider.GetNextSkill(Bot, out SkillMode mode);
                switch (mode)
                {
                    case SkillMode.Optimistic:
                        if (Bot.Player.CanUseSkill(skill))
                            Bot.Player.UseSkill(skill);
                        break;
                    case SkillMode.Wait:
                        if (skill != -1)
                        {
                            Bot.Wait.ForTrue(() => Bot.Player.CanUseSkill(skill), SkillTimeout, SkillTimer);
                            Bot.Player.UseSkill(skill);
                        }
                        break;
                }
            }
            else if (_provider?.ShouldUseSkill(Bot) == null)
                _provider.GetNextSkill(Bot, out SkillMode mode);
        }
    }
}
