using System;
using System.Globalization;
using  Passive_Componets;
using System.Windows.Forms;

namespace PassiveComponentsView.Controls
{
    public partial class ResistorControl : UserControl
    {
        public ResistorControl()
        {
            InitializeComponent();
        }

        public Resistor Resistor
        {
            get
            {
                var resistor = new Resistor();
                resistor.Name = textBoxNameResistor.Text;
                try
                {
                    resistor.Value = Convert.ToDouble(textBoxResistance.Text);
                }
                catch (FormatException)
                {
                    var exception = new FormatException(@"Ошибка сопротивления резистора");
                    throw exception;
                }
                return resistor;
            }

            set
            {
                textBoxResistance.Text = value.Value.ToString(CultureInfo.InvariantCulture);
                textBoxNameResistor.Text = value.Name;
                try
                {
                    double textBoxResistor = Convert.ToDouble(textBoxResistance.Text);
                }
                catch (FormatException)
                {
                    var exception = new FormatException(@"Ошибка сопротивления резистора");
                    throw exception;
                }
            }
        }

        /// <summary>
        /// Заполнение поля имени резистора
        /// </summary>
        /// <param name="nameResistor"></param>
        public void ChangeNameResistor(string nameResistor)
        {
            textBoxNameResistor.Text = nameResistor;
        }

    }
}
