using static System.Console;

WriteLine("Hello, World!");

string myName;

int number = 34;

int maxNum = int.MaxValue;

WriteLine(maxNum);

float maxFloatValue = float.MaxValue;

WriteLine(maxFloatValue);

double Number = 5.323244343;

long maxLongValue = long.MaxValue;

const string name = "John";

char myChar = 'a';

bool myBool = true;

// A long value is stored in 64-bit,with its first digit to show if it's a positive/negative number.
// while ulong is also 64-bit, with all 64 bit to store the number.
// so the maximum of ulong is 2(64)-1, while long is 2(63)-1

WriteLine("Enter Number 1");

int num1 = Convert.ToInt32(ReadLine());

WriteLine("Enter Number 2");

int num2 = Convert.ToInt32(ReadLine());

WriteLine(num1 + num2);
WriteLine(num1 - num2);
WriteLine(num1 * num2);
WriteLine(num1 / num2);













