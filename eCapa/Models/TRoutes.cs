using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eCapa.Models
{
    [Table("tRoutes")]
    public partial class TRoutes
    {
        public TRoutes()
        {
            DocumentHistory = new HashSet<DocumentHistory>();
            RoutesUsers = new HashSet<RoutesUsers>();
        }

        [Key]
        public int IdRoute { get; set; }
        [Required]
        [StringLength(250)]
        public string Name { get; set; }
        [Required]
        public bool? IsActive { get; set; }

        [InverseProperty("ApprovedByNavigation")]
        public virtual ICollection<DocumentHistory> DocumentHistory { get; set; }
        [InverseProperty("IdrouteNavigation")]
        public virtual ICollection<RoutesUsers> RoutesUsers { get; set; }
    }
}
