using static System.Console;


//Create a while loop to print numbers from 1 to 10

//int number = 11;
//WriteLine("Printing numbers from 1 to 10 from while loop");
//while (number <= 10)
//{
//    WriteLine($"You have entered number : {number}");
//    number++;
//}

//Create a Do while loop to print numbers from 1 to 10
//int count = 11;
//WriteLine("Printing numbers from 1 to 10 from do while loop");
//do
//{
//    WriteLine(count);
//    count++;
//    //count = count + 2;
//    //count += 2;
//    //count = count - 2 == count -= 2;
//} while (count <= 10);



//Create a for loop to print numbers from 1 to 10
//WriteLine("Printing numbers from 1 to 10 from for loop");
//for (int i = 1; i <= 10; i+=3)
//{
//    WriteLine(i);
//}

//Create a foreach loop to print numbers from 1 to 10
WriteLine("Printing numbers from 1 to 10 from foreach loop");

//string[] names = { "John", "Jane", "Joe" };

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

foreach (int i in numbers)
{
    WriteLine(i);
}

//Create a recursive function to print numbers from 1 to 10
WriteLine("Printing numbers from 1 to 10 from recursive function");

Numbers.Print(5);

public static class Numbers
{
    public static void Print(int number)
    {
        if (number > 10) return;
        WriteLine(number);
        Print(number + 1);
    }
}








