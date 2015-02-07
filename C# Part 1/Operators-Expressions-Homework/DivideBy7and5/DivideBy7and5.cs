using System;

//Divide by 7 and 5

//Write a Boolean expression that checks for given integer if it can be divided (without remainder)
//by 7 and 5 at the same time.

class DivideBy7and5
{
    static void Main()
    {
        Console.WriteLine("Enter intiger number : ");
        int number = int.Parse(Console.ReadLine());
        if ((number % 7 == 0) && (number % 5 == 0))
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}
