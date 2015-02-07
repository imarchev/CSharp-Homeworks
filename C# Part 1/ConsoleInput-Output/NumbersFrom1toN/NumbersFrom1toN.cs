using System;

// Numbers from 1 to n

//Write a program that reads an integer number n from the console and prints all the numbers in the interval 
//[1..n], each on a single line.


class NumbersFrom1toN
{
    static void Main()
    {

        int a = int.Parse(Console.ReadLine());

        for (int i = 1; i <= a; i++)
        {
            Console.WriteLine(i);
        }

    }
}
