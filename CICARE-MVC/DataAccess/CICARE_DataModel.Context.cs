﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class CiCareEntities : DbContext
    {
        public CiCareEntities()
            : base("name=CiCareEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AlternateObserver> AlternateObservers { get; set; }
        public DbSet<AttendanceRequirement> AttendanceRequirements { get; set; }
        public DbSet<Chair> Chairs { get; set; }
        public DbSet<ChairRoundingScore> ChairRoundingScores { get; set; }
        public DbSet<ChairRoundingStatu> ChairRoundingStatus { get; set; }
        public DbSet<ChairSuperior> ChairSuperiors { get; set; }
        public DbSet<ChairSupervisor> ChairSupervisors { get; set; }
        public DbSet<Configuration> Configurations { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<HealthstreamCourse> HealthstreamCourses { get; set; }
        public DbSet<Interaction> Interactions { get; set; }
        public DbSet<InteractionStatu> InteractionStatus { get; set; }
        public DbSet<ManagementRound> ManagementRounds { get; set; }
        public DbSet<ManagementRoundAttendance> ManagementRoundAttendances { get; set; }
        public DbSet<OrganizationDeptCode> OrganizationDeptCodes { get; set; }
        public DbSet<OrganizationJobCode> OrganizationJobCodes { get; set; }
        public DbSet<OrganizationRole> OrganizationRoles { get; set; }
        public DbSet<OrganizationStatu> OrganizationStatus { get; set; }
        public DbSet<Practice> Practices { get; set; }
        public DbSet<PracticeInteraction> PracticeInteractions { get; set; }
        public DbSet<Recognition> Recognitions { get; set; }
        public DbSet<RecognitionGiver> RecognitionGivers { get; set; }
        public DbSet<RecognitionReason> RecognitionReasons { get; set; }
        public DbSet<RecognitionRecipientMap> RecognitionRecipientMaps { get; set; }
        public DbSet<RecoveryItem> RecoveryItems { get; set; }
        public DbSet<RecoveryItemReplenishment> RecoveryItemReplenishments { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<ResourceCategory> ResourceCategories { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Round> Rounds { get; set; }
        public DbSet<RoundInteraction> RoundInteractions { get; set; }
        public DbSet<RoundObserver> RoundObservers { get; set; }
        public DbSet<ServiceRecovery> ServiceRecoveries { get; set; }
        public DbSet<ServiceRecoveryDetail> ServiceRecoveryDetails { get; set; }
        public DbSet<ServiceRecoveryReason> ServiceRecoveryReasons { get; set; }
        public DbSet<ServiceRecoveryRecipient> ServiceRecoveryRecipients { get; set; }
        public DbSet<SpecialAttendee> SpecialAttendees { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<TemplatePractice> TemplatePractices { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserChair> UserChairs { get; set; }
    
        [EdmFunction("CiCareEntities", "tryUsersGrouped")]
        public virtual IQueryable<tryUsersGrouped_Result> tryUsersGrouped(Nullable<System.DateTime> startdate, Nullable<System.DateTime> healthstreamThreshold)
        {
            var startdateParameter = startdate.HasValue ?
                new ObjectParameter("startdate", startdate) :
                new ObjectParameter("startdate", typeof(System.DateTime));
    
            var healthstreamThresholdParameter = healthstreamThreshold.HasValue ?
                new ObjectParameter("HealthstreamThreshold", healthstreamThreshold) :
                new ObjectParameter("HealthstreamThreshold", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<tryUsersGrouped_Result>("[CiCareEntities].[tryUsersGrouped](@startdate, @HealthstreamThreshold)", startdateParameter, healthstreamThresholdParameter);
        }
    
        [EdmFunction("CiCareEntities", "udf_FiscalYearTable")]
        public virtual IQueryable<udf_FiscalYearTable_Result> udf_FiscalYearTable(Nullable<System.DateTime> fromdate)
        {
            var fromdateParameter = fromdate.HasValue ?
                new ObjectParameter("fromdate", fromdate) :
                new ObjectParameter("fromdate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<udf_FiscalYearTable_Result>("[CiCareEntities].[udf_FiscalYearTable](@fromdate)", fromdateParameter);
        }
    
        [EdmFunction("CiCareEntities", "udf_GroupedUsersTable")]
        public virtual IQueryable<udf_GroupedUsersTable_Result> udf_GroupedUsersTable(Nullable<System.DateTime> fromdate)
        {
            var fromdateParameter = fromdate.HasValue ?
                new ObjectParameter("fromdate", fromdate) :
                new ObjectParameter("fromdate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<udf_GroupedUsersTable_Result>("[CiCareEntities].[udf_GroupedUsersTable](@fromdate)", fromdateParameter);
        }
    
        [EdmFunction("CiCareEntities", "udf_GroupedUsersTable_Alternate")]
        public virtual IQueryable<udf_GroupedUsersTable_Alternate_Result> udf_GroupedUsersTable_Alternate(Nullable<System.DateTime> fromdate)
        {
            var fromdateParameter = fromdate.HasValue ?
                new ObjectParameter("fromdate", fromdate) :
                new ObjectParameter("fromdate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<udf_GroupedUsersTable_Alternate_Result>("[CiCareEntities].[udf_GroupedUsersTable_Alternate](@fromdate)", fromdateParameter);
        }
    
        [EdmFunction("CiCareEntities", "udf_GroupedUsersTable_Alternate2")]
        public virtual IQueryable<udf_GroupedUsersTable_Alternate2_Result> udf_GroupedUsersTable_Alternate2(Nullable<System.DateTime> fromdate)
        {
            var fromdateParameter = fromdate.HasValue ?
                new ObjectParameter("fromdate", fromdate) :
                new ObjectParameter("fromdate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<udf_GroupedUsersTable_Alternate2_Result>("[CiCareEntities].[udf_GroupedUsersTable_Alternate2](@fromdate)", fromdateParameter);
        }
    
        [EdmFunction("CiCareEntities", "udf_nameSearch")]
        public virtual IQueryable<udf_nameSearch_Result> udf_nameSearch(string keywords)
        {
            var keywordsParameter = keywords != null ?
                new ObjectParameter("keywords", keywords) :
                new ObjectParameter("keywords", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<udf_nameSearch_Result>("[CiCareEntities].[udf_nameSearch](@keywords)", keywordsParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_GetBreakdownOfSubordinatesByMonth_Result> sp_GetBreakdownOfSubordinatesByMonth(Nullable<System.DateTime> fromdate, Nullable<int> userID, Nullable<int> employeeID, string lastName, Nullable<int> chairID)
        {
            var fromdateParameter = fromdate.HasValue ?
                new ObjectParameter("fromdate", fromdate) :
                new ObjectParameter("fromdate", typeof(System.DateTime));
    
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("EmployeeID", employeeID) :
                new ObjectParameter("EmployeeID", typeof(int));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var chairIDParameter = chairID.HasValue ?
                new ObjectParameter("ChairID", chairID) :
                new ObjectParameter("ChairID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetBreakdownOfSubordinatesByMonth_Result>("sp_GetBreakdownOfSubordinatesByMonth", fromdateParameter, userIDParameter, employeeIDParameter, lastNameParameter, chairIDParameter);
        }
    
        public virtual ObjectResult<sp_GetChairToSupervisorChairRelationships_Result> sp_GetChairToSupervisorChairRelationships(Nullable<int> chairID, string chairCode)
        {
            var chairIDParameter = chairID.HasValue ?
                new ObjectParameter("ChairID", chairID) :
                new ObjectParameter("ChairID", typeof(int));
    
            var chairCodeParameter = chairCode != null ?
                new ObjectParameter("ChairCode", chairCode) :
                new ObjectParameter("ChairCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetChairToSupervisorChairRelationships_Result>("sp_GetChairToSupervisorChairRelationships", chairIDParameter, chairCodeParameter);
        }
    
        public virtual ObjectResult<sp_GetChairToUserRelationships_Result> sp_GetChairToUserRelationships(Nullable<int> chairID, string chairCode, Nullable<int> userID, Nullable<int> employeeID)
        {
            var chairIDParameter = chairID.HasValue ?
                new ObjectParameter("ChairID", chairID) :
                new ObjectParameter("ChairID", typeof(int));
    
            var chairCodeParameter = chairCode != null ?
                new ObjectParameter("ChairCode", chairCode) :
                new ObjectParameter("ChairCode", typeof(string));
    
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("EmployeeID", employeeID) :
                new ObjectParameter("EmployeeID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetChairToUserRelationships_Result>("sp_GetChairToUserRelationships", chairIDParameter, chairCodeParameter, userIDParameter, employeeIDParameter);
        }
    
        public virtual ObjectResult<sp_GetDepartmentRoundsForUsersSubordinates_Result> sp_GetDepartmentRoundsForUsersSubordinates(Nullable<int> userID, string lastName, Nullable<System.DateTime> fromdate)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var fromdateParameter = fromdate.HasValue ?
                new ObjectParameter("fromdate", fromdate) :
                new ObjectParameter("fromdate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetDepartmentRoundsForUsersSubordinates_Result>("sp_GetDepartmentRoundsForUsersSubordinates", userIDParameter, lastNameParameter, fromdateParameter);
        }
    
        public virtual ObjectResult<sp_GetInactiveChairs_Result> sp_GetInactiveChairs(Nullable<int> supervisorChairID, Nullable<System.DateTime> fromdate)
        {
            var supervisorChairIDParameter = supervisorChairID.HasValue ?
                new ObjectParameter("SupervisorChairID", supervisorChairID) :
                new ObjectParameter("SupervisorChairID", typeof(int));
    
            var fromdateParameter = fromdate.HasValue ?
                new ObjectParameter("fromdate", fromdate) :
                new ObjectParameter("fromdate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetInactiveChairs_Result>("sp_GetInactiveChairs", supervisorChairIDParameter, fromdateParameter);
        }
    
        public virtual ObjectResult<sp_GetManagementRoundsForUser_Result> sp_GetManagementRoundsForUser(Nullable<int> userID, Nullable<int> employeeID, string lastName, Nullable<System.DateTime> fromdate)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("EmployeeID", employeeID) :
                new ObjectParameter("EmployeeID", typeof(int));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var fromdateParameter = fromdate.HasValue ?
                new ObjectParameter("fromdate", fromdate) :
                new ObjectParameter("fromdate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetManagementRoundsForUser_Result>("sp_GetManagementRoundsForUser", userIDParameter, employeeIDParameter, lastNameParameter, fromdateParameter);
        }
    
        public virtual ObjectResult<sp_GetManagementRoundsSchedule_Result> sp_GetManagementRoundsSchedule(Nullable<System.DateTime> fromdate)
        {
            var fromdateParameter = fromdate.HasValue ?
                new ObjectParameter("fromdate", fromdate) :
                new ObjectParameter("fromdate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetManagementRoundsSchedule_Result>("sp_GetManagementRoundsSchedule", fromdateParameter);
        }
    
        public virtual ObjectResult<sp_GetRecognitionsGivenForUser_Result> sp_GetRecognitionsGivenForUser(Nullable<int> userID, Nullable<int> employeeID, string lastName, Nullable<System.DateTime> fromdate, Nullable<bool> breakOut)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("EmployeeID", employeeID) :
                new ObjectParameter("EmployeeID", typeof(int));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var fromdateParameter = fromdate.HasValue ?
                new ObjectParameter("fromdate", fromdate) :
                new ObjectParameter("fromdate", typeof(System.DateTime));
    
            var breakOutParameter = breakOut.HasValue ?
                new ObjectParameter("BreakOut", breakOut) :
                new ObjectParameter("BreakOut", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetRecognitionsGivenForUser_Result>("sp_GetRecognitionsGivenForUser", userIDParameter, employeeIDParameter, lastNameParameter, fromdateParameter, breakOutParameter);
        }
    
        public virtual ObjectResult<sp_GetUserDetails_Result> sp_GetUserDetails(string lastName, string sID, Nullable<int> employeeID, Nullable<int> userID)
        {
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var sIDParameter = sID != null ?
                new ObjectParameter("SID", sID) :
                new ObjectParameter("SID", typeof(string));
    
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("EmployeeID", employeeID) :
                new ObjectParameter("EmployeeID", typeof(int));
    
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetUserDetails_Result>("sp_GetUserDetails", lastNameParameter, sIDParameter, employeeIDParameter, userIDParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<sp_WhoDoesUserReportTo_Result> sp_WhoDoesUserReportTo(Nullable<int> employeeID, string lastName, string sID, Nullable<int> userID, Nullable<bool> activeOnly)
        {
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("EmployeeID", employeeID) :
                new ObjectParameter("EmployeeID", typeof(int));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var sIDParameter = sID != null ?
                new ObjectParameter("SID", sID) :
                new ObjectParameter("SID", typeof(string));
    
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            var activeOnlyParameter = activeOnly.HasValue ?
                new ObjectParameter("ActiveOnly", activeOnly) :
                new ObjectParameter("ActiveOnly", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_WhoDoesUserReportTo_Result>("sp_WhoDoesUserReportTo", employeeIDParameter, lastNameParameter, sIDParameter, userIDParameter, activeOnlyParameter);
        }
    
        public virtual ObjectResult<sp_WhoReportsToUser_Result> sp_WhoReportsToUser(Nullable<int> employeeID, string lastName, string sID, Nullable<int> userID, Nullable<bool> activeOnly)
        {
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("EmployeeID", employeeID) :
                new ObjectParameter("EmployeeID", typeof(int));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var sIDParameter = sID != null ?
                new ObjectParameter("SID", sID) :
                new ObjectParameter("SID", typeof(string));
    
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            var activeOnlyParameter = activeOnly.HasValue ?
                new ObjectParameter("ActiveOnly", activeOnly) :
                new ObjectParameter("ActiveOnly", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_WhoReportsToUser_Result>("sp_WhoReportsToUser", employeeIDParameter, lastNameParameter, sIDParameter, userIDParameter, activeOnlyParameter);
        }
    }
}