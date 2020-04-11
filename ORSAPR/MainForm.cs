using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kompas6API5;
using Kompas6Constants3D;
using Kompas6Constants;

namespace ORSAPR
{
    public partial class MainForm : Form
    {
        private Builder _builder;
        
        public MainForm()
        {
            InitializeComponent();
            _builder = new Builder();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                _builder.KompasConnector.StartKompas();
            }
            else
            {
                _builder.KompasConnector.StopKompas();
            }
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
            if (!_builder.Build())
            {
                MessageBox.Show("Ошибочка вышла!");
            }
        }
    }
}
