using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eCapa.Models
{
    [Table("dStandardClause")]
    public partial class DStandardClause
    {
        [Key]
        public int IdStandardClause { get; set; }
        public int ClauseId { get; set; }
        public int StandardId { get; set; }

        [ForeignKey(nameof(ClauseId))]
        [InverseProperty(nameof(DClauses.DStandardClause))]
        public virtual DClauses Clause { get; set; }
        [ForeignKey(nameof(StandardId))]
        [InverseProperty(nameof(Dstandards.DStandardClause))]
        public virtual Dstandards Standard { get; set; }
    }
}
