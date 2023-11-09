using Week2Project;

List<Product> products = new List<Product>();

Console.WriteLine("Enter a new product. Enter 'q' to quit");
while (true)
{
    Console.Write("Enter Category: ");
    string categoryInput = Console.ReadLine();
    if (categoryInput.ToLower().Trim() == "q")
    {
        break;
    }

    Console.Write("Enter Product: ");
    string productInput = Console.ReadLine();
    if (productInput.ToLower().Trim() == "q")
    {
        break;
    }

    Console.Write("Enter Price: ");
    string priceInput = Console.ReadLine();
    if(priceInput.ToLower().Trim() == "q")
    {
        break;
    }

    bool isInt = int.TryParse(priceInput, out int value);
    if (isInt)
    {
        Product product = new Product(categoryInput, productInput, value);
        products.Add(product);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The product was added.");
        Console.ResetColor();
    }

}

Console.WriteLine("Your product list: ");
Console.WriteLine("Category".PadRight(15) + "Name".PadRight(15) + "Price");
// ascending
var sortedProductList = products.OrderBy(product => product.Price).ToList();
foreach (Product product in sortedProductList)
{
    Console.WriteLine(product.Category.PadRight(15) + product.Name.PadRight(15) + product.Price);
}
Console.WriteLine("-----------------------------------");
int priceSum = products.Sum(product => product.Price); 

Console.WriteLine("\nSum ".PadRight(30) + priceSum);