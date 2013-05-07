using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.MultiCurrencyMoney
{
    public class Franc : Money
    {
        private String currency;

        public Franc(int amount, string currency) : base(amount, currency) {}


        public override Money Times(int multiplier)
        {
            return Money.Franc(amount*multiplier);
        }

    }
}
