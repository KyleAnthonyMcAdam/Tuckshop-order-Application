using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuckshop_forms
{
    internal class Sales
    {
        public void DisplaySales(List<string> orderedItems)
        {
            string food;
            int price;
            int total = 0;
            Console.WriteLine("Items Ordered:");

            foreach (string item in orderedItems)
            {
                food = item.Substring(item.IndexOf(":"));
                price = Convert.ToInt32(item.Substring(item.IndexOf(":"), item.Length));
                total += price;
                Console.WriteLine(food + "\t" + price);
            }

            Console.WriteLine("Total amount owed:\t" + total);
        }
    }
}
