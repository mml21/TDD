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

        private String currency;


        public abstract Money Times(int amount);

        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public string Currency()
        {
            return currency;
        }


        public override bool Equals(Object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount
                && GetType() == obj.GetType() ;
        }

        public static Dollar Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Franc Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }
    }
}
