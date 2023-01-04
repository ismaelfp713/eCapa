using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eCapa.Models
{
    [Table("tUsers")]
    public partial class TUsers
    {
        [Key]
        [Column("iduser")]
        public string Iduser { get; set; }
        [Required]
        [Column("email")]
        [StringLength(250)]
        public string Email { get; set; }
        [Required]
        [Column("password")]
        [StringLength(50)]
        public string Password { get; set; }
        [Column("iddepartment")]
        public int Iddepartment { get; set; }
        public bool IsApprover { get; set; }
        public bool IsAdmin { get; set; }
        public bool CanReview { get; set; }
        [Required]
        public bool? IsActive { get; set; }
    }
}
