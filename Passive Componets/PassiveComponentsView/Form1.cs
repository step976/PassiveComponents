using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Passive_Componets;

namespace PassiveComponentsView
{
    public partial class AddForm : Form
    {
        public IElement Element { get; set; }

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
            if (comboBoxSelect.SelectedIndex == 0)
            {
                var resistor = new Resistor
                {
                    Value = Convert.ToDouble(textBoxNominal.Text)
                };
                Element = resistor;
            }
            if (comboBoxSelect.SelectedIndex == 1)
            {
                var capacitor = new Capacitor
                {
                    Value = Convert.ToDouble(textBoxNominal.Text)
                };
                Element = capacitor;
            }
            if (comboBoxSelect.SelectedIndex == 2)
            {
                var inductor = new Inductor
                {
                    Value = Convert.ToDouble(textBoxNominal.Text)
                };
                Element = inductor;
            }

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
