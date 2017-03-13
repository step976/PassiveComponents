using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                if ( comboBoxSelect.SelectedIndex == 0 )
                {
                    var resistor = new Resistor
                                   {
                                           Value = Convert.ToDouble(textBoxNominal.Text),
                                           UniqueName = Convert.ToString(textBoxNameElement.Text)
                                   };
                    unit = resistor;
                }
                if (comboBoxSelect.SelectedIndex == 1)
                {
                    var capacitor = new Capacitor
                                    {
                                            Value = Convert.ToDouble(textBoxNominal.Text),
                                            UniqueName = Convert.ToString(textBoxNameElement.Text)
                                    };
                    unit = capacitor;
                }
                if (comboBoxSelect.SelectedIndex == 2)
                {
                    var inductor = new Inductor
                                   {
                                           Value = Convert.ToDouble(textBoxNominal.Text),
                                           UniqueName = Convert.ToString(textBoxNameElement.Text)
                                   };
                    unit = inductor;
                }
                return unit;
            }
            set
            {
                if ( value is Resistor )
                {
                    textBoxNominal.Text = value.Value.ToString(CultureInfo.InvariantCulture);
                }
                if (value is Capacitor)
                {
                    textBoxNominal.Text = value.Value.ToString(CultureInfo.InvariantCulture);
                }
                if (value is Inductor)
                {
                    textBoxNominal.Text = value.Value.ToString(CultureInfo.InvariantCulture);
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
        private void Form1KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( e.KeyChar != Convert.ToChar(Keys.Enter) )
            {
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

    }

}
