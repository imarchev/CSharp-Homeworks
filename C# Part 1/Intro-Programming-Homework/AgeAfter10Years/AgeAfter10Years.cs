using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Enter your date of birth (yyyy-mm-dd)");
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Now;
        int age = today.Year - birthday.Year;
        if (today < birthday.AddYears(age)) age--;
        Console.WriteLine("You are {0} years old.", age);
        Console.WriteLine("After 10 years you will be {0} years old.", age + 10);
    }
}
