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
    
    public partial class Competition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Competition()
        {
            this.Competition_Category = new HashSet<Competition_Category>();
            this.Competition_Category1 = new HashSet<Competition_Category>();
            this.Competition_External_Competitor = new HashSet<Competition_External_Competitor>();
            this.Competition_External_Competitor1 = new HashSet<Competition_External_Competitor>();
            this.Competition_External_Competitor_Contact_Person = new HashSet<Competition_External_Competitor_Contact_Person>();
            this.Competition_External_Competitor_Contact_Person1 = new HashSet<Competition_External_Competitor_Contact_Person>();
            this.Competition_Internal_Competitor = new HashSet<Competition_Internal_Competitor>();
        }
    
        public int Id { get; set; }
        public int ClubId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public System.DateTime EndSignupDate { get; set; }
        public string Location { get; set; }
        public bool IsExternal { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime StartSignupDate { get; set; }
        public bool IsGlobal { get; set; }
        public bool IsClubCompetition { get; set; }
        public Nullable<int> CreatedBy { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Account Account1 { get; set; }
        public virtual Club Club { get; set; }
        public virtual Club Club1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Competition_Category> Competition_Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Competition_Category> Competition_Category1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Competition_External_Competitor> Competition_External_Competitor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Competition_External_Competitor> Competition_External_Competitor1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Competition_External_Competitor_Contact_Person> Competition_External_Competitor_Contact_Person { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Competition_External_Competitor_Contact_Person> Competition_External_Competitor_Contact_Person1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Competition_Internal_Competitor> Competition_Internal_Competitor { get; set; }
    }
}
