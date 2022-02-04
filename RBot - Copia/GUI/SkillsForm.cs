using System;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using RBot.Skills;
using RBot.Skills.UseRules;
using RBot.Utils;

namespace RBot
{
    public partial class SkillsForm : HideForm
    {
        public SimpleSkillProvider Current { get; set; } = new SimpleSkillProvider();

        public SkillsForm()
        {
            InitializeComponent();
        }

        public void LoadSkills(string file)
        {
            Current.Load(file);
            lbSkills.Items.Clear();
            lbSkills.Items.AddRange(Current.Skills.ToArray());
            numDelay.Value = Current.Delay;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new();
            ofd.Filter = "Skill Definitions (*.xml)|*.xml";
            ofd.InitialDirectory = Path.Combine(Environment.CurrentDirectory, "Skills");
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                LoadSkills(ofd.FileName);
                Bot.Skills.OverrideProvider = Current;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using SaveFileDialog sfd = new();
            sfd.Filter = "Skill Definitions (*.xml)|*.xml";
            sfd.InitialDirectory = Path.Combine(Environment.CurrentDirectory, "Skills");
            if (sfd.ShowDialog() == DialogResult.OK)
                Current.Save(sfd.FileName);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int selected = lbSkills.SelectedIndex;
            int up = selected - 1;
            if (up > -1)
            {
                Current.Skills.Swap(selected, up);
                object swap = lbSkills.SelectedItem;
                lbSkills.Items.Remove(swap);
                lbSkills.Items.Insert(up, swap);
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int selected = lbSkills.SelectedIndex;
            int down = selected + 1;
            if (selected > -1 && down < lbSkills.Items.Count)
            {
                Current.Skills.Swap(selected, down);
                object swap = lbSkills.SelectedItem;
                lbSkills.Items[selected] = lbSkills.Items[down];
                lbSkills.Items[down] = swap;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Current.Skills.Clear();
            lbSkills.Items.Clear();
        }

        private void btnEditUseRule_Click(object sender, EventArgs e)
        {
            if (lbSkills.SelectedItem is SimpleSkill skill && skill.Rule is CombinedUseRule)
            {
                using SkillRuleForm srf = new()
                {
                    Edit = (CombinedUseRule)skill.Rule
                };
                srf.ShowDialog();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbSkills.SelectedIndex > -1)
            {
                Current.Skills.RemoveAt(lbSkills.SelectedIndex);
                lbSkills.Items.RemoveAt(lbSkills.SelectedIndex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbSkills.SelectedItem is SkillInfo info)
            {
                SimpleSkill skill = new()
                {
                    Index = Array.FindIndex(Bot.Player.Skills, x => x.ID == info.ID),
                    Rule = new CombinedUseRule()
                };
                Current.Skills.Add(skill);
                lbSkills.Items.Add(skill);
            }
        }

        private void numDelay_ValueChanged(object sender, EventArgs e)
        {
            Current.Delay = (int)numDelay.Value;
        }

        private void SkillsForm_Load(object sender, EventArgs e)
        {
            lnkRefreshSkills_LinkClicked(null, null);
        }

        private void lnkRefreshSkills_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SkillInfo[] skills = Bot.Player.Skills;
            if (skills != null)
            {
                cbSkills.Items.Clear();
                cbSkills.Items.AddRange(Bot.Player.Skills.Skip(1).Take(4).ToArray());
                cbSkills.SelectedIndex = 0;
            }
        }
    }
}
