using static System.String;

namespace Demo_Console_C_Sharp_Fundamentals;

class Program
{
    static void Main(string[] args)
    {
        var products = new List<Product>
        {
            new("Strawberry", new List<string> {"Fruit"}),
            new("Banana", new List<string> {"Fruit", "Yellow"}),
            new("Apple", new List<string> {"Fruit", "Red"}),
            new("Orange", new List<string> {"Fruit", "Orange"}),
            new("Grape", new List<string> {"Fruit", "Red"}),
        };
        
        var product = products.FirstOrDefault(p => p.Name.Contains("PLE", StringComparison.InvariantCultureIgnoreCase));
        if (product != null)
        {
            Console.WriteLine(product.Name);
        }

        Console.ReadLine();
        
        //Selecting a list of distinct category names
        var categoryNames = products
        .SelectMany(p => p.Categories)
        .Distinct()
        .ToList();

        foreach (var item in categoryNames)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("..............................");

        //Sort all products by name
        products.Sort((p1, p2) => Compare(p1.Name, p2.Name, StringComparison.Ordinal));

        //Print all products
        foreach (var item in products)
        {
            Console.WriteLine(item.Name);
        }
        
        Console.ReadLine(); 
        //Sort all products by name
        products.Sort((p1, p2) => Compare(p1.Name, p2.Name, StringComparison.Ordinal));
    }
}