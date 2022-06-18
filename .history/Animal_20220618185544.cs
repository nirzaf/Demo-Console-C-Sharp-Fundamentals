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
    public void Bark()
    {
        Console.WriteLine("I am DogWoof!");
    }
}
