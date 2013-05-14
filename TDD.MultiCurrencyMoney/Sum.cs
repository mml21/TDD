using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.MultiCurrencyMoney
{
    public class Sum : Expression
    {
        public Money Augend { get; set; }

        public Money Addend { get; set; }


        public Sum(Money augend, Money addend)
        {
            this.Augend = augend;
            this.Addend = addend;
        }

        public Money Reduce(string to)
        {
            int amount = Augend.amount + Addend.amount;
            return new Money(amount, to);
        }

    }
}
