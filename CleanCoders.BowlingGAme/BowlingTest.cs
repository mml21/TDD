using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanCoders.BowlingGAme
{
    [TestClass]
    public class BowlingTest
    {
        private Game g;

        [TestInitialize]
        public void SetUp()
        {
            g = new Game();
        }

        private void RollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
                g.Roll(pins);
        }

        [TestMethod]
        public void GutterGame()
        {
            RollMany(20, 0);
            Assert.AreEqual(0, g.Score());
        }

        [TestMethod]
        public void AllOnes()
        {
            RollMany(20, 1);
            Assert.AreEqual(20, g.Score());
        }

        [TestMethod]
        public void OneSpare()
        {
            g.Roll(5);
            g.Roll(5); // Spare
            g.Roll(3);
            RollMany(17, 0);
            Assert.AreEqual(16, g.Score());
        }


    }
}
