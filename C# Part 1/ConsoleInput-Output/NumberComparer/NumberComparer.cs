using System;
using System.Threading;
using System.Globalization;

//Number Comparer

//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

class NumberComparer
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Enter first number:");
        double firtsNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        double secondNum = double.Parse(Console.ReadLine());
        
        Console.WriteLine("The greater number is {0}",Math.Max(firtsNum, secondNum));      
    }
}

