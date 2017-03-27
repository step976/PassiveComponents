using System;
using System.Globalization;
using System.Windows.Forms;
using Passive_Componets;

namespace PassiveComponentsView
{
    public partial class AddForm : Form
    {
        private IElement _element;

        /// <summary>
        /// Создание или изменение элемента
        /// </summary>
        public IElement Element
        {
            get
            {
                if ( ElementComboBoxSelect.SelectedIndex == 0 )
                {
                    var resistor = new Resistor();
                    _element = resistor;
                }
                else if ( ElementComboBoxSelect.SelectedIndex == 1 )
                {
                    var capacitor = new Capacitor();
                    _element = capacitor;
                }
                else if ( ElementComboBoxSelect.SelectedIndex == 2 )
                {
                    var inductor = new Inductor();
                    _element = inductor;
                }
                _element.Freq = Convert.ToDouble(10);
                _element.Value = Convert.ToDouble(NominalTextBox.Text);
                _element.UniqueName = Convert.ToString(NameElementTextBox.Text);
                return _element;
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
                else
                {
                    throw new ArgumentException("Данный тип элемента не поддерживается данной формой.");
                }
            }
        }

        public AddForm()
        {
            InitializeComponent();
        }

        private void ComboBoxSelectSelectedIndexChanged(object sender, EventArgs e)
        {
            if ( ElementComboBoxSelect.SelectedIndex == 0 )
            {
                NominalLabel.Text = @"Введите его номинал, Ом:";
            }
            if ( ElementComboBoxSelect.SelectedIndex == 1 )
            {
                NominalLabel.Text = @"Введите его номинал, Ф:";
            }
            if ( ElementComboBoxSelect.SelectedIndex == 2 )
            {
                NominalLabel.Text = @"Введите его номинал, Гн:";
            }
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            // метод добавить
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void NominalTextBox_TextChanged(object sender, EventArgs e)
        {
            
            {
                throw new ArgumentException("Поле не может быть пустым.");
            }
        }

        private void NameElementTextBox_TextChanged(object sender, EventArgs e)
        {
            
            {
                throw new ArgumentException("Поле не может быть пустым.");
            }
        }
    }
}
