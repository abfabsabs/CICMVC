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
    
    public partial class tryUsersGrouped_Result
    {
        public int UniqueChairID { get; set; }
        public string ChairCode { get; set; }
        public string ChairTitle { get; set; }
        public string Occupant { get; set; }
        public Nullable<int> OccupantCiCareUserID { get; set; }
        public Nullable<int> OccupantEmployeeID { get; set; }
        public Nullable<bool> OccupantAIP { get; set; }
        public Nullable<int> OccupantDepartmentID { get; set; }
        public string OccupantDepartmentName { get; set; }
        public string SupervisorChairCode { get; set; }
        public string SupervisorChairTitle { get; set; }
        public string SupervisorName { get; set; }
        public Nullable<int> SupervisorCiCareUserID { get; set; }
        public Nullable<int> SupervisorEmployeeID { get; set; }
        public Nullable<bool> SupervisorAIP { get; set; }
        public int DirectReportDepartmentCode { get; set; }
        public string DirectReportDepartmentName { get; set; }
        public Nullable<int> DirectReportCount { get; set; }
        public Nullable<int> LawsonDirectReportCount { get; set; }
        public Nullable<int> DirectReportsCompliantWithHealthstream { get; set; }
        public Nullable<int> Rounds { get; set; }
        public Nullable<int> Recognitions { get; set; }
        public Nullable<int> DirectReportServiceRecoveries { get; set; }
        public Nullable<int> OccupantsServiceRecoveries { get; set; }
        public Nullable<int> OccupantManagementDayRoundsAttended { get; set; }
        public Nullable<int> OccupantManagementEveningRoundsAttended { get; set; }
        public Nullable<int> Month { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    }
}
