//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Klinik.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class PatientVisit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PatientVisit()
        {
            this.DetailPatientVisits = new HashSet<DetailPatientVisit>();
        }
    
        public int Id { get; set; }
        public System.DateTime TimeIn { get; set; }
        public System.DateTime TimeOut { get; set; }
        public string Diagnose { get; set; }
        public string Condition { get; set; }
        public string Treatment { get; set; }
        public string Comments { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailPatientVisit> DetailPatientVisits { get; set; }
        public virtual MsPatient Patient { get; set; }
    }
}
