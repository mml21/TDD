using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CleanCoders.TDD.PrimeFactors
{
    [TestClass]
    // Rule: As the Tests more specific, the Production code gets more generic
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
            AssertPrimeFactors(2 * 2 * 3 * 3 * 5 * 7 * 11 * 11 * 13, 
                List(2, 2, 3, 3, 5, 7, 11, 11, 13));
        }

        private List<int> Of(int n) // Returns primes factors of a number
        {
            var factors = new List<int>();

            // This algorithm is effectively The Sieve of Eratosthenes
            // Minor improvement: Terminate loop with sqrt(n)
            var termination = Math.Sqrt(n);
            for (int divisor = 2; n > 1 || divisor < termination; divisor++)
            {
                for (; n % divisor == 0; n /= divisor)
                    factors.Add(divisor);
            }


            return factors;
        }
    }
}