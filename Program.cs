using Demo_Console_C_Sharp_Fundamentals;


var input = Console.ReadLine();

MultiplicationTable(Convert.ToInt32(input));

/*
 Write a program in C# to display the multiplication table
 vertically from 1 to n
 */

static void MultiplicationTable(int n)
{
    for(int i=1; i<=n; i++)
    {
        int ans = 1 * i;
        Console.WriteLine("{0} X {1} = {2}", i, 1, ans);
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
