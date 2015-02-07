using System;
using System.Threading;
using System.Globalization;

//Trapezoids

//Write an expression that calculates trapezoid's area by given sides a and b and height h.

class Trapezoids
{
    static void Main()
    {
        //Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Enter trapezoid side a: ");
        double sideA = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter trapezoid side b: ");
        double sideB = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter trapezoid side height: ");
        double height = double.Parse(Console.ReadLine());

        double result = (double)((sideA + sideB) * height) / 2; ;
        
        Console.WriteLine("The area of trapezoid is:{0} ",result);
        Console.ReadLine();


    }
}

