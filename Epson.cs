namespace Demo_Console_C_Sharp_Fundamentals;

public class Epson : Printer
{
    public override void Print()
    {
        Console.WriteLine("Printing in black and white");
    }
    public override void Scan()
    {
        Console.WriteLine("Scanning with 300 DPI");
    }
    public override int TotalPrintCopies()
    {
        return 20;
    }
}