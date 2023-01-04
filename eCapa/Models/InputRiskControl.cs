using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eCapa.Models
{
    public partial class InputRiskControl
    {
        [Key]
        public int Id { get; set; }
        public int InputRiskId { get; set; }
        [Required]
        [StringLength(250)]
        public string Control { get; set; }
        [Required]
        public bool? Implemented { get; set; }
        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        [ForeignKey(nameof(InputRiskId))]
        [InverseProperty("InputRiskControl")]
        public virtual InputRisk InputRisk { get; set; }
    }
}
