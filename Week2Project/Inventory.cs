using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Week2Project
{
    internal class Inventory
    {
        public List<Product> products = new List<Product>();

        // Method for showing items in list
        // using optional param for search results
        public void displayList([Optional] List<Product> searchResult)
        {
            Console.WriteLine("\nYour product list: ");
            Console.WriteLine("Category".PadRight(15) + "Name".PadRight(15) + "Price");
            // Ascending order
            var sortedProductList = products.OrderBy(product => product.Price).ToList();
            foreach (Product product in sortedProductList)
            {
                if(searchResult != null && searchResult.Contains(product))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(product.Category.PadRight(15) + product.Name.PadRight(15) + product.Price);
                    Console.ResetColor();
                }
                else { 
                Console.WriteLine(product.Category.PadRight(15) + product.Name.PadRight(15) + product.Price);
                }
            }
            Console.WriteLine("-----------------------------------");
            // Calculate sum
            int priceSum = products.Sum(product => product.Price);

            Console.WriteLine("\nSum ".PadRight(30) + priceSum);

        }

        public void searchProduct()
        {
            Console.Write("Search for product name: ");
            string searchInput = Console.ReadLine();

            // search for lower case name in list
            var result = products.Where(product => product.Name.ToLower().Contains(searchInput.ToLower())).ToList();

            
            if (result.Count > 0)
            {
                displayList(result);
            }
            else Console.WriteLine($"{searchInput} was not found in the list");
        }
    }
}
