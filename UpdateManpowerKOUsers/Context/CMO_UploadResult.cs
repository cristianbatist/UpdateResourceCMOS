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
    
    public partial class CMO_UploadResult
    {
        public int id { get; set; }
        public int id_CMO_Tender { get; set; }
        public Nullable<System.DateTime> dateTimeUpload { get; set; }
        public string userUpload { get; set; }
        public double cost { get; set; }
        public Nullable<System.DateTime> dateComplited { get; set; }
        public int id_CMO_Company { get; set; }
        public Nullable<int> day { get; set; }
        public Nullable<bool> winnerBit { get; set; }
    
        public virtual CMO_Company CMO_Company { get; set; }
        public virtual CMO_Tender CMO_Tender { get; set; }
    }
}
