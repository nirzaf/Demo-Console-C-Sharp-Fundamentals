﻿using Demo_Console_C_Sharp_Fundamentals;

//Console.WriteLine($"{(int)Math.Pow(2, 3)}");

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
