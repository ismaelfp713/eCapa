using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eCapa.Models
{
    [Table("tOutputs")]
    public partial class TOutputs
    {
        public TOutputs()
        {
            OutputRisk = new HashSet<OutputRisk>();
        }

        [Key]
        [Column("OutputID")]
        public int OutputId { get; set; }
        [Required]
        public string Output { get; set; }
        public int? DocumentHistoryId { get; set; }
        [Required]
        public bool? IsActive { get; set; }
        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        [ForeignKey(nameof(DocumentHistoryId))]
        [InverseProperty("TOutputs")]
        public virtual DocumentHistory DocumentHistory { get; set; }
        [InverseProperty("Output")]
        public virtual ICollection<OutputRisk> OutputRisk { get; set; }
    }
}
