using System;

//Problem 1. Declare Variables

//Declare five variables choosing for each of them the most appropriate of the types
//byte, sbyte, short, ushort, int, uint, long, ulong 
//to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
//Submit the source code of your Visual Studio project as part of your homework submission.

class DeclareVariables
{
    static void Main()
    {
        sbyte a = -115;
        byte b = 97;
        short c = -10000;
        ushort d = 52130;
        int e = 4825932;

        Console.WriteLine("sbyte {0}, byte {1}, short {2}, ushort {3}, int {4}", a, b, c, d, e);
    }
}

