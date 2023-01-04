using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eCapa.Models
{
    [Table("dProcessClauses")]
    public partial class DProcessClauses
    {
        [Key]
        public int ProcessId { get; set; }
        [Key]
        public int ClauseId { get; set; }

        [ForeignKey(nameof(ClauseId))]
        [InverseProperty(nameof(DClauses.DProcessClauses))]
        public virtual DClauses Clause { get; set; }
        [ForeignKey(nameof(ProcessId))]
        [InverseProperty(nameof(DProcesses.DProcessClauses))]
        public virtual DProcesses Process { get; set; }
    }
}
