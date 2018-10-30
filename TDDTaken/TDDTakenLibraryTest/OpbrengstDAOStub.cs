using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDTakenLibrary;

namespace TDDTakenLibraryTest
{
    class OpbrengstDAOStub : IOpbrengstDao
    {
        public decimal TotaleOpbrengst()
        {
            //throw new NotImplementedException();
            return 250m;
        }
    }
}
