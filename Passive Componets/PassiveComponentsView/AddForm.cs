﻿using System;
using System.Globalization;
using System.Windows.Forms;

using Passive_Componets;

namespace PassiveComponentsView
{
    public partial class AddForm : Form
    {
        /// <summary>
        /// Создание или изменение элемента
        /// </summary>
        public IElement Element
        {
            get
            {
                IElement unit = null;
                if ( ElementComboBoxSelect.SelectedIndex == 0 )
                {
                    var resistor = new Resistor
                                   {
                                           Freq = Convert.ToDouble(10),
                                           Value = Convert.ToDouble(NominalTextBox.Text),
                                           UniqueName = Convert.ToString(NameElementTextBox.Text)
                                   };
                    unit = resistor;
                }
                else if ( ElementComboBoxSelect.SelectedIndex == 1 )
                {
                    var capacitor = new Capacitor
                                    {
                                            Value = Convert.ToDouble(NominalTextBox.Text),
                                            Freq = Convert.ToDouble(10),
                                            UniqueName = Convert.ToString(NameElementTextBox.Text)
                                    };
                    unit = capacitor;
                }
                else if ( ElementComboBoxSelect.SelectedIndex == 2 )
                {
                    var inductor = new Inductor
                                   {
                                           Freq = Convert.ToDouble(10),
                                           Value = Convert.ToDouble(NominalTextBox.Text),
                                           UniqueName = Convert.ToString(NameElementTextBox.Text)
                                   };
                    unit = inductor;
                }
                return unit;
            }
            set
            {
                if ( value is Resistor )
                {
                    var res = (Resistor)value;
                    ElementComboBoxSelect.SelectedIndex = 0;
                    ElementComboBoxSelect.Enabled = false;
                    NominalTextBox.Text = res.Value.ToString(CultureInfo.InvariantCulture);
                    NameElementTextBox.Text = res.UniqueName;
                }
                else if ( value is Capacitor )
                {
                    var capacitor = (Capacitor)value;
                    ElementComboBoxSelect.Enabled = false;
                    ElementComboBoxSelect.SelectedIndex = 1;
                    NominalTextBox.Text = capacitor.Value.ToString(CultureInfo.InvariantCulture);
                    NameElementTextBox.Text = capacitor.UniqueName;
                }
                else if ( value is Inductor )
                {
                    var inductor = (Inductor)value;
                    ElementComboBoxSelect.Enabled = false;
                    ElementComboBoxSelect.SelectedIndex = 2;
                    NominalTextBox.Text = inductor.Value.ToString(CultureInfo.InvariantCulture);
                    NameElementTextBox.Text = inductor.UniqueName;
                }
            }
        }

        public AddForm()
        {
            InitializeComponent();
        }

        private void AddFormLoad(object sender, EventArgs e)
        {
        }

        private void ComboBoxSelectSelectedIndexChanged(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// Кнопка ОК
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOk_Click(object sender, EventArgs e)
        {
            try
            {
                IElement element = Element;
            }
            catch ( FormatException fe )
            {
                MessageBox.Show(fe.Message, @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch ( ArgumentException fe )
            {
                MessageBox.Show(fe.Message, @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            DialogResult = DialogResult.OK;
            Close();
        }
        /// <summary>
        /// Кнопка Отмена
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SelectElement_Click(object sender, EventArgs e)
        {

        }

        private void NominalTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
