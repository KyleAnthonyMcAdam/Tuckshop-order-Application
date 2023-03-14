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

    public partial class DeleteIForms : Form
    {
        List<string> productID = new List<string>();
        List<string> productName = new List<string>();
        List<string> productPrice = new List<string>();
        List<string> productQuantity = new List<string>();
        public DeleteIForms()
        {
            InitializeComponent();
        }

        private void btnBackUpdate_Click(object sender, EventArgs e)// back to menu
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)//deletes item
        {
            productID.Clear();
            productName.Clear();
            productPrice.Clear();
            productQuantity.Clear();
            string id = txtboxItemDelete.Text;
            string product = "";
            Product remove = new Product(productID, productName, productPrice, productQuantity);
            remove.Remove(id);

            dataGridItemsDelete.Rows.Clear();
            remove.LoadProducts();

            int icount = 0;
            dataGridItemsDelete.ColumnCount = 4;
            dataGridItemsDelete.Rows.Add("Product ID", "Name", "Price", "Quantity");

            foreach (var item in productID)
            {
                if (item == id)
                {
                    product = productName[icount];
                }
                dataGridItemsDelete.Rows.Add(productID[icount], productName[icount], productPrice[icount], productQuantity[icount]);
                icount++;
            }
            MessageBox.Show("Product " + product + " removed");
            productID.Clear();
            productName.Clear();
            productPrice.Clear();
            productQuantity.Clear();
        }


        private void DeleteIForms_Load(object sender, EventArgs e)//load items in to grid
        {
            Product products = new Product(productID, productName, productPrice, productQuantity);
            products.LoadProducts();
            int icount = 0;

            dataGridItemsDelete.ColumnCount = 4;
            dataGridItemsDelete.Rows.Add("Product ID", "Name", "Price", "Quantity");
            foreach (var item in productID)
            {
                dataGridItemsDelete.Rows.Add(productID[icount], productName[icount], "R " + productPrice[icount], productQuantity[icount]);
                icount++;
            }
        }
    }
}
