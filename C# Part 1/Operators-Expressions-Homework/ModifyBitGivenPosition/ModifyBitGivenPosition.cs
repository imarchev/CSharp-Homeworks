using System;

//Modify a Bit at Given Position

//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) 
//that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.

class ModifyBitGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Enter intiger number : ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter possion # : ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value : ");
        int v = int.Parse(Console.ReadLine());

        if (v == 0)
        {
            int mask = ~(1 << p);
            int result = mask & n;
            Console.WriteLine("The new number is {0}",result);
        }
        else
        {
            int mask = 1 << p;
            int result = mask | n;
            Console.WriteLine("The new number is {0}", result);
        }

        
    }
}

