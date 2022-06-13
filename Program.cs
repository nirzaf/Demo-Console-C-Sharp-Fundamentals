using Demo_Console_C_Sharp_Fundamentals;

//Console.WriteLine($"{(int)Math.Pow(2, 3)}");

Vehicle v1 = new()
{
    VehicleType = "Car"
};

v1.ChangeVehicleType("Bus");

Console.WriteLine(v1.VehicleType);