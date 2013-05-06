using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.MultiCurrencyMoney
{
    public class Dollar : Money
    {
        

        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }
    }
}
