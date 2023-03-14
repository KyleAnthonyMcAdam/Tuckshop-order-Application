using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuckshop_forms
{
    internal class Login
    {
        string userName;
        string userPassword;
        private Dictionary<string, string> Credentials = new Dictionary<string, string>();

        public string UserName { get => userName; set => userName = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }
        public Dictionary<string, string> Credentials1 { get => Credentials; set => Credentials = value; }

  //

        public void LoadUserPassword()//loads user details from text file
            {
                string TextFileName = "Login.txt";
          
                try
                {
                    using (StreamReader UserPassword = new StreamReader(TextFileName))
                    {
                        string line;

                        // Read and display lines from the file until the end of
                        // the file is reached.
                        while ((line = UserPassword.ReadLine()) != null)
                        {
                            string[] login = line.Split(':');
                            Credentials.Add(login[0], login[1]);
                        }
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(e.Message);
           
            }
            }
            public bool CheckUserPassword(string user, string password)// checks password returns bool
            {
                bool authentication = false;
                foreach (KeyValuePair<string, string> item in Credentials)
                {
                    if (item.Key == user && item.Value == password)
                    {
                        return true;
                    }
                }
                return authentication;
            }
        


    }
}
