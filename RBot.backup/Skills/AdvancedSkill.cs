using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot.Skills
{
    public class AdvancedSkill
    {
        public AdvancedSkill(string className, string skills, int skillTimeout = -1, string useMode = "Base")
        {
            ClassName = className;
            Skills = skills;
            SkillTimeout = skillTimeout;
            UseMode = (ClassUseMode)Enum.Parse(typeof(ClassUseMode), useMode);
        }

        public string ClassName { get; set; } = "Generic";
        public string Skills { get; set; } = "1 | 2 | 3 | 4 | Mode Optimistic";
        public int SkillTimeout { get; set; } = -1;
        public ClassUseMode UseMode { get; set; } = ClassUseMode.Base;

        public override string ToString() => $"{ClassName} => {Skills}";
    }

    public enum ClassUseMode
    {
        Base,
        Atk,
        Def,
        Farm,
        Solo,
        Supp
    }
}
