using System;
using System.Globalization;
using System.Windows.Forms;

using Passive_Componets;

namespace PassiveComponentsView
{
    public partial class AddForm : Form
    {
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
                    NominalTextBox.Text = res.Value.ToString(CultureInfo.InvariantCulture);
                    NameElementTextBox.Text = res.UniqueName;
                }
                else if ( value is Capacitor )
                {
                    var capacitor = (Capacitor)value;
                    ElementComboBoxSelect.SelectedIndex = 1;
                    NominalTextBox.Text = capacitor.Value.ToString(CultureInfo.InvariantCulture);
                    NameElementTextBox.Text = capacitor.UniqueName;
                }
                else if ( value is Inductor )
                {
                    var inductor = (Inductor)value;
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

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            if ( ElementComboBoxSelect.SelectedIndex == -1 )
            {
                throw new ArgumentException("Не выбран ни один элемент");
            }
            DialogResult = DialogResult.OK;
            Close();
        }

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
