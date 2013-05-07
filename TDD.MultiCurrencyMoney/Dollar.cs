using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.MultiCurrencyMoney
{
    public class Dollar : Money
    {
        private String currency;

        public Dollar(int amount, string currency) : base(amount, currency) {}

        public override Money Times(int multiplier)
        {
            return Money.Dollar(amount * multiplier);
        }

    }
}
