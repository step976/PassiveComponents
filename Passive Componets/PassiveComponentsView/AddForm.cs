using System;
using System.Globalization;
using System.Windows.Forms;
using PassiveComponentsView.Controls;
using Passive_Componets;

namespace PassiveComponentsView
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Создание или изменение элемента
        /// </summary>
        public IElement Element
        {
            get
            {
                try
                {
                    var cathThrowElements = elementsControl.Elements;
                }
                catch (FormatException exception)
                {
                    MessageBox.Show(exception.Message);
                    return null;
                }
                return elementsControl.Elements;
            }

            set
            {
                try
                {
                    elementsControl.Elements = value;
                }
                catch (FormatException exception)
                {
                    MessageBox.Show(exception.Message);
                    throw;
                }
            }
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception de)
            {
                MessageBox.Show(de.Message, @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
