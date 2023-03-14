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
    public partial class LoginForm : Form
    {

        Login login = new Login();
        public LoginForm()
        {
            InitializeComponent();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName=      this.txtUsername.Text;
            string userpassword = this.txtPassword.Text;
            bool bLogin;
            bLogin = login.CheckUserPassword(userName, userpassword);
            if (bLogin)
            {
                MessageBox.Show("Username and password correct");


             
                this.Hide();
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
            
            }
          else
                MessageBox.Show("Username and password incorrect, Try Again");

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            login.LoadUserPassword();

      
        }

        private void lblTuckshopHeading_Click(object sender, EventArgs e)
        {
      
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
