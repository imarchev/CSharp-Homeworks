using System;

////Problem 2. Float or Double?

////Which of the following values can be assigned to a variable of type float and which to a variable of type double: 
//34.567839023, 12.345, 8923.1234857, 3456.091?
////Write a program to assign the numbers in variables and print them to ensure no precision is lost.

class FloatOrDouble
    {
        static void Main()
        {
            float a = 12.345F;
            float b = 33456.091F;
            double c = 34.567839023;
            double d = 8923.1234857;

            Console.WriteLine("Numbers {0} & {1} are float type .", a, b);
            Console.WriteLine("Numbers {0} & {1} are double type .", c, d);

 
        }
    }
