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
    
    public partial class DetailMedicinePurchase
    {
        public int Id { get; set; }
        public string Price { get; set; }
        public string Qty { get; set; }
        public System.DateTime ExpDate { get; set; }
    
        public virtual MsMedicinePurchase MedicinePurchase { get; set; }
        public virtual MsMedicine Medicine { get; set; }
    }
}
