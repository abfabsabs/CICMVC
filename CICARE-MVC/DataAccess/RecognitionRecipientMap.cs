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
    
    public partial class RecognitionRecipientMap
    {
        public int RecognitionRecipientMapID { get; set; }
        public int RecognitionID { get; set; }
        public int UserID { get; set; }
        public string RewardSerialNumber { get; set; }
    
        public virtual Recognition Recognition { get; set; }
        public virtual User User { get; set; }
    }
}