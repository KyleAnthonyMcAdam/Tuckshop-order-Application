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
    public partial class OrderForm : Form
    {

        double Total = 0;
        string FilePath = @"C:\Users\User\Desktop\PRG281_TuckShop_Project1\Tuckshop forms\OrdersTextFile.txt";

        List<string> OrderList = new List<string>();
        public List <string> OrderedItems = new List<string>();
        public OrderForm()
        {
            InitializeComponent();
             
        }

        private void btnBackOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
           

            double Total = 0;
            if (OrderedItems != null)
            {
                List <string> productID = new List <string>();
                List <string> productName = new List <string>();
                List <string> productPrice = new List <string>();
                List <string> productQuantity = new List <string>();
              
                Product products = new Product(productID, productName, productPrice, productQuantity);
                products.LoadProducts();
                int itemProd;
                string text="";
                foreach (var item in OrderedItems)
                {
                    itemProd = Convert.ToInt32(item);
                    if (item == productID[itemProd-1])
                    {                   
                            text=text+(productID[itemProd - 1] + ":" + productName[itemProd - 1] + ":" + productPrice[itemProd - 1] + ":" + productQuantity[itemProd - 1]+"\n" );
                     
                         

                    }
                }
                add(text);
                MessageBox.Show("Order Placed");
            }
            
        }
        public void add(string text)
        {

            string FilePath = "OrdersTextFile.txt";
            File.WriteAllText(FilePath, text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridItemsOrder.Rows.Clear();
            List<string> productID = new List<string>();
            List<string> productName = new List<string>();
            List<string> productPrice = new List<string>();
            List<string> productQuantity = new List<string>();
            Total = 0;
            string id = txtboxItemOrder.Text;
            OrderedItems.Add(id);
            int icount = 0;

            Product products = new Product(productID, productName, productPrice, productQuantity);
            products.LoadProducts();
            dataGridItemsOrder.ColumnCount = 4;
            foreach (var item in OrderedItems)
            {
               
                foreach (var item2 in productID)
                    {
                        if (item==item2)
                        {
                        dataGridItemsOrder.Rows.Add(productID[icount], productName[icount], "R " + productPrice[icount], productQuantity[icount]);
                        Total = Total + int.Parse(productPrice[icount]);
                    }
                    icount++;
                    
                }
           
                icount = 0;
            }
            dataGridItemsOrder.Rows.Add("", "", "total: R ", Total.ToString()); 
        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            List<string> productID = new List<string>();
            List<string> productName = new List<string>();
            List<string> productPrice = new List<string>();
            List<string> productQuantity = new List<string>();
            int icount = 0;
            Product products = new Product(productID, productName, productPrice, productQuantity);

            products.LoadProducts();
            dataGridViewProducts.ColumnCount = 4;
            dataGridViewProducts.Rows.Add("Product ID", "Name", "Price", "Quantity");
            foreach (var item in productID)
            {
                dataGridViewProducts.Rows.Add(productID[icount], productName[icount], "R " + productPrice[icount], productQuantity[icount]);
                icount++;
            }
        }
    }
}
