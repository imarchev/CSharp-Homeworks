using System;

//Gravitation on the Moon

//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

class GravitatioOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("Enter your weight :");
        decimal weight = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Your weight on the moon will be : " + (weight * 17) / 100 + " kg");
    }
}
       // Depends on regional settings you may have to use "." or "," sign when enter the weight.
