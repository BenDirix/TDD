﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;
using Moq;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class LandServiceTest
    {
        private Mock<ILandDAO> mockFactory;

        private ILandDAO landDAO; //STUB
        private LandService landService; //TE TESTEN CLASS

        [TestInitialize]
        public void Initialize()
        {
            mockFactory = new Mock<ILandDAO>();

            mockFactory.Setup(eenLandDAO => eenLandDAO.OppervlakteAlleLanden()).Returns(20);
            mockFactory.Setup(eenLandDAO => eenLandDAO.Read("B")).Returns(new Land { Landcode = "B", Oppervlakte = 5 });

            mockFactory.Setup(eenLandDAO => eenLandDAO.Read("NL")).Returns(new Land { Landcode = "NL", Oppervlakte = 6 });
            mockFactory.Setup(eenLandDAO => eenLandDAO.Read(string.Empty)).Throws(new ArgumentException());

            landDAO = mockFactory.Object;
            landService = new LandService(landDAO);
        }
        [TestMethod]
        public void VerhoudingOppervlakteLandTovOppervlakteAlleLanden()
        {
            Assert.AreEqual(0.25m,landService.VerhoudingOppervlakteLandTovOppervlakteAlleLanden("B"));

            mockFactory.Verify(eenLandDAO => eenLandDAO.OppervlakteAlleLanden());
            mockFactory.Verify(eenLandDAO => eenLandDAO.Read("B"));
        }
    }
}
