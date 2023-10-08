using System;
using System.Runtime.Serialization;

namespace Organiziranje_sportskog_događaja
{
    
    public class RegistracijaException : Exception
    {
        public string Poruka { get; set; }

        public RegistracijaException(string poruka) 
        {
            Poruka = poruka;
        }

    }
}