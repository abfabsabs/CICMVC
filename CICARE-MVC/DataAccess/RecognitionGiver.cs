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
    
    public partial class RecognitionGiver
    {
        public RecognitionGiver()
        {
            this.Recognitions = new HashSet<Recognition>();
        }
    
        public int RecognitionGiverID { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<Recognition> Recognitions { get; set; }
    }
}
