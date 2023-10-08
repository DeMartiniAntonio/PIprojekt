using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organiziranje_sportskog_događaja.Kreiranje_tima
{
    public class KreiranjeTimaException : ApplicationException
    {
        public string Poruka { get; set; }
        public KreiranjeTimaException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
