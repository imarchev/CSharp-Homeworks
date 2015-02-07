using System;

//8. Prime Number Check

//Write an expression  thatchecks if given positive integer number n (n = 100) is prime 
//(i.e. it is divisible without remainder only to itself and 1).

class PrimeNumberCheck
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        if (number == 1)
        {
            Console.WriteLine(false);
        }
        else
            if ((number % 2 > 0)
                && (number % 3 > 0) && (number % 5 > 0)
                && (number % 7 > 0) || (number == 2)
                || (number == 3) || (number == 5) || (number == 7))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

    }
}
