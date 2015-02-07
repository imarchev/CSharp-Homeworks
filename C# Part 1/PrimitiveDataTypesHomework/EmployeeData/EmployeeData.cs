using System;

//A marketing company wants to keep record of its employees. Each record would have the following characteristics:

//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
//Use descriptive names. Print the data at the console.

    class EmployeeData
    {
        static void Main()
        {
            Console.WriteLine("First Name :");
            string firstName = Console.ReadLine();

            Console.WriteLine("Last Name :");
            string lastName = Console.ReadLine();

            Console.WriteLine("Age :");
            string ageInput = Console.ReadLine();
            byte age = byte.Parse(ageInput);

            Console.WriteLine("Gender m/f :");
            char gender = char.Parse(Console.ReadLine());
            
            Console.WriteLine("Personal ID number :");
            string idNumberInput = Console.ReadLine();
            int idNumber = int.Parse(idNumberInput);

            Console.WriteLine("Employee number :");
            string employeeNumberInput = Console.ReadLine();
            long employeeNumber = long.Parse(employeeNumberInput);
            Console.Clear();

            Console.WriteLine("First Name:{0}",firstName);
            Console.WriteLine("Last Name:{0}", lastName);
            Console.WriteLine("Age:{0}", age);
            Console.WriteLine("Gender:{0}", gender);
            Console.WriteLine("Personal ID number:{0}", idNumber);
            Console.WriteLine("Employee number:{0}", employeeNumber);


        }
    }
