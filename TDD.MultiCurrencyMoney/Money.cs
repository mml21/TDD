using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.MultiCurrencyMoney
{
    public class Money
    {
        protected internal int amount;

        private String currency;


        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public string Currency()
        {
            return currency;
        }

        public Money Times(int multiplier)
        {
            return new Money(amount * multiplier, currency);
        }

        public override bool Equals(Object obj)
        {
            Money money = (Money) obj;
            return amount == money.amount
                && Currency().Equals(money.Currency()) ;
        }

        // Factory Method
        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        // Factory Method
        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }

    }
}
