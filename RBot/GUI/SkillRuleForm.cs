using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RBot.Skills.UseRules;

namespace RBot
{
    public partial class SkillRuleForm : Form
    {
        private static List<Type> _ruleTypes = new List<Type>
        {
            typeof(HealthUseRule),
            typeof(ManaUseRule),
            typeof(CombinedUseRule)
        };

        public CombinedUseRule Edit { get; set; }

        public SkillRuleForm()
        {
            InitializeComponent();

            lbRules.SelectedIndexChanged += LbRules_SelectedIndexChanged;
        }

        private void SkillRuleForm_Load(object sender, EventArgs e)
        {
            cbRules.Items.AddRange(_ruleTypes.ToArray());
            lbRules.Items.AddRange(Edit.Rules.ToArray());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Type t = cbRules.SelectedItem as Type;
            if (t != null)
            {
                object o = Activator.CreateInstance(t);
                lbRules.Items.Add(o);
                Edit.Rules.Add((UseRule)o);
                lbRules.SelectedItem = o;
            }
        }

        private void LbRules_SelectedIndexChanged(object sender, EventArgs e)
        {
            propsRule.SelectedObject = lbRules.SelectedItem;
        }

        private void btnEditCombined_Click(object sender, EventArgs e)
        {
            propsRule.SelectedObject = Edit;
        }
    }
}
