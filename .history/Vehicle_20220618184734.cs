using static System.Console;

namespace Demo_Console_C_Sharp_Fundamentals
{
    public class Vehicle
    {
        public string VehicleNumber { get; set; }
        public string VehicleName { get; set; }
        public string GearType { get; set; }

        public string MaximumSpeed()
        {
            return "Maximum speed of the vehicle is 100 km/hr";
        }
    }

    public class AudiCar : Vehicle
    {
        public string GetGearType()
        {
            return $"This is an automatic and manual gear";
        }
    }

}
