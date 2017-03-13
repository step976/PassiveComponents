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
                
            }
        }
    }
}
