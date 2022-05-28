
using Demo_Console_C_Sharp_Fundamentals;
using static System.Console;

//Initiating a new instance of the vehicle class
Vehicle car = new ();

//Object name is car
car.VehicleNumber = 5102;
car.VehicleMaxSpeed = 100;
car.VehicleColor = "Black";
car.VehicleType = "Auto";
car.IsVehicleRegistered = true;

//WriteLine(car.VehicleNumber);


car.PrintVehicleDetails();
car.ChangeVehicleType("Manual");
WriteLine("-----------------------------------");
car.PrintVehicleDetails();

