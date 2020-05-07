using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

using FastColoredTextBoxNS;

namespace RBot
{
    public partial class ScriptEditorForm : HideForm
    {
        public EditorTab CurrentTab => tabsEditors.SelectedTab as EditorTab;

        public ScriptEditorForm()
        {
            InitializeComponent();

            tabsEditors.MouseClick += TabsEditors_MouseClick;
        }

        private void TabsEditors_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                EditorTab tab = tabsEditors.TabPages.Cast<EditorTab>().Where((t, i) => tabsEditors.GetTabRect(i).Contains(e.Location)).FirstOrDefault();
                if (tab != null)
                {
                    if (tab.Modified || tab.FileName == null)
                    {
                        DialogResult result = MessageBox.Show("This tab has unsaved changes. Would you like to save them before closing?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            saveToolStripMenuItem.PerformClick();
                            tabsEditors.TabPages.Remove(tab);
                        }
                        else if (result == DialogResult.No)
                            tabsEditors.TabPages.Remove(tab);
                    }
                    else
                        tabsEditors.TabPages.Remove(tab);
                }
            }
        }

        private void ScriptEditorForm_Load(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditorTab tab = new EditorTab();
            tab.CodeBox.Text = Properties.Resources.DefaultScript;
            tab.Modified = false;
            tab.Text = "New Script";
            tabsEditors.TabPages.Add(tab);
            tabsEditors.SelectedTab = tab;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "RBot Scripts (*.cs)|*.cs";
                ofd.InitialDirectory = "Scripts";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string full = Path.GetFullPath(ofd.FileName);
                    EditorTab tab = tabsEditors.TabPages.Cast<EditorTab>().Where(x => x.FileName == full).FirstOrDefault();
                    if (tab == null)
                    {
                        tab = new EditorTab();
                        tab.Load(full);
                        tabsEditors.TabPages.Add(tab);
                    }
                    tabsEditors.SelectedTab = tab;
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentTab != null)
            {
                if (CurrentTab.FileName == null)
                    _SaveAs();
                else
                    CurrentTab.Save();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _SaveAs();
        }

        private void _SaveAs()
        {
            if (CurrentTab != null)
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "RBot Scripts (*.cs)|*.cs";
                    sfd.InitialDirectory = "Scripts";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        CurrentTab.FileName = sfd.FileName;
                        CurrentTab.Text = Path.GetFileName(CurrentTab.FileName);
                        CurrentTab.Save();
                    }
                }
            }
        }
    }

    public class EditorTab : TabPage
    {
        public string FileName { get; set; }
        public bool Modified { get; set; }
        public FastColoredTextBox CodeBox { get; } = new FastColoredTextBox();

        private AutocompleteMenu auto;

        public EditorTab() : base()
        {
            CodeBox.Dock = DockStyle.Fill;
            CodeBox.Language = Language.CSharp;
            CodeBox.KeyDown += CodeBox_KeyDown;
            CodeBox.TextChanged += CodeBox_TextChanged;
            Controls.Add(CodeBox);
            auto = new AutocompleteMenu(CodeBox);
            auto.SearchPattern = @"[\w\.:=!<>()]";
            auto.AllowTabKey = true;
        }

        private void CodeBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Text = FileName != null ? Path.GetFileName(FileName) + "*" : "New Script*";
            Modified = true;
        }

        private void CodeBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.N || e.KeyCode == Keys.O || e.KeyCode == Keys.S))
                e.Handled = true;
        }

        public void Save()
        {
            File.WriteAllText(FileName, CodeBox.Text);
            Text = Path.GetFileName(FileName);
        }

        public void Load(string file)
        {
            FileName = file;
            CodeBox.Text = File.ReadAllText(file);
            Text = Path.GetFileName(file);
            Modified = false;
        }
    }
}
