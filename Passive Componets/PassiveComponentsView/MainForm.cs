using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

using Passive_Componets;

namespace PassiveComponentsView
{

    #region

    #endregion

    public partial class MainForm : Form
    {
        private List<IElement> _elements;
        private BinaryFormatter _formatter = new BinaryFormatter();

        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
            _elements = new List<IElement>();
            iElementBindingSource.DataSource = _elements;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddElement_Click(object sender, EventArgs e)
        {
            var form = new AddForm();
            if ( form.ShowDialog() == DialogResult.OK )
            {
                iElementBindingSource.Add(form.Element);
            }
        }

        private void RemoveElement_Click(object sender, EventArgs e)
        {
            if ( iElementBindingSource.Current != null )
            {
                foreach (DataGridViewRow row in ElementDataGridView.SelectedRows)
                {
                    iElementBindingSource.RemoveAt(row.Index);
                }
            }
            else
            {
                MessageBox.Show(@"Вы не выбрали строку которую хотите удалить", @"Ошибка!");
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            iElementBindingSource.DataSource = null;
            foreach (IElement i in _elements)
            {
                i.Freq = Convert.ToDouble(AngularFreqTextBox.Text);
            }
            iElementBindingSource.DataSource = _elements;
        }

        private void ModifyElement_Click(object sender, EventArgs e)
        {
            if ( iElementBindingSource.Current == null )
            {
                MessageBox.Show(@"Вы не выбрали строки для изменения", @"Ошибка!");
            }
            else
            {
                int index = ElementDataGridView.SelectedCells[0].RowIndex;
                var form = new AddForm
                           {
                                   Element = _elements[index]
                           };
                if ( form.ShowDialog() == DialogResult.OK )
                {
                    iElementBindingSource.RemoveAt(index);
                    iElementBindingSource.Insert(index, form.Element);
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( _elements.Count != 0 )
            {
                var ofd = new SaveFileDialog
                          {
                                  Filter = @"dat files (*.dat)|*.dat",
                                  RestoreDirectory = true
                          };
                if ( !(ofd.FileName == null || ofd.ShowDialog() == DialogResult.Cancel) )
                {
                    Serialization.Serialize(ofd.FileName, _elements);
                }
            }
            else
            {
                MessageBox.Show(@"Ошибка. Файл не може быть пустым");
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if ( !(ofd.FileName == null || ofd.ShowDialog() == DialogResult.Cancel) )
            {
                _elements = Serialization.Deserialize(ofd.FileName);
                iElementBindingSource.DataSource = _elements;
            }
        }

        private void AutoCreateButton_Click(object sender, EventArgs e)
        {
            iElementBindingSource.Add(new Resistor("Резистор ", 91.3, 10));
            iElementBindingSource.Add(new Capacitor("Конденсатор ", 1.9, 10));
            iElementBindingSource.Add(new Inductor("Катушка ", 23, 10));
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if ( SearchTextBox.Text != "" )
            {
                for (var i = 0; i < ElementDataGridView.RowCount; i++)
                {
                    ElementDataGridView.Rows[i].Selected = false;
                    for (var j = 0; j < ElementDataGridView.ColumnCount; j++)
                    {
                        if ( ElementDataGridView.Rows[i].Cells[j].Value == null )
                        {
                            continue;
                        }
                        if ( !ElementDataGridView.Rows[i].Cells[j].Value.ToString().Contains(SearchTextBox.Text) )
                        {
                            continue;
                        }
                        ElementDataGridView.Rows[i].Selected = true;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show(@"Введите значение поиска", @"Ошибка!");
            }
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _elements= new List<IElement>();
            iElementBindingSource.DataSource = _elements;
        }
    }
}