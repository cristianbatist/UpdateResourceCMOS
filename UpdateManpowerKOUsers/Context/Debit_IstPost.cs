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
    
    public partial class Debit_IstPost
    {
        public int id { get; set; }
        public int id_DebitTask { get; set; }
        public double transportSum { get; set; }
        public string numberOrder { get; set; }
        public double ndsSum { get; set; }
        public Nullable<int> currency { get; set; }
    
        public virtual Debit_WorkBit Debit_WorkBit { get; set; }
    }
}
