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
    
    public partial class ManagementRoundAttendance
    {
        public int ManagementRoundAttendanceID { get; set; }
        public int ManagementRoundID { get; set; }
        public int AttendeeUserID { get; set; }
    
        public virtual ManagementRound ManagementRound { get; set; }
        public virtual User User { get; set; }
    }
}
