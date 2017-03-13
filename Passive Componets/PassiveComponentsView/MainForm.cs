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
    public partial class MainForm : Form
    {
        private List<IElement> Elements { get; set; }
        public MainForm()
        {
            Elements = new List<IElement>();
            InitializeComponent();
        }

        private void Form1Load(object sender, EventArgs e)
        {

        }


        private void FileToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddElement_Click(object sender, EventArgs e)
        {
           
            var form = new AddForm();
            if ( form.ShowDialog() == DialogResult.OK )
            {
                IElement element = form.Element;
                Elements.Add(element);
                elementDataGridView.Rows.Add(element.UniqueName, element.Value, element.GetImpedance(Convert.ToDouble(AngularFreq.Text)));
            }
        }

        private void RemoveElementClick(object sender, EventArgs e)
        {
            int index = elementDataGridView.SelectedCells[0].RowIndex;
            elementDataGridView.Rows.RemoveAt(index);
            Elements.RemoveAt(index);
        }

        private void CalculateButtonClick(object sender, EventArgs e)
        {
            for (var i = 0; i < Elements.Count; i++)
            {
                elementDataGridView.Rows[i].Cells[2].Value = Elements[i].GetImpedance(Convert.ToDouble((AngularFreq.Text)));
            }
        }

        private void ModifyElementClick(object sender, EventArgs e)
        {
            int index = elementDataGridView.SelectedCells[0].RowIndex;
            var form = new AddForm();
            form.Element = Elements[index];
            form.ShowDialog();
            IElement elemnt = form.Element;
            Elements.RemoveAt(index);
            Elements.Insert(index, elemnt);
            elementDataGridView.Rows.RemoveAt(index);
            elementDataGridView.Rows.Insert(index, elemnt.UniqueName, elemnt.Value, elemnt.GetImpedance(Convert.ToDouble(AngularFreq.Text)));
        }
    }
}
