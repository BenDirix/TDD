using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intellitest
{
    public class Class1
    {
        public bool IsSchrikkelJaar(int jaar)
        {
            if(jaar % 400 == 0)
            {
                return true;
            }
            if(jaar % 100 == 0)
            {
                return false;
            }
            return jaar % 4 == 0;
        }
    }
}
