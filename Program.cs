using static System.Console;

//string myName;

//int number = 34;

//int maxNum = int.MaxValue;

//WriteLine(maxNum);

//float maxFloatValue = float.MaxValue;

//WriteLine(maxFloatValue);

//double Number = 5.323244343;

//long maxLongValue = long.MaxValue;

//const string name = "John";

//char myChar = 'a';

//bool myBool = true;

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


string[] names = { "john", "jane", "joe", "Mohamed Fazrin", "Mohamed Farook" };

//var name = names.Contains("jane");

//var myName = names.SingleOrDefault(c => c.Contains("Moh"));

var familyNames = names.Where(c => c.Contains("Mohamed"));

foreach (var item in familyNames)
{
   WriteLine(item);   
}



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
    WriteLine(age);
}

WriteLine("----------------");

//studentAgesList.Remove(33);
//studentAgesList.RemoveAt(3);

studentAgesList.Insert(2, 1000);

studentAgesList.RemoveAll(x => x == 33);


foreach (int age in studentAgesList)
{
    WriteLine(age);
}












