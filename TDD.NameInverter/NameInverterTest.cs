using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace TDD.NameInverter
{
    [TestClass]
    public class NameInverterTest
    {
        private NameInverter nameInverter;

        [TestInitialize]
        public void Setup()
        {
            nameInverter = new NameInverter();
        }

        private void AssertInverted(String originalName, String invertedName)
        {
            Assert.AreEqual(invertedName, nameInverter.InvertName(originalName));
        }

        [TestMethod]
        public void GivenNull_ReturnsEmptyString() 
        {
           AssertInverted(null, string.Empty);
        }

        [TestMethod]
        public void GivenEmptyString_ReturnEmptyString()
        {
            AssertInverted(string.Empty, string.Empty);
        }

        [TestMethod]
        public void GivenSimpleName_ReturnSimpleName()
        {
            AssertInverted("Name", "Name");
        }

        [TestMethod]
        public void GivenFirstLast_ReturnLastFirst()
        {
            AssertInverted("First Last", "Last, First");
        }

        [TestMethod]
        public void GivenASimpleNameWithSpaces_ReturnSimpleNameWithoutSpaces()
        {
            AssertInverted(" Name ", "Name");
        }

        [TestMethod]
        public void GivenFirstLastWithExtraSpaces_ReturnsLastFirst()
        {
            AssertInverted("    First   Last   ", "Last, First");
            AssertInverted("First Last BS. Phd.", "Last, First BS. Phd.");
        }

        [TestMethod]
        public void IgnoreHonorifics()
        {
            AssertInverted("Mr. First Last", "Last, First");
            AssertInverted("Mrs. First Last", "Last, First");
        }

        [TestMethod]
        public void PostNominals_StayAtEnd()
        {
            AssertInverted("First Last Sr.", "Last, First Sr.");
        }

        [TestMethod]
        public void Integration()
        {
            AssertInverted("   Robert    Martin    III   esq.     ", "Martin, Robert III esq.");
        }

      
    }
}
