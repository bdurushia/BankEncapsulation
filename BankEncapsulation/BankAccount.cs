using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        // Setting Property
        private double _balance {  get; set; }

        // Methods
        public void Deposit(double addMoney)
        {
            _balance += addMoney;
        }

        public double GetBalance() { return _balance; }
    }
}
