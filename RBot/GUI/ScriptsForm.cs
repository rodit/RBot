using System;

namespace RBot
{
    public partial class ScriptsForm : HideForm
    {
        public ScriptsForm()
        {
            InitializeComponent();
        }

        internal void ToggleScript() => ucScripts.btnStartScript.PerformClick();

        internal void LoadScript() => ucScripts.btnLoadScript.PerformClick();

        private void btnClearEventHandlers_Click(object sender, EventArgs e)
        {
            Bot.Events.ClearHandlers();
        }
    }
}
