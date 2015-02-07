using System;

class PrintLongSequence
{
    static void Main()
    {
        for (int i = 2; i <= 1001; i++)
        Console.WriteLine(i * Math.Pow(-1, i));
    }
}
