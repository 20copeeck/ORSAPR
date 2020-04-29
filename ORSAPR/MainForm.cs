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
using System.Collections.Specialized;

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


            ChangeComboBoxesItems();
            _diskParams.AvailableParameters.ValuesChanged += ChangeComboBoxesItems;

            DiskDiameterComboBox.SelectedIndexChanged += DoubleComboBox_SelectedIndexChanged;
            WidthComboBox.SelectedIndexChanged += DoubleComboBox_SelectedIndexChanged;
            BoltsCountComboBox.SelectedIndexChanged += IntComboBox_SelectedIndexChanged;
            BoltArrangementDiameterComboBox.SelectedIndexChanged += DoubleComboBox_SelectedIndexChanged;
            CentralHoleDiameterComboBox.SelectedIndexChanged += DoubleComboBox_SelectedIndexChanged;
            AirVentsCountComboBox.SelectedIndexChanged += IntComboBox_SelectedIndexChanged;
            AirVentsDiameterNumericUpDown.ValueChanged += AirVentsDiameterNumericUpDown_ValueChanged;
        }

        private void ChangeComboBoxesItems(object sender, EventArgs e)
        {
            ChangeComboBoxesItems();
        }

        private void ChangeComboBoxesItems()
        {
            var availableParameters = _diskParams.AvailableParameters;

            UpdateComboBox(DiskDiameterComboBox, availableParameters.DiskDiameterValues.ToList(), _diskParams.DiskDiameter);
            UpdateComboBox(WidthComboBox, availableParameters.WidthValues.ToList(), _diskParams.Width);
            UpdateComboBox(BoltsCountComboBox, availableParameters.BoltsCountValues.ToList(), _diskParams.BoltsCount);
            UpdateComboBox(BoltArrangementDiameterComboBox, availableParameters.BoltArrangementDiameterValues.ToList(), _diskParams.BoltArrangementDiameter);
            UpdateComboBox(CentralHoleDiameterComboBox, availableParameters.CentralHoleDiameterValues.ToList(), _diskParams.CentralHoleDiameter);
        }

        private void UpdateComboBox<T>(ComboBox comboBox, List<T> values, T current) where T : IComparable<T>
        {
            var items = comboBox.Items;

            items.Clear();

            foreach (var value in values)
            {
                items.Add(value);

                if (value.CompareTo(current) == 0)
                {
                    comboBox.SelectedItem = value;
                }
            }
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
            if (!_builder.Build(_diskParams))
            {
                MessageBox.Show("Ошибочка вышла!");
            }
        }

        private void IntComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = GetComboBox(sender);

            int result;

            if (Int32.TryParse(comboBox.SelectedItem.ToString(), out result))
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

        private void DoubleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = GetComboBox(sender);

            double result;

            if (Double.TryParse(comboBox.SelectedItem.ToString(), out result))
            {
                var comboBoxName = comboBox.Name;
                int index = comboBoxName.IndexOf("ComboBox");
                var property = comboBoxName.Remove(index);
                typeof(DiskParams).GetProperty(property).SetValue(_diskParams, result);
            }
            else
            {
                MessageBox.Show("Преобразование объекта ComboBoxItem к типу double завершилось с ошибкой");
            }
        }

        private ComboBox GetComboBox(object sender)
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

            return comboBox;
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
