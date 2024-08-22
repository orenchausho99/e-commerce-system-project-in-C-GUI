using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_orengal_part5_GUI
{
    public class Store
    {
        string name;
        List<Seller> listOfSellers;
        List<Buyer> listOfBuyers;
         

        public static Store operator +(Store store, Buyer ub)
        {
            store.listOfBuyers.Add(ub);
            return store;
        }
        public static Store operator +(Store store, Seller us)
        {
            store.listOfSellers.Add(us);
            return store;
        }
        public string GetName()
        {
            return name;
        }
        public List<Seller> GetListOfSellers()
        {
            return listOfSellers;
        }
        public List<Buyer> GetListOFBuyer()
        {
            return listOfBuyers;
        }
        public bool SetName(string name)
        {
            if (name != null)
            {
                this.name = name;
                return true;
            }
            return false;
        }
        public bool SetListOfSellers(List<Seller> sellers)
        {
            if (sellers != null)
            {
                listOfSellers = sellers;
                return true;
            }
            return false;
        }

        public bool SetListOfBuyer(Buyer buyer, int index)
        {
            if (buyer != null && (index >= 0 && index <= listOfBuyers.Count))
            {
                listOfBuyers[index] = buyer;
                return true;
            }
            return false;
        }

        public void AddUserBuyer(Buyer ub)
        {
            listOfBuyers.Add(ub);
        }

        public void AddUserSeller(Seller us)
        {
            listOfSellers.Add(us);
        }

        public Store(string allBuyers,string allSellers,string name, List<Seller> listOfSellers, List<Buyer> listOfBuyers)
        {
             
            this.name = name;
            this.listOfSellers = new List<Seller>();
            this.listOfBuyers = new List<Buyer>();
        }
        public Store()
        {
           
            name = "";
            listOfBuyers = new List<Buyer>();
            listOfSellers = new List<Seller>();
        }
        public string DisplayAllBuyers()
        {
            string allBuyers = name + "Shop buyers:";
            allBuyers += Environment.NewLine+"List of Buyers" + Environment.NewLine;
          
            if ( listOfBuyers.Count != 0)
            {
                for (int j = 0; j < listOfBuyers.Count; j++)
                {
                    allBuyers += "Buyer " + (j + 1) + ":" + Environment.NewLine;                   
                   allBuyers+= listOfBuyers[j].ToString() + Environment.NewLine;
                    allBuyers += "------------" + Environment.NewLine;
                }

            }
            else
            {
                allBuyers += "There are no buyers!" + Environment.NewLine;
            }
            return allBuyers;   
        }

        public string DisplayAllSellers()
        {
            listOfSellers.Sort((p1, p2) => p2.GetNumOfProducts().CompareTo(p1.GetNumOfProducts()));
           string allSellers = " Shop sellers:" + Environment.NewLine;
            

            allSellers += "List of Sellers:" + Environment.NewLine;
            if (listOfSellers == null || listOfSellers.Count == 0)
            {
                allSellers += "There are no sellers" + Environment.NewLine;
                return allSellers;
            }
            for (int i = 0; i < listOfSellers.Count; i++)
            {

                allSellers += "Seller " + (i + 1) + ":" + Environment.NewLine;
                allSellers+= listOfSellers[i].ToString() + Environment.NewLine;
                allSellers += Environment.NewLine + "------------" + Environment.NewLine;

            }
            return allSellers;
        }

    }
}
