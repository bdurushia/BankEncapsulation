using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public static class Deposit
    {
        public static void AddMoney(BankAccount account)
        {
            
            bool isDouble;
            do
            {
                Console.Write("\n\t\tEnter the amount of money you'd like to deposit: $");
                isDouble = double.TryParse(Console.ReadLine(), out double addMoney);

                if (isDouble)
                {
                    account.Deposit(addMoney);
                    Console.Clear();
                    ATM.AsciiTitle();
                }
                else
                {
                    Console.Clear();
                    ATM.AsciiTitle();
                    Console.WriteLine("\t\tSorry, your entry must be numbers. Please try again.\n");
                }

            } while (!isDouble);
        }
    }
}
