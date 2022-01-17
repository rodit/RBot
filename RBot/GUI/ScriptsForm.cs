using RBot.Utils;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace RBot
{
    public partial class ScriptsForm : HideForm
    {
        public ScriptsForm()
        {
            InitializeComponent();
        }

        private void btnClearEventHandlers_Click(object sender, EventArgs e)
            => Bot.Events.ClearHandlers();
    }
}
