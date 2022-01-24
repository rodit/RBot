using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBot;

public partial class ConsoleForm : HideForm
{
    private volatile bool _ignoreKey = false;

    public ConsoleForm()
    {
        InitializeComponent();
        txtCode.KeyDown += TxtCode_KeyDown;
        txtCode.KeyPress += TxtCode_KeyPress;
    }

    protected override void OnGotFocus(EventArgs e)
    {
        base.OnGotFocus(e);
        ActiveControl = txtCode;
    }

    private void TxtCode_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter && e.Modifiers.HasFlag(Keys.Control))
        {
            e.Handled = true;
            _ignoreKey = true;
            btnRun.PerformClick();
        }
    }

    private void TxtCode_KeyPress(object sender, KeyPressEventArgs e)
    {
        e.Handled = _ignoreKey;
        _ignoreKey = false;
    }

    private void btnRun_Click(object sender, EventArgs e)
    {
        if (chkAsync.Checked)
            Task.Run(_RunCode);
        else
            _RunCode();
    }

    private void _RunCode()
    {
        try
        {
            string source = "using RBot;using RBot.Factions;using RBot.Flash;using RBot.Items;using RBot.Monsters;using RBot.Options;using RBot.PatchProxy;using RBot.Players;using RBot.Plugins;using RBot.Quests;using RBot.Servers;using RBot.Skills;using RBot.Utils;using System;using System.Collections.Generic;using System.Threading;using System.Linq;using Newtonsoft.Json;public class Script{public void ScriptMain(ScriptInterface bot){" + txtCode.Text + "}}";
            object o = ScriptManager.Compile(source);
            o.GetType().GetMethod("ScriptMain").Invoke(o, new object[] { Bot });
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error running snippet:\r\n" + ex);
        }
    }
}
