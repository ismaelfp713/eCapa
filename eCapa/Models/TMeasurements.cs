using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eCapa.Models
{
    [Table("tMeasurements")]
    public partial class TMeasurements
    {
        [Key]
        [Column("MeasurementID")]
        public int MeasurementId { get; set; }
        [Required]
        public string Measurement { get; set; }
        public int? DocumentHistoryId { get; set; }
        [Required]
        public bool? IsActive { get; set; }
        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        [ForeignKey(nameof(DocumentHistoryId))]
        [InverseProperty("TMeasurements")]
        public virtual DocumentHistory DocumentHistory { get; set; }
    }
}
