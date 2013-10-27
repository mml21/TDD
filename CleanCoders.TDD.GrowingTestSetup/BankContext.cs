using System;
using NUnit.Framework;

namespace CleanCoders.TDD.GrowingTestSetup
{
    // Test Hierarchies in NUnit
    // Test classes can inherit from each other
    // NUnit allows you to specify that a class is a TestClass
    // Composed Actions: Multiple Acts on a single Utility Method, e.g. 2 pops
    // The Single Assert Rule means one single logical assertion (can be composed of multiple
    // physical assertions). No Act-Assert, Act-Assert. Composed Assert is one utility function
    // that contains multiple physical Asserts. 
    // E.g AssertHVAstate("HFc") -> Heater and Fan on, Cooler off. 
    public class BankContext
    {
        [SetUp]
        public void SetInterest()
        {
            Bank.SetStandardRate(2.75);
        }

        [TestFixture]
        public class NewAccountContext : BankContext
        {
            private Account newAccount;

            [SetUp] 
            public void CreateNewAccount()
            {
                newAccount = new Account();
            }

            [Test]
            public void ItHasZeroBalance()
            {
                Assert.AreEqual(0.0, newAccount.GetBalance());
            }

            [Test]
            public void ItHasCurrentInterestRate()
            {
                Assert.AreEqual(2.75, newAccount.GetInterestRate());
            }
        }
    }
}
