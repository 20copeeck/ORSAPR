namespace View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.LaunchCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BoltsCountComboBox = new System.Windows.Forms.ComboBox();
            this.CentralHoleDiameterComboBox = new System.Windows.Forms.ComboBox();
            this.BoltArrangementDiameterComboBox = new System.Windows.Forms.ComboBox();
            this.WidthComboBox = new System.Windows.Forms.ComboBox();
            this.DiskDiameterComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AirVentsCountComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LaunchDrawingHumpCheckBox = new System.Windows.Forms.CheckBox();
            this.AirVentsDiameterNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BuildButton = new System.Windows.Forms.Button();
            this.DiskDiameterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WidthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BoltsCountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BoltArrangementDiameterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CentralHoleDiameterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AirVentsDiameterNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiskDiameterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoltsCountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoltArrangementDiameterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CentralHoleDiameterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Диаметр диска (D), дюйм";
            // 
            // LaunchCheckBox
            // 
            this.LaunchCheckBox.AutoSize = true;
            this.LaunchCheckBox.Location = new System.Drawing.Point(18, 12);
            this.LaunchCheckBox.Name = "LaunchCheckBox";
            this.LaunchCheckBox.Size = new System.Drawing.Size(257, 21);
            this.LaunchCheckBox.TabIndex = 0;
            this.LaunchCheckBox.Text = "Включить/Выключить КОМПАС 3D";
            this.LaunchCheckBox.UseVisualStyleBackColor = true;
            this.LaunchCheckBox.CheckedChanged += new System.EventHandler(this.LaunchCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BoltsCountComboBox);
            this.groupBox1.Controls.Add(this.CentralHoleDiameterComboBox);
            this.groupBox1.Controls.Add(this.BoltArrangementDiameterComboBox);
            this.groupBox1.Controls.Add(this.WidthComboBox);
            this.groupBox1.Controls.Add(this.DiskDiameterComboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 213);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Основные параметры";
            // 
            // BoltsCountComboBox
            // 
            this.BoltsCountComboBox.FormattingEnabled = true;
            this.BoltsCountComboBox.Location = new System.Drawing.Point(212, 57);
            this.BoltsCountComboBox.Name = "BoltsCountComboBox";
            this.BoltsCountComboBox.Size = new System.Drawing.Size(64, 24);
            this.BoltsCountComboBox.TabIndex = 4;
            this.BoltsCountComboBox.Text = "5";
            // 
            // CentralHoleDiameterComboBox
            // 
            this.CentralHoleDiameterComboBox.FormattingEnabled = true;
            this.CentralHoleDiameterComboBox.Location = new System.Drawing.Point(212, 171);
            this.CentralHoleDiameterComboBox.Name = "CentralHoleDiameterComboBox";
            this.CentralHoleDiameterComboBox.Size = new System.Drawing.Size(64, 24);
            this.CentralHoleDiameterComboBox.TabIndex = 7;
            this.CentralHoleDiameterComboBox.Text = "108.5";
            // 
            // BoltArrangementDiameterComboBox
            // 
            this.BoltArrangementDiameterComboBox.FormattingEnabled = true;
            this.BoltArrangementDiameterComboBox.Location = new System.Drawing.Point(212, 96);
            this.BoltArrangementDiameterComboBox.Name = "BoltArrangementDiameterComboBox";
            this.BoltArrangementDiameterComboBox.Size = new System.Drawing.Size(64, 24);
            this.BoltArrangementDiameterComboBox.TabIndex = 5;
            this.BoltArrangementDiameterComboBox.Text = "139.7";
            // 
            // WidthComboBox
            // 
            this.WidthComboBox.FormattingEnabled = true;
            this.WidthComboBox.Location = new System.Drawing.Point(212, 132);
            this.WidthComboBox.Name = "WidthComboBox";
            this.WidthComboBox.Size = new System.Drawing.Size(64, 24);
            this.WidthComboBox.TabIndex = 6;
            this.WidthComboBox.Text = "6";
            // 
            // DiskDiameterComboBox
            // 
            this.DiskDiameterComboBox.FormattingEnabled = true;
            this.DiskDiameterComboBox.Location = new System.Drawing.Point(212, 27);
            this.DiskDiameterComboBox.Name = "DiskDiameterComboBox";
            this.DiskDiameterComboBox.Size = new System.Drawing.Size(64, 24);
            this.DiskDiameterComboBox.TabIndex = 3;
            this.DiskDiameterComboBox.Text = "16";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(5, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 40);
            this.label5.TabIndex = 12;
            this.label5.Text = "Диаметр центрального отверстия (DIA), мм";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 43);
            this.label4.TabIndex = 10;
            this.label4.Text = "Диаметр расположения болтов (PCD), мм";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Количество болтов (LZ)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ширина диска (B), дюйм";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 34);
            this.label6.TabIndex = 16;
            this.label6.Text = "Количество вентиляционных отверстий (KN)";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 40);
            this.label7.TabIndex = 17;
            this.label7.Text = "Диаметр вентиляционных отверстий (DN), мм";
            // 
            // AirVentsCountComboBox
            // 
            this.AirVentsCountComboBox.FormattingEnabled = true;
            this.AirVentsCountComboBox.Location = new System.Drawing.Point(212, 68);
            this.AirVentsCountComboBox.Name = "AirVentsCountComboBox";
            this.AirVentsCountComboBox.Size = new System.Drawing.Size(64, 24);
            this.AirVentsCountComboBox.TabIndex = 14;
            this.AirVentsCountComboBox.Text = "12";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LaunchDrawingHumpCheckBox);
            this.groupBox2.Controls.Add(this.AirVentsDiameterNumericUpDown);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.AirVentsCountComboBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 151);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дополнительные параметры";
            // 
            // LaunchDrawingHumpCheckBox
            // 
            this.LaunchDrawingHumpCheckBox.AutoSize = true;
            this.LaunchDrawingHumpCheckBox.Location = new System.Drawing.Point(9, 30);
            this.LaunchDrawingHumpCheckBox.Name = "LaunchDrawingHumpCheckBox";
            this.LaunchDrawingHumpCheckBox.Size = new System.Drawing.Size(206, 21);
            this.LaunchDrawingHumpCheckBox.TabIndex = 18;
            this.LaunchDrawingHumpCheckBox.Text = "Вкл/Выкл отрисовку хампа";
            this.LaunchDrawingHumpCheckBox.UseVisualStyleBackColor = true;
            this.LaunchDrawingHumpCheckBox.CheckedChanged += new System.EventHandler(this.LaunchDrawingHumpCheckBox_CheckedChanged);
            // 
            // AirVentsDiameterNumericUpDown
            // 
            this.AirVentsDiameterNumericUpDown.DecimalPlaces = 1;
            this.AirVentsDiameterNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.AirVentsDiameterNumericUpDown.Location = new System.Drawing.Point(212, 112);
            this.AirVentsDiameterNumericUpDown.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.AirVentsDiameterNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.AirVentsDiameterNumericUpDown.Name = "AirVentsDiameterNumericUpDown";
            this.AirVentsDiameterNumericUpDown.Size = new System.Drawing.Size(64, 22);
            this.AirVentsDiameterNumericUpDown.TabIndex = 15;
            this.AirVentsDiameterNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // BuildButton
            // 
            this.BuildButton.Location = new System.Drawing.Point(12, 415);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(286, 38);
            this.BuildButton.TabIndex = 1;
            this.BuildButton.Text = "Построить";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 463);
            this.Controls.Add(this.BuildButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LaunchCheckBox);
            this.MaximumSize = new System.Drawing.Size(328, 510);
            this.MinimumSize = new System.Drawing.Size(328, 510);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Диски 3D";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AirVentsDiameterNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiskDiameterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoltsCountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoltArrangementDiameterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CentralHoleDiameterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox LaunchCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox BoltsCountComboBox;
        private System.Windows.Forms.ComboBox CentralHoleDiameterComboBox;
        private System.Windows.Forms.ComboBox BoltArrangementDiameterComboBox;
        private System.Windows.Forms.ComboBox WidthComboBox;
        private System.Windows.Forms.ComboBox DiskDiameterComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox AirVentsCountComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.NumericUpDown AirVentsDiameterNumericUpDown;
        private System.Windows.Forms.BindingSource DiskDiameterBindingSource;
        private System.Windows.Forms.BindingSource WidthBindingSource;
        private System.Windows.Forms.BindingSource BoltsCountBindingSource;
        private System.Windows.Forms.BindingSource BoltArrangementDiameterBindingSource;
        private System.Windows.Forms.BindingSource CentralHoleDiameterBindingSource;
        private System.Windows.Forms.CheckBox LaunchDrawingHumpCheckBox;
    }
}

