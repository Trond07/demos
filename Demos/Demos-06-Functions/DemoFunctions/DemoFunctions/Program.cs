using System;

// Call simple methods.
SayHello();
SayGoodbye();

// Call a method that takes parameters.
RepeatMessage("Wales!", 3);

// Call a method and assign result to a variable.
int result = GetMin(10, 20);
Console.WriteLine("The minimum value is {0}", result);

// Call a method and use result in-situ in an expression.
Console.WriteLine("The minimum value is {0}", GetMin(10, 20));


// Here are the functions...
void SayHello()
{
    Console.WriteLine("Hello");
}

void SayGoodbye()
{
    Console.WriteLine("Goodbye");
}

void RepeatMessage(string message, int count)
{
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(message);
    }
}

int GetMin(int num1, int num2)
{
    if (num1 < num2)
        return num1;
    else
        return num2;
}