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
    
    public partial class ServiceRecoveryDetail
    {
        public int ServiceRecoveryDetailID { get; set; }
        public int ServiceRecoveryID { get; set; }
        public int ReasonID { get; set; }
        public int RecipientID { get; set; }
        public int RecoveryItemID { get; set; }
        public int Count { get; set; }
    
        public virtual RecoveryItem RecoveryItem { get; set; }
        public virtual ServiceRecovery ServiceRecovery { get; set; }
        public virtual ServiceRecoveryReason ServiceRecoveryReason { get; set; }
        public virtual ServiceRecoveryRecipient ServiceRecoveryRecipient { get; set; }
    }
}
