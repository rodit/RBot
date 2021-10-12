using RBot.Flash;

namespace RBot
{
    public class ScriptLite : ScriptableObject
    {
        [ObjectBinding("litePreference.data.bDebugger")]
        public bool Debugger { get; set; }

        [ObjectBinding("litePreference.data.bHideUI")]
        public bool HideUI { get; set; }

        [ObjectBinding("litePreference.data.bMonsType")]
        public bool ShowMonsterType { get; set; }

        [ObjectBinding("litePreference.data.bSmoothBG")]
        public bool SmoothBackground { get; set; }

        [ObjectBinding("litePreference.data.bUntargetSelf")]
        public bool UntargetSelf { get; set; }

        [ObjectBinding("litePreference.data.bUntargetDead")]
        public bool UntargetDead { get; set; }

        [ObjectBinding("litePreference.data.bDisSkillAnim")]
        public bool DisableSkillAnimations { get; set; }

        [ObjectBinding("litePreference.data.bCustomDrops")]
        public bool CustomDropsUI { get; set; }

        public T Get<T>(string optionName)
        {
            return Bot.GetGameObject<T>($"litePreferences.data.{optionName}");
        }

        public void Set<T>(string optionName, T value)
        {
            Bot.SetGameObject($"litePreferences.data.{optionName}", value);
        }
    }
}