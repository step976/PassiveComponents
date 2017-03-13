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
    public partial class AddForm : Form
    {
        public IElement Element { get; set; }

        public AddForm()
        {
            InitializeComponent();
        }

        private void AddFormLoad(object sender, EventArgs e)
        {

        }

        private void ComboBoxSelectSelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
