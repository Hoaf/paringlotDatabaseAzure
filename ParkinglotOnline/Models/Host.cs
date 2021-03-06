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

    public partial class Host
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Host()
        {
            this.BookingLotDetails = new HashSet<BookingLotDetail>();
            this.Finances = new HashSet<Finance>();
            this.LotHosts = new HashSet<LotHost>();
        }

        [Required(ErrorMessage = "You must be enter Host ID!")]
        public string ID { get; set; }
        [Required(ErrorMessage = "You must be enter Pasword!")]
        public string Password { get; set; }
        [Required(ErrorMessage = "You must be enter Full Name!")]
        public string Fullname { get; set; }
        [Required(ErrorMessage = "You must be enter Address!")]
        public string Address { get; set; }
        public string CountyID { get; set; }
        public bool isEnable { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingLotDetail> BookingLotDetails { get; set; }
        public virtual County County { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Finance> Finances { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LotHost> LotHosts { get; set; }
    }
}
