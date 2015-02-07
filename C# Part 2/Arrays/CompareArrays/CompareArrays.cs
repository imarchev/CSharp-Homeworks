using System;
using System.Linq;

//Write a program that reads two integer arrays from the console and compares them element by element.


class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("Enter size of first array : ");  // Read first array
        int f = int.Parse(Console.ReadLine());
        int[] firstNum = new int[f];
        for (int i = 0; i < firstNum.Length; i++)
        {
            Console.WriteLine("enter element : ");
            firstNum[i] = int.Parse(Console.ReadLine());

        }

        Console.WriteLine("Enter size of second array : "); //Read second array
        int s = int.Parse(Console.ReadLine());
        int[] secondNum = new int[s];
        for (int i = 0; i < secondNum.Length; i++)
        {
            Console.WriteLine("enter element : ");
            secondNum[i] = int.Parse(Console.ReadLine());
        }


        if (firstNum.Length == secondNum.Length)            // Check arrays length 
        {
            for (int i = 0; i < firstNum.Length; i++)       // Compare elements
            {
                bool equal = firstNum[i] == secondNum[i];

                Console.WriteLine(equal);

            }
        }
    }
}


