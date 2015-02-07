using System;

//Bitwise: Extract Bit #3

//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0

class BitwiseExtractBit3
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int a = 3;                              //bit #3
        int b = int.Parse(Console.ReadLine());

        int mask = 1 << a;
        int bMask = (b & mask);
        int bit = bMask >> a;
        Console.WriteLine("The value of the bit #3 of number {0} is {1}",b,bit);

    }
}
