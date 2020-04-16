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
        private DiskParams _diskParams;

        public MainForm()
        {
            InitializeComponent();
            _builder = new Builder();
            _diskParams = new DiskParams();
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
            if (!_builder.Build(_diskParams))
            {
                MessageBox.Show("Ошибочка вышла!");
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = null;
            try
            {
                comboBox = (ComboBox)sender;
                if (comboBox == null)
                {
                    throw new NullReferenceException("ComboBox не найден");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
            }

            double result;
            if (Double.TryParse(comboBox.SelectedItem.ToString(), out result))
            {
                var str = comboBox.Name;
                int index = str.IndexOf("ComboBox");
                var property = str.Remove(index);
                typeof(DiskParams).GetProperty(property).SetValue(_diskParams, result);
            }
            else
            {
                MessageBox.Show("Преобразование объекта ComboBoxItem к типу double завершилось с ошибкой");
            }
        }

        private void AirVentsDiameterNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = null;
            try
            {
                numericUpDown = (NumericUpDown)sender;
                if (numericUpDown == null)
                {
                    throw new NullReferenceException("NumericUpDown не найден");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
            }

            _diskParams.AirVentsDiameter = numericUpDown.Value;

        }

        private void LaunchCheckBox_CheckedChanged(object sender, EventArgs e)
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
    }
}
