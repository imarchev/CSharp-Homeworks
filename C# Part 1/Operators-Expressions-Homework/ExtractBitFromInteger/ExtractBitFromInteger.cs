using System;

//Extract Bit from Integer

//Write an expression that extracts from given integer n the value of given bit at index p.

class ExtractBitFromInteger
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
        Console.WriteLine("The value of the bit on # {0} of number {1}  is {2} ", p, n, bit);
        
    }
}
