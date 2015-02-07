using System;

//11. Bank Account Data

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance),
//bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

class BankAccountData
{
    static void Main()
    {
        string fullName = "Ivan Ivanov Georgiev";
        decimal balance = 14531 ;
        string bankName = "Burkan Bank";
        string iban = ("BG80 BGBB 9661 1020 3456 78");
        long cCard1 = 1234567898765432;
        long cCard2 = 1234567898765433;
        long cCard3 = 1234567898765432;

        Console.WriteLine("Full Name : "+fullName);
        Console.WriteLine("Balance : "+balance+" "+"BGN");
        Console.WriteLine("Bank Name: "+bankName);
        Console.WriteLine("IBAN : "+iban);
        Console.WriteLine("Credit Card Number: "+cCard1);
        Console.WriteLine("Credit Card Number: "+cCard2);
        Console.WriteLine("Credit Card Number: "+cCard3);
    }
}
