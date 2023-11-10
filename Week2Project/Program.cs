using Week2Project;

List<Product> products = new List<Product>();
// Show main menu
switchMenu(products);

static void switchMenu (List<Product> products)
{
    Console.WriteLine("------------------------------------");
    Console.WriteLine("Enter a number to make a selection");
    Console.WriteLine("1/ Add product");
    Console.WriteLine("2/ List added products");
    //Console.WriteLine("3/ Search");
    Console.WriteLine("0/ Quit");
    Console.WriteLine("------------------------------------");

    Console.WriteLine("Enter a number");
    string selectionInput = Console.ReadLine();
    switch (selectionInput)
    {
        case "1":
            addProducts(products);
            break;
        case "2":
            // shows main menu again after displaying list
            displayList(products);
            switchMenu(products);
            break;
        //case "3":
        //    searchProduct();
        //    break;
        case "0":
            break;
        default:
            Console.WriteLine("Incorrect selection");
            break;
    }
}
static List<Product> addProducts (List<Product> products)
{
    Console.WriteLine("Enter a new product. Enter 'q' to quit");
    while (true)
    {
        Console.Write("Enter Category: ");
        string categoryInput = Console.ReadLine();
        if (categoryInput.ToLower().Trim() == "q")
        {
            displayList(products);
            switchMenu(products);
            break;
        }

        Console.Write("Enter Product: ");
        string productInput = Console.ReadLine();
        if (productInput.ToLower().Trim() == "q")
        {
            displayList(products);
            switchMenu(products);
            break;
        }

        Console.Write("Enter Price: ");
        string priceInput = Console.ReadLine();
        if (priceInput.ToLower().Trim() == "q")
        {
            displayList(products);
            switchMenu(products);
            break;
        }
        // check if int
        bool isInt = int.TryParse(priceInput, out int value);   
        // add product to list if int
        if (isInt)
        {
            Product product = new Product(categoryInput, productInput, value);
            products.Add(product);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The product was added.");
            Console.ResetColor();
        }

    }
    return products;
}
// Function for showing items in list
static void displayList(List<Product> products)
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