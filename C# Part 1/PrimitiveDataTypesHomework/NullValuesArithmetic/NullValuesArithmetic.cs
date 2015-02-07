using System;

//create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

class Program
{
    static void Main()
    {
        int? number = null;
        Console.WriteLine(number);
        number += 5;
        Console.WriteLine(number);
        number = 5;
        Console.WriteLine(number);

        double? anotherNumber = null;
        Console.WriteLine(anotherNumber);
        anotherNumber += 5.6;
        Console.WriteLine(anotherNumber);
        anotherNumber = 5.6;
        Console.WriteLine(anotherNumber);
   }

}
