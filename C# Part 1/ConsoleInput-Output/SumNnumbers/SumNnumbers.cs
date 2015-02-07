using System;
using System.Threading;
using System.Globalization;

//Sum of n Numbers

//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
//Note: You may need to use a for-loop.

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("How many number you want to sum :");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        Console.WriteLine("Numbers :");
        for (int i = 0; i < n; i++)
        {
           int number = int.Parse(Console.ReadLine());
            sum+=number;
            
        }
        Console.WriteLine("The sum of numbers is: {0}",sum);
    }
}
