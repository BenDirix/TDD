using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTakenLibrary
{
    public class WinstService
    {
        private readonly IOpbrengstDao _opbrengstDAO;
        private readonly IKostDAO _kostDAO;

        public WinstService(IOpbrengstDao opbrengstDao, IKostDAO kostDAO)
        {
            _opbrengstDAO = opbrengstDao;
            _kostDAO = kostDAO;
        }
        public decimal Winst
        {
            get
            {                
                return _opbrengstDAO.TotaleOpbrengst() - _kostDAO.TotaleKost();
            }
        }
    }
}
