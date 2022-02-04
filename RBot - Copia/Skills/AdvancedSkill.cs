using System;

namespace RBot.Skills;

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

    public string SaveString => $"{UseMode} = {ClassName} = {Skills}{(SkillTimeout != -1 ? $" | Timeout:{SkillTimeout}" : "")}";
    public override string ToString() => $"{UseMode} : {ClassName} => {Skills}";
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
