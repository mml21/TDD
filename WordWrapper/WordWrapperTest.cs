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
            Assert.AreEqual("a dog", Wrap("a dog", 5));
        }

        private string Wrap(string s, int width)
        {
            return (s.Length > width ? s.Replace(" ", "\n") : s);
        }
    }
}
