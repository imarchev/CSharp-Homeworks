using System;
using System.Threading;
using System.Globalization;
//Circle Perimeter and Area

//Write a program that reads the radius r of a circle and prints its perimeter and 
//area formatted with 2 digits after the decimal point.

class CirclePerimeterArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Enter radius : ");
        double r = double.Parse(Console.ReadLine());
        double diametar = r+r;
        double perimeter = diametar*Math.PI;
        double area = Math.Pow(r, 2) * Math.PI;
            Console.WriteLine("The perimatar is {0:0.00}",perimeter);
            Console.WriteLine("The area is {0:0.00}",area);
    }
}

