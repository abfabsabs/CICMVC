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
    
    public partial class SpecialAttendee
    {
        public int SpecialAttendeeID { get; set; }
        public int UserID { get; set; }
        public bool IsVP { get; set; }
        public System.DateTime CreateDate { get; set; }
    
        public virtual User User { get; set; }
    }
}
