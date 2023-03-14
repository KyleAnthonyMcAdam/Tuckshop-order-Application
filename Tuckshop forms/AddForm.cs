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
    public partial class AddForm : Form
    {

        List<string> productID = new List<string>();//parallel lists
        List<string> productName = new List<string>();
        List<string> productPrice = new List<string>();
        List<string> productQuantity = new List<string>();
        public AddForm()
        {
            InitializeComponent();
        
        }

        private void btnLogin_Click(object sender, EventArgs e)//does back to menu
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
        private void AddForm_Load(object sender, EventArgs e)
        {
          
        }
        private void button1_Click(object sender, EventArgs e)//adds  item
        {
            Product addProduct = new Product(productID, productName, productPrice, productQuantity);
            addProduct.LoadProducts();
            bool isValid = true;
            string text;
            string name = txtAddItem.Text;
            string price = txtAddPrice.Text;
            string quantity = textAddQuantity.Text;
            string id = "0";
            int n;
            bool isPrice = int.TryParse(price, out n);//validation 
            bool isQuantity = int.TryParse(quantity, out n);
            foreach (var item in productName)
            {
                if (item == name)
                {
                    MessageBox.Show("Product Already exists");
                    isValid = false;
                }
            }
            if (name=="")
            {
                MessageBox.Show("Product name can not be blank");
                isValid = false;
            }
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

                text = addProduct.Add(name, price, quantity);
                MessageBox.Show("Product : " + name +"\nHas been added");
            }

        }

      
    }
}
