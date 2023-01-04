using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eCapa.Models
{
    [Table("DFour")]
    public partial class Dfour
    {
        [Key]
        public int IdFour { get; set; }
        public int GeneralInformartionId { get; set; }
        [Required]
        public string Why { get; set; }
        public bool IsRootCause { get; set; }
        public bool ImpactOthers { get; set; }
        [Column(TypeName = "text")]
        public string Explain { get; set; }
        [Required]
        [StringLength(50)]
        public string Type { get; set; }
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

        [ForeignKey(nameof(GeneralInformartionId))]
        [InverseProperty(nameof(GeneralInformation.Dfour))]
        public virtual GeneralInformation GeneralInformartion { get; set; }
    }
}
