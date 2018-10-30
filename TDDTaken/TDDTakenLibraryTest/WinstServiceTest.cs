using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTakenLibrary;

namespace TDDTakenLibraryTest
{
    [TestClass]
    public class WinstServiceTest
    {
        private IKostDAO _kostDAO;
        private IOpbrengstDao _opbrengstDAO;
        private WinstService winstService;

        [TestInitialize]
        public void Initialize()
        {            
            _kostDAO = new KostDAOStub();
            _opbrengstDAO = new OpbrengstDAOStub();
            winstService = new WinstService(_opbrengstDAO, _kostDAO);
        }
        [TestMethod]
        public void WinstIsOpbrengstMinTotaleKost()
        {
            Assert.AreEqual(50m, winstService.Winst);
        }
    }
}
