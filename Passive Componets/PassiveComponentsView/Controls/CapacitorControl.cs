using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Passive_Componets;

namespace PassiveComponentsView.Controls
{
    public partial class CapacitorControl : UserControl
    {
        public CapacitorControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Инициализация полей конденсатора
        /// </summary>
        public Capacitor Capacitor
        {
            get
            {
                var capacitor = new Capacitor();
                capacitor.Name = textBoxNameCapacitor.Text;
                try
                {
                    capacitor.Value = Convert.ToDouble(textBoxCapacitance.Text);
                }
                catch (FormatException)
                {
                    var exception = new FormatException(@"Ошибка емкости конденсатора");
                    throw exception;
                }
                return capacitor;
            }

            set
            {
                textBoxCapacitance.Text = value.Value.ToString(CultureInfo.InvariantCulture);
                textBoxNameCapacitor.Text = value.Name;
                try
                {
                    double textBoxCapacitor = Convert.ToDouble(textBoxCapacitance.Text);
                }
                catch (FormatException)
                {
                    var exception = new FormatException(@"Ошибка емкости конденсатора");
                    throw exception;
                }
            }
        }

        /// <summary>
        /// Заполнение поля имени конденсатора
        /// </summary>
        /// <param name="nameCapacitor"></param>
        public void ChangeNameCapacitor(string nameCapacitor)
        {
            textBoxNameCapacitor.Text = nameCapacitor;
        }
    }
}
