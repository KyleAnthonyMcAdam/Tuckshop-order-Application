using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuckshop_forms
{
    internal class Order
    {
        public string TextFileName = @"C:\Users\User\Desktop\PRG281_TuckShop_Project1\Tuckshop forms\Products.txt";
 
        private List<string> ProductID = new List<string>();
        private List<string> ProductName = new List<string>();
        private List<string> ProductPrice = new List<string>();
        private List<string> ProductQuantity = new List<string>();
        private List<string> OrderedItems = new List<string>();

        public Order(List<string> productID, List<string> productName, List<string> productPrice, List<string> productQuantity)
        {
            ProductID = productID;
            ProductName = productName;
            ProductPrice = productPrice;
            ProductQuantity = productQuantity;
        
        }
        public Order()
        {


        }

        public List<string> ProductID1 { get => ProductID; set => ProductID = value; }
        public List<string> ProductName1 { get => ProductName; set => ProductName = value; }
        public List<string> ProductPrice1 { get => ProductPrice; set => ProductPrice = value; }
        public List<string> ProductQuantity1 { get => ProductQuantity; set => ProductQuantity = value; }
     

        public void LoadandDisplay()
        {
            string line;
            int count = 0;
            int test;

            try
            {
                using (StreamReader sr = new StreamReader(TextFileName))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] ProductDetails = line.Split(':');
                        ProductID1.Add(ProductDetails[0]);
                        ProductName1.Add(ProductDetails[1]);
                        ProductPrice1.Add(ProductDetails[2]);
                        ProductQuantity1.Add(ProductDetails[3]);
                    }
                }
              
            }
            catch (Exception e)
            {

                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        public List<string> OrderItems()
        {
            Console.WriteLine("Please enter the item number you'd like to order\nWhen you are finished ordering enter a negative number");

            int choice = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            Console.WriteLine(ProductName.Count);

            while (choice >= 0 && (ProductName.Count) >= count)
            {
                OrderedItems.Add(ProductName[choice] + ":" + ProductPrice[choice]);
                choice = Convert.ToInt32(Console.ReadLine());
                count++;
            }

            return OrderedItems;
        }
    }
}
