using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RBot.Options;

namespace RBot
{
    public partial class GenericOptionsForm : Form
    {
        private OptionContainer _container;
        public OptionContainer Container
        {
            get => _container;
            set
            {
                _container = value;
                propOptions.SelectedObject = new OptionPropertyGridAdapter(_container);
            }
        }

        public GenericOptionsForm()
        {
            InitializeComponent();
        }

        private void GenericOptionsForm_Load(object sender, EventArgs e)
        {
            propOptions.SelectedObject = new OptionPropertyGridAdapter(_container);
        }
    }
}
