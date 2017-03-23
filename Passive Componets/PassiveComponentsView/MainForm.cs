using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Drawing;
using System.Text;
using Passive_Componets;

namespace PassiveComponentsView
{
    public partial class MainForm : Form
    {
        private List<IElement> Elements;
        BinaryFormatter formatter = new BinaryFormatter();

        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
            Elements = new List<IElement>();
            iElementBindingSource.DataSource = Elements;
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            AngularFreqTextBox.Text = 1.ToString();
        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            iElementBindingSource.RemoveCurrent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
         /*   for (var i = 0; i < Elements.Count; i++)
            {
                elementDataGridView.Rows[i].Cells[2].Value = Elements[i].GetImpedance(Convert.ToDouble((AngularFreqTextBox.Text)));
            }*/
        }

        private void ModifyElement_Click(object sender, EventArgs e)
        {
            int index = elementDataGridView.SelectedCells[0].RowIndex;
            var form = new AddForm
                       {
                               Element = Elements[index]
                       };
            form.ShowDialog();
            IElement elemnt = form.Element;
            Elements.RemoveAt(index);
            Elements.Insert(index, elemnt);
            elementDataGridView.Rows.RemoveAt(index);
            elementDataGridView.Rows.Insert(index, elemnt.UniqueName, elemnt.Value);
            // elemnt.GetImpedance(Convert.ToDouble(AngularFreqTextBox.Text)));
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Elements.Count != 0)
            {
                SaveFileDialog ofd = new SaveFileDialog();
                ofd.Filter = "txt files (*.dat)|*.dat";
                ofd.RestoreDirectory = true;
                if (!(ofd.FileName == null || ofd.ShowDialog() == DialogResult.Cancel))
                {
                    Serialization.Serialize(ofd.FileName, Elements);
                }
            }
            else
            {
                MessageBox.Show("Ошибка. Файл не може быть пустым");
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if ( !(ofd.FileName == null || ofd.ShowDialog() == DialogResult.Cancel) )
            {
                Elements = Serialization.Deserialize(ofd.FileName);
                iElementBindingSource.DataSource = Elements;
            }
        }
    }   
}
