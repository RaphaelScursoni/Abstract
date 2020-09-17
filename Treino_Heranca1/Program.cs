using System;
using Treino_Heranca1.Entities;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;

namespace Treino_Heranca1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            new BusinessAccount(1001, "Alex", 500.0, 500);
            new SavingsAccount(1002, "Anna", 1000.0, 0.01);
            new BusinessAccount(1003, "Pedro", 550.0, 500);
            new SavingsAccount(1004, "Raphael", 1500.0, 0.02);

            double sum = 0;

            foreach (Account acc in list)
            {

                sum += acc.Balance;
            }

            Console.WriteLine("Sum acc: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
            }
            foreach (Account acc in list)
            {
                Console.WriteLine
                    (
                        "Updated ballance from account: "
                        + acc.Number
                        + ": "
                        + acc.Balance
                    ) ;
            }


        }
    }
}
