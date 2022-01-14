using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace RBot.Skills.UseRules
{
    public class CombinedSkillEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService svc = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;
            CombinedUseRule rule = value as CombinedUseRule;
            bool flag = svc != null && rule != null;
            if (flag)
            {
                using SkillRuleForm form = new();
                form.Edit = rule;
                form.ShowDialog();
            }
            return value;
        }
    }
}
