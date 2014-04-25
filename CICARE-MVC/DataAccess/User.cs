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
    
    public partial class User
    {
        public User()
        {
            this.ManagementRoundAttendances = new HashSet<ManagementRoundAttendance>();
            this.Recognitions = new HashSet<Recognition>();
            this.Recognitions1 = new HashSet<Recognition>();
            this.Recognitions2 = new HashSet<Recognition>();
            this.RecognitionRecipientMaps = new HashSet<RecognitionRecipientMap>();
            this.Rounds = new HashSet<Round>();
            this.Rounds1 = new HashSet<Round>();
            this.RoundObservers = new HashSet<RoundObserver>();
            this.ServiceRecoveries = new HashSet<ServiceRecovery>();
            this.SpecialAttendees = new HashSet<SpecialAttendee>();
            this.UserChairs = new HashSet<UserChair>();
        }
    
        public int UserID { get; set; }
        public string SID { get; set; }
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public int OrganizationStatusID { get; set; }
        public int OrganizationRoleID { get; set; }
        public int OrganizationDeptCodeID { get; set; }
        public int OrganizationJobCodeID { get; set; }
        public bool AIP { get; set; }
        public bool HealthstreamComplete { get; set; }
        public Nullable<System.DateTime> HealthstreamDate { get; set; }
    
        public virtual ICollection<ManagementRoundAttendance> ManagementRoundAttendances { get; set; }
        public virtual OrganizationDeptCode OrganizationDeptCode { get; set; }
        public virtual OrganizationJobCode OrganizationJobCode { get; set; }
        public virtual OrganizationRole OrganizationRole { get; set; }
        public virtual OrganizationStatu OrganizationStatu { get; set; }
        public virtual ICollection<Recognition> Recognitions { get; set; }
        public virtual ICollection<Recognition> Recognitions1 { get; set; }
        public virtual ICollection<Recognition> Recognitions2 { get; set; }
        public virtual ICollection<RecognitionRecipientMap> RecognitionRecipientMaps { get; set; }
        public virtual ICollection<Round> Rounds { get; set; }
        public virtual ICollection<Round> Rounds1 { get; set; }
        public virtual ICollection<RoundObserver> RoundObservers { get; set; }
        public virtual ICollection<ServiceRecovery> ServiceRecoveries { get; set; }
        public virtual ICollection<SpecialAttendee> SpecialAttendees { get; set; }
        public virtual ICollection<UserChair> UserChairs { get; set; }
    }
}
