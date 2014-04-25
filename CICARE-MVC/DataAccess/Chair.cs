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
    
    public partial class Chair
    {
        public Chair()
        {
            this.AlternateObservers = new HashSet<AlternateObserver>();
            this.AlternateObservers1 = new HashSet<AlternateObserver>();
            this.ChairSuperiors = new HashSet<ChairSuperior>();
            this.ChairSuperiors1 = new HashSet<ChairSuperior>();
            this.ChairRoundingStatus = new HashSet<ChairRoundingStatu>();
            this.ChairSupervisors = new HashSet<ChairSupervisor>();
            this.ChairSupervisors1 = new HashSet<ChairSupervisor>();
            this.ChairSupervisors2 = new HashSet<ChairSupervisor>();
            this.Rounds = new HashSet<Round>();
            this.Rounds1 = new HashSet<Round>();
            this.RoundObservers = new HashSet<RoundObserver>();
            this.UserChairs = new HashSet<UserChair>();
        }
    
        public int ChairID { get; set; }
        public string Code { get; set; }
        public string ChairTitle { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
    
        public virtual ICollection<AlternateObserver> AlternateObservers { get; set; }
        public virtual ICollection<AlternateObserver> AlternateObservers1 { get; set; }
        public virtual ICollection<ChairSuperior> ChairSuperiors { get; set; }
        public virtual ICollection<ChairSuperior> ChairSuperiors1 { get; set; }
        public virtual ICollection<ChairRoundingStatu> ChairRoundingStatus { get; set; }
        public virtual ICollection<ChairSupervisor> ChairSupervisors { get; set; }
        public virtual ICollection<ChairSupervisor> ChairSupervisors1 { get; set; }
        public virtual ICollection<ChairSupervisor> ChairSupervisors2 { get; set; }
        public virtual ICollection<Round> Rounds { get; set; }
        public virtual ICollection<Round> Rounds1 { get; set; }
        public virtual ICollection<RoundObserver> RoundObservers { get; set; }
        public virtual ICollection<UserChair> UserChairs { get; set; }
    }
}
