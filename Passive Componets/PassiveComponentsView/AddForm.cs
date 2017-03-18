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
                                           Value = Convert.ToDouble(NominalTextBox.Text),
                                           UniqueName = Convert.ToString(NameElementtextBox.Text)
                                   };
                    unit = resistor;
                }
                if ( ElementComboBoxSelect.SelectedIndex == 1 )
                {
                    var capacitor = new Capacitor
                                    {
                                            Value = Convert.ToDouble(NominalTextBox.Text),
                                            UniqueName = Convert.ToString(NameElementtextBox.Text)
                                    };
                    unit = capacitor;
                }
                if ( ElementComboBoxSelect.SelectedIndex == 2 )
                {
                    var inductor = new Inductor
                                   {
                                           Value = Convert.ToDouble(NominalTextBox.Text),
                                           UniqueName = Convert.ToString(NameElementtextBox.Text)
                                   };
                    unit = inductor;
                }
                return unit;
            }
            set
            {
                if ( value is Resistor )
                {
                    NominalTextBox.Text = value.Value.ToString(CultureInfo.InvariantCulture);
                }
                if ( value is Capacitor )
                {
                    NominalTextBox.Text = value.Value.ToString(CultureInfo.InvariantCulture);
                }
                if ( value is Inductor )
                {
                    NominalTextBox.Text = value.Value.ToString(CultureInfo.InvariantCulture);
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

        private void ButtonOkClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
