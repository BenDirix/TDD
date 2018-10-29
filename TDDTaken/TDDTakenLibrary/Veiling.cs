using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTakenLibrary
{
    public class Veiling
    {
        private decimal _hoogsteBod;
        public void DoeBod(decimal bedrag)
        {
            if(bedrag > _hoogsteBod)
                _hoogsteBod = bedrag;
        }
        public decimal HoogsteBod
        {
            get
            {
                return _hoogsteBod;
            }
        }
    }
}
