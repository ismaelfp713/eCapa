using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eCapa.Models
{
    public partial class Turtle
    {
        public Turtle()
        {
            DocumentHistory = new HashSet<DocumentHistory>();
        }

        [Key]
        [Column("TurtleID")]
        public int TurtleId { get; set; }
        [StringLength(50)]
        public string DocumentNumber { get; set; }
        [Required]
        public bool? IsActive { get; set; }

        [InverseProperty("Turtle")]
        public virtual ICollection<DocumentHistory> DocumentHistory { get; set; }
    }
}
