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

        private void RollSpare()
        {
            g.Roll(5);
            g.Roll(5);
        }

        private void RollStrike()
        {
            g.Roll(10);
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
            RollSpare();
            g.Roll(3);
            RollMany(17, 0);
            Assert.AreEqual(16, g.Score());
        }

        [TestMethod]
        public void OneStrike()
        {
            RollStrike();
            g.Roll(3); // After a strike we roll two more balls
            g.Roll(4);
            RollMany(16, 0);
            Assert.AreEqual(24, g.Score());
        }

        [TestMethod]
        public void PerfectGame() {
            RollMany(12, 10);
            Assert.AreEqual(300, g.Score());
        }


    }
}
