using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eCapa.Models
{
    public partial class DsevenCross
    {
        [Key]
        [Column("IdDSeven")]
        public int IdDseven { get; set; }
        public int GeneralInformationId { get; set; }
        public bool UpdatesRequired { get; set; }
        [Column("Core_Tools")]
        public bool CoreTools { get; set; }
        public bool Procedures { get; set; }
        public bool Instructions { get; set; }
        public bool InternalAudit { get; set; }
        public bool Others { get; set; }
        public bool EmployeesTrained { get; set; }
        public bool SimilarNonConformities { get; set; }
        [Column(TypeName = "text")]
        public string SmcDescription { get; set; }
        public bool NcAnalysis { get; set; }
        [Column(TypeName = "text")]
        public string ActionsTaken { get; set; }
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
        [InverseProperty("DsevenCross")]
        public virtual GeneralInformation GeneralInformation { get; set; }
    }
}
