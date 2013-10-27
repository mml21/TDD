using System;
using NUnit.Framework;

namespace CleanCoders.TDD.TestFixtures {

    [TestFixture]
    public class TransientFreshTestNUnit 
    {
        // Never need teardown functions with Transient Fresh Tests since
        // nothing survives the tests

        // We could use the constructor but the convention makes us use a setup
        // method instead
        public TransientFreshTestNUnit()
        {
            Console.Out.WriteLine("construct");
        }

        [SetUp]
        public void SetUp()
        {
            Console.Out.WriteLine("setup");
        }

        [TestCase]
        public void TestMethod1()
        {
            Console.Out.WriteLine("test1");
        }

        [TestCase]
        public void TestMethod2()
        {
            Console.Out.WriteLine("test2");
        }
    }
}
