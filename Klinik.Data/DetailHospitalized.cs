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
    
    public partial class DetailHospitalized
    {
        public int Id { get; set; }
        public string Diagnose { get; set; }
        public string HospitalName { get; set; }
        public string Notes { get; set; }
    
        public virtual MsPatient Patient { get; set; }
        public virtual MsHospitalized Hospitalized { get; set; }
    }
}
