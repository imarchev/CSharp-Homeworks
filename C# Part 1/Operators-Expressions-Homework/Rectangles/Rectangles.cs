using System;

//4. Rectangles

//Write an expression that calculates rectangle’s perimeter and area by given width and height.

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Enter rectangle width: ");
        decimal width = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter rectangle height: ");
        decimal height = decimal.Parse(Console.ReadLine());

        decimal perimeter = (height + width) * 2;
        Console.WriteLine("The perimeter of rectangle is " + perimeter);
        decimal area = (height * width);
        Console.WriteLine("The area of rectangle is " + area);
    }
}
