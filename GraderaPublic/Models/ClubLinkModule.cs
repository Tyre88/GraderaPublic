//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GraderaPublic.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClubLinkModule
    {
        public int Id { get; set; }
        public int ClubId { get; set; }
        public int ModuleId { get; set; }
    
        public virtual Club Club { get; set; }
        public virtual Club Club1 { get; set; }
        public virtual Module Module { get; set; }
        public virtual Module Module1 { get; set; }
    }
}
