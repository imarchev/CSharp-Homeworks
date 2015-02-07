using System;

//Fibonacci Numbers

//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
//(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

class FibonacciNumbers
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        for (long f = 1, s = 1; s < n ; f+=s, s+=f )
        {
            Console.Write(f); 
            Console.Write(", ");
            Console.Write(s);
            Console.Write(", ");
        }
    }
}
