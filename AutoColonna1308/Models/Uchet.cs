//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoColonna1308.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Uchet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Uchet()
        {
            this.Staff = new HashSet<Staff>();
        }
    
        public int IdUchet { get; set; }
        public int IdChel { get; set; }
        public Nullable<System.DateTime> DaytimeStart { get; set; }
        public Nullable<System.DateTime> DaytimeFinish { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Staff> Staff { get; set; }
        public virtual Staff Staff1 { get; set; }
        public virtual Staff Staff2 { get; set; }
    }
}
