using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.MultiCurrencyMoney
{
    public class Sum : Expression
    {
        public Expression Augend { get; set; }
        public Expression Addend { get; set; }


        public Sum(Expression augend, Expression addend)
        {
            this.Augend = augend;
            this.Addend = addend;
        }

        public Money Reduce(Bank bank, string to)
        {
            int amount = Augend.Reduce(bank, to).amount + Addend.Reduce(bank, to).amount;
            return new Money(amount, to);
        }

        public Expression Plus(Expression addend)
        {
            return null;
        }
    }
}
