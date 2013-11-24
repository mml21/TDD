using System;
using NUnit.Framework;

namespace WordWrapperKata
{
    [TestFixture]
    public class WordWrapperTests
    {
        [Test]
        public void WrapTests()
        {
            Assert.AreEqual(string.Empty, Wrap(string.Empty, 1));
            Assert.AreEqual("x", Wrap("x", 1));
            Assert.AreEqual("xx", Wrap("xx", 2));
            Assert.AreEqual("x\nx", Wrap("xx", 1));
            Assert.AreEqual("x\nx", Wrap("x x", 1));
            Assert.AreEqual("x\nx", Wrap("x x", 2));
            Assert.AreEqual("x\nx\nx", Wrap("xxx", 1));
            Assert.AreEqual("four\nscore\nand\nseven\nyears\nago our\nfathers\nbrought\nforth\nupon\nthis\ncontine\nnt", 
                            Wrap("four score and seven years ago our fathers brought forth upon this continent", 7));
            Assert.AreEqual("When in the course\nof human events it\nbecomes necessary\nfor one People to\ndissolve the\nPolitical bonds\nwhich have tied them\nto another", 
                Wrap("When in the course of human events it becomes necessary for one People to dissolve the Political bonds which have tied them to another", 20));
        }

        public string Wrap(string s, int width)
        {
            if (string.IsNullOrWhiteSpace(s))
                return string.Empty;

            if (s.Length <= width)
                return s;
             
            int breakpoint = s.LastIndexOf(" ", width);
            if (breakpoint == -1) // If we don't find any space, we have to break the word on the max width
                breakpoint = width;
            var firstPart = s.Substring(0, breakpoint).Trim();
            var secondPart = s.Substring(breakpoint).Trim();
            return string.Format("{0}\n{1}", firstPart, Wrap(secondPart, width));

        }
    }
}
