using System.Collections;
using Demo_Console_C_Sharp_Fundamentals;


var daysBetweenDates = GetDaysBetweenTwoDates(DateTime.Now, DateTime.Now.AddDays(5));
static int GetDaysBetweenTwoDates(DateTime startDate, DateTime endDate)
{
    return (int)(endDate - startDate).TotalDays;
}

Console.WriteLine(daysBetweenDates);

var students = new Hashtable();

var s1 = new Student(1, "John", 15);
var s2 = new Student(2, "Jane", 12);
var s3 = new Student(3, "Jack", 13);
var s4 = new Student(4, "Jill", 11);
var s5 = new Student(5, "Joe", 14);

students.Add(s1.Id, s1);
students.Add(s2.Id, s2);
students.Add(s3.Id, s3);
students.Add(s4.Id, s4);
students.Add(s5.Id, s5);


foreach (Student student in students.Values)
{
    Console.WriteLine($"Student Id : {student.Id}, Name: {student.Name}, Age: {student.Age}");
}

var input = Console.ReadLine();
MultiplicationTable(Convert.ToInt32(input));

int[] numbers =  { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

var prime = FilterPrimeNumbersFromIntArray(numbers);

foreach (var d in prime)
{
    Console.WriteLine(d);
}


var emp = new Employee
{
    EmployeeId = "123",
    FirstName = "John",
    LastName = "Doe",
    Email = "abcd@gmail.com",
    PhoneNumber = "0772049123",
    JobTitle = "Software Engineer",
    Department = "IT",
    OfficeLocation = "Colombo",
    Salary = 1000,
    Overtime = 10,
    WorkHours = 8
};

Console.WriteLine(emp.CalculateSalary());
Console.WriteLine(emp.ToString());

/*
 Write a program in C# to display the multiplication table
 vertically from 1 to n
 */

//Filter int array and return only prime numbers in an array
static int[] FilterPrimeNumbersFromIntArray(int[] arr)
{
    return arr.Where(IsPrime).ToArray();
}

static bool IsPrime(int number)
{
    if (number == 1)
    {
        return false;
    }
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
        {
            return false;
        }
    }
    return true;
}


try
{
    Console.ReadKey();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}




