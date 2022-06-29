namespace Demo_Console_C_Sharp_Fundamentals;

public class Hp : Printer
{
    public override void Print()
    {
        Console.WriteLine("Printing in color");
    }
    public override void Scan()
    {
        Console.WriteLine("Scanning with 600 DPI");
    }
    public override int TotalPrintCopies()
    {
        return 30;
    }
}