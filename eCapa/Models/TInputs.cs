using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eCapa.Models
{
    [Table("tInputs")]
    public partial class TInputs
    {
        public TInputs()
        {
            InputRisk = new HashSet<InputRisk>();
        }

        [Key]
        [Column("InputID")]
        public int InputId { get; set; }
        [Required]
        public string Input { get; set; }
        public int? DocumentHistoryId { get; set; }
        [Required]
        public bool? IsActive { get; set; }
        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        [ForeignKey(nameof(DocumentHistoryId))]
        [InverseProperty("TInputs")]
        public virtual DocumentHistory DocumentHistory { get; set; }
        [InverseProperty("Input")]
        public virtual ICollection<InputRisk> InputRisk { get; set; }
    }
}
