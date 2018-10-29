using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTakenLibrary;

namespace TDDTakenLibraryTest
{
    [TestClass]
    public class VeilingTest
    {
        [TestMethod]
        public void HetHoogsteBodIsNulAlsGeenBodIsUitgevoerd()
        {
            var veiling = new Veiling();
            Assert.AreEqual(0m, veiling.HoogsteBod);
        }
        [TestMethod]
        public void NaEersteBodIsHetHoogsteBodGelijkAanHetBedragVanHetEersteBod()
        {
            var bedrag = 30m;
            var veiling = new Veiling();
            veiling.DoeBod(bedrag);
            Assert.AreEqual(bedrag, veiling.HoogsteBod);
        }
        [TestMethod]
        public void NaMeerKeerBiedenIsHetHoogsteBodGelijkAanBedragHoogsteBod()
        {
            var veiling = new Veiling();
            veiling.DoeBod(30m);
            veiling.DoeBod(50m);
            veiling.DoeBod(45m);
            
            Assert.AreEqual(50m, veiling.HoogsteBod);
        }
    }
}
