using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class RekeningTest
    {
        [TestMethod]
        public void HetSaldoVanEenNieuweRekeningIsNul()
        {
            var rekening = new Rekening();
            Assert.AreEqual(decimal.Zero, rekening.Saldo);
        }

        [TestMethod]
        public void HetSaldoNaeenEersteStortingIsHetBedragvanDieStorting()
        {
            var rekening = new Rekening();
            var bedrag = 2.5m;
            rekening.Storten(bedrag);
            Assert.AreEqual(bedrag, rekening.Saldo);
        }

        [TestMethod]
        public void HetSaldoNaTweeStortingenIsDeSomVanDeBedragenVanDieStortingen()
        {
            var rekening = new Rekening();
            rekening.Storten(2.5m);
            rekening.Storten(1.2m);
            Assert.AreEqual(3.7m, rekening.Saldo);
        }
    }
}
