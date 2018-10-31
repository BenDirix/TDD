using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TDDTakenLibrary
{
    public class ISBN
    {
        private readonly Regex regex = new Regex(@"^\d{13}$");
        private long _isbnNummer;
        public ISBN(long nummer)
        {
            var somOnevenPosities = 0;
            var somEvenPosities = 0;
            var numString = nummer.ToString();
            if (!regex.IsMatch(numString))
                throw new ArgumentException();
            
            for(var i = 0; i < 12; i++)
            {
                if (i % 2 == 0)
                    somEvenPosities += int.Parse(numString[i].ToString());
                else
                    somOnevenPosities += int.Parse(numString[i].ToString());
            }
            somEvenPosities *= 3;
            var somResultaten = somEvenPosities += somEvenPosities;
            var verschil = somResultaten % 10;
            var controlegetal = 10 - verschil;
            var dertiendeCijfer = int.Parse(numString[12].ToString());
            if(controlegetal == 10)            
                controlegetal = 0;
            if (dertiendeCijfer != controlegetal)
                throw new ArgumentException();     

            _isbnNummer = nummer;
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
