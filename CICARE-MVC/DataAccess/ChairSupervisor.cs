//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChairSupervisor
    {
        public int ChairSupervisorID { get; set; }
        public int ChairID { get; set; }
        public int SupervisorChairID { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public bool Active { get; set; }
        public int AssignedToChairID { get; set; }
    
        public virtual Chair Chair { get; set; }
        public virtual Chair Chair1 { get; set; }
        public virtual Chair Chair2 { get; set; }
    }
}
