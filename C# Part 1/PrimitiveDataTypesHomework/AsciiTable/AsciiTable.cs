using System;
using System.Text;



class AsciiTable
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine();

        int min = 0;                        
        int max = 255;                      
        for (int i = min; i < max; i++)     
        {
            char c = (char)i;      
            Console.Write(" " + c); 
        }
    }
}