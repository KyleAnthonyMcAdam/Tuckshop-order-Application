using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tuckshop_forms
{
    public partial class DisplayOrdersDorm : Form
    {
        public DisplayOrdersDorm()
        {
            InitializeComponent();
        }

        private void btnBackIPastOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void DisplayOrdersDorm_Load(object sender, EventArgs e)
        {
            List<string> productID = new List<string>();
            List<string> productName = new List<string>();
            List<string> productPrice = new List<string>();
            List<string> productQuantity = new List<string>();
            string line;
            int count = 0;

            try
            {
             
                string filePath = "OrdersTextFile.txt";

                using (StreamReader sr = new StreamReader(filePath))//reads orders
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] ProductDetails = line.Split(':');
                        productID.Add(ProductDetails[0]);
                        productName.Add(ProductDetails[1]);
                        productPrice.Add(ProductDetails[2]);
                        productQuantity.Add(ProductDetails[3]);
                    }
                }
            }catch(Exception ex)
            {

                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }

            gridviewPastOrders.ColumnCount = 4;
            gridviewPastOrders.Rows.Add("Product ID", "Name", "Price", "Quantity");

            foreach(var item in productID)
            {
                gridviewPastOrders.Rows.Add(productID[count], productName[count], "R "+productPrice[count], productQuantity[count]);
                count++;
            }

            //int icount = 0;

  
        }
    }
}
