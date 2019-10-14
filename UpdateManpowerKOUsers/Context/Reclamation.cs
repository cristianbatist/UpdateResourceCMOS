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
    
    public partial class Reclamation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reclamation()
        {
            this.Reclamation_Answer = new HashSet<Reclamation_Answer>();
            this.Reclamation_PZ = new HashSet<Reclamation_PZ>();
            this.Reclamation_TechnicalAdvice = new HashSet<Reclamation_TechnicalAdvice>();
            this.ServiceRemarksReclamations = new HashSet<ServiceRemarksReclamations>();
        }
    
        public int id { get; set; }
        public int id_Reclamation_Type { get; set; }
        public int id_DevisionReclamation { get; set; }
        public int id_Reclamation_CountErrorFirst { get; set; }
        public int id_Reclamation_CountErrorFinal { get; set; }
        public string id_AspNetUsersCreate { get; set; }
        public int id_DevisionCreate { get; set; }
        public System.DateTime dateTimeCreate { get; set; }
        public string text { get; set; }
        public string description { get; set; }
        public double timeToSearch { get; set; }
        public double timeToEliminate { get; set; }
        public bool close { get; set; }
        public bool gip { get; set; }
        public bool closeDevision { get; set; }
        public string PCAM { get; set; }
        public bool editManufacturing { get; set; }
        public Nullable<int> editManufacturingIdDevision { get; set; }
        public int id_PF { get; set; }
        public bool technicalAdvice { get; set; }
        public string id_AspNetUsersError { get; set; }
        public bool closeMKO { get; set; }
        public bool fixedExpert { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual AspNetUsers AspNetUsers1 { get; set; }
        public virtual Devision Devision { get; set; }
        public virtual Devision Devision1 { get; set; }
        public virtual PF PF { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reclamation_Answer> Reclamation_Answer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reclamation_PZ> Reclamation_PZ { get; set; }
        public virtual Reclamation_CountError Reclamation_CountError { get; set; }
        public virtual Reclamation_CountError Reclamation_CountError1 { get; set; }
        public virtual Reclamation_Type Reclamation_Type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reclamation_TechnicalAdvice> Reclamation_TechnicalAdvice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceRemarksReclamations> ServiceRemarksReclamations { get; set; }
    }
}