using static System.Console;

//WriteLine("Hello, World!");

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

//long allocates 64 bits in memory
//ULong allocates 128 bits in memory

//WriteLine("Enter Number 1");

//int num1 = Convert.ToInt32(ReadLine());

//WriteLine("Enter Number 2");

//int num2 = Convert.ToInt32(ReadLine());

//WriteLine(num1 + num2);
//WriteLine(num1 - num2);
//WriteLine(num1 * num2);
//WriteLine(num1 / num2);

//string firstName = ReadLine();
//string lastName = ReadLine();

//WriteLine("Hello, " + firstName + " " + lastName);

//WriteLine("Enter a number : ");

//int x = Convert.ToInt32(ReadLine());

//WriteLine("Enter a symbol : ");

//char symbol = Convert.ToChar(ReadLine());

//WriteLine("Enter a number 2 : ");

//int y = Convert.ToInt32(ReadLine());

//if (symbol == '+')
//{
//    WriteLine(x+y);
//}
//else if (symbol == '-')
//{
//    WriteLine(x - y);
//}
//else if (symbol == '*')
//{
//    WriteLine(x * y);
//}
//else if (symbol == '/')
//{
//    WriteLine(x / y);
//}
//else 
//{
//    WriteLine("Invalid Symbol");
//}

//int currentBalance = 1000;

//WriteLine("Enter amount to withdraw : ");

//int amount = Convert.ToInt32(ReadLine());

//if (amount <= currentBalance)
//{
//    WriteLine("Withdrawal Successful");
//    currentBalance = currentBalance - amount;
//    WriteLine("Current Balance : " + currentBalance);
//}
//else
//{
//    WriteLine("Insufficient Funds");
//}

WriteLine("Enter your age : ");
int age = Convert.ToInt32(ReadLine());

WriteLine("Enter your marks");
int marks = Convert.ToInt32(ReadLine());;

if (age > 18 || marks > 50)
{
    WriteLine("You are eligible for Scholarship");
}
else
{
    WriteLine("You are not eligible for Scholarship");
}









