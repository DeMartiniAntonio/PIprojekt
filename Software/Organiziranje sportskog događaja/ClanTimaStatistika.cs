using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organiziranje_sportskog_događaja
{
    public class ClanTimaStatistika
    {
        public string ime { get; set; }
        public string  prezime { get; set; }
        public string korisnicko_ime { get; set; }
        public ClanTimaStatistika(string ime, string prezime, string korisnicko_ime)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.korisnicko_ime = korisnicko_ime;
        }
    }
}
