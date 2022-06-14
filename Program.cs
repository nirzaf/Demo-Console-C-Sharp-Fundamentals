using Demo_Console_C_Sharp_Fundamentals;
var input = Console.ReadLine();
MultiplicationTable(Convert.ToInt32(input));

/*
 Write a program in C# to display the multiplication table
 vertically from 1 to n
 */

static void MultiplicationTable(int n)
{
    int j,i;
    Console.Write("\n\n");
    Console.Write("Display the multiplication table vertically from 1 to n:\n");
    Console.Write("---------------------------------------------------------");
    Console.Write("\n\n");
    Console.Write("Input upto the table number starting from 1 : ");
    Console.Write("Multiplication table from 1 to {0} \n",n);
    for(i=1;i<=10;i++)
    {
        for(j=1;j<=n;j++)
        {
            Console.Write(j <= n - 1 ? "{0}x{1} = {2}, " : "{0}x{1} = {2}", j, i, i * j);
        }
        Console.Write("\n");
    }
}


Vehicle v1 = new()
{
    VehicleNumber = 12121,
    VehicleType = "Car",
    VehicleColor = "Red",
    VehicleMaxSpeed = 150,
    IsVehicleRegistered = true
};

v1.ChangeVehicleType("Bus");

v1.PrintVehicleDetails();

//Console.WriteLine(v1.VehicleType);
