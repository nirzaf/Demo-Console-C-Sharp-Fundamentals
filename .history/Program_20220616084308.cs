var input = Console.ReadLine();
MultiplicationTable(Convert.ToInt32(input));

int[] numbers =  { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

var prime = FilterPrimeNumbersFromIntArray(numbers);

foreach (var a in prime)
{
    Console.WriteLine(a);
}

Employee emp = new Employee();
emp.EmployeeId = "123";
emp.FirstName = "John";
emp.LastName = "Doe";
emp.Email = "abcd@gmail.com";
emp.PhoneNumber = "0772049123";
emp.JobTitle = "Software Engineer";
emp.Department = "IT";
emp.OfficeLocation = "Colombo";
emp.Salary = 1000;
emp.Overtime = 10;
emp.WorkHours = 8;


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


static void MultiplicationTable(int n)
{
    int j,i;
    Console.Write("\n\n");
    Console.Write("Display the multiplication table vertically from 1 to n:\n");
    Console.Write("---------------------------------------------------------");
    Console.Write("\n\n");
    Console.Write("Input up to the table number starting from 1 : ");
    Console.Write("Multiplication table from 1 to {0} \n",n);
    for(i=1;i<=10;i++)
    {
        for(j=1;j<=n;j++)
        {
            if (j<n)
            {
                Console.Write("{0} X {1} = {2}, ",j,i,i*j);
            }
            else
            {
                Console.Write("{0} X {1} = {2}",j,i,i*j);
            }
        }
        Console.Write("\n");
    }
}

Console.ReadKey();

