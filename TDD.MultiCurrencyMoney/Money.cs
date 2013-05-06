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


        public override bool Equals(Object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount
                && GetType() == obj.GetType() ;
        }
    }
}
