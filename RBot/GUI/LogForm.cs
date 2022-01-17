using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Diagnostics;

using RBot.Flash;
using System.Runtime.CompilerServices;

namespace RBot
{
    public partial class LogForm : HideForm, INotifyPropertyChanged
    {
        public LogForm()
        {
            InitializeComponent();

            Trace.Listeners.Add(new DebugListener(this));
        }

        private string scriptLogs;
        public string ScriptLogs
        {
            get => scriptLogs;
            set => SetProperty(ref scriptLogs, value);
        }

        private string debugLogs;
        public string DebugLogs
        {
            get => debugLogs;
            set => SetProperty(ref debugLogs, value);
        }

        private string flashLogs;
        public string FlashLogs
        {
            get => flashLogs;
            set => SetProperty(ref flashLogs, value);
        }

        private void LogForm_Load(object sender, EventArgs e)
        {
            FlashUtil.FlashError += (flash, e, function, args) => FlashLogs += $"{function} Args[{args.Length}] = {{{string.Join(",", args.Select(a => a.ToString()))}}}\r\n";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
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
            _form.DebugLogs += message;
        }

        public override void WriteLine(string message)
        {
            _form.DebugLogs += $"{message}\r\n";
        }
    }
}
