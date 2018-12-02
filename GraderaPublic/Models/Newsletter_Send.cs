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
    
    public partial class Newsletter_Send
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Newsletter_Send()
        {
            this.Newsletter_Send_Item = new HashSet<Newsletter_Send_Item>();
        }
    
        public int Id { get; set; }
        public int NewsletterId { get; set; }
        public System.DateTime SendDate { get; set; }
        public int UserSendId { get; set; }
        public int ClubId { get; set; }
        public string NewsletterContent { get; set; }
        public string NewsletterName { get; set; }
        public string NewsletterSendGUID { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Club Club { get; set; }
        public virtual Newsletters Newsletters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Newsletter_Send_Item> Newsletter_Send_Item { get; set; }
    }
}
