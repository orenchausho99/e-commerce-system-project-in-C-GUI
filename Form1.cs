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
    public partial class Form1 : Form
    {
        Store store;

        public Form1()
        {           
            InitializeComponent();
            store = new Store();
            store.SetName("Karnaf_Afula ");
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btmAddSeller_Click(object sender, EventArgs e)
        {
            Seller us = new Seller();
            using (frmAddSeller frmAddSeller = new frmAddSeller(us))
            {

                frmAddSeller.ShowDialog();
                if (frmAddSeller.DialogResult == DialogResult.OK)
                {

                    us = frmAddSeller.Seller;
                    store.AddUserSeller(us);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (store.GetListOfSellers().Count == 0)
            {
                MessageBox.Show("No sellers available to add a product.");
                return;
            }

            using (frmAddItem_Seller frmAddItem_Seller = new frmAddItem_Seller(store))
            {
                if (frmAddItem_Seller.ShowDialog() == DialogResult.OK)                                   
                    store = frmAddItem_Seller._store;
                
            }




        }


        private void btnAddBuyer_Click(object sender, EventArgs e)
        {
            Buyer ub = new Buyer();
            using (FrmAddBuyer FrmAddBuyer = new FrmAddBuyer(ub))
            {

                FrmAddBuyer.ShowDialog();
                if (FrmAddBuyer.DialogResult == DialogResult.OK)
                {

                    ub = FrmAddBuyer.Buyer;
                    store.AddUserBuyer(ub);
                }
            }

        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {          

            using (frmDisplayAll frmDisplayAll = new frmDisplayAll(store))
            {
                frmDisplayAll.ShowDialog();
               
            }
        }
        private void btnProductBuyer_Click(object sender, EventArgs e)
        {
            if (store.GetListOFBuyer().Count == 0)
            {
                MessageBox.Show("There are no Buyers available to add the product.");
                return;
            }

            using (frmAddItem_Buyer frmAddItem_Buyer = new frmAddItem_Buyer(store))
            {
                if (frmAddItem_Buyer.ShowDialog() == DialogResult.OK)                                    
                    store = frmAddItem_Buyer._store;
                
            }
        }
    }
}

