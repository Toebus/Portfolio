// See https://aka.ms/new-console-template for more information



int num1;
int num2;
string answer;
int result = 0;
Console.WriteLine("Hello and welcome to the calculator program!");

Console.WriteLine("please enter your first number" );

num1 = Convert.ToInt32( Console.ReadLine());


Console.WriteLine("please enter your Second number");

num2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("What type of operation  would you like to do?");

Console.WriteLine("Please enter a for add s for subtraction, d for devision. x for mltiplication");


answer = Console.ReadLine();

if (answer == "a")
    {
    result = num1 + num2;
     };

if (answer == "s")
{
    result = num1 - num2;
};


if (answer == "d")
{
    result = num1 / num2;
};


if (answer == "x")
{
    result = num1 * num2;
};

Console.WriteLine("here is the resualt: " + result.ToString());





Console.ReadKey();