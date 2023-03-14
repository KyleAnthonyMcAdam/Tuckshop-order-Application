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
    public partial class UpdateForm : Form
    {
        List<string> productID = new List<string>();
        List<string> productName = new List<string>();
        List<string> productPrice = new List<string>();
        List<string> productQuantity = new List<string>();
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void btnBackUpdate_Click(object sender, EventArgs e)//back to menu
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)//validates and update items
        {

            bool isValid = true;
            int n;
            string line;
            string id = txtboxItemUpdating.Text;
            string name = txtUpdateItem.Text;
            string price = txtUpdatePrice.Text;
            string quantity = textUpdateQuantity.Text;
            Product update = new Product(productID, productName, productPrice, productQuantity);
            bool isPrice = int.TryParse(price, out n);
            bool isQuantity = int.TryParse(quantity, out n);

            if (!isPrice)
            {
                MessageBox.Show("Price is not a number");
                isValid = false;
            }
            if (!isQuantity)
            {
                MessageBox.Show("Qantity is not a number");
                isValid = false;

            }
            if (isValid)
            {
                line = update.Update(id, name, price, quantity);
                string product = "";
                update.LoadProducts();
                dataGridItemsUpdate.Rows.Clear();

                int icount = 0;
                dataGridItemsUpdate.ColumnCount = 4;
                dataGridItemsUpdate.Rows.Add("Product ID", "Name", "Price", "Quantity");

                foreach (var item in productID)
                {
                    if (item == id)
                    {
                        product = productName[icount];
                    }
                    dataGridItemsUpdate.Rows.Add(productID[icount], productName[icount], productPrice[icount], productQuantity[icount]);
                    icount++;
                }
                MessageBox.Show("Product " + product + " Updated");
                productID.Clear();
                productName.Clear();
                productPrice.Clear();
                productQuantity.Clear();
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateForm_Load(object sender, EventArgs e)// loads gride with items
        {
            Product products = new Product(productID, productName, productPrice, productQuantity);
            products.LoadProducts();
            int icount = 0;

            dataGridItemsUpdate.ColumnCount = 4;
            dataGridItemsUpdate.Rows.Add("Product ID", "Name", "Price", "Quantity");
            foreach (var item in productID)
            {
                dataGridItemsUpdate.Rows.Add(productID[icount], productName[icount], "R " + productPrice[icount], productQuantity[icount]);
                icount++;
            }
        }
    }
}
