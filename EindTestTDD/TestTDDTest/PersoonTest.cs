using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTDDLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTDDTest
{
    [TestClass]
    public class PersoonTest
    {              
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void LijstVoornamenMagNietLeegZijn()
        {
           new Persoon(new List<string> { });
        }
        [TestMethod, ExpectedException(typeof(NullReferenceException))]
        public void LijstVoornamenMagNietNullZijn()
        {
            new Persoon(null);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NaamMoetMinstens1LetterBevatten()
        {
            new Persoon(new List<string> { "Asterix", "" });
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NaamMagGeenWhiteSpacesBevatten()
        {
            new Persoon(new List<string> { "asterix", "Obelix "});
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NaamMagGeenSymbolenBevatten()
        {
            new Persoon(new List<string> { "asterix", "Ob3l!x" });
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenPersoonMagGeenTweeKeerDezelfdeVoornaamHebben()
        {
            new Persoon(new List<string> { "Asterix", "Obelix", "Idefix", "obelix" });
        }

        [TestMethod]
        public void ToStringGeeftStringVoornamenGescheidenDoorSpatiesOK()
        {            
            var persoon = new Persoon(new List<string> { "Asterix", "Obelix" });
            Assert.AreEqual("Asterix Obelix", persoon.ToString());
        }

        [TestMethod]
        public void ToStringGeeftStringVoornamenGescheidenDoorSpatiesNietOK()
        {
            var persoon = new Persoon(new List<string> { "Asterix", "Obelix" });
            Assert.AreNotEqual("AsterixObelix", persoon.ToString());
        }
        [TestMethod]
        public void ToStringGeeftBij1NaamGewoonDeVoornaamOK()
        {
            var persoon = new Persoon(new List<string> { "Asterix"});
            Assert.AreEqual("Asterix", persoon.ToString());
        }
        [TestMethod]
        public void ToStringGeeftBij1NaamGewoonDeVoornaamNietOK()
        {
            var persoon = new Persoon(new List<string> { "Asterix" });
            Assert.AreNotEqual("Asterix ", persoon.ToString());
        }
    }
}
