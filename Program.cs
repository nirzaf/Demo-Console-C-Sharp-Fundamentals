using static System.Console;


WriteLine("Enter a number : ");

int x = Convert.ToInt32(ReadLine());

WriteLine("Enter a symbol : ");

char symbol = Convert.ToChar(ReadLine());

WriteLine("Enter a number 2 : ");

int y = Convert.ToInt32(ReadLine());

switch (symbol)
{
    case '+':
        WriteLine("Answer is : " + (x + y));
        break;
    case '-':
        WriteLine("Answer is :" + (x - y));
        break;
    case '*':
        WriteLine(x * y);
        break;
    case '/':
        WriteLine(x / y);
        break;
    default:
        WriteLine("Invalid Symbol");
        break;
}










