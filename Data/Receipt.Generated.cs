//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeightProgram.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Receipt
    {
        public int Id { get; set; }
        public string ReceiptCode { get; protected set; }
        public int TotalCost { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> WeightDataId { get; set; }
    
        public virtual WeightData WeightData { get; set; }
    }
}
