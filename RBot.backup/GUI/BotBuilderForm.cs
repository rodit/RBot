using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RBot.CodeBuilder;
using RBot.CodeBuilder.Commands;

namespace RBot
{
    public partial class BotBuilderForm : HideForm
    {
        public MultilineCodeBlock Root { get; set; } = new MultilineCodeBlock();

        public BotBuilderForm()
        {
            InitializeComponent();

            propCommand.PropertyValueChanged += PropCommand_PropertyValueChanged;
            cbCommandTypes.Items.AddRange(typeof(CodeCommand).Assembly.GetTypes().Where(t => t.IsPublic && t.Namespace == "RBot.CodeBuilder.Commands" && t != typeof(CodeCommand)).ToArray());
        }

        private void PropCommand_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            lbCommands.SelectedIndexChanged -= lbCommands_SelectedIndexChanged;
            int index = lbCommands.SelectedIndex;
            lbCommands.Items.RemoveAt(index);
            lbCommands.Items.Insert(index, propCommand.SelectedObject);
            lbCommands.SelectedIndex = index;
            lbCommands.SelectedIndexChanged += lbCommands_SelectedIndexChanged;
        }

        private void btnAddCommand_Click(object sender, EventArgs e)
        {
            Type t = cbCommandTypes.SelectedItem as Type;
            if (t != null)
            {
                CodeCommand cmd = (CodeCommand)Activator.CreateInstance(t);
                Root.Blocks.Add(cmd);
                lbCommands.Items.Add(cmd);
            }
        }

        private void lbCommands_SelectedIndexChanged(object sender, EventArgs e)
        {
            propCommand.SelectedObject = lbCommands.SelectedItem;
        }
    }
}
