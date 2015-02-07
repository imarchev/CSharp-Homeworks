using System;

//Min, Max, Sum and Average of N Numbers

//Write a program that reads from the console a sequence of n integer numbers 
//and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.

class MinMaxSumAverageNumbers
{
    static void Main()
    {
        double number;
        double min = 0;
        double max = 0;
        double sum = 0;
        double avg = 0;

        Console.WriteLine("How many numbers you want to enter: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter the number : ");
            number = double.Parse(Console.ReadLine());
            sum += number;
            if (number > max)
            {
                max = number;
            }
            if (number < max)
            {
                min = number;
            }

        }
        avg = sum / n;
        Console.WriteLine("Min = {0}", min);
        Console.WriteLine("Max = {0}", max);
        Console.WriteLine("Sum = {0}", sum);
        Console.WriteLine("Avg = {0}", Math.Round(avg, 2));
    }

}
