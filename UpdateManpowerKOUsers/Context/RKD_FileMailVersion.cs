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
    
    public partial class RKD_FileMailVersion
    {
        public int id { get; set; }
        public int id_RKD_Mail_Version { get; set; }
        public System.DateTime dateTimeLastUpdateFile { get; set; }
        public string nameFile { get; set; }
    
        public virtual RKD_Mail_Version RKD_Mail_Version { get; set; }
    }
}
