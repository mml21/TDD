using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.MultiCurrencyMoney
{
    public abstract class Money
    {
        protected internal int amount;


        public override bool Equals(Object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount
                && GetType() == obj.GetType() ;
        }

        public static Dollar Dollar(int amount)
        {
            return new Dollar(amount);
        }

        public abstract Money Times(int amount);
    }
}
