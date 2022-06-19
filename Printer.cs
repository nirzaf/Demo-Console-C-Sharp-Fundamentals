namespace Demo_Console_C_Sharp_Fundamentals;

public abstract class Printer
{
     public abstract void Print();
     public abstract void Scan();
     public abstract int TotalPrintCopies();
}

public class Samsung : Printer
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
          return 10;
     }
}

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
