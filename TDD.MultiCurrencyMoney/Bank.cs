using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.MultiCurrencyMoney
{
    public class Bank
    {
        private Dictionary<Pair, int> rates = new Dictionary<Pair, int>();  

        public Money Reduce(Expression source, string to)
        {
            return source.Reduce(this, to);
        }

        public int Rate(String from, String to)
        {
            int rate;
            if (from.Equals(to)) return 1;
            if (rates.TryGetValue(new Pair(from, to), out rate))
                return rate;
            return 1;
        }

        public void AddRate(String from, String to, int rate)
        {
            rates.Add(new Pair(from, to), rate);
        }

    }

    class Pair
    {
        private String from;
        private String to;

        public Pair(String from, String to)
        {
            this.from = from;
            this.to = to;
        }

        public override bool Equals(object o)
        {
            Pair pair = (Pair) o;
            return from.Equals(pair.from) && to.Equals(pair.to);
        }

        public override int GetHashCode()
        {
            return 0;
        }

    }
}
