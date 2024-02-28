using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class ATM
    {
        public static void UserInterface(BankAccount account)
        {
            AsciiTitle();
            Console.Write("\n\n\t\tWelcome to Filthy Casual Banking Inc.!\n\t\tPress Enter to Conintue: ");
            Console.ReadLine();

            bool runATM = true;

            while (runATM)
            {
                Console.WriteLine("\n\t\tWhat would you like to do in your account?");
                Console.Write("\n\t\tType '1' to deposit, '2' to Check Balance, or '3' to exit: ");
                var continueAddMoney = Console.ReadLine().ToLower();

                Console.Clear();
                AsciiTitle();
                
                switch (continueAddMoney)
                {
                    case "1":
                        Deposit.AddMoney(account);
                        runATM = true;
                        break;
                    case "2":
                        var currentBalance = String.Format("{0:0.00}", account.GetBalance());
                        Console.WriteLine($"\n\t\tYour balance is ${currentBalance}");
                        runATM = true;
                        break;
                    case "3":
                        Console.WriteLine("\n\t\tThank you for using Filthy Casual Banking Inc!\n\n\t\t\tPlease come again!");
                        runATM = false;
                        break;
                    default:
                        Console.WriteLine("\n\t\tInvalid entry. Try again.");
                        break;
                }

            }
        }

        public static void AsciiTitle()
        {
            Console.WriteLine
            ("  _____ _ _ _   _              ____                      _ \r\n |  ___(_) | |_| |__  _   _   / ___|__ _ ___ _   _  __ _| |\r\n | |_  | | | __| '_ \\| | | | | |   / _` / __| | | |/ _` | |\r\n |  _| | | | |_| | | | |_| | | |__| (_| \\__ \\ |_| | (_| | |\r\n |_|   |_|_|\\__|_| |_|\\__, |  \\____\\__,_|___/\\__,_|\\__,_|_|\r\n  ____              _ |___/              ___               \r\n | __ )  __ _ _ __ | | _(_)_ __   __ _  |_ _|_ __   ___    \r\n |  _ \\ / _` | '_ \\| |/ / | '_ \\ / _` |  | || '_ \\ / __|   \r\n | |_) | (_| | | | |   <| | | | | (_| |  | || | | | (__ _  \r\n |____/ \\__,_|_| |_|_|\\_\\_|_| |_|\\__, | |___|_| |_|\\___(_) \r\n                                 |___/                     ");
        }
    }
}
