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
    
    public partial class Lot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lot()
        {
            this.LotHosts = new HashSet<LotHost>();
        }
    
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double UnitPrice { get; set; }
        public string Image { get; set; }


        public string FormatPrice
        {
            get
            {
                if (UnitPrice > 1000)
                {
                    return String.Format("{0:n}", UnitPrice);
                }
                return UnitPrice + "";
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LotHost> LotHosts { get; set; }
    }
}
