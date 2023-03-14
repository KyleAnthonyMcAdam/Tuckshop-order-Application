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
    public partial class MainMenu : Form
    {
  
        public MainMenu()
        {
            InitializeComponent();


           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           DisplayProductsForm displayProductsForm = new DisplayProductsForm();
            displayProductsForm.Show();
           
    


        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddForm addForm = new AddForm();    
            addForm.Show(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteIForms deleteIForms=new DeleteIForms();   
            deleteIForms.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateForm updateForm = new UpdateForm();
            updateForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DisplayOrdersDorm displayOrdersDorm= new DisplayOrdersDorm();
            displayOrdersDorm.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string filePath = "OrdersTextFile.txt";
            File.WriteAllText(filePath, String.Empty);
            this.Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
