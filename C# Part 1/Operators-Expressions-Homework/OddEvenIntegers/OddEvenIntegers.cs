using System;

//Odd or Even Integers

//Write an expression that checks if given integer is odd or even.

class OddEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter one number to check is it Even :");
        int number = int.Parse(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine( true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}

