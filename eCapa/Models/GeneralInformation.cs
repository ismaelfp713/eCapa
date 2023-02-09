using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eCapa.Models
{
    public partial class GeneralInformation
    {
        public GeneralInformation()
        {
            DCapaExtraMembers = new HashSet<DCapaExtraMembers>();
            Deight = new HashSet<Deight>();
            Dfive = new HashSet<Dfive>();
            Dfour = new HashSet<Dfour>();
            Dseven = new HashSet<Dseven>();
            DsevenCross = new HashSet<DsevenCross>();
            Dthree = new HashSet<Dthree>();
            Dtwo = new HashSet<Dtwo>();
        }

        [Key]
        public int GeneralInformartionId { get; set; }
        [Required]
        [StringLength(50)]
        public string Type { get; set; }
        [Required]
        [StringLength(450)]
        public string CreatedBy { get; set; }
        public int CustomerId { get; set; }
        public int DepartmentId { get; set; }
        public int ProcessId { get; set; }
        [Required]
        [StringLength(250)]
        public string Standard { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Created { get; set; }
        [Column("Expected_Closure_Date", TypeName = "date")]
        public DateTime ExpectedClosureDate { get; set; }
        [Column("Actual_Closed_Date", TypeName = "date")]
        public DateTime? ActualClosedDate { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string Symptom { get; set; }
        [Required]
        [StringLength(50)]
        public string Severity { get; set; }
        [Required]
        [StringLength(50)]
        public string Source { get; set; }
        [Required]
        [Column("Audit_Report_Number")]
        [StringLength(50)]
        public string AuditReportNumber { get; set; }
        public int Clause { get; set; }
        public int SubClause { get; set; }
        [Required]
        [StringLength(450)]
        public string QaManagerApprover { get; set; }
        [Required]
        [StringLength(450)]
        public string DepartmentApprover { get; set; }
        [Required]
        [StringLength(450)]
        public string Verifier { get; set; }
        [Required]
        [StringLength(150)]
        public string Status { get; set; }
        [StringLength(450)]
        public string Owner { get; set; }
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
        public string CapaNumber { get; set; }

        [ForeignKey(nameof(CreatedBy))]
        [InverseProperty(nameof(AspNetUsers.GeneralInformationCreatedByNavigation))]
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        [ForeignKey(nameof(CustomerId))]
        [InverseProperty(nameof(Customers.GeneralInformation))]
        public virtual Customers Customer { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        [InverseProperty(nameof(DDepartment.GeneralInformation))]
        public virtual DDepartment Department { get; set; }
        [ForeignKey(nameof(Owner))]
        [InverseProperty(nameof(AspNetUsers.GeneralInformationOwnerNavigation))]
        public virtual AspNetUsers OwnerNavigation { get; set; }
        [ForeignKey(nameof(ProcessId))]
        [InverseProperty(nameof(DProcesses.GeneralInformation))]
        public virtual DProcesses Process { get; set; }
        [InverseProperty("IdCapaNavigation")]
        public virtual ICollection<DCapaExtraMembers> DCapaExtraMembers { get; set; }
        [InverseProperty("GeneralInformation")]
        public virtual ICollection<Deight> Deight { get; set; }
        [InverseProperty("GeneralInformartion")]
        public virtual ICollection<Dfive> Dfive { get; set; }
        [InverseProperty("GeneralInformartion")]
        public virtual ICollection<Dfour> Dfour { get; set; }
        [InverseProperty("GeneralInformartion")]
        public virtual ICollection<Dseven> Dseven { get; set; }
        [InverseProperty("GeneralInformation")]
        public virtual ICollection<DsevenCross> DsevenCross { get; set; }
        [InverseProperty("GeneralInformartion")]
        public virtual ICollection<Dthree> Dthree { get; set; }
        [InverseProperty("GeneralInformartion")]
        public virtual ICollection<Dtwo> Dtwo { get; set; }
    }
}
