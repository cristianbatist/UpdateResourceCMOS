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
    
    public partial class PZ_Setup
    {
        public int id { get; set; }
        public int id_PZ_PlanZakaz { get; set; }
        public int KolVoDneyNaPrijemku { get; set; }
        public string PunktDogovoraOSrokahPriemki { get; set; }
        public string UslovieOplatyText { get; set; }
        public int UslovieOplatyInt { get; set; }
        public int TimeNaRKD { get; set; }
        public int RassmotrenieRKD { get; set; }
        public int SrokZamechanieRKD { get; set; }
        public string userTP { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual PZ_PlanZakaz PZ_PlanZakaz { get; set; }
    }
}
