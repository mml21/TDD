using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCoders.TDD.GrowingTestSetup
{
    public class Account
    {
        private int balance = 0;
        private double interestRate = 0;

        public Account() 
        {
            balance = 0;
            interestRate = Bank.GetStandardRate(); 
        }

        public double GetBalance()
        {
            return balance;
        }

        public double GetInterestRate()
        {
            return interestRate;
        }
    }
}
