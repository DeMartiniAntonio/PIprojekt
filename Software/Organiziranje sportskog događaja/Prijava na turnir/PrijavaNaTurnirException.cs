using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organiziranje_sportskog_događaja.Prijava_na_turnir
{
    public class PrijavaNaTurnirException : ApplicationException
    {
        public string Poruka { get; set; }

        public PrijavaNaTurnirException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
