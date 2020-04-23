using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot.Skills
{
    public interface ISkillProvider
    {
        /// <summary>
        /// Indicates if this skill provider can be saved to a file.
        /// </summary>
        bool CanSerialize { get; }

        /// <summary>
        /// This method should return true if the bot should attempt to use a skill at the given time.
        /// </summary>
        /// <returns>Whether or not the bot should attempt to use a skill.</returns>
        bool ShouldUseSkill(ScriptInterface bot);
        /// <summary>
        /// This method should return the index of the next skill the bot should try and use. The mode parameter should be set to indicate how the skill should be used.
        /// </summary>
        /// <param name="mode">The mode that the skill should be used in.</param>
        /// <returns>The index of the skill to be used.</returns>
        int GetNextSkill(ScriptInterface bot, out SkillMode mode);
        /// <summary>
        /// This method is called when the target is reset/changed.
        /// </summary>
        void OnTargetReset(ScriptInterface bot);
        /// <summary>
        /// This method is called when the skill timer is stopped.
        /// </summary>
        void Stop(ScriptInterface bot);
        /// <summary>
        /// Loads this skill provider from the given file.
        /// </summary>
        /// <param name="file">The file to load this provider from.</param>
        void Load(string file);
        /// <summary>
        /// Saves this skill provider to the given file.
        /// </summary>
        /// <param name="file">The file to save this provider to.</param>
        void Save(string file);
    }

    public enum SkillMode
    {
        /// <summary>
        /// Assumes the skill is used when it should be.
        /// </summary>
        Optimistic,
        /// <summary>
        /// Waits for the skill to be available before using it.
        /// </summary>
        Wait
    }
}
