using RBot.Skills;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RBot;

public partial class AdvancedSkillForm : HideForm
{
    public List<AdvancedSkill> LoadedSkills { get; set; } = new List<AdvancedSkill>();
    public AdvancedSkillForm()
    {
        InitializeComponent();
        lstSkillSequence.AllowDrop = true;
        LoadSkills();
    }

    private void btnRemoveSkill_Click(object sender, EventArgs e)
    {
        if (lstSavedSkills.SelectedIndex == -1)
            return;

        string path = Path.Combine(Environment.CurrentDirectory, "Skills", "AdvancedSkills.txt");

        List<string> skills = File.ReadAllLines(path).ToList();

        for (int i = skills.Count - 1; i >= 0; i--)
        {
            if (skills[i] == ((AdvancedSkill)lstSavedSkills.SelectedItem).SaveString)
            {
                skills.RemoveAt(i);
                lstSavedSkills.Items.RemoveAt(lstSavedSkills.SelectedIndex);
                break;
            }
        }
        File.WriteAllLines(path, skills);
    }

    private void LoadSkills()
    {
        string path = Path.Combine(Environment.CurrentDirectory, "Skills", "AdvancedSkills.txt");
        lstSavedSkills.Items.Clear();
        LoadedSkills.Clear();

        if (!File.Exists(path))
            return;

        File.ReadAllLines(path).ToList().ForEach(l =>
        {
            string[] parts = l.Split(new[] { '=' }, 3);
            if (parts.Length == 2)
            {
                if (int.TryParse(Regex.Replace(parts[1].Split(':').Last(), "[^0-9.]", ""), out int result))
                    LoadedSkills.Add(new AdvancedSkill(parts[0].Trim(), parts[1].Trim(), result));
                else
                    LoadedSkills.Add(new AdvancedSkill(parts[0].Trim(), parts[1].Trim()));
            }
            else if (parts.Length == 3)
            {
                if (parts[2].Contains("timeout", StringComparison.OrdinalIgnoreCase) && int.TryParse(Regex.Replace(parts[2].Split(':').Last(), "[^0-9.]", ""), out int result))
                    LoadedSkills.Add(new AdvancedSkill(parts[1].Trim(), parts[2].Trim(), result, parts[0].Trim()));
                else
                    LoadedSkills.Add(new AdvancedSkill(parts[1].Trim(), parts[2].Trim(), 1, parts[0].Trim()));
            }
        });
        lstSavedSkills.Items.AddRange(LoadedSkills.ToArray());
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (txtSaveName.Text.Length == 0)
            return;

        if (lstSkillSequence.Items.Count > 0)
            Convert();

        string path = Path.Combine(Environment.CurrentDirectory, "Skills", "AdvancedSkills.txt");
        string mode = cbModes.SelectedIndex == -1 ? "Base" : cbModes.SelectedItem.ToString();
        if (chkOverride.Checked && File.Exists(path))
        {
            List<string> savedSkill = File.ReadAllLines(path).ToList();
            
            int index = savedSkill.FindIndex(l => l.Contains(txtSaveName.Text));
            if (index != -1)
            {
                savedSkill[index] = $"{mode} = {txtSaveName.Text} = {txtSkillString.Text}";
                File.WriteAllLines(path, savedSkill);
            }
            else
                File.AppendAllLines(path, new[] { $"{mode} = {txtSaveName.Text} = {txtSkillString.Text}" });
        }
        else
            File.AppendAllLines(path, new[] { $"{mode} = {txtSaveName.Text} = {txtSkillString.Text}" });
        LoadSkills();
    }

    private List<SkillListBoxObj> ConvertBack(string skillString)
    {
        List<SkillListBoxObj> list = new();
        List<string> skills = skillString.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        bool timeoutChanged = false, modeChanged = false;
        skills.ForEach(s => 
        {
            if (s.Contains("Timeout"))
            {
                int.TryParse(Regex.Replace(s, "[^0-9.]", ""), out int result);
                numSkillTimeout.Value = result;
                timeoutChanged = true;
            }
            else if(s.Contains("Mode"))
            {
                if (s.Trim().Split(' ').Last() == "Optimistic")
                    rbOptMode.Checked = true;                        
                modeChanged = true;
            }
            else
                list.Add(new SkillListBoxObj(s.Trim()));
        });
        if(!timeoutChanged)
            numSkillTimeout.Value = -1;
        if (!modeChanged)
            rbWaitMode.Checked = true;
        return list;
    }

    private void btnConvert_Click(object sender, EventArgs e) => Convert();

    private void Convert()
    {
        txtSkillString.Text = "";
        if (lstSkillSequence.Items.Count != 0 && lstSkillSequence.Items != null)
        {
            foreach (SkillListBoxObj info in lstSkillSequence.Items)
                txtSkillString.Text = $"{txtSkillString.Text}{info.Skill} | ";
            if (rbOptMode.Checked)
                txtSkillString.Text = $"{txtSkillString.Text}Mode Optimistic | ";
            if (numSkillTimeout.Value > 0)
                txtSkillString.Text = $"{txtSkillString.Text}Timeout:{numSkillTimeout.Value} | ";

            txtSkillString.Text = txtSkillString.Text.Substring(0, txtSkillString.Text.Length - 3);
            Clipboard.SetText(txtSkillString.Text);
            btnCopy.Text = "Copied";
        }
    }

    private void numSkillCD_ValueChanged(object sender, EventArgs e)
    {
        int value = (int)(numSkillCD.Value / numSkillTimer.Value);
        numSkillTimeout.Value = value;
    }

