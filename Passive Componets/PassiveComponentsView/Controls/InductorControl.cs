using System;
using Passive_Componets;
using System.Windows.Forms;

namespace PassiveComponentsView.Controls
{
    public partial class InductorControl : UserControl
    {
        public InductorControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Инициализация полей индуктивного элемента
        /// </summary>
        public Inductor Inductor
        {
            get
            {
                var inductor = new Inductor();
                inductor.Name = textBoxNameInductor.Text;
                try
                {
                    inductor.Value = Convert.ToDouble(textBoxInductance.Text);
                }
                catch (FormatException)
                {
                    var exception = new FormatException(@"Ошибка индуктивности катушки");
                    throw exception;
                }
                return inductor;
            }

            set
            {
                textBoxInductance.Text = value.Value.ToString();
                textBoxNameInductor.Text = value.Name;

                try
                {
                    double textBoxInductor = Convert.ToDouble(textBoxInductance.Text);
                }
                catch (FormatException)
                {
                    var exception = new FormatException(@"Ошибка индуктивности катушки");
                    throw exception;
                }
            }
        }

        /// <summary>
        /// Заполнение поля имени индуктивного элемента
        /// </summary>
        /// <param name="nameInductor"></param>
        public void ChangeNameInductor(string nameInductor)
        {
            textBoxNameInductor.Text = nameInductor;
        }
    }
}
