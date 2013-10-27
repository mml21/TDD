using System;
using NUnit.Framework;

namespace CleanCoders.TDD.TestFixtures
{
    [TestFixture]
    public class PersistentFreshTestNUnit
    {
        // Here we could delete socket or connections opened by the test
        // We eat breakfast in the plate and then we clean it for lunch

        public PersistentFreshTestNUnit()
        {
            Console.Out.WriteLine("construct");
        }

        [SetUp]
        public void SetUp()
        {
            Console.Out.WriteLine("setup");
        }

        [TearDown]
        public void TearDown() {
            Console.Out.WriteLine("teardown");
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
