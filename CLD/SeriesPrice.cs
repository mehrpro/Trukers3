//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CLD
{
    using System;
    using System.Collections.Generic;
    
    public partial class SeriesPrice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SeriesPrice()
        {
            this.Cash = new HashSet<Cash>();
            this.Queue = new HashSet<Queue>();
        }
    
        public int SereisID { get; set; }
        public int SeriesName { get; set; }
        public Nullable<int> SeriesCount { get; set; }
        public System.DateTime SeriesDateStart { get; set; }
        public Nullable<System.DateTime> SeriesDateEnd { get; set; }
        public Nullable<int> Faleh { get; set; }
        public Nullable<int> Packet { get; set; }
        public Nullable<int> Gandom { get; set; }
        public Nullable<int> Clinker { get; set; }
        public Nullable<bool> closing { get; set; }
        public Nullable<byte> userCreator { get; set; }
        public Nullable<short> Member { get; set; }
        public Nullable<short> Native { get; set; }
        public Nullable<short> Other { get; set; }
        public Nullable<bool> enabeled { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cash> Cash { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Queue> Queue { get; set; }
        public virtual Users Users { get; set; }
    }
}
