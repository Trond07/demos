using System;
using System.Security.Cryptography.X509Certificates;

Exercise1();
Exercise2();
Exercise3();
Exercise4();

void Exercise1()
{
    Console.WriteLine("gijve number");
    string input = Console.ReadLine();
    bool conversionresult = int.TryParse(input, out int number);    
    if (conversionresult == false )
    {
        Console.WriteLine("sorry not valid number");

    }

    int num = 6;
    int result = 1;

    while (num >= 1)
    {
        result *= num;
        num--;
    }
    Console.WriteLine("The factorial of {0} is {1}", num, result);
    Console.WriteLine($"The factorial of {num} is {result}"); //gir samme resultat
}

void Exercise2()
{
    // Simple implementation...
    for (int num = 1; num < 100; num++)
    {
        bool isPrime = true;
        for (int f = 2; f < num; f++)
        {
            if (num % f == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
        {
            Console.WriteLine("{0} is prime", num);
        }
        else
        {
            Console.WriteLine("{0} is not prime", num);
        }
    }
}

void Exercise3()
{
    for (int r = 1; r <= 10; r++)
    {
        for (int c = 1; c <= 10; c++)
        {
            int num = r * c;
            Console.Write("{0} ", num);
        }
        Console.WriteLine();
    }
}

void Exercise4()
{
    // Loop through all the rows.
    for (int r = 1; r <= 10; r++)
    {
        // Print a row of stars before each row in the table.
        for (int i = 0; i < 62; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();

        // Loop through all the columns for the current row.
        for (int c = 1; c <= 10; c++)
        {
            // Calculate the number to print.
            int num = r * c;

            // Print a * followed by the appropriate amount of leading spaces (to align numbers nicely).
            Console.Write("* ");
            for (int tempNum = num; tempNum < 100; tempNum *= 10)
            {
                Console.Write(" ");
            }

            // Print the number followed by a trailing space.
            Console.Write("{0} ", num);
        }

        // At the end of each row, print a trailing * and then a line-feed.
        Console.WriteLine(" *");
    }

    // Print a row of stars after the final row in the table.
    for (int i = 0; i < 62; i++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}