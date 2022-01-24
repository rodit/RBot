using RBot.Utils;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace RBot
{
    public partial class LogsUserControl : UserControl
    {
        public LogsUserControl()
        {
            InitializeComponent();
        }

        [Description("The log type to be displayed.")]
        public LogType SetLogType { get; set; }

        public enum LogType
        {
            DebugLogs,
            ScriptLogs,
            FlashLogs
        }

        private void LogsUserControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                txtLogs.DataBindings.Add(AsyncBindingHelper.GetBinding(txtLogs, "Text", Forms.Log, SetLogType.ToString())); 
            }
            btnSave.Enabled = SetLogType != LogType.FlashLogs;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string text = SetLogType switch
            {
                LogType.DebugLogs => Forms.Log.DebugLogs,
                LogType.ScriptLogs => Forms.Log.ScriptLogs,
                LogType.FlashLogs => Forms.Log.FlashLogs,
                _ => "No logs were saved, contact the developer."
            };
            using SaveFileDialog sfd = new();
            sfd.Filter = "Text Files (*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
                File.WriteAllText(sfd.FileName, text);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            switch (SetLogType)
            {
                case LogType.DebugLogs:
                    Forms.Log.DebugLogs = "";
                    break;
                case LogType.ScriptLogs:
                    Forms.Log.ScriptLogs = "";
                    break;
                case LogType.FlashLogs:
                    Forms.Log.FlashLogs = "";
                    break;
            }
        }

        private void txtLogs_TextChanged(object sender, EventArgs e)
        {
            txtLogs.SelectionStart = txtLogs.Text.Length;
            txtLogs.ScrollToCaret();
        }
    }
}
