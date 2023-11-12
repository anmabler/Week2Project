using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Project
{
    internal class Inventory
    {
        public List<Product> products = new List<Product>();

        // Method for showing items in list
        public void displayList()
        {
            Console.WriteLine("\nYour product list: ");
            Console.WriteLine("Category".PadRight(15) + "Name".PadRight(15) + "Price");
            // Ascending order
            var sortedProductList = products.OrderBy(product => product.Price).ToList();
            foreach (Product product in sortedProductList)
            {
                Console.WriteLine(product.Category.PadRight(15) + product.Name.PadRight(15) + product.Price);
            }
            Console.WriteLine("-----------------------------------");
            // Calculate sum
            int priceSum = products.Sum(product => product.Price);

            Console.WriteLine("\nSum ".PadRight(30) + priceSum);

        }
    }
}
