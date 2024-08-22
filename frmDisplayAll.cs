using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_orengal_part5_GUI
{
    
    public partial class frmDisplayAll : Form
    {
        Store _store;
        public frmDisplayAll(Store store)
        {
            InitializeComponent();
            _store = store;

        }

        private void txtBoxPrintAll_TextChanged(object sender, EventArgs e)
        {
            StringBuilder output = new StringBuilder();
            output.Append(_store.DisplayAllBuyers());       
            output.Append(_store.DisplayAllSellers());
            txtBoxPrintAll.Text = output.ToString();
        }
    }
}
