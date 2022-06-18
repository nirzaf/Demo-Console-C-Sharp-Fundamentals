using System.ComponentModel.DataAnnotations;

namespace Demo_Console_C_Sharp_Fundamentals
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public double BasicSalary { get;set; }
        puublic double Overtime { get; set; }

        public double TotalBasicSalary()
        {
            return BasicSalary;
        }
    }

    public class FullTimeEmployee : Employee
    {
        public int MyProperty { get; set; }
    }
}