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
    
    public partial class sp_GetChairToSupervisorChairRelationships_Result
    {
        public int ChairID { get; set; }
        public string ChairTitle { get; set; }
        public string ChairCode { get; set; }
        public System.DateTime Chair_CreateDate { get; set; }
        public System.DateTime Chair_UpdateDate { get; set; }
        public Nullable<int> SupervisorChairID { get; set; }
        public Nullable<System.DateTime> ChairSupervisor_CreateDate { get; set; }
        public Nullable<System.DateTime> ChairSupervisor_UpdateDate { get; set; }
        public Nullable<bool> ChairSupervisor_Active { get; set; }
        public string Supervisor_ChairTitle { get; set; }
        public string Supervisor_ChairCode { get; set; }
        public Nullable<System.DateTime> Supervisor_CreateDate { get; set; }
        public Nullable<System.DateTime> Supervisor_UpdateDate { get; set; }
    }
}