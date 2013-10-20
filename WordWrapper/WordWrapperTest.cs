using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WordWrapper
{
    [TestClass]
    public class WordWrapperTest
    {
        // Getting stuck is a result of diving into the problem instead of
        // incrementally dealing with complexity.
        // First we do the simplest degenerate cases in TDD
        private void AssertWraps(string s, int width, string expected)
        {
            Assert.AreEqual(expected, Wrap(s, width));
        }

        [TestMethod]
        public void ShouldWrap()
        {
            AssertWraps(null, 1, string.Empty);
            AssertWraps(string.Empty, 1, string.Empty);
            AssertWraps("x", 1, "x");
            AssertWraps("xx", 1, "x\nx");
            AssertWraps("xxx", 1, "x\nx\nx");
            AssertWraps("x x", 1, "x\nx");
            AssertWraps("x xx", 3, "x\nxx");
            AssertWraps("four score and seven years ago our fathers brought forth upon this continent"
                , 7, "four\nscore\nand\nseven\nyears\nago our\nfathers\nbrought\nforth\nupon\nthis\ncontine\nnt");
        }

        private string Wrap(string s, int width)
        {
            if (s == null)
                return string.Empty;
            if (s.Length <= width)
                return s;
            else
            {
                int breakPoint = s.LastIndexOf(" ", width);
                if (breakPoint == -1)
                    breakPoint = width;
                return s.Substring(0, breakPoint) + '\n' + Wrap(s.Substring(breakPoint).Trim(), width);
            }
        }
    }
}