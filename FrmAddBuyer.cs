using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinalProject_orengal_part5_GUI
{
    public partial class FrmAddBuyer : Form
    {
        string streetName;
        string city;
        string state;
        string adressNum;
        string userName;
        string password;
        Buyer _ub;

        public FrmAddBuyer(Buyer ub)
        {
            InitializeComponent();
            _ub = ub;
        }

        public Buyer Buyer => _ub;

        private bool isEmpty(string s)
        {
            return !string.IsNullOrEmpty(s);
        }

        private bool isIntWrong(string input)
        {
            int result;

            if (!int.TryParse(input, out result) || result <= 0)
            {
                return false;
            }
            return int.TryParse(input, out result);
        }


        private bool isIntEmpty(string input)
        {
            if (string.IsNullOrEmpty(input) || int.Parse(input) <= 0)
            {
                return false;
            }
            int result;
            return int.TryParse(input, out result);
        }

        private void txtState_TextChanged(object sender, EventArgs e)
        {
            state = txtState.Text;

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            city = txtCity.Text;
        }

        private void txtStreetName_TextChanged(object sender, EventArgs e)
        {
            streetName = txtStreetName.Text;
        }

        private void txtAddressNum_TextChanged(object sender, EventArgs e)
        {
            adressNum = txtAddressNum.Text;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            userName = txtUserName.Text;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            password = txtPassword.Text;
        }

        private void btnGo_Buyer_Click(object sender, EventArgs e)
        {

            if (!isEmpty(state) || !isEmpty(city) || !isEmpty(streetName) ||!isEmpty(adressNum) 
                || !isEmpty(userName) || !isEmpty(password))
            {
                MessageBox.Show("Please ensure that all the details are completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!isIntWrong(adressNum))
            {
                MessageBox.Show("Invalid number - must be a valid number greater than zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
     
            Address usadress = new Address(int.Parse(adressNum), state, city, streetName);
            _ub.SetAddress(usadress);
            _ub.SetUserName(userName);
            _ub.SetPassword(password);
            Buyer ub = _ub;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void citylbl_Click(object sender, EventArgs e)
        {

        }

        private void userNamelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
