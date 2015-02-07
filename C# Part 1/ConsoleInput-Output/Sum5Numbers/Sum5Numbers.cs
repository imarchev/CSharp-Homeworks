using System;
using System.Threading;
using System.Globalization;

//Sum of 5 Numbers

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.


class Sum5Numbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter numbers as is Example :");
        string[] input = Console.ReadLine().Split(' ');

        double a = double.Parse(input[0]);
        double b = double.Parse(input[1]);
        double c = double.Parse(input[2]);
        double d = double.Parse(input[3]);
        double e = double.Parse(input[4]);
        double sum = a + b + c + d + e;
        Console.WriteLine("The sum of numbers is: {0}", sum);

    }
}
