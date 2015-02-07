using System;

//Multiplication Sign

//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

class MultiplicationSign
{
    static void Main()
    {
        Console.Write("Enter first number :");
        double firstNum = double.Parse(Console.ReadLine());
        Console.Write("Enter second number :");
        double secondNum = double.Parse(Console.ReadLine());
        Console.Write("Enter third number :");
        double thirdNum = double.Parse(Console.ReadLine());

        if (firstNum*secondNum*thirdNum>0)
        {
            Console.WriteLine("the sign is +");
        }
        else if (firstNum * secondNum * thirdNum < 0)
        {
            Console.WriteLine("the sign is -");
        }
        else if (firstNum * secondNum * thirdNum == 0)
        {
            Console.WriteLine(" the sign is 0");
        }
    }
}
