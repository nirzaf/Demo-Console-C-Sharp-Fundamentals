using System.Collections;

HashSet<string> hash = new();
hash.Add("Fazrin");
hash.Add("Fazrin");
hash.Add("Fazrin");
hash.Add("Fazrin");

foreach (var h in hash)
{
    Console.WriteLine(h);
}

Console.WriteLine("Printing List ......");
List<string> names = new();
names.Add("Fazrin");
names.Add("Fazrin");
names.Add("Fazrin");
names.Add("Fazrin");

foreach (var name in names)
{
    Console.WriteLine(name);
}

IDictionary<int, string> dictionary = new Dictionary<int, string>();

dictionary.Add(1, "one");
dictionary.Add(2, "two");
dictionary.Add(3, "three");
dictionary.Add(4, "Fazrin");


int[] a = {1,2,3,34,434,3,34,3};

foreach (var item in dictionary)
{
    Console.WriteLine($"{item.Key}, {item.Value}");
}


// var daysBetweenDates = GetDaysBetweenTwoDates(DateTime.Now, DateTime.Now.AddDays(5));
// static int GetDaysBetweenTwoDates(DateTime startDate, DateTime endDate)
// {
//     return (int)(endDate - startDate).TotalDays;
// }
//
// Console.WriteLine(daysBetweenDates);

// Hashtable hbEmployees = new();
//
// hbEmployees.Add(1, "Fazrin");
// hbEmployees.Add(2, "Farook");
// hbEmployees.Add(3, "Mohamed");
//
// //Print the Key and Values of hbEmployees hashtable
// ICollection keys = hbEmployees.Keys;
//
// foreach (var k in keys)
// {
//     Console.WriteLine(hbEmployees[k]);
// }

// foreach (var emp in hbEmployees.Values)
// {
//     Console.WriteLine($"{ hbEmployees.Keys } , { emp }");
// }


Hashtable students = new ();

var s1 = new Student(1, "John", 15);
var s2 = new Student(2, "Jane", 12);
var s3 = new Student(3, "Jack", 13);
var s4 = new Student(3, "Jill", 11);
var s5 = new Student(3, "Joe", 14);

students.Add(s1.Id, s1);
students.Add(s2.Id, s2);
students.Add(s3.Id, s3);
students.Add(s4.Id, s4);
students.Add(s5.Id, s5);

foreach (Student student in students.Values)
{
    Console.WriteLine($"Student Id : {student.Id}, Name: {student.Name}, Age: {student.Age}");
}

// int[] numbers =  { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
// var prime = FilterPrimeNumbersFromIntArray(numbers);

// foreach (var d in prime)
// {
//     Console.WriteLine(d);
// }


// var emp = new Employee
// {
//     EmployeeId = "123",
//     FirstName = "John",
//     LastName = "Doe",
//     Email = "abcd@gmail.com",
//     PhoneNumber = "0772049123",
//     JobTitle = "Software Engineer",
//     Department = "IT",
//     OfficeLocation = "Colombo",
//     Salary = 1000,
//     Overtime = 10,
//     WorkHours = 8
// };

// Console.WriteLine(emp.CalculateSalary());
// Console.WriteLine(emp.ToString());

// /*
//  Write a program in C# to display the multiplication table
//  vertically from 1 to n
//  */

// //Filter int array and return only prime numbers in an array
// static int[] FilterPrimeNumbersFromIntArray(int[] arr)
// {
//     return arr.Where(IsPrime).ToArray();
// }

// static bool IsPrime(int number)
// {
//     if (number == 1)
//     {
//         return false;
//     }
//     for (int i = 2; i < number; i++)
//     {
//         if (number % i == 0)
//         {
//             return false;
//         }
//     }
//     return true;
// }


// try
// {
//     Console.ReadKey();
// }
// catch (Exception ex)
// {
//     Console.WriteLine(ex.Message);
// }

var input = Console.ReadLine();
MultiplicationTable(Convert.ToInt32(input));

static void MultiplicationTable(int n)
{
    for(int i=1;i<=10;i++)
    {
        for(int j=1;j<=n;j++)
        {
            if (j<n)
            {
                //Console.Write(i + " X " + j + " = " + j*i);
                Console.Write($"{j} X {i} = {j*i} ");
                
                //Console.Write("{0} X {1} = {2}, ",j,i,i*j);
            }
            else
            {
                Console.Write("{0} X {1} = {2}",j,i,i*j);
            }
        }
        Console.Write("\n");
    }
}


