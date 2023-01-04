using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eCapa.Models
{
    public partial class OutputRisk
    {
        public OutputRisk()
        {
            OutputRiskControl = new HashSet<OutputRiskControl>();
        }

        [Key]
        public int Id { get; set; }
        [Column("OutputID")]
        public int OutputId { get; set; }
        [StringLength(250)]
        public string PossibleRisk { get; set; }
        public int? Ocurrence { get; set; }
        public int? Severity { get; set; }
        public int? RiskIdentified { get; set; }
        public bool? IsActive { get; set; }
        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        [ForeignKey(nameof(OutputId))]
        [InverseProperty(nameof(TOutputs.OutputRisk))]
        public virtual TOutputs Output { get; set; }
        [InverseProperty("OutputRisk")]
        public virtual ICollection<OutputRiskControl> OutputRiskControl { get; set; }
    }
}
