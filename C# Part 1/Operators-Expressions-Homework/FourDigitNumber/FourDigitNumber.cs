using System;

//Four-Digit Number

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Enter four digit number : ");
        int number = int.Parse((Console.ReadLine()));
        int firstNumber = (number / 1000);
        int secondNumber = ((number / 100) % 10);
        int trirhNumber = ((number / 10) % 10);
        int fourthNumber = ((number / 1) % 10);
        int sum = fourthNumber + trirhNumber + secondNumber + firstNumber;

        Console.WriteLine("Sum of digits is :{0}",sum);
        Console.WriteLine("Reversed : {0}{1}{2}{3}", fourthNumber, trirhNumber, secondNumber, firstNumber);
        Console.WriteLine("Last digit in front ; {0}{1}{2}{3}", fourthNumber, firstNumber, secondNumber, trirhNumber);
        Console.WriteLine("Second and third digits exchanged ; {0}{1}{2}{3}", firstNumber, trirhNumber, secondNumber, fourthNumber);
    }
}

