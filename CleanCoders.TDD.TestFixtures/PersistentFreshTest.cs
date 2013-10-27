using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanCoders.TDD.TestFixtures
{
    [TestClass]
    public class PersistentFreshTest
    {
        // Here we could delete socket or connections opened by the test
        // We eat breakfast in the plate and then we clean it for lunch

        public PersistentFreshTest()
        {
            Console.Out.WriteLine("construct");
        }

        [TestInitialize]
        public void SetUp()
        {
            Console.Out.WriteLine("setup");
        }

        [TestCleanup]
        public void TearDown() {
            Console.Out.WriteLine("teardown");
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
