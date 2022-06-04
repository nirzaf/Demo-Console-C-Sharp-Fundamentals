// string myName;
//
// int number = 34;
//
// int maxNum = int.MaxValue;
//
// Console.WriteLine(maxNum);
//
// float maxFloatValue = float.MaxValue;
//
// Console.WriteLine(maxFloatValue);
//
// double Number = 5.323244343;
//
// long maxLongValue = long.MaxValue;
//
// decimal BigNumber = 7235657656; //decimal is a number with a decimal point with 128 bit and upto 28 digits 
//
// const string name = "John"; //256 bit   
//
// char myChar = 'a';  // + , -, /, *, %, 
//
// bool myBool = true;

// A long value is stored in 64-bit,with its first digit to show if it's a positive/negative number.
// while ulong is also 64-bit, with all 64 bit to store the number.
// so the maximum of ulong is 2(64)-1, while long is 2(63)-1

//WriteLine("Enter Number 1");

//int num1 = Convert.ToInt32(ReadLine());

//WriteLine("Enter Number 2");

//int num2 = Convert.ToInt32(ReadLine());

//WriteLine(num1 + num2);
//WriteLine(num1 - num2);
//WriteLine(num1 * num2);
//WriteLine(num1 / num2);

// Arrays
// Lists
// Dictionaries
// Tuples
// Enumerable


// string[] names = { "john", "jane", "joe", "Mohamed Fazrin", "Mohamed Farook" };

// int[] numbers = { 5, 52, 43, 34 };
// Console.WriteLine(numbers[3]);

//Sort the numbers array
//Array.Sort(numbers);
//Print the numbers array
// foreach (int number in numbers)
// {
//     Console.WriteLine(number);
// }

//Console.WriteLine("1, 2, 3, 4, 5, 6, 7, 8, 9, 10");

//Print numbers from 1 to 10 using loop
// for (int rishdha = 1; rishdha <= 1000; rishdha += 2)   
// {
//     Console.WriteLine("Number: " + rishdha);
// }

int fazrin = 101;
while (fazrin < 100)
{
    Console.WriteLine("My age is : " + fazrin);
    fazrin++;
    if (fazrin == 91)
    {
        Console.WriteLine("Dead");
        break;
    }
}

do
{
    Console.WriteLine("Hello :");
    fazrin++;
}while(fazrin<100);

//Console.WriteLine("Dead");

double[] numbers2 = { 5.5, 52.5, 43.5, 34.5, 65.5, 76.5, 47.5, 38.5, 49.5, 410.5 };

char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };




//var name = names.Contains("jane");

//var myName = names.SingleOrDefault(c => c.Contains("Moh"));

// var familyNames = names.Where(c => c.Contains("Mohamed"));
//
// foreach (var item in familyNames)
// {
//    Console.WriteLine(item);   
// }



//WriteLine(myName);


//WriteLine(name);

//names[3] = "Mohamed";

//WriteLine(names[2]);

//names[2] = "Fazrin";

//WriteLine(names[2]);


//int[] studentAges = new int[5];

//studentAges[0] = 10;
//studentAges[1] = 12;
//studentAges[2] = 33;
//studentAges[3] = 44;
//studentAges[4] = 25;

//foreach (int age in studentAges)
//{ 
//    WriteLine(age);
//}

List<int> studentAgesList = new();

studentAgesList.Add(10);
studentAgesList.Add(12);
studentAgesList.Add(33);
studentAgesList.Add(33);
studentAgesList.Add(33);
studentAgesList.Add(33);
studentAgesList.Add(33);
studentAgesList.Add(44);
studentAgesList.Add(25);


foreach (int age in studentAgesList)
{
    Console.WriteLine(age);
}

Console.WriteLine("----------------");

//studentAgesList.Remove(33);
//studentAgesList.RemoveAt(3);

studentAgesList.Insert(2, 1000);

studentAgesList.RemoveAll(x => x == 33);


foreach (int age in studentAgesList)
{
    Console.WriteLine(age);
}












