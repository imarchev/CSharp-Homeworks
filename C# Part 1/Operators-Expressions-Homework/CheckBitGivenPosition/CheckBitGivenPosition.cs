using System;

//Check a Bit at Given Position

//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
//in given integer number n, has value of 1.

class CheckBitGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Enter intiger number : ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter possion # : ");
        int p = int.Parse(Console.ReadLine());

        int mask = 1 << p;
        int nMask = mask & n;
        int bit = nMask >> p;
        if (bit == 1)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}