    private void btnAddSkill_Click(object sender, EventArgs e)
    {
        SkillListBoxObj info = new SkillListBoxObj(numSkillIndex.Value.ToString());
        if (chkShouldUse.Checked)
        {
            if (numWait.Value != 0)
                info.Skill = $"{info.Skill} WW{numWait.Value}";
            if (numHealth.Value != 0)
                info.Skill = $"{info.Skill} H{lblGreaterHealth.Text}{numHealth.Value}";
            if (numMana.Value != 0)
                info.Skill = $"{info.Skill} M{lblGreaterMana.Text}{numMana.Value}";
            if (chkSkip.Checked)
                info.Skill = $"{info.Skill}S";
        }
        lstSkillSequence.Items.Add(info);
    }

    private void SwitchGreaterSign(object sender, EventArgs e)
    {
        var label = (Label)sender;
        if (label.Text == ">")
            label.Text = "<";
        else
            label.Text = ">";
    }

    private void btnCopy_Click(object sender, EventArgs e)
    {
        Clipboard.SetText(txtSkillString.Text);
        btnCopy.Text = "Copied";
    }

    private void txtSkillString_TextChanged(object sender, EventArgs e)
    {
        if (btnCopy.Text != "Copy")
            btnCopy.Text = "Copy";
    }

    private void lstSkillSequence_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Right)
            return;
        if (lstSkillSequence.SelectedItem == null)
            return;

        lstSkillSequence.DoDragDrop(lstSkillSequence.SelectedItem, DragDropEffects.Move);
    }

    private void lstSkillSequence_DragOver(object sender, DragEventArgs e)
    {
        e.Effect = DragDropEffects.Move;

        ListBox lst = sender as ListBox;

        Point point = lst.PointToClient(new Point(e.X, e.Y));
        lst.SelectedIndex = lst.IndexFromPoint(point);
    }

    private void lstSkillSequence_DragDrop(object sender, DragEventArgs e)
    {
        ListBox lst = sender as ListBox;

        SkillListBoxObj info = (SkillListBoxObj)e.Data.GetData(typeof(SkillListBoxObj));

        Point point = lst.PointToClient(new Point(e.X, e.Y));
        int newIndex = lst.IndexFromPoint(point);

        if (newIndex == -1)
            newIndex = lst.Items.Count - 1;

        lst.Items.Remove(info);
        lst.Items.Insert(newIndex, info);

        lst.SelectedIndex = newIndex;
    }

    private void MoveSkill(int direction)
    {
        if (lstSkillSequence.SelectedItem == null || lstSkillSequence.SelectedIndex < 0)
            return;

        int newIndex = lstSkillSequence.SelectedIndex + direction;

        if (newIndex < 0 || newIndex >= lstSkillSequence.Items.Count)
            return;

        SkillListBoxObj info = lstSkillSequence.SelectedItem as SkillListBoxObj;

        lstSkillSequence.Items.Remove(info);
        lstSkillSequence.Items.Insert(newIndex, info);
        lstSkillSequence.SetSelected(newIndex, true);
    }

    private void RemoveSkill(bool all = false)
    {
        if (all)
        {
            lstSkillSequence.Items.Clear();
            return;
        }

        if (lstSkillSequence.SelectedItem == null || lstSkillSequence.SelectedIndex < 0)
            return;

        int index = lstSkillSequence.SelectedIndex;
        lstSkillSequence.Items.RemoveAt(index);
        lstSkillSequence.SelectedIndex = index - 1;
    }

    private void cmsSkill_Up_Click(object sender, EventArgs e) => MoveSkill(-1);

    private void cmsSkill_Down_Click(object sender, EventArgs e) => MoveSkill(1);

    private void cmsSkill_Remove_Click(object sender, EventArgs e) => RemoveSkill();

    private void cmsSkill_RemoveAll_Click(object sender, EventArgs e) => RemoveSkill(true);

    private void lstSkillSequence_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Down && e.Control)
        {
            MoveSkill(1);
            lstSkillSequence.SelectedIndex--;
            return;
        }
        if (e.KeyCode == Keys.Up && e.Control)
        {
            MoveSkill(-1);
            lstSkillSequence.SelectedIndex++;
            return;
        }
        if (e.KeyCode == Keys.Delete)
        {
            RemoveSkill();
            return;
        }
        if (e.KeyCode == Keys.Delete && e.Control)
        {
            RemoveSkill(true);
            return;
        }
    }

    private void cmsUseRule_Reset_Click(object sender, EventArgs e)
    {
        lblGreaterHealth.Text = ">";
        lblGreaterMana.Text = ">";
        numHealth.Value = 0;
        numMana.Value = 0;
        numWait.Value = 0;
        chkSkip.Checked = false;
    }

    public class SkillListBoxObj
    {
        public SkillListBoxObj(string skill)
        {
            Skill = skill;
        }
        public string Skill { get; set; }
        public override string ToString()
        {
            StringBuilder bob = new StringBuilder(Skill);
            bob.Replace("S", " Skip if not available.");
            bob.Replace("WW", " - Wait for ");
            bob.Replace("H", " - Health");
            bob.Replace("M", " - Mana");
            bob.Replace(">", " greater than ");
            bob.Replace("<", " less than ");
            bob.Insert(0, "Skills = ");
            return bob.ToString();
        }
    }

    private void lstSavedSkills_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        if (lstSavedSkills.SelectedItem == null && lstSavedSkills.SelectedIndex < 0)
            return;

        txtSaveName.Text = ((AdvancedSkill)lstSavedSkills.SelectedItem).ClassName;
        lstSkillSequence.Items.Clear();
        lstSkillSequence.Items.AddRange(ConvertBack(((AdvancedSkill)lstSavedSkills.SelectedItem).Skills).ToArray());
    }

    private void btnClearSkillString_Click(object sender, EventArgs e) => txtSkillString.Text = "";
}
