//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace fabrika
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tekniker
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tekniker()
        {
            this.Faaliyet = new HashSet<Faaliyet>();
        }
    
        public byte tekniker_id { get; set; }
        public string tekniker_adi { get; set; }
        public string tekniker_soyadi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Faaliyet> Faaliyet { get; set; }
    }
}
