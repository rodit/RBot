using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBot;

public partial class PromptDialog : Form
{
    public string Result { get; set; }
    public PromptDialog()
    {
        InitializeComponent();
    }

    public PromptDialog(string caption, string hint)
    {
        InitializeComponent();

        Text = caption;
        lblHint.Text = hint;
    }

    private void btnConfirm_Click(object sender, EventArgs e)
    {
        Result = txtInput.Text;
        DialogResult = DialogResult.OK;
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
    }
}
