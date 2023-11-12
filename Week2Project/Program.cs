using Week2Project;

Inventory products = new Inventory();
// Show main menu
switchMenu(products);

static void switchMenu (Inventory products)
{
    Console.WriteLine("------------------------------------");
    Console.WriteLine("Enter a number to make a selection");
    Console.WriteLine("1/ Add product");
    Console.WriteLine("2/ List added products");
    Console.WriteLine("3/ Search");
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
            products.displayList();
            switchMenu(products);
            break;
        case "3":
            products.searchProduct();
            switchMenu(products);
            break;
        case "0":
            break;
        default:
            Console.WriteLine("Incorrect selection");
            switchMenu(products);
            break;
    }
}
// TODO: Move to Inventory class
static List<Product> addProducts (Inventory products)
{
    Console.WriteLine("Enter a new product. Enter 'q' to quit");
    while (true)
    {
        Console.Write("Enter Category: ");
        string categoryInput = Console.ReadLine();
        if (categoryInput.ToLower().Trim() == "q")
        {
            products.displayList();
            switchMenu(products);
            break;
        }

        Console.Write("Enter Product: ");
        string productInput = Console.ReadLine();
        if (productInput.ToLower().Trim() == "q")
        {
            products.displayList();
            switchMenu(products);
            break;
        }

        Console.Write("Enter Price: ");
        string priceInput = Console.ReadLine();
        if (priceInput.ToLower().Trim() == "q")
        {
            products.displayList();
            switchMenu(products);
            break;
        }
        // check if int
        bool isInt = int.TryParse(priceInput, out int value);   
        // add product to list if int
        if (isInt)
        {
            Product product = new Product(categoryInput, productInput, value);
            products.products.Add(product);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The product was added.");
            Console.ResetColor();
        }

    }
    return products.products;
}
