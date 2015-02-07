﻿using System;
using System.Threading;
using System.Globalization;

//Formatting Numbers

//Write a program that reads 3 numbers:
//integer a (0 <= a <= 500)
//floating-point b
//floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.

class FormattingNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter a :");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b :");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c :");
        double c = double.Parse(Console.ReadLine());

        Console.Write("{0,-1:X}", a);
        Console.Write(" |" + Convert.ToString(a, 2).PadLeft(10, '0') + "| ");
        Console.Write("{0,1:F2}|", b);
        Console.Write("{0,-1:F3} |", c);
        Console.WriteLine();
    }

}

