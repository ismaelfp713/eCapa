using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eCapa.Models
{
    public partial class DocumentHistory
    {
        public DocumentHistory()
        {
            THows = new HashSet<THows>();
            TInputs = new HashSet<TInputs>();
            TMeasurements = new HashSet<TMeasurements>();
            TOutputs = new HashSet<TOutputs>();
            TWhats = new HashSet<TWhats>();
            TWhos = new HashSet<TWhos>();
        }

        [Key]
        public int HistoryId { get; set; }
        public int TurtleId { get; set; }
        [Required]
        [StringLength(250)]
        public string Name { get; set; }
        [Required]
        public string Process { get; set; }
        [Column("DepartmentID")]
        public long DepartmentId { get; set; }
        [Required]
        [StringLength(10)]
        public string Revision { get; set; }
        [Required]
        [StringLength(450)]
        public string CreatedBy { get; set; }
        public int? ApprovedBy { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ReleaseDate { get; set; }
        [Required]
        public string Purpose { get; set; }
        [Column(TypeName = "date")]
        public DateTime? RevisionDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime CreationDate { get; set; }
        [Required]
        public bool? IsActive { get; set; }
        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        [ForeignKey(nameof(ApprovedBy))]
        [InverseProperty(nameof(TRoutes.DocumentHistory))]
        public virtual TRoutes ApprovedByNavigation { get; set; }
        [ForeignKey(nameof(CreatedBy))]
        [InverseProperty(nameof(AspNetUsers.DocumentHistory))]
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        [ForeignKey(nameof(TurtleId))]
        [InverseProperty("DocumentHistory")]
        public virtual Turtle Turtle { get; set; }
        [InverseProperty("DocumentHistory")]
        public virtual ICollection<THows> THows { get; set; }
        [InverseProperty("DocumentHistory")]
        public virtual ICollection<TInputs> TInputs { get; set; }
        [InverseProperty("DocumentHistory")]
        public virtual ICollection<TMeasurements> TMeasurements { get; set; }
        [InverseProperty("DocumentHistory")]
        public virtual ICollection<TOutputs> TOutputs { get; set; }
        [InverseProperty("DocumentHistory")]
        public virtual ICollection<TWhats> TWhats { get; set; }
        [InverseProperty("DocumentHistory")]
        public virtual ICollection<TWhos> TWhos { get; set; }
    }
}
