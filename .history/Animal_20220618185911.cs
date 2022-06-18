public class Animal
{
    public string Name { get; set; }

    public void Display()
    {
        Console.WriteLine("I am an Animal");
    }
}

public class Dog : Animal
{
    public void getName()
    {
        Console.WriteLine($"I am Dog! and my Name is : {Name}");
    }
    public void Bark()
    {
        Console.WriteLine($"Woof!");
    }
}

public class 