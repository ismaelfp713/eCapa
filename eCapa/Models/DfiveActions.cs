using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eCapa.Models
{
    [Table("DFiveActions")]
    public partial class DfiveActions
    {
        [Key]
        public int IdFive { get; set; }
        public int GeneralInformartionId { get; set; }
        public int IdActionPlan { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string Action { get; set; }
        [Required]
        [StringLength(450)]
        public string Owner { get; set; }
        [Required]
        [StringLength(50)]
        public string Status { get; set; }
        [Required]
        [StringLength(50)]
        public string Type { get; set; }
        [Column(TypeName = "date")]
        public DateTime DueDate { get; set; }
        public string DelayReason { get; set; }
        public bool DelayRequested { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DelayRequestedOn { get; set; }
        public int DelayCount { get; set; }
        public string Evidence { get; set; }
        public string Comment { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MarkedAsCompleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CompletedOn { get; set; }
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
        [StringLength(450)]
        public string EffectivenessVerifiedByOne { get; set; }
        [StringLength(150)]
        public string EffectivenessVerificationStatusOne { get; set; }
        [Column(TypeName = "text")]
        public string EffectivenessVerificationCommentOne { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EffectivenessVerifiedOnOne { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EffectivenessVerificationDateOne { get; set; }
        public string EffectivenessVerificationDelayReasonOne { get; set; }
        public bool EffectivenessVerificationDelayRequestedOne { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EffectivenessVerificationDelayRequestedOnOne { get; set; }
        [StringLength(450)]
        public string EffectivenessVerifiedByTwo { get; set; }
        [StringLength(150)]
        public string EffectivenessVerificationStatusTwo { get; set; }
        [Column(TypeName = "text")]
        public string EffectivenessVerificationCommentTwo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EffectivenessVerifiedOnTwo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EffectivenessVerificationDateTwo { get; set; }
        public string EffectivenessVerificationDelayReasonTwo { get; set; }
        public bool EffectivenessVerificationDelayRequestedTwo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EffectivenessVerificationDelayRequestedOnTwo { get; set; }
        [StringLength(450)]
        public string EffectivenessVerifiedByThree { get; set; }
        [StringLength(150)]
        public string EffectivenessVerificationStatusThree { get; set; }
        [Column(TypeName = "text")]
        public string EffectivenessVerificationCommentThree { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EffectivenessVerifiedOnThree { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EffectivenessVerificationDateThree { get; set; }
        public string EffectivenessVerificationDelayReasonThree { get; set; }
        public bool EffectivenessVerificationDelayRequestedThree { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EffectivenessVerificationDelayRequestedOnThree { get; set; }

        [ForeignKey(nameof(IdActionPlan))]
        [InverseProperty(nameof(Dfive.DfiveActions))]
        public virtual Dfive IdActionPlanNavigation { get; set; }
        [ForeignKey(nameof(Owner))]
        [InverseProperty(nameof(AspNetUsers.DfiveActions))]
        public virtual AspNetUsers OwnerNavigation { get; set; }
    }
}
