using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanCoders.TDD.TestFixtures
{
    [TestClass]
    public class TransientFreshTest 
    {
        // Never need teardown functions with Transient Fresh Tests since
        // nothing survives the tests

        // We could use the constructor but the convention makes us use a setup
        // method instead
        public TransientFreshTest()
        {
            Console.Out.WriteLine("construct");
        }

        [TestInitialize]
        public void SetUp()
        {
            Console.Out.WriteLine("setup");
        }

        [TestMethod]
        public void TestMethod1()
        {
            Console.Out.WriteLine("test1");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Console.Out.WriteLine("test2");
        }
    }
}
