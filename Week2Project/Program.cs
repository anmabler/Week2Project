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
int sum = 0;
for (int i = 0; i < products.Count; i++)
{
    Console.WriteLine(products[i].Category.PadRight(20) + products[i].Name.PadRight(20) + products[i].Price);
    sum += products[i].Price;
}
Console.WriteLine("\nSum ".PadRight(40) + sum);