//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Organiziranje_sportskog_događaja
{
    using System;
    using System.Collections.Generic;
    
    public partial class dogadaj
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dogadaj()
        {
            this.turnirs = new HashSet<turnir>();
            this.korisniks = new HashSet<korisnik>();
        }
    
        public int Id_dogadaj { get; set; }
        public string naziv { get; set; }
        public string opis { get; set; }
        public System.DateTime datum_izvodenja { get; set; }
        public string lokacija { get; set; }
        public System.DateTime rok_prijave { get; set; }
        public int organizator { get; set; }
        public int status { get; set; }
    
        public virtual organizacija organizacija { get; set; }
        public virtual status_dogadaja status_dogadaja { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<turnir> turnirs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<korisnik> korisniks { get; set; }
    }
}
