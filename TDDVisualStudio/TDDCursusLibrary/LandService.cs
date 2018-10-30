using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class LandService
    {
        //private LandDAO landDAO = new LandDAO();
        private readonly ILandDAO landDAO; //landDAO = null

        //constructor
        public LandService(ILandDAO landDAO)
        {
            this.landDAO = landDAO;
        }
        public decimal VerhoudingOppervlakteLandTovOppervlakteAlleLanden(string landcode)
        {
            //throw new NotImplementedException();
            var land = landDAO.Read(landcode);
            var oppervlakteAlleLanden = landDAO.OppervlakteAlleLanden();
            return (decimal)land.Oppervlakte / oppervlakteAlleLanden;
        }
    }
}
