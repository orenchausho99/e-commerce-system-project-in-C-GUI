using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinalProject_orengal_part5_GUI
{
    public class Buyer : User
    {

        List<Product> ShoppingCart;
        List<Order> OrderList;
        double TotalShoppingCart;


        public static bool operator <(Buyer count1, Buyer count2)
        {
            count1.SetTotalShoppingCart();
            count2.SetTotalShoppingCart();

            return (count1.GetTotalShoppingCart() < count2.GetTotalShoppingCart());
        }
        public static bool operator >(Buyer count1, Buyer count2)
        {
            count1.SetTotalShoppingCart();
            count2.SetTotalShoppingCart();

            return (count1.GetTotalShoppingCart() > count2.GetTotalShoppingCart());
        }

        public List<Order> GetOrderList()
        {
            return OrderList;
        }


        public bool SetOrderList(List<Order> OrderList)
        {
            if (OrderList == null)
                return false;

            this.OrderList = OrderList;

            return true;
        }


        public List<Product> GetShoppingCart()
        {
            return ShoppingCart;
        }


        public bool SetShoppingCart(List<Product> ShoppingCart)

        {
            if (ShoppingCart != null)
            {
                this.ShoppingCart = ShoppingCart;
                return true;
            }

            return false;


        }
        public bool SetOneItem(Product item, int index)
        {
            if (item != null && (index >= 0 && index <= ShoppingCart.Count))
            {
                ShoppingCart[index] = item;
                return true;
            }
            return false;
        }
        public void AddProduct(Product theproduct)
        {
            ShoppingCart.Add(theproduct);
        }

        public void UseOrderHistory(int input)
        {
            if ((OrderList != null) && ((input - 1) <= OrderList.Count) && (input - 1 >= 0))
            {
                ShoppingCart = OrderList[input - 1].GetItem_List();
            }
        }
        public double GetTotalShoppingCart()
        {
            return TotalShoppingCart;
        }


        public double SetTotalShoppingCart()
        {
            double total = 0.0;
            for (int i = 0; i < ShoppingCart.Count; i++)
                total += ShoppingCart[i].GetProduct_Price();
            TotalShoppingCart = total;

            return TotalShoppingCart;
        }

        public bool Checkout(Buyer buyer)
        {
            if (ShoppingCart.Count == 0)
            {
                throw new Exception("Error - shopping cart is empty!");

            }
            if (ShoppingCart.Count == 1)
            {
                throw new Exception("Error - can not checkout with only one item!");
            }
            double total = SetTotalShoppingCart();
            Order checkout = new Order(ShoppingCart, total, buyer);
            this.ShoppingCart = null;
            AddOrderToOrderList(checkout);
            return true;
        }

        public void AddOrderToOrderList(Order checkout)
        {
            OrderList.Add(checkout);
        }
        public Buyer(string username, string password, Address address, List<Product> ShoppingCart, List<Order> OrderList)
            : base(username, password, address)
        {
            SetShoppingCart(ShoppingCart);
            SetOrderList(OrderList);

        }

        public Buyer() : base()
        {

            ShoppingCart = new List<Product>();
            OrderList = new List<Order>();
        }

        public void OrdersToString()
        {
            Console.WriteLine("Order list:");
            if (OrderList == null)
            {

                Console.WriteLine("Order list is empty");
            }
            else
            {
                for (int j = 0; j < OrderList.Count; j++)
                {
                    if (OrderList[j] != null)
                    {
                        Console.WriteLine($"order {j + 1} : ");
                        OrderList[j].ToString();
                    }

                }
            }
        }
        public string ToString()
        {
            string Stringbuyer = "The format:[Name][Password]" + Environment.NewLine;
            Stringbuyer += $"Username: {username}, Password: {password}" + Environment.NewLine;
            Stringbuyer += address.ToString() + Environment.NewLine;
            Stringbuyer += "Shopping cart:";
            Stringbuyer += Environment.NewLine + " Orders & Shoping cart : " + Environment.NewLine;

            if (ShoppingCart == null)
            {
                Stringbuyer += "Shoping cart is empty" + Environment.NewLine;
            }
            else
            {
                for (int i = 0; i < ShoppingCart.Count; i++)
                {
                    if (ShoppingCart[i] != null)
                    {
                        Stringbuyer+= $"Product {i + 1} : " + Environment.NewLine;
                        Stringbuyer+=ShoppingCart[i].ToString() + Environment.NewLine;
                    }

                }
            }
            Stringbuyer += " " + Environment.NewLine;

            OrdersToString();
            return Stringbuyer; 
        }




    

    }
}
