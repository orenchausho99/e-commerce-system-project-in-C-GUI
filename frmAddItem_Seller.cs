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
    public partial class frmAddItem_Seller : Form
    {
        string Product_Name;
        string Product_Price;
        Product.Category category ;
        bool specialPackaging;
        Product product;
        public Store _store;
        string sellerName;
        public frmAddItem_Seller(Store store)
        {
            InitializeComponent();
            _store = store;
            PopulateSellerComboBox();
        }

        public Product Product => product;

        private bool isEmpty(string s)
        {
            return !string.IsNullOrEmpty(s);
        }

        private bool isDoubleEmpty(string input)
        {
            if (string.IsNullOrEmpty(input) || double.Parse(input) <= 0)
            {
                return false;
            }
            double result;
            return double.TryParse(input, out result);
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            Product_Name = txtProductName.Text;
        }

        private void txtProductPrice_TextChanged(object sender, EventArgs e)
        {
            Product_Price = txtProductPrice.Text;

        }

        private void radKids_CheckedChanged(object sender, EventArgs e)
        {
            category = Product.Category.kids;
        }

        private void radElectronics_CheckedChanged(object sender, EventArgs e)
        {
            category = Product.Category.electronics;
        }

        private void radOffice_CheckedChanged(object sender, EventArgs e)
        {
            category = Product.Category.office;
        }

        private void radClothing_CheckedChanged(object sender, EventArgs e)
        {
            category = Product.Category.clothing;
        }




        private void comboSeller_SelectedIndexChanged(object sender, EventArgs e)
        {

            sellerName = comboSeller.SelectedItem.ToString();

        }


        private void PopulateSellerComboBox()
        {
            comboSeller.Items.Clear();
            foreach (var seller in _store.GetListOfSellers())
            {
                comboSeller.Items.Add(seller.GetUserName());
            }
        }



        private void cboxSpecialPackage_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxSpecialPackage.Checked)
                specialPackaging = true;

            else
                specialPackaging = false;
        }


        private void btnGo_AddItem_Click(object sender, EventArgs e)
        {
            Product np = new Product();
            if (isEmpty(Product_Name) == false || isDoubleEmpty(Product_Price) == false)
            {
                MessageBox.Show("Please ensure that all the details are completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (category == default)
            {
                MessageBox.Show("Choose a category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (cboxSpecialPackage.Checked)
            {
                np.Setspecial_packaging('Y');
            }

            else
                np.Setspecial_packaging('N');

            if (sellerName == null)
            {
                MessageBox.Show("Choose a seller.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            np.SetProduct_Name(Product_Name);
            np.SetProduct_Price(double.Parse(Product_Price));
            np.SetCategory(category);
            for (int i = 0; i < _store.GetListOfSellers().Count; i++)
                if (_store.GetListOfSellers()[i].GetUserName() == sellerName)
                {
                    _store.GetListOfSellers()[i].AddItem(np);
                    break;
                }

            Store store = _store;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmAddItem_Seller_Load(object sender, EventArgs e)
        {

        }
    }
}
