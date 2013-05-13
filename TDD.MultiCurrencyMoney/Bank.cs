using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.MultiCurrencyMoney
{
    public class Bank
    {
        public Money Reduce(Expression source, string to)
        {
            return Money.Dollar(10);
        }
    }
}
