//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ParkinglotOnline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class LotHost
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LotHost()
        {
            this.BookingLotDetails = new HashSet<BookingLotDetail>();
        }
        
        public string LoHID { get; set; }
        public string HostID { get; set; }
        public string LotID { get; set; }
        public bool Available { get; set; }
        public Nullable<bool> isEnable { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingLotDetail> BookingLotDetails { get; set; }
        public virtual Host Host { get; set; }
        public virtual Lot Lot { get; set; }
    }
}