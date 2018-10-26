using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTakenLibrary;

namespace TDDTakenLibraryTest
{
    [TestClass]
    public class WoordTest
    {
        [TestMethod]
        public void RacecarIsEenPalindroom()
        {
            Assert.IsTrue(new Woord("Racecar").IsPalindroom);
        }
        [TestMethod]
        public void KayakIsEenPalindroom()
        {
            Assert.IsTrue(new Woord("Kayak").IsPalindroom);
        }

        [TestMethod]
        public void MotorIsGeenPalindroom()
        {
            Assert.IsFalse(new Woord("Motor").IsPalindroom);
        }
    }
}
