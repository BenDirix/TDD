using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{    
    public class Rekeningnummer
    {
        private static readonly Regex regex = new Regex(@"^\d{3}-\d{7}-\d{2}$");
        private readonly string nummer;

        public Rekeningnummer(string nummer)
        {
            //throw new NotImplementedException();

            if (!regex.IsMatch(nummer))
                throw new ArgumentException();

            var eerste10Cijfers = long.Parse(nummer.Substring(0, 3) + nummer.Substring(4, 7));
            var laatste2Cijfers = long.Parse(nummer.Substring(12, 2));
            if (eerste10Cijfers % 97 != laatste2Cijfers)
                throw new ArgumentException();

            this.nummer = nummer;
        }
        public override string ToString()
        {
            return nummer;
        }
    }
}
