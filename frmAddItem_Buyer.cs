using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FinalProject_orengal_part5_GUI.Product;
using static System.Windows.Forms.AxHost;

namespace FinalProject_orengal_part5_GUI
{
    public partial class frmAddItem_Buyer : Form
    {
        string Product_Name;


        Product product;
        public Store _store;
        string sellerName;
        string buyerName;
        public frmAddItem_Buyer(Store store)
        {

            InitializeComponent();
            _store = store;
            PopulateSellerComboBox();
            PopulateBuyerComboBox();
            PopulateProductComboBox(sellerName);
        }

        private bool isEmpty(string s)
        {
            return !string.IsNullOrEmpty(s);
        }




        private void comboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product_Name = comboProduct.SelectedItem.ToString();
        }



        private void PopulateProductComboBox(string seller)
        {
            comboProduct.Items.Clear();

            // Find the correct seller object based on sellerName
            var selectedSeller = _store.GetListOfSellers().FirstOrDefault(s => s.GetUserName() == sellerName);

            if (selectedSeller != null)
            {
                // Populate the comboProduct with products from the selected seller
                foreach (var product in selectedSeller.GetItemList())
                {
                    comboProduct.Items.Add(product.GetProduct_Name());

                }
            }

        }


        private void comboSeller_SelectedIndexChanged(object sender, EventArgs e)
        {
            sellerName = comboSeller.SelectedItem.ToString();
            PopulateProductComboBox(sellerName);
        }

        private void PopulateSellerComboBox()
        {
            comboSeller.Items.Clear();
            foreach (var seller in _store.GetListOfSellers())
            {
                comboSeller.Items.Add(seller.GetUserName());
            }

        }

        private void comboBuyer_SelectedIndexChanged(object sender, EventArgs e)
        {
            buyerName = comboBuyer.SelectedItem.ToString();
        }


        private void PopulateBuyerComboBox()
        {
            comboBuyer.Items.Clear();
            foreach (var buyer in _store.GetListOFBuyer())
            {
                comboBuyer.Items.Add(buyer.GetUserName());
            }
        }


        private void btnGo_AddItem_Click(object sender, EventArgs e)
        {
            Product np = new Product();

            if (isEmpty(Product_Name) == false)
            {
                MessageBox.Show("Please ensure that all the details are completed.");
                return;
            }



            if (sellerName == null)
            {
                MessageBox.Show("Choose a seller");
                return;
            }


            if (buyerName == null)
            {
                MessageBox.Show("Choose a buyer");
                return;
            }




            for (int j = 0; j < _store.GetListOfSellers().Count; j++)
            {

                if (_store.GetListOfSellers()[j].GetUserName() == sellerName)
                {
                    Seller selectedseller = _store.GetListOfSellers()[j];
                    for (int i = 0; i < selectedseller.GetItemList().Count; i++)
                    {
                        if (selectedseller.GetItemList()[i].GetProduct_Name() == Product_Name)
                            np = selectedseller.GetItemList()[i];
                    }
                }

            }



            for (int i = 0; i < _store.GetListOFBuyer().Count; i++)

                if (_store.GetListOFBuyer()[i].GetUserName() == buyerName)
                {

                    _store.GetListOFBuyer()[i].AddProduct(np);
                    break;
                }
            Store store = _store;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void sellerNamelbl_Click(object sender, EventArgs e)
        {

        }
    }
}

//np.SetProduct_Name(Product_Name);


//for (int i = 0; i < _store.GetListOFBuyer().Count; i++)
//{

//    if (_store.GetListOFBuyer()[i].GetUserName() == buyerName)
//    {
//        _store.GetListOFBuyer()[i].AddProduct(np);
//        break;
//    }
//}
