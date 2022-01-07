using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

using RBot.Flash;
using RBot.Utils;

namespace RBot
{
    public partial class LogForm : HideForm
    {
        public LogForm()
        {
            InitializeComponent();

            Trace.Listeners.Add(new DebugListener(this));
        }

        private void LogForm_Load(object sender, EventArgs e)
        {
            FlashUtil.FlashError += FlashUtil_FlashError;
        }

        private void FlashUtil_FlashError(AxShockwaveFlashObjects.AxShockwaveFlash flash, Exception e, string function, params object[] args)
        {
            if (Visible)
            {
                lbFlashCalls.CheckedInvoke(() =>
                {
                    lbFlashCalls.Items.Add($"{function} Args[{args.Length}] = {{{string.Join(",", args.Select(a => a.ToString()))}}}");
                    lbFlashCalls.TopIndex = lbFlashCalls.Items.Count - 1;
                });
            }
        }

        private void _AppendText(TextBox tb, string text)
        {
            if(Visible)
                tb.CheckedInvoke(() => tb.AppendText(text));
        }

        private void _SaveText(string text)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text Files (*.txt)|*.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                    File.WriteAllText(sfd.FileName, text);
            }
        }

        private void _ClearText(TextBox tb)
        {
            tb.CheckedInvoke(tb.Clear);
        }

        private void btnSaveDebug_Click(object sender, EventArgs e)
        {
            _SaveText(txtDebugLog.Text);
        }

        private void btnClearDebug_Click(object sender, EventArgs e)
        {
            _ClearText(txtDebugLog);
        }

        private void btnSaveScript_Click(object sender, EventArgs e)
        {
            _SaveText(txtScriptLog.Text);
        }

        private void btnClearScript_Click(object sender, EventArgs e)
        {
            _ClearText(txtScriptLog);
        }

        private void btnClearFlash_Click(object sender, EventArgs e)
        {
            lbFlashCalls.CheckedInvoke(lbFlashCalls.Items.Clear);
        }

        public void AppendDebug(string line)
        {
            _AppendText(txtDebugLog, line);
        }

        public void AppendScript(string line)
        {
            _AppendText(txtScriptLog, line);
        }
    }

    public class DebugListener : TraceListener
    {
        private LogForm _form;

        public DebugListener(LogForm form)
        {
            _form = form;
        }

        public override void Write(string message)
        {
            _form.AppendDebug(message);
        }

        public override void WriteLine(string message)
        {
            _form.AppendDebug(message + "\r\n");
        }
    }
}
