using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eCapa.Models
{
    [Table("DFive")]
    public partial class Dfive
    {
        public Dfive()
        {
            DfiveActions = new HashSet<DfiveActions>();
        }

        [Key]
        public int IdActionPlan { get; set; }
        public int GeneralInformartionId { get; set; }
        [StringLength(50)]
        public string QaApprovalStatus { get; set; }
        [StringLength(50)]
        public string FunctionalApprovalStatus { get; set; }
        [Column(TypeName = "text")]
        public string QaApproverComment { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? QaApprovedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FunctionalApprovedDate { get; set; }
        [Column(TypeName = "text")]
        public string FunctionalApproverComment { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Submitted { get; set; }
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
        [InverseProperty(nameof(GeneralInformation.Dfive))]
        public virtual GeneralInformation GeneralInformartion { get; set; }
        [InverseProperty("IdActionPlanNavigation")]
        public virtual ICollection<DfiveActions> DfiveActions { get; set; }
    }
}
