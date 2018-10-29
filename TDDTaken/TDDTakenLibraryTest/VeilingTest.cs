using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTakenLibrary;

namespace TDDTakenLibraryTest
{
    [TestClass]
    public class VeilingTest
    {
        private Veiling veiling;
        [TestInitialize]public void Initialize()
        {
            veiling = new Veiling();
        }

        [TestMethod]
        public void HetHoogsteBodIsNulAlsGeenBodIsUitgevoerd()
        {            
            Assert.AreEqual(0m, veiling.HoogsteBod);
        }

        [TestMethod]
        public void NaEersteBodIsHetHoogsteBodGelijkAanHetBedragVanHetEersteBod()
        {
            var bedrag = 30m;            
            veiling.DoeBod(bedrag);
            Assert.AreEqual(bedrag, veiling.HoogsteBod);
        }

        [TestMethod]
        public void NaMeerKeerBiedenIsHetHoogsteBodGelijkAanBedragHoogsteBod()
        {            
            veiling.DoeBod(30m);
            veiling.DoeBod(50m);
            veiling.DoeBod(45m);            
            Assert.AreEqual(50m, veiling.HoogsteBod);
        }
    }
}
