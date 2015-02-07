using System;

//Digit as Word

//Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
//Print “not a digit” in case of invalid input.
//Use a switch statement.


class DigitWord
{
    static void Main()
    {
        Console.Write("Enter number from 0-9 :");
        int input = int.Parse(Console.ReadLine());
        switch(input)
        {
            case 0: Console.WriteLine("0-->zero"); break;
            case 1: Console.WriteLine("1-->one"); break;
            case 2: Console.WriteLine("2-->two"); break;
            case 3: Console.WriteLine("3-->three"); break;
            case 4: Console.WriteLine("4-->four"); break;
            case 5: Console.WriteLine("5-->five"); break;
            case 6: Console.WriteLine("6-->six"); break;
            case 7: Console.WriteLine("7-->seven"); break;
            case 8: Console.WriteLine("8-->eight"); break;
            case 9: Console.WriteLine("9-->nine"); break;
            default: Console.WriteLine("invalid number"); break;
        }
    }
}

