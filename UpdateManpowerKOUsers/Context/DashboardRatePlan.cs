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
    
    public partial class DashboardRatePlan
    {
        public int id { get; set; }
        public int id_DashboardBP_State { get; set; }
        public double rate { get; set; }
        public double plan { get; set; }
    
        public virtual DashboardBP_State DashboardBP_State { get; set; }
    }
}
