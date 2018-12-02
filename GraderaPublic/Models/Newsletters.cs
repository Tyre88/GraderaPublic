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
    
    public partial class Newsletters
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Newsletters()
        {
            this.Newsletter_Send = new HashSet<Newsletter_Send>();
        }
    
        public int Id { get; set; }
        public int ClubId { get; set; }
        public int CreatedBy { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedDate { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Club Club { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Newsletter_Send> Newsletter_Send { get; set; }
    }
}
