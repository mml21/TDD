using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordWrapper
{
    [TestClass]
    public class WordWrapperTest
    {
        [TestMethod]
        public void ShouldWrap()
        {
            Assert.AreEqual("word\nword", Wrap("word word", 4));
        }

        private string Wrap(string s, int width)
        {
            return s.Replace(" ", "\n");
        }
    }
}
