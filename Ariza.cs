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
    
    public partial class Ariza
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ariza()
        {
            this.Faaliyet = new HashSet<Faaliyet>();
        }
    
        public byte ariza_id { get; set; }
        public string ariza_nedeni { get; set; }
        public string ariza_tarih { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Faaliyet> Faaliyet { get; set; }
    }
}
