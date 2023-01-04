using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eCapa.Models
{
    [Table("dSubClauses")]
    public partial class DSubClauses
    {
        [Key]
        public int SubClauseId { get; set; }
        [Required]
        [StringLength(20)]
        public string SubClauseNumber { get; set; }
        [StringLength(450)]
        public string SubClauseName { get; set; }
        public int ClauseId { get; set; }
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

        [ForeignKey(nameof(ClauseId))]
        [InverseProperty(nameof(DClauses.DSubClauses))]
        public virtual DClauses Clause { get; set; }
    }
}
