using System;
using System.Windows.Forms;

namespace RBot.Utils;

public static class ControlUtils
{
    public static bool CheckedInvoke(this Control c, Action a)
    {
        bool req = c.InvokeRequired;
        (req ? () => c.Invoke(a) : a)();
        return req;
    }

    public static DialogResult ShowErrorMessage(string text, string caption)
    {
        return MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
