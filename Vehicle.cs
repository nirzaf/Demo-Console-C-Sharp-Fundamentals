using static System.Console;

namespace Demo_Console_C_Sharp_Fundamentals
{
    public class Vehicle
    {
        public Vehicle()
        {
        }
        public Vehicle(int vehicleNumber, string vehicleType, string vehicleColor, double vehicleMaxSpeed, bool isVehicleRegistered)
        {
            VehicleNumber = vehicleNumber;
            VehicleType = vehicleType;
            VehicleColor = vehicleColor;
            VehicleMaxSpeed = vehicleMaxSpeed;
            IsVehicleRegistered = isVehicleRegistered;
        }

        public int VehicleNumber { get; set; }
        public string VehicleType { get; set; }
        public string VehicleColor { get; set; }
        public double VehicleMaxSpeed { get; set; }
        public bool IsVehicleRegistered { get; set; }

        public void PrintVehicleDetails()
        {
            WriteLine("Vehicle Number: {0}", VehicleNumber);
            WriteLine("Vehicle Type: {0}", VehicleType);
            WriteLine("Vehicle Color: {0}", VehicleColor);
            WriteLine("Vehicle Max Speed: {0}", VehicleMaxSpeed);
            WriteLine("Is Vehicle Registered: {0}", IsVehicleRegistered);
        }

        public void ChangeVehicleType(string type)
        {
            VehicleType = type;
        }

    }
}
