using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTakenLibrary;
using Moq;

namespace TDDTakenLibraryTest
{
    [TestClass]
    public class WinstServiceTest
    {
        private Mock<IKostDAO> _mockKostDAO;
        private Mock<IOpbrengstDao> _mockOpbrengstDAO;
        private IKostDAO _kostDAO;
        private IOpbrengstDao _opbrengstDAO;
        private WinstService winstService;

        [TestInitialize]
        public void Initialize()
        {
            _mockKostDAO = new Mock<IKostDAO>();
            _mockOpbrengstDAO = new Mock<IOpbrengstDao>();
            _kostDAO = _mockKostDAO.Object;
            _opbrengstDAO = _mockOpbrengstDAO.Object;
            winstService = new WinstService(_opbrengstDAO, _kostDAO);

            _mockKostDAO.Setup(eenKostDAO => eenKostDAO.TotaleKost()).Returns(200m);
            _mockOpbrengstDAO.Setup(eenOpbrengstDAO => eenOpbrengstDAO.TotaleOpbrengst()).Returns(250m);
        }
        [TestMethod]
        public void WinstIsOpbrengstMinTotaleKost()
        {
            Assert.AreEqual(50m, winstService.Winst);
            _mockKostDAO.Verify(eenKostDAO => eenKostDAO.TotaleKost());
            _mockOpbrengstDAO.Verify(eenOpbrengstDAO => eenOpbrengstDAO.TotaleOpbrengst());
        }
    }
}
