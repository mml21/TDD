using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CleanCoders.TDD.PrimeFactors
{
    [TestClass]
    // Rule: When the Tests more specific, the Production code gets more generic
        // While more general than If, If degenerate form of While
    public class PrimesFactorsTest
    {
        private List<int> List(params int[] ints)
        {
            return new List<int>(ints);
        }

        private void AssertPrimeFactors(int n, List<int> primeFactors)
        {
            CollectionAssert.AreEqual(primeFactors, Of(n));
        }

        [TestMethod]
        public void CanFactorIntoPrimes()
        {
            AssertPrimeFactors(1, List());
            AssertPrimeFactors(2, List(2));
            AssertPrimeFactors(3, List(3));
            AssertPrimeFactors(4, List(2, 2));
            AssertPrimeFactors(5, List(5));
            AssertPrimeFactors(6, List(2, 3));
            AssertPrimeFactors(7, List(7));
            AssertPrimeFactors(8, List(2, 2, 2));
            AssertPrimeFactors(9, List(3, 3));
        }

        private List<int> Of(int n) // Returns primes factors of a number
        {
            var factors = new List<int>();
            if (n > 1)
            {
 
                while (n % 2 == 0)
                {
                    factors.Add(2);
                    n /= 2;
                }
                while (n % 3 == 0)
                {
                    factors.Add(3);
                    n /= 3;
                }
            }            
            if (n > 1) 
                factors.Add(n);

            return factors;
        }
    }
}