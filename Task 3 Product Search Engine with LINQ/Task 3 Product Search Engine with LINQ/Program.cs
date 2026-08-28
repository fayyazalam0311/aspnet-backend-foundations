class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; } = 0;

}
static class program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>();

        products.Add(new Product { ID = 1, Name = "Laptop", Category = "Electronics", Price = 120000, StockQuantity = 15 });
        products.Add(new Product { ID = 2, Name = "Wireless Mouse", Category = "Electronics", Price = 2500, StockQuantity = 8 });
        products.Add(new Product { ID = 3, Name = "Office Chair", Category = "Furniture", Price = 18000, StockQuantity = 20 });
        products.Add(new Product { ID = 4, Name = "Study Table", Category = "Furniture", Price = 25000, StockQuantity = 5 });
        products.Add(new Product { ID = 5, Name = "Bluetooth Speaker", Category = "Electronics", Price = 6000, StockQuantity = 12 });
        products.Add(new Product { ID = 6, Name = "Notebook Pack", Category = "Stationery", Price = 500, StockQuantity = 100 });
        products.Add(new Product { ID = 7, Name = "Gaming Keyboard", Category = "Electronics", Price = 8500, StockQuantity = 7 });
        products.Add(new Product { ID = 8, Name = "LED Desk Lamp", Category = "Furniture", Price = 3200, StockQuantity = 25 });
        products.Add(new Product { ID = 9, Name = "Ball Pens (Box)", Category = "Stationery", Price = 300, StockQuantity = 200 });
        products.Add(new Product { ID = 10, Name = "External Hard Drive", Category = "Electronics", Price = 15000, StockQuantity = 9 });


        bool running = true;

        while (running)
        {
            Console.WriteLine("********* Welcome to the Product Search Engine! *********");
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Press 1 to Search by Name");
            Console.WriteLine("2. Press 2 to Filter by Category");
            Console.WriteLine("3. Press 3 to Filter by Price Range");
            Console.WriteLine("4. Press 4 to Sort by Price");
            Console.WriteLine("5. Press 5 to View Top 3 Most Expensive Products");
            Console.WriteLine("6. Press 6 to View Products Low on Stock");
            Console.WriteLine("7. Press 7 to View Average Price of All Products");
            Console.WriteLine("8. Press 8 to Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter the name to search products by name:");
                string searchByName = Console.ReadLine();

                List<Product> FilteredByName = products.Where(e => e.Name.ToLower().Contains(searchByName.ToLower())).ToList();

                if (FilteredByName.Count > 0)
                {
                    Console.WriteLine($"Products matching the name '{searchByName}':");
                    foreach (Product e in FilteredByName)
                    {
                        Console.WriteLine($"ID: {e.ID}, Category: {e.Category}, Price: {e.Price}, Stock Quantity: {e.StockQuantity}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid name.");
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter the Category to filter products by category:");
                string searchByCategory = Console.ReadLine();

                List<Product> FilteredByCategory = products.Where(e => e.Category.ToLower().Contains(searchByCategory.ToLower())).ToList();


                if (FilteredByCategory.Count > 0)
                {
                    Console.WriteLine($"Products matching the category '{searchByCategory}':");
                    foreach (Product e in FilteredByCategory)
                    {
                        Console.WriteLine($"ID: {e.ID}, Name: {e.Name}, Price: {e.Price}, Stock Quantity: {e.StockQuantity}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid category.");
                }
            }
            else if (choice == 3)
            {
                Console.WriteLine("Enter the minimum price:");
                decimal minPrice = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter the maximum price:");
                decimal maxPrice = Convert.ToDecimal(Console.ReadLine());

                List<Product> FilterByPriceRange = products.Where(e => e.Price >= minPrice && e.Price <= maxPrice).ToList();

                if (FilterByPriceRange.Count > 0)
                {
                    Console.WriteLine("Products within the price range:");
                    foreach (Product e in FilterByPriceRange)
                    {
                        Console.WriteLine($"ID: {e.ID}, Name: {e.Name}, Category: {e.Category}, Price: {e.Price}, Stock Quantity: {e.StockQuantity}");
                    }
                }
                else
                {
                    Console.WriteLine("No products found within the specified price range.");
                }

            }
            else if (choice == 4)
            {
                Console.WriteLine("Sort by Price:");
                Console.WriteLine("1. Press 1 to Sort by Price in Ascending Order");
                Console.WriteLine("2. Press 2 to Sort by Price in Descending Order");
                int sortChoice = Convert.ToInt32(Console.ReadLine());

                if (sortChoice == 1)
                {
                    if (products.Any())
                    {
                        var sortedByPriceAsc = products.OrderBy(e => e.Price).ToList();

                        Console.WriteLine("Products sorted by price in ascending order:");
                        foreach (Product e in sortedByPriceAsc)
                        {
                            Console.WriteLine($"ID: {e.ID}, Name: {e.Name}, Category: {e.Category}, Price: {e.Price}, Stock Quantity: {e.StockQuantity}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No products available.");
                    }
                }
                else if (sortChoice == 2)
                {
                    if (products.Any())
                    {
                        var sortedByPriceDesc = products.OrderByDescending(e => e.Price).ToList();

                        Console.WriteLine("Products sorted by price in descending order:");
                        foreach (Product e in sortedByPriceDesc)
                        {
                            Console.WriteLine($"ID: {e.ID}, Name: {e.Name}, Category: {e.Category}, Price: {e.Price}, Stock Quantity: {e.StockQuantity}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No products available.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid option.");
                }
            }
            else if (choice == 5)
            {
                if (products.Any())
                {
                    Console.WriteLine("Top 3 Most Expensive Product");
                    var Top3MostExpensiveProducts = products.OrderByDescending(e => e.Price).Take(3).ToList();
                    foreach (Product e in Top3MostExpensiveProducts)
                    {
                        Console.WriteLine($"ID: {e.ID}, Name: {e.Name}, Category: {e.Category}, Price: {e.Price}, Stock Quantity: {e.StockQuantity}");
                    }

                }
                else
                {
                    Console.WriteLine("No products available.");

                }
            }
            else if (choice == 6)
            {
                if (products.Any())
                {
                    List<Product> LowStockProducts = products.Where(e => e.StockQuantity < 10).ToList();

                    Console.WriteLine("Products Low on Stock (Stock Quantity < 10):");
                    foreach (Product e in LowStockProducts)
                    {
                        Console.WriteLine($"ID: {e.ID}, Name: {e.Name}, Category: {e.Category}, Price: {e.Price}, Stock Quantity: {e.StockQuantity}");
                    }
                }
                else
                {
                    Console.WriteLine("No products available.");
                }

            }
            else if (choice == 7)
            {
                if (products.Any())
                {
                    decimal averagePrice = products.Average(e => e.Price);
                    Console.WriteLine($"Average Price of All Products: {averagePrice}");

                }
                else
                {
                    Console.WriteLine("No products available.");
                }
            }
            else if (choice == 8)
            {
                Console.WriteLine("Exiting the Product Search Engine. Goodbye!");
                running = false;
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid option.");

            }
        }
    }
}