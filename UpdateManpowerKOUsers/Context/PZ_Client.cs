//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UpdateManpowerKOUsers.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class PZ_Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PZ_Client()
        {
            this.PZ_Client1 = new HashSet<PZ_Client>();
            this.PZ_Client11 = new HashSet<PZ_Client>();
            this.PZ_FIO = new HashSet<PZ_FIO>();
            this.PZ_PlanZakaz = new HashSet<PZ_PlanZakaz>();
        }
    
        public int id { get; set; }
        public string NameSort { get; set; }
        public string INN_UNN { get; set; }
        public string Name { get; set; }
        public int GCompany { get; set; }
        public int DCCompany { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PZ_Client> PZ_Client1 { get; set; }
        public virtual PZ_Client PZ_Client2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PZ_Client> PZ_Client11 { get; set; }
        public virtual PZ_Client PZ_Client3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PZ_FIO> PZ_FIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PZ_PlanZakaz> PZ_PlanZakaz { get; set; }
    }
}
