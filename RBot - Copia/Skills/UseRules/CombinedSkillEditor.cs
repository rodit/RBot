using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms.Design;

namespace RBot.Skills.UseRules;

public class CombinedSkillEditor : UITypeEditor
{
    public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
    {
        return UITypeEditorEditStyle.Modal;
    }

    public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
    {
        CombinedUseRule rule = value as CombinedUseRule;
        bool flag = provider.GetService(typeof(IWindowsFormsEditorService)) is IWindowsFormsEditorService svc && rule != null;
        if (flag)
        {
            using SkillRuleForm form = new();
            form.Edit = rule;
            form.ShowDialog();
        }
        return value;
    }
}
