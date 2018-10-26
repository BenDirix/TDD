using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTakenLibrary
{
    public class Woord
    {
        private string woord;
        public Woord(string woord)
        {
            this.woord = woord;
        }

        public bool IsPalindroom
        {
            get
            {
                woord = woord.ToLower();
                var reversed = woord.Reverse().ToArray();
                for(var i=0; i < woord.Length; i++)
                {
                    if (woord[i] != reversed[i])
                        return false;
                }
                return true;
            }
        }
            

    }
}
