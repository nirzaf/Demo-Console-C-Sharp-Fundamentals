var input = Console.ReadLine();
MultiplicationTable(Convert.ToInt32(input));

/*
 Write a program in C# to display the multiplication table
 vertically from 1 to n
 */

//Filter int array and return only prime numbers in an array
static int[] FilterPrimeNumbersFromIntArray(int[] arr)
{
    List<int> primeNumbers = new List<int>();
    for (int i = 0; i < arr.Length; i++)
    {
        if (IsPrime(arr[i]))
        {
            primeNumbers.Add(arr[i]);
        }
    }
    return primeNumbers.ToArray();
}

int bool IsPrime(int number)
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
    Console.Write("Input upto the table number starting from 1 : ");
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

