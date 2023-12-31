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
    
    public partial class turnir
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public turnir()
        {
            this.grupas = new HashSet<grupa>();
            this.raspored_utakmica = new HashSet<raspored_utakmica>();
            this.tims = new HashSet<tim>();
            this.korisniks = new HashSet<korisnik>();
            this.statistika_igraca = new HashSet<statistika_igraca>();
        }
    
        public int id_turnir { get; set; }
        public string naziv { get; set; }
        public double kotizacija { get; set; }
        public int max_clanova_tima { get; set; }
        public int id_dogadaj { get; set; }
        public int id_sport { get; set; }
    
        public virtual dogadaj dogadaj { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<grupa> grupas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<raspored_utakmica> raspored_utakmica { get; set; }
        public virtual sport sport { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tim> tims { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<korisnik> korisniks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<statistika_igraca> statistika_igraca { get; set; }
    }
}
