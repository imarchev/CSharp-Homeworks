using System;

//The Biggest of 3 Numbers

//Write a program that finds the biggest of three numbers.

    class Biggest3Numbers
    {
        static void Main()
        {
            Console.Write("Enter number a :");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter number b :");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter number c :");
            double c = double.Parse(Console.ReadLine());

            if (a >= b && a >= c)
            {
                Console.WriteLine("The bigest number is {0}",a);
            }
            else if (b >= a && b >= c)
            {
                Console.WriteLine("The bigest number is {0}", b);
            }
            else if (c >= a && c >= b)
            {
                Console.WriteLine("The bigest number is {0}", c);
            }
        }
    }
