using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eCapa.Models
{
    [Table("dClauses")]
    public partial class DClauses
    {
        public DClauses()
        {
            DProcessClauses = new HashSet<DProcessClauses>();
            DSubClauses = new HashSet<DSubClauses>();
        }

        [Key]
        public int ClauseId { get; set; }
        [Required]
        [StringLength(20)]
        public string ClauseNumber { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string ClauseName { get; set; }
        public bool IsException { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Created { get; set; }
        [Required]
        [StringLength(450)]
        public string CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
        [StringLength(450)]
        public string DeletedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeletedOn { get; set; }
        [StringLength(450)]
        public string LastModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedOn { get; set; }

        [InverseProperty("Clause")]
        public virtual ICollection<DProcessClauses> DProcessClauses { get; set; }
        [InverseProperty("Clause")]
        public virtual ICollection<DSubClauses> DSubClauses { get; set; }
    }
}
