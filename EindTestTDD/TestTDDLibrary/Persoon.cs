using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestTDDLibrary
{
    public class Persoon
    {
        private readonly Regex naam = new Regex(@"^([A-Za-z])+$");
        private List<string> _voornamen;
        public Persoon(List<string> voornamen)
        {
            _voornamen = voornamen;
            if (_voornamen.Count == 0)
                throw new ArgumentException();

            if (_voornamen == null)
                throw new NullReferenceException();            
            
            for (int i = 0; i < _voornamen.Count(); i++)
            {
                if (!naam.IsMatch(_voornamen[i]))
                    throw new ArgumentException();

                List<string> voornamen2 = new List<string>(voornamen);
                voornamen2.Remove(_voornamen[i]);
                for (int j = 0; j < voornamen2.Count(); j++)
                {
                    if (voornamen[i].ToLower() == voornamen2[j].ToLower())
                        throw new ArgumentException();
                }
            }              
        }
        public override string ToString()
        {
            if (_voornamen.Count > 1)
                return string.Join(" ", _voornamen).ToString();
            else
                return _voornamen[0];
        }
    }
}
