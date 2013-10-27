using NUnit.Framework;
using System;

namespace CleanCoders.TDD.TestFixtures
{
    [TestFixture]
    public class PersistentSharedTestNUnit
    {
        public PersistentSharedTestNUnit()
        {
            Console.Out.WriteLine("construct");
        }

        [TestFixtureSetUp]
        public void SuiteSetup()
        {
            Console.Out.WriteLine("Suite setup");
        }

        [TestFixtureTearDown]
        public void SuiteTeardown()
        {
            Console.Out.WriteLine("Suite teardown");
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
