using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

using Passive_Componets;

namespace PassiveComponentsView
{
    public partial class MainForm : Form
    {
        private List<IElement> Elements;
        private BinaryFormatter _formatter = new BinaryFormatter();

        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
            Elements = new List<IElement>();
            iElementBindingSource.DataSource = Elements;
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            AngularFreqTextBox.Text = 10.ToString();
        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Добавление объекта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddElement_Click(object sender, EventArgs e)
        {
            var form = new AddForm();
            if ( form.ShowDialog() == DialogResult.OK )
            {
                iElementBindingSource.Add(form.Element);
            }
        }
        /// <summary>
        /// Удаление объектов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveElement_Click(object sender, EventArgs e)
        {
            iElementBindingSource.RemoveCurrent();
        }
        /// <summary>
        /// Вычисление сопротивления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            iElementBindingSource.DataSource = null;
            foreach (IElement i in Elements )
            {
                i.Freq = Convert.ToDouble(AngularFreqTextBox.Text);
            }
            iElementBindingSource.DataSource = Elements;
        }
        /// <summary>
        /// Изменение объектов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyElement_Click(object sender, EventArgs e)
        {
            int index = elementDataGridView.SelectedCells[0].RowIndex;
            var form = new AddForm
                       {
                               Element = Elements[index]
                       };
            if ( form.ShowDialog() == DialogResult.OK )
            {
                iElementBindingSource.RemoveAt(index);
                iElementBindingSource.Insert(index, form.Element);
            }
        }
        /// <summary>
        /// Сохранение 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Elements.Count != 0 )
            {
                var ofd = new SaveFileDialog
                          {
                                  Filter = @"txt files (*.dat)|*.dat",
                                  RestoreDirectory = true
                          };
                if ( !(ofd.FileName == null || ofd.ShowDialog() == DialogResult.Cancel) )
                {
                    Serialization.Serialize(ofd.FileName, Elements);
                }
            }
            else
            {
                MessageBox.Show(@"Ошибка. Файл не може быть пустым");
            }
        }
        /// <summary>
        /// Открытие
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if ( !(ofd.FileName == null || ofd.ShowDialog() == DialogResult.Cancel) )
            {
                Elements = Serialization.Deserialize(ofd.FileName);
                iElementBindingSource.DataSource = Elements;
            }
        }
        /// <summary>
        /// Автозаполнение таблицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutoCreateButton_Click(object sender, EventArgs e)
        {
            iElementBindingSource.Add(new Resistor("Резистор ", 91.3, 10));
            iElementBindingSource.Add(new Capacitor("Конденсатор ", 1.9, 10));
            iElementBindingSource.Add(new Inductor("Катушка ", 23, 10));
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var form = new SearchForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
}
