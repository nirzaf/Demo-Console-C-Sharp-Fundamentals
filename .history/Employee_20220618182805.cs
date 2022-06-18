namespace Demo_Console_C_Sharp_Fundamentals
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public double BasicSalary { get;set; }
        public double Overtime { get; set; }

        public double GetTotalGrossSalary()
        {
            return BasicSalary + Overtime;
        }
    }

    public class FullTimeEmployee : Employee
    {
        public double GetBonus()
        {
            return GetTotalGrossSalary() * 0.1;
        }
    }

    public class PartTimeEmployee : Employee
    {
        public double BonusPartTime()
        {
            return GetTotalGrossSalary() * 0.05;
        }
    }

    public class ContractEmployee : Employee
    {
        public double GetBonus()
        {
            return GetTotalGrossSalary() * 0.05;
        }

    }
}