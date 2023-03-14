using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuckshop_forms
{
    public partial class DisplayProductsForm : Form
    {
        List<string> productID = new List<string>();
        List<string> productName = new List<string>();
        List<string> productPrice = new List<string>();
        List<string> productQuantity = new List<string>();

        public DisplayProductsForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void DisplayProductsForm_Load(object sender, EventArgs e)//dispalys items
        {
           
            int icount = 0;

            Product products = new Product(productID, productName, productPrice, productQuantity);
            products.LoadProducts();
            gridviewProducts.ColumnCount = 4;
            gridviewProducts.Rows.Add("Product ID", "Name", "Price", "Quantity");
            foreach (var item in productID)
            {
                gridviewProducts.Rows.Add(productID[icount], productName[icount], "R " + productPrice[icount], productQuantity[icount]);
                icount++;
            }

            
        }
    }
}
