using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Model;
using KompasAPI;

namespace View
{
    /// <summary>
    /// Главная форма 
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Отрисовщик диска
        /// </summary>
        private Builder _builder;
        /// <summary>
        /// Параметры диска
        /// </summary>
        private DiskParams _diskParams;

        /// <summary>
        /// Конструктор
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            BuildButton.Enabled = false;

            _builder = new Builder();
            _diskParams = new DiskParams();

            var availableParameters = _diskParams.AvailableParameters;

            UpdateComboBox(DiskDiameterComboBox, availableParameters.DiskDiameterValues.ToList(),
                _diskParams.DiskDiameter);
            UpdateComboBox(WidthComboBox, availableParameters.WidthValues.ToList(), _diskParams.Width);
            UpdateComboBox(BoltsCountComboBox, availableParameters.BoltsCountValues.ToList(), _diskParams.BoltsCount);
            UpdateComboBox(BoltArrangementDiameterComboBox, availableParameters.BoltArrangementDiameterValues.ToList(),
                _diskParams.BoltArrangementDiameter);
            UpdateComboBox(CentralHoleDiameterComboBox, availableParameters.CentralHoleDiameterValues.ToList(),
                _diskParams.CentralHoleDiameter);
            UpdateComboBox(AirVentsCountComboBox, availableParameters.AirVentsCountValues.ToList(),
                _diskParams.AirVentsCount);

            AirVentsDiameterNumericUpDown.Value = _diskParams.AirVentsDiameter;
            AirVentsDiameterNumericUpDown.Maximum = availableParameters.MaxAirVentsDiameter;
            AirVentsDiameterNumericUpDown.Minimum = availableParameters.MinAirVentsDiameter;
            AirVentsDiameterNumericUpDown.ReadOnly = true;
            DiskDiameterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            BoltsCountComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            BoltArrangementDiameterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            WidthComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CentralHoleDiameterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AirVentsCountComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            _diskParams.AvailableParameters.ValuesChanged += ChangeComboBoxesItems;

            DiskDiameterComboBox.SelectedIndexChanged += IntComboBox_SelectedIndexChanged;
            WidthComboBox.SelectedIndexChanged += DoubleComboBox_SelectedIndexChanged;
            BoltsCountComboBox.SelectedIndexChanged += IntComboBox_SelectedIndexChanged;
            BoltArrangementDiameterComboBox.SelectedIndexChanged += DoubleComboBox_SelectedIndexChanged;
            CentralHoleDiameterComboBox.SelectedIndexChanged += DoubleComboBox_SelectedIndexChanged;
            AirVentsCountComboBox.SelectedIndexChanged += IntComboBox_SelectedIndexChanged;
            AirVentsDiameterNumericUpDown.ValueChanged += AirVentsDiameterNumericUpDown_ValueChanged;
        }

        /// <summary>
        /// Изменить списки элементов комбобоксов
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Аргументы события</param>
        private void ChangeComboBoxesItems(object sender, ValuesChangeEventArgs e)
        {
            var availableParameters = _diskParams.AvailableParameters;

            if (e.Type == AvailableValuesChangeType.DiskDiameterChanged)
            {
                UpdateComboBox(AirVentsCountComboBox, availableParameters.AirVentsCountValues.ToList(),
                    availableParameters.AirVentsCountValues.First());
                UpdateComboBox(BoltsCountComboBox, availableParameters.BoltsCountValues.ToList(),
                    availableParameters.BoltsCountValues.First());
            }

            if (e.Type != AvailableValuesChangeType.BoltArrangementDiameterChanged)
            {
                UpdateComboBox(BoltArrangementDiameterComboBox, availableParameters.BoltArrangementDiameterValues.ToList(),
                    availableParameters.BoltArrangementDiameterValues.First());
            }

            UpdateComboBox(WidthComboBox, availableParameters.WidthValues.ToList(), availableParameters.WidthValues.First());
            UpdateComboBox(CentralHoleDiameterComboBox, availableParameters.CentralHoleDiameterValues.ToList(),
                availableParameters.CentralHoleDiameterValues.First());
        }

        /// <summary>
        /// Обновить комбобокс
        /// </summary>
        /// <typeparam name="T">Тип параметров</typeparam>
        /// <param name="comboBox">Комбобокс</param>
        /// <param name="values">Значения параметров</param>
        /// <param name="current">Текущее значение параметра</param>
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

        /// <summary>
        /// Построить диск
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Аргументы события</param>
        private void BuildButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_builder.Build(_diskParams))
                {
                    MessageBox.Show("Ошибка построения");
                }
            }
            catch (NullReferenceException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
            }
            catch (System.Runtime.InteropServices.COMException exception)
            {
                MessageBox.Show("Компас выключен");
            }
        }

        /// <summary>
        /// Изменить текущее значение параметра типа int 
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Аргументы события</param>
        private void IntComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = GetComboBox(sender);

            int result;

            if (Int32.TryParse(comboBox.SelectedItem.ToString(), out result))
            {
                var str = comboBox.Name;
                int index = str.IndexOf("ComboBox");
                var property = str.Remove(index);
                try
                {
                    typeof(DiskParams).GetProperty(property).SetValue(_diskParams, result);
                }
                catch(ArgumentException exception)
                {
                    MessageBox.Show($"Ошибка: {exception.Message}");
                }
            }
            else
            {
                MessageBox.Show("Преобразование объекта ComboBoxItem к типу double завершилось с ошибкой");
            }
        }

        /// <summary>
        /// зменить текущее значение параметра типа double
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Аргументы события</param>
        private void DoubleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = GetComboBox(sender);

            double result;

            if (Double.TryParse(comboBox.SelectedItem.ToString(), out result))
            {
                var comboBoxName = comboBox.Name;
                int index = comboBoxName.IndexOf("ComboBox");
                var property = comboBoxName.Remove(index);
                try
                {
                    typeof(DiskParams).GetProperty(property).SetValue(_diskParams, result);
                }
                catch (ArgumentException exception)
                {
                    MessageBox.Show($"Ошибка: {exception.Message}");
                }
            }
            else
            {
                MessageBox.Show("Преобразование объекта ComboBoxItem к типу double завершилось с ошибкой");
            }
        }

        /// <summary>
        /// Получить комбобокс
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <returns>Комбобокс</returns>
        private ComboBox GetComboBox(object sender)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox == null)
            {
                MessageBox.Show("ComboBox не найден");
            }
            return comboBox;
        }

        /// <summary>
        /// Изменить текущее значение для диаметра вентиляционных отверстий
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Аргументы события</param>
        private void AirVentsDiameterNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            if (numericUpDown == null)
            {
                MessageBox.Show("NumericUpDown не найден");
            }
            try
            {
                _diskParams.AirVentsDiameter = numericUpDown.Value;
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
            }
        }

        /// <summary>
        /// Изменить параметры в соответствии с состоянием чекбокса
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Аргументы события</param>
        private void LaunchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                _builder.KompasConnector.StartKompas();
                BuildButton.Enabled = true;
            }
            else
            {
                try
                {
                    _builder.KompasConnector.StopKompas();
                }
                catch (System.Runtime.InteropServices.COMException exception)
                {
                    MessageBox.Show("Компас уже выключен");
                }

                BuildButton.Enabled = false;
            }
        }
    }
}
