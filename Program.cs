namespace Demo_Console_C_Sharp_Fundamentals;

class Program
{
    static void Main(string[] args)
    {
        Epson ep = new ();
        ep.Print();
        ep.Scan();
        Console.ReadLine();
    }
}