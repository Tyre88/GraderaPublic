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
    
    public partial class Technique
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Technique()
        {
            this.Grade_Category_Link_Technique = new HashSet<Grade_Category_Link_Technique>();
            this.Technique_Image = new HashSet<Technique_Image>();
            this.TrainingExerciseLinkTechnique = new HashSet<TrainingExerciseLinkTechnique>();
        }
    
        public int Id { get; set; }
        public int ClubId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TechniqueTypeId { get; set; }
        public bool IsGlobal { get; set; }
    
        public virtual Club Club { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Grade_Category_Link_Technique> Grade_Category_Link_Technique { get; set; }
        public virtual Technique_Type Technique_Type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Technique_Image> Technique_Image { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrainingExerciseLinkTechnique> TrainingExerciseLinkTechnique { get; set; }
    }
}
