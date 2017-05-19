using System;
using Passive_Componets;
using System.Windows.Forms;
using PassiveComponentsView.Tools;

namespace PassiveComponentsView.Controls
{
    public partial class ElementsControl : UserControl
    {
        public ElementsControl()
        {
            InitializeComponent();

            ElementsComboBox.Items.Add("Резистор");
            ElementsComboBox.Items.Add("Катушка индуктивности");
            ElementsComboBox.Items.Add("Конденсатор");

            resistorControl.Visible = false;
            inductorControl.Visible = false;
            capacitorControl.Visible = false;
        }
        /// <summary>
        /// Инициализация элемента
        /// </summary>
        public IElement Elements
        {
            get
            {
                IElement element = null;
                int ss = ElementsComboBox.SelectedIndex;
                switch (ss)
                {
                    case 0:
                    {
                        try
                        {
                            element = resistorControl.Resistor;
                        }
                        catch (FormatException exception)
                        {
                            throw exception;
                        }
                        break;
                    }
                    case 1:
                    {
                        try
                        {
                            element = inductorControl.Inductor;
                        }
                        catch (FormatException exception)
                        {
                            throw exception;
                        }
                        break;
                    }
                    case 2:
                    {
                        try
                        {
                            element = capacitorControl.Capacitor;
                        }
                        catch (FormatException exception)
                        {
                            throw exception;
                        }
                        break;
                    }
                }
                return element;
            }
            set
            {
                if (value is Resistor)
                {
                    ElementsComboBox.SelectedIndex = 0;
                    try
                    {
                        resistorControl.Resistor = (Resistor) value;
                    }
                    catch (FormatException exception)
                    {
                        throw exception;
                    }
                }
                else if (value is Inductor)
                {
                    ElementsComboBox.SelectedIndex = 1;

                    inductorControl.Inductor = (Inductor) value;
                }
               else  if (value is Capacitor)
                {
                    ElementsComboBox.SelectedIndex = 2;

                    capacitorControl.Capacitor = (Capacitor) value;
                }
            }
        }

        private void ElementsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            resistorControl.Visible = (ElementsComboBox.SelectedIndex == 0);
            inductorControl.Visible = (ElementsComboBox.SelectedIndex == 1);
            capacitorControl.Visible = (ElementsComboBox.SelectedIndex == 2);
            switch (ElementsComboBox.SelectedIndex)
            {
                case 0:
                    {
                        resistorControl.ChangeNameResistor(ElementNameGenerate.GenerateNameResistor());
                        break;
                    }
                case 1:
                    {
                        inductorControl.ChangeNameInductor(ElementNameGenerate.GenerateNameInductor());
                        break;
                    }
                case 2:
                    {
                        capacitorControl.ChangeNameCapacitor(ElementNameGenerate.GenerateNameCapacitor());
                        break;
                    }
            }
        }
    }
}
