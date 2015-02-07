using System;
using System.Threading;
using System.Globalization;

//Play with Int, Double and String

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

class PlayIntDoubleString
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        int choise = int.Parse(Console.ReadLine());
        switch(choise)
        {
            case 1: Console.WriteLine("Please enter a int: ");
                    int iResult = int.Parse(Console.ReadLine());
                    Console.WriteLine(iResult+=1);
                    break;
            case 2: Console.WriteLine("Please enter a double: ");
                    double dResult = double.Parse(Console.ReadLine());
                    Console.WriteLine(dResult += 1);
                    break;
            case 3: Console.WriteLine("Please enter a string: ");
                    string sResult = Console.ReadLine();
                    Console.WriteLine(sResult+"*");
                break;
            default: Console.WriteLine("Invalid choice, try again");
                break;
                
        }
    }
}

