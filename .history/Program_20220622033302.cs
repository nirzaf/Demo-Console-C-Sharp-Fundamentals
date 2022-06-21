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
        
        //Selecting a list of distinct category names
        var categoryNames = products.SelectMany(p => p.Categories).Distinct().ToList();

        foreach (var item in categoryNames)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine*

        //Sort all products by name
        products.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));

        //Print all products
        foreach (var item in products)
        {
            Console.WriteLine(item.Name);
        }

        Console.ReadLine();
    }
}

public record Product(string Name, List<string> Categories);

