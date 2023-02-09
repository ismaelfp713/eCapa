using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eCapa.Models
{
    [Table("DStandards")]
    public partial class Dstandards
    {
        public Dstandards()
        {
            DStandardClause = new HashSet<DStandardClause>();
        }

        [Key]
        public int IdStandard { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(450)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Created { get; set; }
        public bool IsDeleted { get; set; }
        [StringLength(450)]
        public string DeletedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeletedOn { get; set; }
        [StringLength(450)]
        public string LastModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedOn { get; set; }

        [InverseProperty("Standard")]
        public virtual ICollection<DStandardClause> DStandardClause { get; set; }
    }
}
