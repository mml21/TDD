using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace PrimeFactorsKata
{
    [TestFixture]
    public class PrimeFactorsTests
    {
        private IEnumerable<int> List(params int[] ints)
        {
            return new List<int>(ints);
        }

        [Test]
        public void CanFactorIntoPrimes()
        {
            CollectionAssert.AreEqual(List(), PrimeFactorsOf(1));
            CollectionAssert.AreEqual(List(2), PrimeFactorsOf(2));
            CollectionAssert.AreEqual(List(3), PrimeFactorsOf(3));
            CollectionAssert.AreEqual(List(2, 2), PrimeFactorsOf(4));
            CollectionAssert.AreEqual(List(5), PrimeFactorsOf(5));
            CollectionAssert.AreEqual(List(2,3), PrimeFactorsOf(6));
            CollectionAssert.AreEqual(List(7), PrimeFactorsOf(7));
            CollectionAssert.AreEqual(List(2, 2, 2), PrimeFactorsOf(8));
            CollectionAssert.AreEqual(List(3, 3), PrimeFactorsOf(9));
            CollectionAssert.AreEqual(List(2, 2, 3, 3, 5, 7, 11, 11, 13), PrimeFactorsOf(2 * 2 * 3 * 3 * 5 * 7 * 11 * 11 * 13));
            CollectionAssert.AreEqual(List(17), PrimeFactorsOf(17));
            CollectionAssert.AreEqual(List(23), PrimeFactorsOf(23));
        }

        private IEnumerable<int> PrimeFactorsOf(int n)
        {
            var factors = new List<int>();
            var number = n;

            for (int divisor = 2; n > 1 && divisor <= Math.Sqrt(number); divisor++)
            {
                for (; n % divisor == 0; n /= divisor)
                    factors.Add(divisor);          
            }

            if (n > 1) // Input number was prime
                factors.Add(n);

            return factors;
        }
    }
}
