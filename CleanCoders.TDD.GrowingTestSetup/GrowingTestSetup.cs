using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanCoders.TDD.GrowingTestSetup
{
    [TestClass]
    public class GrowingTestSetup
    {
        private Account newAccount;
        private Account oldAccount;
        private double newRate = 0.0035;
        private double oldRate = 0.0025;
        private double delta = 0.000001;

        [TestInitialize]
        public void SetUp()
        {
            Bank.SetStandardRate(oldRate);
            oldAccount = new Account();
            Bank.SetStandardRate(newRate);
            newAccount = new Account();
        }

        [TestMethod]
        public void UponNewAccount_BalanceWillBeZero()
        {
            Assert.AreEqual(0, newAccount.GetBalance());
        }

        [TestMethod]
        public void UponNewAccount_HasStandardInterestRate() 
        {
            Assert.AreEqual(Bank.GetStandardRate(), newAccount.GetInterestRate(), delta);
        }

        [TestMethod]
        public void WhenRateChange_OldAccountKeepsOldRate()
        {
            Assert.AreEqual(oldRate, oldAccount.GetInterestRate(), delta);
            Assert.AreEqual(newRate, newAccount.GetInterestRate(), delta);
        }
    }
}
