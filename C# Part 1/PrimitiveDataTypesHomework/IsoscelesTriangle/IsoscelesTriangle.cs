using System;

//Problem 8. Isosceles Triangle

//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//   ©

//  © ©

// ©   ©

//© © © ©


    class IsoscelesTriangle
    {
        static void Main()
        {
           char a = '©';
           Console.WriteLine("    {0}",a);
           Console.WriteLine();
           Console.WriteLine("   {0} {0}",a);
           Console.WriteLine();
           Console.WriteLine("  {0} {0} {0}",a);
           Console.WriteLine();
           Console.WriteLine(" {0} {0} {0} {0}",a);
        }
    }
