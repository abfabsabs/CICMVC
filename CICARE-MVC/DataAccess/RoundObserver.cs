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
    
    public partial class RoundObserver
    {
        public int RoundObserverID { get; set; }
        public int RoundID { get; set; }
        public int UserID { get; set; }
        public int ChairID { get; set; }
    
        public virtual Chair Chair { get; set; }
        public virtual Round Round { get; set; }
        public virtual User User { get; set; }
    }
}
