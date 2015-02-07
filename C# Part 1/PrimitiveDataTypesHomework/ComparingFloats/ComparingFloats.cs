using System;

//13.* Comparing Floats

//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
//Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. 
//Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        double first = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");

        double second = double.Parse(Console.ReadLine());

        bool test = Math.Abs(first - second) < 0.000001;
        Console.WriteLine(test);
          
    }
}
