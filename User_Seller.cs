using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_orengal_part5_GUI
{
    public class Seller : User
    {
        int numOfProducts = 0;
        List<Product> itemList;


        public int GetNumOfProducts()
        { return numOfProducts; }

        public List<Product> GetItemList()
        {
            return itemList;
        }

        public bool SetItemList(List<Product> itemList)
        {
            if (itemList != null)
            {
                this.itemList = itemList;
                return true;
            }
            return false;
        }
        public bool SetOneItem(Product item, int index)
        {
            if (item != null && (index >= 0 && index <= itemList.Count))
            {
                itemList[index] = item;
                return true;
            }
            return false;
        }
        public void AddItem(Product theitem)
        {
            itemList.Add(theitem);
            numOfProducts++;
        }




        public Seller(string username, string password, Address address, List<Product> itemList, int numOfProducts)
            : base(username, password, address)
        {
            this.numOfProducts = numOfProducts;
            this.itemList = itemList;
        }
        public Seller() : base()
        {
            numOfProducts = 0;
            itemList = new List<Product>();
        }

        public string ToString()
        {
            string Stringseller = "The format:[name][password]" + Environment.NewLine;
            Stringseller += "Username: " + username + "  Password: " + password + Environment.NewLine;
            Stringseller += address.ToString() + Environment.NewLine;


            Stringseller += "Number of products: " + numOfProducts + Environment.NewLine +"Seller item list :" + Environment.NewLine;
            if (itemList != null)
            {
                for (int i = 0; i < itemList.Count; i++)
                {
                    if (itemList[i] != null)
                    {
                        Stringseller += $"Product {i + 1} : " + Environment.NewLine;
                        Stringseller+=itemList[i].ToString() + Environment.NewLine;
                    }

                }
            }
            else
                Stringseller += "There are no items" + Environment.NewLine;    
            
            return Stringseller;    
        }
    }
}
