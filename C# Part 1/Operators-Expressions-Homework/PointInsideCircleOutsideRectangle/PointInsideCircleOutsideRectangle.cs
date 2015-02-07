using System;
using System.Threading;
using System.Globalization;

//Point Inside a Circle & Outside of a Rectangle

//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5)
//and out of the rectangle R(top=1, left=-1, width=6, height=2).

class PointInsideCircleOutsideRectangle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter the value of x : ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter the value of y : ");
        double y = double.Parse(Console.ReadLine());
        Console.WriteLine();
        if (!(x >= 2.5 || x <= -0.5) && !(y > 2.5 || y <= 1))
        {
            Console.WriteLine("Q:Inside K & outside of R? A: Yes");
        }
        else
        {
            Console.WriteLine("Q:Inside K & outside of R? A: No");
        }
    }
}