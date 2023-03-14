using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuckshop_forms
{
    internal class Product
    {

        List<string> productID = new List<string>();//parallel lists
        List<string> productName = new List<string>();
        List<string> productPrice = new List<string>();
        List<string> productQuantity = new List<string>();
        public string TextFileName = "Products.txt";
       

        public List<string> ProductID { get => productID; set => productID = value; }
        public List<string> ProductName { get => productName; set => productName = value; }
        public List<string> ProductPrice { get => productPrice; set => productPrice = value; }
        public List<string> ProductQuantity { get => productQuantity; set => productQuantity = value; }


        public Product(List<string> productID, List<string> productName, List<string> productPrice, List<string> productQuantity)
        {
            this.productID = productID;
            this.productName = productName;
            this.productPrice = productPrice;
            this.productQuantity = productQuantity;
  

        }
        public Product()
        {
    

        }
        public void LoadProducts()// load text file items in to lists
        {
            string line;

            try
            {

                using (StreamReader productDetials = new StreamReader(TextFileName))
                {

                    while ((line = productDetials.ReadLine()) != null)
                    {
                        string[] ProductDetails = line.Split(':');
                        productID.Add(ProductDetails[0]);
                        productName.Add(ProductDetails[1]);
                        productPrice.Add(ProductDetails[2]);
                        productQuantity.Add(ProductDetails[3]);
                    }
                    productDetials.Close();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
           // Product products = new Product(productID, productName, productPrice, productQuantity);
        }

    

        public string Add(string name,string price,string quantity)// adds item to textfile and lists
        {
            string text;
            string ID;
            //var lines = File.ReadAllLines(TextFileName).Where(arg => !string.IsNullOrWhiteSpace(arg));
            //File.WriteAllLines(TextFileName, lines);

        LoadProducts();
      
            ID = (productName.Count + 1).ToString();
            productName.Add(name);
            productPrice.Add(price);
            productQuantity.Add(quantity);
            productID.Add(ID);


            text = ID + ":" + name + ":" + price + ":" + quantity;
            File.AppendAllText(TextFileName,text);
            //await file.WriteLineAsync(text);
            return text;
            productID.Clear();
            productName.Clear();
            productPrice.Clear();
            productQuantity.Clear();
            LoadProducts();


            }
        public void Remove(string id)//removes item from list
        {
            string tempFile = Path.GetTempFileName();
            string line;
       
            using (var streamReader = new StreamReader(TextFileName))
            using (var streamWriter = new StreamWriter(tempFile))
            {
                while ((line = streamReader.ReadLine()) != null)
                {

                    string[] productDetails = line.Split(':');
                    if (productDetails[0] != id)
                        streamWriter.WriteLine(line);
                }
            }

            File.Delete(TextFileName);
            File.Move(tempFile, TextFileName);

            productID.Clear();
            productName.Clear();
            productPrice.Clear();
            productQuantity.Clear();

            LoadProducts();

        }
        public string Update(string id,string name,string price, string quantity)//changes item details based on id
        {
            int icount = 0;
            LoadProducts();
            string Line = null;
            foreach (var item in productID)
            {
                if (item == id)
                {
                    Line = productID[icount] + ":" + name + ":" + price + ":" + quantity;

                    break;
                }
                else
                {
                    icount++;
                }
            }
            if (Line != null)
            {
                string[] arrLine = File.ReadAllLines(TextFileName);
                arrLine[icount] = Line;
                File.WriteAllLines(TextFileName, arrLine);
            }
            
       
          return Line;
        }

    }
}
