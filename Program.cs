using static System.Console;

WriteLine("Enter a number : ");

int x = Convert.ToInt32(ReadLine());

WriteLine("Enter a symbol : ");

char symbol = Convert.ToChar(ReadLine());

WriteLine("Enter a number 2 : ");

int y = Convert.ToInt32(ReadLine());

if (symbol == '+')
{
    WriteLine(x + y);
}
else if (symbol == '-')
{
    WriteLine(x - y);
}
else if (symbol == '*')
{
    WriteLine(x * y);
}
else if (symbol == '/')
{
    WriteLine(x / y);
}
else
{
    WriteLine("Invalid Symbol");
}

int currentBalance = 1000;

WriteLine("Enter amount to withdraw : ");

int amount = Convert.ToInt32(ReadLine());

if (amount <= currentBalance)
{
    WriteLine("Withdrawal Successful");
    currentBalance = currentBalance - amount;
    WriteLine("Current Balance : " + currentBalance);
}
else
{
    WriteLine("Insufficient Funds");
}

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









