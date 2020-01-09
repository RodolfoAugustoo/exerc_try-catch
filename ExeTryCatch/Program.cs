using System;
using System.Globalization;
using ExeTryCatch.Entities;
using ExeTryCatch.Entities.DomainExceptions;

namespace ExeTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the account data ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw limit: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(number, holder, initialBalance, withdraw);

                Console.Write("\r\nEnter the amount for withdraw: ");
                acc.Withdraw(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                Console.WriteLine(acc.ToString());
            }
            catch(DomainException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
