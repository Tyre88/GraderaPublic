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
    
    public partial class Competition_External_Competitor
    {
        public int Id { get; set; }
        public int CompetitionId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public int Grade { get; set; }
        public int CategoryId { get; set; }
        public int ContactPersonId { get; set; }
        public string Weight { get; set; }
        public int Gender { get; set; }
    
        public virtual Competition Competition { get; set; }
        public virtual Competition Competition1 { get; set; }
        public virtual Competition_Category Competition_Category { get; set; }
        public virtual Competition_Category Competition_Category1 { get; set; }
        public virtual Competition_External_Competitor_Contact_Person Competition_External_Competitor_Contact_Person { get; set; }
        public virtual Competition_External_Competitor_Contact_Person Competition_External_Competitor_Contact_Person1 { get; set; }
    }
}
