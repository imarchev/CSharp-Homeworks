using System;
using System.Threading;
using System.Globalization;

//Quadratic Equation

//Write a program that reads the coefficients a, b and c of a quadratic equation 
//ax2 + bx + c = 0 and solves it (prints its real roots).

class QuadraticEquation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter \"a\":");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter \"b\":");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter \"c\":");
        double c = double.Parse(Console.ReadLine());

        double d = (b * b) - (4 * a) * c;
        if (d < 0)
        {
            Console.WriteLine("no real roots");
        }
        if (d>0)
        {
            double x1 = (-b + Math.Sqrt(d)) / (a * a);
            double x2 = (-b - (Math.Sqrt(d))) / (a * a);
            Console.WriteLine("x1={0}", x1);
            Console.WriteLine("x2={0}", x2);
        }
        if (d == 0)
        {
            double x3 = (-b / (2 * a));
            Console.WriteLine("x1=x2= {0}",x3);
        }
            
    }       

}
