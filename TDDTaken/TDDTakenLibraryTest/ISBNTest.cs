using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTakenLibrary;

namespace TDDTakenLibraryTest
{
    [TestClass]
    public class ISBNTest
    {  
        [TestMethod]
        public void NummerMet13CijfersJuisteControleIsOk()
        {
           new ISBN(9789027439642L);
        }
        [TestMethod]
        public void NummerMet13CijfersJuisteControle10IsOk()
        {
            new ISBN(9789227439640L);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NummerMet12CijfersIsNietOK()
        {
           new ISBN(978902743964L);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NummerMet14CijfersIsNietOK()
        {
            new ISBN(97890274396423L);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void HetNummer0IsVerkeerd()
        {
            new ISBN(0);
        }
        [TestMethod,ExpectedException(typeof(ArgumentException))]
        public void EenNegatiefNummerIsVerkeerd()
        {
            new ISBN(-9789027439642L);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NummerMet13CijfersVerkeerdeControleIsNietOk()
        {
            new ISBN(9789027439641L);
        }        
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NummerMet13CijfersVerkeerdeControle10IsNietOk()
        {
            new ISBN(7789227439640L);
        }
    }
}
