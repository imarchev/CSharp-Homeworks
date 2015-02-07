using System;

//Problem 4. Unicode Character

//Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, 
//and then print it.
//Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. The output should be *.

class UnicodeCharacter
{
    static void Main()
    {
        //Hexadecimal representation of 42 is 2A

        char symbol = '\u002A';
        Console.WriteLine("The symbol with Unicode code 42 is {0}", symbol);
    }
}

