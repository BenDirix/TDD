using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDTakenLibrary;

namespace TDDTakenLibraryTest
{
    class KostDAOStub : IKostDAO
    {
        public decimal TotaleKost()
        {
            //throw new NotImplementedException();
            return 200m;
        }
    }
}
