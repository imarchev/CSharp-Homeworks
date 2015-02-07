using System;
using System.Threading;
using System.Globalization;

// Sum of 3 Numbers

//Write a program that reads 3 real numbers from the console and prints their sum.

class Sum3Numbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        double c = double.Parse(Console.ReadLine());
        double sum = (a + b + c);
        Console.WriteLine();
        Console.WriteLine("The sum of the three numbers is {0}", sum);
    }
}

