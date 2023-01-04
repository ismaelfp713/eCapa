using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eCapa.Models
{
    [Table("DEight")]
    public partial class Deight
    {
        [Key]
        [Column("IdDEight")]
        public int IdDeight { get; set; }
        public int GeneralInformationId { get; set; }
        public bool ActionsClosed { get; set; }
        public bool EvidenceCentrallyStored { get; set; }
        public bool TeamRewarded { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CloseDate { get; set; }
        [StringLength(450)]
        public string ChampionApprover { get; set; }
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

        [ForeignKey(nameof(GeneralInformationId))]
        [InverseProperty("Deight")]
        public virtual GeneralInformation GeneralInformation { get; set; }
    }
}
