using System;
using System.Threading;
using System.Globalization;

//Print Company Information

//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, 
//age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

class PrintCompanyInformation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Company Name:");
        string companyName = Console.ReadLine();
        Console.WriteLine("Company address:");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("Phone number:");
        string phoneNumber = Console.ReadLine();
        Console.WriteLine("Fax number: ");
        string faxNumber = Console.ReadLine();
        Console.WriteLine("Web site:");
        string webSite = Console.ReadLine();
        Console.WriteLine("Manager first name:");
        string firstNama = Console.ReadLine();
        Console.WriteLine("Manager last name:");
        string lastName = Console.ReadLine();
        Console.WriteLine("Manager age:");
        byte age = byte.Parse(Console.ReadLine());
        Console.WriteLine("Manager phone:");
        string managePhone = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", phoneNumber);
        Console.WriteLine("Fax: {0}", faxNumber);
        Console.WriteLine("Web site: {0}", webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel.{3})", firstNama, lastName, age, managePhone);
    }
}

