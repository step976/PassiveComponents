using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

using Passive_Componets;

namespace PassiveComponentsView
{
    public partial class MainForm : Form
    {
        private List<IElement> Elements { get; set; }

        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
            Elements = new List<IElement>();

            UpdateGrid();
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
                IElement element = form.Element;
                Elements.Add(element);
                elementDataGridView.Rows.Add(
                        element.UniqueName,
                        element.Value,
                        element.GetImpedance(Convert.ToDouble(AngularFreqTextBox.Text)));
            }
        }

        private void RemoveElement_Click(object sender, EventArgs e)
        {
            int index = elementDataGridView.SelectedCells[0].RowIndex;
            elementDataGridView.Rows.RemoveAt(index);
            Elements.RemoveAt(index);
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < Elements.Count; i++)
            {
                elementDataGridView.Rows[i].Cells[2].Value = Elements[i].GetImpedance(Convert.ToDouble((AngularFreqTextBox.Text)));
            }
        }

        private void ModifyElement_Click(object sender, EventArgs e)
        {
            int index = elementDataGridView.SelectedCells[0].RowIndex;
            var form = new AddForm();
            form.Element = Elements[index];
            form.ShowDialog();
            IElement elemnt = form.Element;
            Elements.RemoveAt(index);
            Elements.Insert(index, elemnt);
            elementDataGridView.Rows.RemoveAt(index);
            elementDataGridView.Rows.Insert(index,
                    elemnt.UniqueName,
                    elemnt.Value,
                    elemnt.GetImpedance(Convert.ToDouble(AngularFreqTextBox.Text)));
        }

        private void UpdateGrid()
        {
            elementDataGridView.Rows.Add(Element.name);
            elementDataGridView.Rows.Add(Element.nominal);
            elementDataGridView.Rows.Add(Element.impedance);
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mySaveFileDialog = new SaveFileDialog
                                   {
                                           InitialDirectory = ".",
                                           Filter = @"element files (*.elm)|*.elm|All files(*.*)|*.*",
                                           FilterIndex = 1,
                                           RestoreDirectory = true,
                                           FileName = "elementDoc"
                                   };

            if ( mySaveFileDialog.ShowDialog() == DialogResult.OK )
            {
                Stream myStream = mySaveFileDialog.OpenFile();

                var serializer = new BinaryFormatter();
                serializer.Serialize(myStream, Elements);
                myStream.Close();
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myOpenFileDialog = new OpenFileDialog
                                   {
                                           InitialDirectory = ".",
                                           Filter = @"element files (*.elm)|*.elm|All files(*.*)|*.*",
                                           FilterIndex = 1,
                                           RestoreDirectory = true
                                   };

            if ( myOpenFileDialog.ShowDialog() == DialogResult.OK )
            {
                Elements.Clear();

                Stream stream = myOpenFileDialog.OpenFile();
                var deserializer = new BinaryFormatter();
                Elements = deserializer.Deserialize(stream) as List<IElement>;
                stream.Close();
                elementDataGridView.Update();

            }
        }
    }   
}
